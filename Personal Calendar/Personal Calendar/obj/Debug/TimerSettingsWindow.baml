   M S B A M L   `   `   `  ����L  HPersonal Calendar, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Personal_CalendarPersonal_Calendar  5   	   +    %Personal_Calendar.TimerSettingsWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:Personal_Calendar     5   	   -   5          � Title$  TimerSettingsWindow��5   	   $	��350��6%   $	��200��62   .��5	      � .+�5
   
   �� ���	#FF1A94F9$
��Left=�6%   $	��319��6@   $��1,0,0,0q�6M   ���	#FF1A94F9$	��Top=�6q   $	��191��6�   �� 5   
   $��Plain Alarm��6   $
��Left=�6&   $��	10,10,0,0q�6A   $	��Top=�6T   $��78��6l   $��Comic Sans MS)�6w   $
��Bold"�6�   �� 5   
   $��Groovy Alarm��6   $
��Left=�6'   $��	10,62,0,0q�6B   $	��Top=�6U   $��91��6m   $��Comic Sans MS)�6x   $
��Bold"�6�   �� 5   
   $��Quiet Alarm��6   $
��Left=�6&   $��
10,114,0,0q�6A   $	��Top=�6U   $��91��6m   $��Comic Sans MS)�6x   $
��Bold"�6�   �� 5   
   $��
Soft Alarm��6   $
��Left=�6%   $��
10,166,0,0q�6@   $	��Top=�6T   $��78��6l   $
��Bold"�6w   $��Comic Sans MS)�6�   �� 5   
   $��Turbo Alarm��6   $
��Left=�6&   $��
10,218,0,0q�6A   $	��Top=�6U   $��82��6m   $
��Bold"�6x   $��Comic Sans MS)�6�   A� 5   
   
�������$
��Left=�6   $��25��6:   $��
100,12,0,0q�6F   
���   �$	��Top=�6i   $��25��6�   A� 5   
   
�������$
��Left=�6   $��25��6:   $��100,220,0,0q�6F   
���   �$	��Top=�6j   $��25��6�   A� 5   
   
�������$
��Left=�6   $��25��6:   $��100,168,0,0q�6F   
���   �$	��Top=�6j   $��25��6�   A� 5   
   
�������$
��Left=�6   $��25��6:   $��100,116,0,0q�6F   
���   �$	��Top=�6j   $��25��6�   A� 5   
   
�������$
��Left=�6   $��25��6:   $��
100,64,0,0q�6F   
���   �$	��Top=�6i   $��25��6�   �� 5   
   -   5         ��Name$ plainAlarmImage��5      $
��Left=�6)   $��24��6D   $��
101,13,0,0q�6P   $	��Top=�6d   $��23��6|   $����C:\Benjamin's\Benjamin's Kalos-Personal Calendar\Personal-Calendar-master\Personal Calendar\Personal Calendar\bin\Debug\playButton.png��6�   6  �� 5   
   -   5        $ turboAlarmImage��5      $
��Left=�6)   $��24��6D   $��101,221,0,0q�6P   $	��Top=�6e   $��23��6}   $����C:\Benjamin's\Benjamin's Kalos-Personal Calendar\Personal-Calendar-master\Personal Calendar\Personal Calendar\bin\Debug\playButton.png��6�   6  �� 5   
   -   5        $ softAlarmImage��5      $
��Left=�6(   $��24��6C   $��101,169,0,0q�6O   $	��Top=�6d   $��23��6|   $����C:\Benjamin's\Benjamin's Kalos-Personal Calendar\Personal-Calendar-master\Personal Calendar\Personal Calendar\bin\Debug\playButton.png��6�   6  �� 5   
   -   5        $ relaxingAlarmImage��5      $
��Left=�6,   $��24��6G   $��101,117,0,0q�6S   $	��Top=�6h   $��23��6�   $����C:\Benjamin's\Benjamin's Kalos-Personal Calendar\Personal-Calendar-master\Personal Calendar\Personal Calendar\bin\Debug\playButton.png��6�   6  �� 5   
   -   5        $ groovyAlarmImage��5      $
��Left=�6*   $��24��6E   $��
101,65,0,0q�6Q   $	��Top=�6e   $��23��6}   $����C:\Benjamin's\Benjamin's Kalos-Personal Calendar\Personal-Calendar-master\Personal Calendar\Personal Calendar\bin\Debug\playButton.png��6�   6  �� 5   
   -   5         ��Name$ plainAlarmLabel��5      $��Current��6)   $
��Left=�6;   $��
130,12,0,0q�6V   $	��Top=�6j   $��52��6�   $��Comic Sans MS)�6�   �� 5   
   -   5        $ turboAlarmLabel��5      $	��Use��6)   $
��Left=�67   $��130,218,0,0q�6R   $	��Top=�6g   $��52��6   $��Comic Sans MS)�6�   �� 5   
   -	   5        $ softAlarmLabel��5      $	��Use��6(   $
��Left=�66   $��130,166,0,0q�6Q   $	��Top=�6f   $��52��6~   $��Comic Sans MS)�6�   �� 5   
   -
   5        $ quietAlarmLabel��5      $	��Use��6)   $
��Left=�67   $��130,114,0,0q�6R   $	��Top=�6g   $��52��6   $��Comic Sans MS)�6�   �� 5   
   -   5        $ groovyAlarmLabel��5      $	��Use��6*   $
��Left=�68   $��
130,62,0,0q�6S   $	��Top=�6g   $��52��6   $��Comic Sans MS)�6�   5      5       