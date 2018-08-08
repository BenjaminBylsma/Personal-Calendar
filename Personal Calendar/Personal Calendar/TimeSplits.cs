using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Personal_Calendar
{
    public class TimeSplits : INotifyPropertyChanged
    {
        private string _posNeg;
        private int _hours;
        private int _minutes;
        private int _seconds;

        public string posNeg
        {
            get
            {
                return _posNeg;
            }
            set
            {
                _posNeg = value;
                NotifyPropertyChanged(nameof(posNeg));
            }
        }
        public int hours
        {
            get
            {
                return _hours;
            }
            set
            {
                _hours = value;
                NotifyPropertyChanged(nameof(hours));
            }
        }
        public int minutes
        {
            get
            {
                return _minutes;
            }
            set
            {
                _minutes = value;
                NotifyPropertyChanged(nameof(minutes));
            }
        }
        public int seconds
        {
            get
            {
                return _seconds;
            }
            set
            {
                _seconds = value;
                NotifyPropertyChanged(nameof(seconds));
            }
        }
        
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public static void checkTimes(int nextSplit, int currentTime, StopwatchPage stopwatch)
        {
            if (nextSplit - currentTime <= 30 && nextSplit - currentTime >= 0)
            {
                stopwatch.onTimeLabel.Content = "Cutting Close";
                stopwatch.onTimeLabel.BorderBrush = new SolidColorBrush(Colors.GreenYellow);
            }
            else if (nextSplit - currentTime >= 180)
            {
                stopwatch.onTimeLabel.Content = "Big Lead";
                stopwatch.onTimeLabel.BorderBrush = new SolidColorBrush(Colors.Gold);
            }
            else if (nextSplit - currentTime < 0)
            {
                stopwatch.onTimeLabel.Content = "Behind Time";
                stopwatch.onTimeLabel.BorderBrush = new SolidColorBrush(Colors.Red);
            }
            else
            {
                stopwatch.onTimeLabel.Content = "On Time";
                stopwatch.onTimeLabel.BorderBrush = new SolidColorBrush(Colors.Green);
            }
        }

        public override string ToString()
        {
            return hours.ToString() + ":" + minutes.ToString() + ":" + seconds.ToString();
        }
    }
}
