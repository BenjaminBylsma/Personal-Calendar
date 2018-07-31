using System;
using System.Collections.Generic;
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
    /// Interaction logic for TimerPage.xaml
    /// </summary>
    public partial class ClockPage : Page
    {
        public DispatcherTimer timer = new DispatcherTimer();
        public ClockPage()
        {
            InitializeComponent();            
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Tick += new EventHandler(clockTimer);
            timer.Start();
    }

        private void eventButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(Globals.events);
        }
        private void stopwatchButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(Globals.stopwatch);
        }

        private void timerButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(Globals.timer);
        }

        private void clockTimer(object sender, EventArgs e)
        {
            hourTxt.Text = DateTime.Now.ToLongTimeString().Split(' ')[0];
            hourTxt1.Text = DateTime.Now.AddHours(-2).ToLongTimeString().Split(' ')[0];
            hourTxt2.Text = DateTime.Now.AddHours(-1).ToLongTimeString().Split(' ')[0];
            hourTxt3.Text = DateTime.Now.AddHours(1).ToLongTimeString().Split(' ')[0];
        }
    }
}
