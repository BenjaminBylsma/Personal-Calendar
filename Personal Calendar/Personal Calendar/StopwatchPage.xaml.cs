using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Drawing;
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
        public event PropertyChangedEventHandler PropertyChanged;
        public DispatcherTimer timer = new DispatcherTimer();

        public ObservableCollection<TimeSplits> splits { get; set; } = new ObservableCollection<TimeSplits>();
        public ObservableCollection<TimeSplits> savedSplits { get; set; } = new ObservableCollection<TimeSplits>();
        public ObservableCollection<TimeSplits> splitDiff { get; set; } = new ObservableCollection<TimeSplits>();

        private int _Hours;
        private int _Minutes;
        private int _Seconds;
        private int _MilSeconds;

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
            timer.Interval = TimeSpan.FromSeconds(1);
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
            splitButton.IsEnabled = true;
            loadSavedSplitsButton.IsEnabled = false;
            saveSplitButton.IsEnabled = false;
        }

        private void pauseButton_Click(object sender, RoutedEventArgs e)
        {
            timer.Stop();
            splitButton.IsEnabled = false;
            loadSavedSplitsButton.IsEnabled = true;
            saveSplitButton.IsEnabled = true;
        }

        private void resetButton_Click(object sender, RoutedEventArgs e)
        {
            timer.Stop();
            splitButton.IsEnabled = true;
            Hours = 0;
            Minutes = 0;
            Seconds = 0;
            splits.Clear();
            splitDiff.Clear();
            savedSplits.Clear();
            onTimeLabel.Content = "";
            onTimeLabel.BorderBrush = new SolidColorBrush(Colors.White);
        }

        private void saveSplitButton_Click(object sender, RoutedEventArgs e)
        {
            using (var writer = new StreamWriter(@"C:\Benjamin's\Benjamin's Kalos-Personal Calendar\Personal-Calendar-master\Personal Calendar\splitSaves.csv"))
            {
                for (var y = 0; y < splits.Count; y++)
                {
                    writer.WriteLine(splits[y].hours + ":" + splits[y].minutes + ":" + splits[y].seconds);
                }                
            }            
        }

        private void stopwatchTimer(object sender, EventArgs e)
        {
            Seconds++;            
            if (Seconds == 59)
            {
                if (Minutes == 59)
                {
                    Hours++;
                    Minutes = 0;
                    Seconds = 0;
                }
                else
                {
                    Minutes++;
                    Seconds = 0;
                }
            }

            try
            {
                string nextSplit = savedSplitsListBox.Items[newSplitListBox.Items.Count].ToString();
                string time = hourTxt.Text + ":" + minTxt.Text + ":" + secTxt.Text;               
                
                string[] info = nextSplit.Split(':');
                string[] info2 = time.Split(':');
                int nextSavedSplit = ((Convert.ToInt32(info[0]) * 3600) + (Convert.ToInt32(info[1]) * 60) + (Convert.ToInt32(info[2])));
                int currentTime = ((Convert.ToInt32(info2[0]) * 3600) + (Convert.ToInt32(info2[1]) * 60) + (Convert.ToInt32(info2[2])));

                TimeSplits.checkTimes(nextSavedSplit, currentTime, this);
            }
            catch(System.ArgumentOutOfRangeException)
            {
                if (newSplitListBox.Items.Count == savedSplitsListBox.Items.Count && savedSplitsListBox.Items.Count != 0)
                {
                    string nextSplit = savedSplitsListBox.Items[newSplitListBox.Items.Count - 1].ToString();
                    string time = newSplitListBox.Items[newSplitListBox.Items.Count - 1].ToString();

                    string[] info = nextSplit.Split(':');
                    string[] info2 = time.Split(':');
                    int nextSavedSplit = ((Convert.ToInt32(info[0]) * 3600) + (Convert.ToInt32(info[1]) * 60) + (Convert.ToInt32(info[2])));
                    int currentTime = ((Convert.ToInt32(info2[0]) * 3600) + (Convert.ToInt32(info2[1]) * 60) + (Convert.ToInt32(info2[2])));

                    TimeSplits.checkTimes(nextSavedSplit, currentTime, this);
                }
                else if (newSplitListBox.Items.Count == 0)
                {

                }
                else
                {
                    onTimeLabel.Content = "New Times";
                    onTimeLabel.BorderBrush = new SolidColorBrush(Colors.Yellow);
                }
            }
        }

        private void splitButton_Click(object sender, RoutedEventArgs e)
        {
            TimeSplits split = new TimeSplits();
            split.hours = Hours;
            split.minutes = Minutes;
            split.seconds = Seconds;
            splits.Add(split);

            try
            {
                string nextSplit = savedSplitsListBox.Items[newSplitListBox.Items.Count - 1].ToString();
                string time = newSplitListBox.Items[newSplitListBox.Items.Count - 1].ToString();

                string[] info = nextSplit.Split(':');
                string[] info2 = time.Split(':');
                int nextSavedSplit = ((Convert.ToInt32(info[0]) * 3600) + (Convert.ToInt32(info[1]) * 60) + (Convert.ToInt32(info[2])));
                int currentTime = ((Convert.ToInt32(info2[0]) * 3600) + (Convert.ToInt32(info2[1]) * 60) + (Convert.ToInt32(info2[2])));

                TimeSplits.checkTimes(nextSavedSplit, currentTime, this);

                TimeSplits diffSplit = new TimeSplits();

                if (onTimeLabel.BorderBrush.ToString() == "#FFFF0000")
                {
                    int total = currentTime - nextSavedSplit;
                    diffSplit.hours = total / 3600;
                    diffSplit.minutes = (total - (diffSplit.hours * 3600)) / 60;
                    diffSplit.seconds = (total - ((diffSplit.hours * 3600) + (diffSplit.minutes * 60)));
                    diffSplit.posNeg = "-";
                    splitDiff.Add(diffSplit);
                }
                else
                {
                    int total = nextSavedSplit - currentTime;
                    diffSplit.hours = total / 3600;
                    diffSplit.minutes = (total - (diffSplit.hours * 3600)) / 60;
                    diffSplit.seconds = (total - ((diffSplit.hours * 3600) + (diffSplit.minutes * 60)));
                    diffSplit.posNeg = "+";
                    splitDiff.Add(diffSplit);
                }
            }
            catch (System.ArgumentOutOfRangeException)
            {
                onTimeLabel.Content = "New Times";
                onTimeLabel.BorderBrush = new SolidColorBrush(Colors.Yellow);               
            }
        }

        private void loadSavedSplitsButton_Click(object sender, RoutedEventArgs e)
        {
            using (var reader = new StreamReader(@"C:\Benjamin's\Benjamin's Kalos-Personal Calendar\Personal-Calendar-master\Personal Calendar\splitSaves.csv"))
            {
                while (reader.Peek() > -1)
                {
                    string[] info = reader.ReadLine().Split(':');
                    TimeSplits split = new TimeSplits();
                    split.hours = Convert.ToInt32(info[0]);
                    split.minutes = Convert.ToInt32(info[1]);
                    split.seconds = Convert.ToInt32(info[2]);
                    savedSplits.Add(split);
                }
            }
        }
    }
}
