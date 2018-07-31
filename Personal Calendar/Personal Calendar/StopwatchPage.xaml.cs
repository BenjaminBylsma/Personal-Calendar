using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Personal_Calendar
{
    /// <summary>
    /// Interaction logic for StopwatchPage.xaml
    /// </summary>
    public partial class StopwatchPage : Page , INotifyPropertyChanged
    {
        public DispatcherTimer timer = new DispatcherTimer();
        public event PropertyChangedEventHandler PropertyChanged;

        private int _Hours;
        private int _Minutes;
        private int _Seconds;
        private int _MilSeconds;

        public int prop;
        public int Hours
        {
            get
            {
                return _Hours;
            }
            set
            {
                _Hours = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(Hours)));
                }
            }

        }
        public int Minutes
        {
            get
            {
                return _Minutes;
            }
            set
            {
                _Minutes = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(Minutes)));
                }
            }

        }
        public int Seconds
        {
            get
            {
                return _Seconds;
            }
            set
            {
                _Seconds = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(Seconds)));
                }
            }

        }
        public int MilSeconds
        {
            get
            {
                return _MilSeconds;
            }
            set
            {
                _MilSeconds = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(MilSeconds)));
                }
            }

        }

        public StopwatchPage()
        {
            DataContext = this;
            InitializeComponent();
            timer.Interval = new TimeSpan(0, 0, 0, 0, 0);
            timer.Tick += new EventHandler(stopwatchTimer);
        }

        private void eventButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(Globals.events);
        }
        private void clockButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(Globals.clock);
        }

        private void timerButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(Globals.timer);
        }

        private void startButton_Click(object sender, RoutedEventArgs e)
        {
            timer.Start();
        }

        private void pauseButton_Click(object sender, RoutedEventArgs e)
        {
            timer.Stop();
        }

        private void resetButton_Click(object sender, RoutedEventArgs e)
        {
            timer.Stop();
            Hours = 0;
            Minutes = 0;
            Seconds = 0;
            MilSeconds = 0;
        }

        private void saveSplitButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void stopwatchTimer(object sender, EventArgs e)
        {
            MilSeconds++;
            if (MilSeconds == 1062)
            {
                if (Seconds == 59)
                {
                    if (Minutes == 59)
                    {
                        Hours++;
                        Minutes = 0;
                        Seconds = 0;
                        MilSeconds = 0;
                    }
                    else
                    {
                        Minutes++;
                        Seconds = 0;
                        MilSeconds = 0;
                    }
                }
                else
                {
                    Seconds++;
                    MilSeconds = 0;
                }
            }
        }

        private void printTime(object sender, RoutedEventArgs e)
        {
            hourTxt.Text = Globals.sHours.ToString();
            minTxt.Text = Globals.sMinutes.ToString();
            secTxt.Text = Globals.sSeconds.ToString();
            milsecTxt.Text = Globals.sMSeconds.ToString();
        }
    }
}
