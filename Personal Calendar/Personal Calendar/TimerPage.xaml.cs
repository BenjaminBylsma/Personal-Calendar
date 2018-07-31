using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using Personal_Calendar;
using System.Windows.Forms;
using System.Drawing;
using System.Media;

namespace Personal_Calendar
{
    /// <summary>
    /// Interaction logic for TimePage.xaml
    /// </summary>
    public partial class TimerPage : Page
    {
        public DispatcherTimer timer = new DispatcherTimer();        

        public TimerPage()
        {
            InitializeComponent();
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Tick += new EventHandler(timerTimer);
        }

        private void eventButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(Globals.events);
        }
        private void clockButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(Globals.clock);
        }

        private void stopwatchButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(Globals.stopwatch);
        }

        private void startButton_Click(object sender, RoutedEventArgs e)
        {
            hourTxt.Focusable = false;
            minTxt.Focusable = false;
            secTxt.Focusable = false;
            try
            {
                Globals.hours = Convert.ToInt32(hourTxt.Text);
                Globals.minutes = Convert.ToInt32(minTxt.Text);
                Globals.seconds = Convert.ToInt32(secTxt.Text);
            }
            catch
            {
                System.Windows.MessageBox.Show("Not a valid time entry.", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
            }            
            timer.Start();
        }

        private void timerTimer(object sender, EventArgs e)
        {            

            if (Globals.seconds == 0 && Globals.minutes == 0 && Globals.hours != 0)
            {
                Globals.hours = Globals.hours - 1;
                Globals.minutes = 59;
                Globals.seconds = 59;
            }
            else if (Globals.seconds == 0 && Globals.minutes != 0)
            {
                Globals.minutes = Globals.minutes - 1;
                Globals.seconds = 59;
            }
            else
            {
                Globals.seconds = Globals.seconds - 1;
            }

            hourTxt.Text = Globals.hours.ToString();
            minTxt.Text = Globals.minutes.ToString();
            secTxt.Text = Globals.seconds.ToString();

            if (Globals.seconds == 0 && Globals.minutes == 0 && Globals.hours == 0)
            {
                timer.Stop();
                //MessageBox.Show("Time's up!");
                SoundPlayer player = new SoundPlayer(Globals.alarmAudio);

                NotifyIcon icon = new NotifyIcon();
                icon.Icon = SystemIcons.Application;                
                icon.Visible = true; 
                icon.ShowBalloonTip(500, "", "Your timer ended!", ToolTipIcon.Info);

                icon.BalloonTipClosed += new EventHandler(balloonClicked);
                icon.BalloonTipClicked += new EventHandler(balloonClicked);

                player.Play();

                hourTxt.Focusable = true;
                minTxt.Focusable = true;
                secTxt.Focusable = true;
            }
        }

        private void balloonClicked(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer();
            player.Stop();
        }

        private void stopButton_Click(object sender, RoutedEventArgs e)
        {
            hourTxt.Focusable = true;
            minTxt.Focusable = true;
            secTxt.Focusable = true;
            Globals.hours = 0;
            Globals.minutes = 0;
            Globals.seconds = 0;
            hourTxt.Text = Globals.hours.ToString();
            minTxt.Text = Globals.minutes.ToString();
            secTxt.Text = Globals.seconds.ToString();
            timer.Stop();
        }

        private void numericTextBox_PreviewKeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            int key = (int)e.Key;

            e.Handled = !(key >= 34 && key <= 43 ||
                          key >= 74 && key <= 83 ||
                          key == 2);
        }

        private void Label_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            TimerSettingsWindow timerSettings = new TimerSettingsWindow();            
            timerSettings.ShowDialog();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            hourTxt.Text = Globals.hours.ToString();
            minTxt.Text = Globals.minutes.ToString();
            secTxt.Text = Globals.seconds.ToString();
        }
    }
}