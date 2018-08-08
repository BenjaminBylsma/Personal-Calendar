using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Calendar
{
    class AudioManager
    {
        public static void setAudio(TimerSettingsWindow timerSettings)
        {
            switch (Globals.currentAlarm)
            {
                case "plainAlarm":
                    timerSettings.plainAlarmLabel.Content = "Current";
                    timerSettings.groovyAlarmLabel.Content = "Use";
                    timerSettings.softAlarmLabel.Content = "Use";
                    timerSettings.quietAlarmLabel.Content = "Use";
                    timerSettings.turboAlarmLabel.Content = "Use";
                    Globals.alarmAudio = @"C:\Benjamin's\Benjamin's Kalos-Personal Calendar\Personal-Calendar-master\Personal Calendar\Personal Calendar\bin\Debug\plainAlarm.wav";
                    break;
                case "groovyAlarm":
                    timerSettings.plainAlarmLabel.Content = "Use";
                    timerSettings.groovyAlarmLabel.Content = "Current";
                    timerSettings.softAlarmLabel.Content = "Use";
                    timerSettings.quietAlarmLabel.Content = "Use";
                    timerSettings.turboAlarmLabel.Content = "Use";
                    Globals.alarmAudio = @"C:\Benjamin's\Benjamin's Kalos-Personal Calendar\Personal-Calendar-master\Personal Calendar\Personal Calendar\bin\Debug\groovyAlarm.wav";
                    break;
                case "softAlarm":
                    timerSettings.plainAlarmLabel.Content = "Use";
                    timerSettings.groovyAlarmLabel.Content = "Use";
                    timerSettings.softAlarmLabel.Content = "Current";
                    timerSettings.quietAlarmLabel.Content = "Use";
                    timerSettings.turboAlarmLabel.Content = "Use";
                    Globals.alarmAudio = @"C:\Benjamin's\Benjamin's Kalos-Personal Calendar\Personal-Calendar-master\Personal Calendar\Personal Calendar\bin\Debug\softAlarm.wav";
                    break;
                case "relaxingAlarm":
                    timerSettings.plainAlarmLabel.Content = "Use";
                    timerSettings.groovyAlarmLabel.Content = "Use";
                    timerSettings.softAlarmLabel.Content = "Use";
                    timerSettings.quietAlarmLabel.Content = "Current";
                    timerSettings.turboAlarmLabel.Content = "Use";
                    Globals.alarmAudio = @"C:\Benjamin's\Benjamin's Kalos-Personal Calendar\Personal-Calendar-master\Personal Calendar\Personal Calendar\bin\Debug\relaxingAlarm.wav";
                    break;
                case "turboAlarm":
                    timerSettings.plainAlarmLabel.Content = "Use";
                    timerSettings.groovyAlarmLabel.Content = "Use";
                    timerSettings.softAlarmLabel.Content = "Use";
                    timerSettings.quietAlarmLabel.Content = "Use";
                    timerSettings.turboAlarmLabel.Content = "Current";
                    Globals.alarmAudio = @"C:\Benjamin's\Benjamin's Kalos-Personal Calendar\Personal-Calendar-master\Personal Calendar\Personal Calendar\bin\Debug\turboAlarm.wav";
                    break;
            }
        }
    }
}
