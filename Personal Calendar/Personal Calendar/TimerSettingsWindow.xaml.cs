using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
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
    /// Interaction logic for TimerSettingsWindow.xaml
    /// </summary>
    public partial class TimerSettingsWindow : Window
    {
        public BitmapImage play = new BitmapImage(new Uri(@"C:\Users\bbylsma\source\repos\Personal Calendar\playButton.png"));
        public SoundPlayer player = new SoundPlayer(Globals.alarmAudio);
        public TimerSettingsWindow()
        {
            InitializeComponent();
        }

        private void plainAlarmImage_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\bbylsma\source\repos\Personal Calendar\.wav");
            playAudioSettings(play, plainAlarmImage, player);            
        }
        
        private void groovyAlarmImage_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\bbylsma\source\repos\Personal Calendar\GroovyAlarm.wav");
            playAudioSettings(play, groovyAlarmImage, player);
        }

        private void relaxingAlarmImage_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\bbylsma\source\repos\Personal Calendar\RelaxingAlarm.wav");
            playAudioSettings(play, relaxingAlarmImage, player);
        }

        private void softAlarmImage_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\bbylsma\source\repos\Personal Calendar\SoftAlarm.wav");
            playAudioSettings(play, softAlarmImage, player);
        }

        private void turboAlarmImage_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\bbylsma\source\repos\Personal Calendar\TurboAlarm.wav");
            playAudioSettings(play, turboAlarmImage, player);
        }

        public void playAudioSettings(BitmapImage play, Image image, SoundPlayer audio)
        {
            if (image.Source.ToString() == play.ToString())
            {
                image.Source = new BitmapImage(new Uri(@"C:\Users\bbylsma\source\repos\Personal Calendar\stopButton.png"));
                audio.PlayLooping();
            }
            else
            {
                image.Source = new BitmapImage(new Uri(@"C:\Users\bbylsma\source\repos\Personal Calendar\playButton.png"));
                audio.Stop();
            }
        }

        private void plainAlarmLabel_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {            
            plainAlarmLabel.Content = "Current";
            groovyAlarmLabel.Content = "Use";
            softAlarmLabel.Content = "Use";
            quietAlarmLabel.Content = "Use";
            turboAlarmLabel.Content = "Use";
            Globals.currentAlarm = "plainAlarm";
            Globals.alarmAudio = @"C:\Users\bbylsma\source\repos\Personal Calendar\plainAlarm.wav";
        }

        private void groovyAlarmLabel_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            plainAlarmLabel.Content = "Use";
            groovyAlarmLabel.Content = "Current";
            softAlarmLabel.Content = "Use";
            quietAlarmLabel.Content = "Use";
            turboAlarmLabel.Content = "Use";
            Globals.currentAlarm = "groovyAlarm";
            Globals.alarmAudio = @"C:\Users\bbylsma\source\repos\Personal Calendar\groovyAlarm.wav";
        }

        private void quietAlarmLabel_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            plainAlarmLabel.Content = "Use";
            groovyAlarmLabel.Content = "Use";
            softAlarmLabel.Content = "Use";
            quietAlarmLabel.Content = "Current";
            turboAlarmLabel.Content = "Use";
            Globals.currentAlarm = "relaxingAlarm";
            Globals.alarmAudio = @"C:\Users\bbylsma\source\repos\Personal Calendar\relaxingAlarm.wav";
        }

        private void softAlarmLabel_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            plainAlarmLabel.Content = "Use";
            groovyAlarmLabel.Content = "Use";
            softAlarmLabel.Content = "Current";
            quietAlarmLabel.Content = "Use";
            turboAlarmLabel.Content = "Use";
            Globals.currentAlarm = "softAlarm";
            Globals.alarmAudio = @"C:\Users\bbylsma\source\repos\Personal Calendar\softAlarm.wav";
        }

        private void turboAlarmLabel_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            plainAlarmLabel.Content = "Use";
            groovyAlarmLabel.Content = "Use";
            softAlarmLabel.Content = "Use";
            quietAlarmLabel.Content = "Use";
            turboAlarmLabel.Content = "Current";
            Globals.currentAlarm = "turboAlarm";
            Globals.alarmAudio = @"C:\Users\bbylsma\source\repos\Personal Calendar\turboAlarm.wav";
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer();
            player.Stop();
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            switch (Globals.currentAlarm)
            {
                case "plainAlarm":
                    plainAlarmLabel.Content = "Current";
                    groovyAlarmLabel.Content = "Use";
                    softAlarmLabel.Content = "Use";
                    quietAlarmLabel.Content = "Use";
                    turboAlarmLabel.Content = "Use";
                    Globals.alarmAudio = @"C:\Users\bbylsma\source\repos\Personal Calendar\plainAlarm.wav";
                    break;
                case "groovyAlarm":
                    plainAlarmLabel.Content = "Use";
                    groovyAlarmLabel.Content = "Current";
                    softAlarmLabel.Content = "Use";
                    quietAlarmLabel.Content = "Use";
                    turboAlarmLabel.Content = "Use";
                    Globals.alarmAudio = @"C:\Users\bbylsma\source\repos\Personal Calendar\groovyAlarm.wav";
                    break;
                case "softAlarm":
                    plainAlarmLabel.Content = "Use";
                    groovyAlarmLabel.Content = "Use";
                    softAlarmLabel.Content = "Current";
                    quietAlarmLabel.Content = "Use";
                    turboAlarmLabel.Content = "Use";
                    Globals.alarmAudio = @"C:\Users\bbylsma\source\repos\Personal Calendar\\softAlarm.wav";
                    break;
                case "relaxingAlarm":
                    plainAlarmLabel.Content = "Use";
                    groovyAlarmLabel.Content = "Use";
                    softAlarmLabel.Content = "Use";
                    quietAlarmLabel.Content = "Current";
                    turboAlarmLabel.Content = "Use";
                    Globals.alarmAudio = @"C:\Users\bbylsma\source\repos\Personal Calendar\relaxingAlarm.wav";
                    break;
                case "turboAlarm":
                    plainAlarmLabel.Content = "Use";
                    groovyAlarmLabel.Content = "Use";
                    softAlarmLabel.Content = "Use";
                    quietAlarmLabel.Content = "Use";
                    turboAlarmLabel.Content = "Current";
                    Globals.alarmAudio = @"C:\Users\bbylsma\source\repos\Personal Calendar\turboAlarm.wav";
                    break;
            }
        }
    }
}