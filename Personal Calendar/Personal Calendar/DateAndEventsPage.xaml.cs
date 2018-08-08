using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Personal_Calendar
{
    /// <summary>
    /// Interaction logic for DateAndEventsPage.xaml
    /// </summary>
    public partial class DateAndEventsPage : Page
    {
        public DispatcherTimer timer = new DispatcherTimer();
        public ObservableCollection<Events> eventData { get; set; } = new ObservableCollection<Events>();

        public DateAndEventsPage()
        {
            DataContext = this;
            InitializeComponent();
            timer.Interval = TimeSpan.FromMilliseconds(50);
            timer.Tick += new EventHandler(eventTimer);
            timer.Start();
        }

        private void eventTimer(object sender, EventArgs e)
        {
            if (Globals.savedEvents.Count != eventData.Count)
            {
                eventData.Clear();
                using (var writer = new StreamWriter(@"C:\Benjamin's\Benjamin's Kalos-Personal Calendar\Personal-Calendar-master\Personal Calendar\events.csv"))
                {
                    for (var x = 0; x < Globals.savedEvents.Count; x++)
                    {
                        eventData.Add(Globals.savedEvents[x]);
                        writer.Write(Globals.savedEvents[x].name + "," + Globals.savedEvents[x].date + "," + Globals.savedEvents[x].time + "," + Globals.savedEvents[x].alarmed + "\n");
                    }
                }
            }
            for (var x = 0; x < Globals.savedEvents.Count; x++)
            {
                int hour = Convert.ToInt32(Globals.savedEvents[x].time.Split(':')[0]);
                int minute = Convert.ToInt32(Globals.savedEvents[x].time.Split(':')[1].Split(' ')[0]);
                DateTime date = new DateTime(Globals.savedEvents[x].date.Year, Globals.savedEvents[x].date.Month, Globals.savedEvents[x].date.Day, hour, minute, 0);
                if (DateTime.Now > Convert.ToDateTime(Globals.savedEvents[x].time) && Globals.savedEvents[x].alarmed == false)
                {
                    SoundPlayer player = new SoundPlayer(Globals.alarmAudio);

                    NotifyIcon icon = new NotifyIcon();
                    icon.Icon = SystemIcons.Application;
                    Globals.savedEvents[x].alarmed = true;
                    icon.Visible = true;
                    icon.ShowBalloonTip(5000, "", $"{Globals.savedEvents[x].name} at {Globals.savedEvents[x].time} has begun!", ToolTipIcon.Info);

                    icon.BalloonTipClosed += new EventHandler(balloonClicked);
                    icon.BalloonTipClicked += new EventHandler(balloonClicked);
                    
                    player.Play();
                }
            }
        }

        private void balloonClicked(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer();
            player.Stop();
        }

        private void timeButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(Globals.timer);
        }

        private void stopwatchButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(Globals.stopwatch);
        }

        private void clockButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(Globals.clock);
        }

        private void addEventButton_Click(object sender, RoutedEventArgs e)
        {
            if (eventCalendar.SelectedDate != null)
            {             
                EventSetterWindow setter = new EventSetterWindow();                
                setter.ShowDialog();
            }
            else
            {
                System.Windows.MessageBox.Show("Select a date before adding an event", "INFORMATION", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void eventCalendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            Globals.eventDate = Convert.ToDateTime(eventCalendar.SelectedDate);
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Globals.savedEvents.Clear();
            using (var reader = new StreamReader(@"C:\Benjamin's\Benjamin's Kalos-Personal Calendar\Personal-Calendar-master\Personal Calendar\events.csv"))
            {
                while (reader.Peek() > -1)
                {
                    string[] savedEvent = reader.ReadLine().Split(',');
                    if (savedEvent.Length > 2)
                    {
                        Events events = new Events();
                        events.name = savedEvent[0];
                        events.date = Convert.ToDateTime(savedEvent[1]);
                        events.time = savedEvent[2];
                        events.alarmed = Convert.ToBoolean(savedEvent[3]);
                        Globals.savedEvents.Add(events);
                    }
                }
            }
        }

        private void removeButton_Click(object sender, RoutedEventArgs e)
        {
            if (eventsGrid.SelectedIndex > -1)
            {
                MessageBoxResult result = System.Windows.MessageBox.Show($"Are you sure you want to delete {eventsGrid.SelectedCells[0].Item.ToString()} from the alarms list?", "WARNING", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                if (result == MessageBoxResult.Yes)
                {
                    Globals.savedEvents.RemoveAt(eventsGrid.SelectedIndex);
                }
            }
        }

        private void silenceButton_Click(object sender, RoutedEventArgs e)
        {
            Globals.savedEvents[eventsGrid.SelectedIndex].alarmed = true;
            System.Windows.MessageBox.Show($"{Globals.savedEvents[eventsGrid.SelectedIndex].name} is silenced");
        }
    }
}