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
using System.Windows.Shapes;

namespace Personal_Calendar
{
    /// <summary>
    /// Interaction logic for EventSetterWindow.xaml
    /// </summary>
    public partial class EventSetterWindow : Window
    {        

        public EventSetterWindow()
        {
            InitializeComponent();        
        }

        private void addEventButton_Click(object sender, RoutedEventArgs e)
        {
            if (eventNameTxt.Text != "" && eventHourTxt.Text != "" && eventMinTxt.Text != "")
            {
                Events events = new Events();
                events.name = eventNameTxt.Text;
                events.time = new DateTime(Globals.eventDate.Year, Globals.eventDate.Month, Globals.eventDate.Day, Convert.ToInt32(eventHourTxt.Text), Convert.ToInt32(eventMinTxt.Text), 0).ToShortTimeString();
                events.date = Convert.ToDateTime(events.time);

                Globals.savedEvents.Add(events);
                this.Close();
            }
            else
            {
                MessageBox.Show("Fill all fields before saving the event.", "INFORMATION", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }        
    }
}
