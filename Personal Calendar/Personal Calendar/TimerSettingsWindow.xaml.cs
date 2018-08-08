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
        public BitmapImage play = new BitmapImage(new Uri(@"C:\Benjamin's\Benjamin's Kalos-Personal Calendar\Personal-Calendar-master\Personal Calendar\Personal Calendar\bin\Debug\playButton.png"));
        public SoundPlayer player = new SoundPlayer(Globals.alarmAudio);
        public TimerSettingsWindow()
        {
            InitializeComponent();
        }

        private void plainAlarmImage_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Benjamin's\Benjamin's Kalos-Personal Calendar\Personal-Calendar-master\Personal Calendar\Personal Calendar\bin\Debug\plainAlarm.wav");
            playAudioSettings(play, plainAlarmImage, player);            
        }
        
        private void groovyAlarmImage_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Benjamin's\Benjamin's Kalos-Personal Calendar\Personal-Calendar-master\Personal Calendar\Personal Calendar\bin\Debug\GroovyAlarm.wav");
            playAudioSettings(play, groovyAlarmImage, player);
        }

        private void relaxingAlarmImage_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Benjamin's\Benjamin's Kalos-Personal Calendar\Personal-Calendar-master\Personal Calendar\Personal Calendar\bin\Debug\RelaxingAlarm.wav");
            playAudioSettings(play, relaxingAlarmImage, player);
        }

        private void softAlarmImage_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Benjamin's\Benjamin's Kalos-Personal Calendar\Personal-Calendar-master\Personal Calendar\Personal Calendar\bin\Debug\SoftAlarm.wav");
            playAudioSettings(play, softAlarmImage, player);
        }

        private void turboAlarmImage_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Benjamin's\Benjamin's Kalos-Personal Calendar\Personal-Calendar-master\Personal Calendar\Personal Calendar\bin\Debug\TurboAlarm.wav");
            playAudioSettings(play, turboAlarmImage, player);
        }

        public void playAudioSettings(BitmapImage play, Image image, SoundPlayer audio)
        {
            if (image.Source.ToString() == play.ToString())
            {
                plainAlarmImage.Source = new BitmapImage(new Uri(@"C:\Benjamin's\Benjamin's Kalos-Personal Calendar\Personal-Calendar-master\Personal Calendar\Personal Calendar\bin\Debug\playButton.png"));
                groovyAlarmImage.Source = new BitmapImage(new Uri(@"C:\Benjamin's\Benjamin's Kalos-Personal Calendar\Personal-Calendar-master\Personal Calendar\Personal Calendar\bin\Debug\playButton.png"));
                relaxingAlarmImage.Source = new BitmapImage(new Uri(@"C:\Benjamin's\Benjamin's Kalos-Personal Calendar\Personal-Calendar-master\Personal Calendar\Personal Calendar\bin\Debug\playButton.png"));
                softAlarmImage.Source = new BitmapImage(new Uri(@"C:\Benjamin's\Benjamin's Kalos-Personal Calendar\Personal-Calendar-master\Personal Calendar\Personal Calendar\bin\Debug\playButton.png"));
                turboAlarmImage.Source = new BitmapImage(new Uri(@"C:\Benjamin's\Benjamin's Kalos-Personal Calendar\Personal-Calendar-master\Personal Calendar\Personal Calendar\bin\Debug\playButton.png"));

                image.Source = new BitmapImage(new Uri(@"C:\Benjamin's\Benjamin's Kalos-Personal Calendar\Personal-Calendar-master\Personal Calendar\Personal Calendar\bin\Debug\stopButton.png"));
                audio.PlayLooping();
            }
            else
            {
                image.Source = new BitmapImage(new Uri(@"C:\Benjamin's\Benjamin's Kalos-Personal Calendar\Personal-Calendar-master\Personal Calendar\Personal Calendar\bin\Debug\playButton.png"));
                audio.Stop();
            }
        }

        private void plainAlarmLabel_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Globals.currentAlarm = "plainAlarm";
            AudioManager.setAudio(this);
        }

        private void groovyAlarmLabel_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Globals.currentAlarm = "groovyAlarm";
            AudioManager.setAudio(this);
        }

        private void quietAlarmLabel_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Globals.currentAlarm = "relaxingAlarm";
            AudioManager.setAudio(this);
        }

        private void softAlarmLabel_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Globals.currentAlarm = "softAlarm";
            AudioManager.setAudio(this);
        }

        private void turboAlarmLabel_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Globals.currentAlarm = "turboAlarm";
            AudioManager.setAudio(this);
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer();
            player.Stop();
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            AudioManager.setAudio(this);
        }
    }
}