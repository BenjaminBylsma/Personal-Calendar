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

namespace Personal_Calendar
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public static class Globals
    {
        public static Page clock = new ClockPage();
        public static Page events = new DateAndEventsPage();
        public static Page timer = new TimerPage();
        public static Page stopwatch = new StopwatchPage();
        public static string currentAlarm = "plainAlarm";
        public static int hours;
        public static int minutes;
        public static int seconds;
        public static int sHours;
        public static int sMinutes;
        public static int sSeconds;
        public static int sMSeconds;
        public static string alarmAudio = @"C:\Users\bbylsma\source\repos\Personal Calendar\PlainAlarm.wav";
    }

    public partial class MainWindow : NavigationWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
