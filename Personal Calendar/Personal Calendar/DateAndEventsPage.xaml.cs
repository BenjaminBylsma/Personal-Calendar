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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Personal_Calendar
{
    /// <summary>
    /// Interaction logic for DateAndEventsPage.xaml
    /// </summary>
    public partial class DateAndEventsPage : Page
    {

        public DateAndEventsPage()
        {     
            InitializeComponent();
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
    }
}
