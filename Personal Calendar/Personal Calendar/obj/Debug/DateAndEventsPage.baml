   M S B A M L   `   `   `  ����L  HPersonal Calendar, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Personal_CalendarPersonal_Calendar  5      )    #Personal_Calendar.DateAndEventsPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:Personal_Calendar     5      -   5          N� Title$  DateAndEventsPage��5      $	��644��6!   $	��800��6.   .��5	      � .+�5
   
   �� $
��Left=�6   $	��644��6/   $	��Top=�6<   $	��800��6T   ���	#FF1A94F9���	#FF1A94F96q   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 
eventsGrid��5      $��Right=�6'   $��	0,0,24,85q�6C   $	��766��6V   $��Comic Sans MS)�6b   $��16(�6}   $	��300��6�   $��Bottom=�6�   ��6�   �� *	eventData+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   CanUserResize .     Header$ Event��6w      Width5  /System.Windows.Controls.DataGridLengthConverter$	 500 6�      CanUserSort .  1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *name+   ClipboardContentBinding 6T   Z� 6�     5       .  $
 Date��6w   $	 150 6�   	   SortDirection$	 	AscendingX�6�    6%   �� *date+ 6T   Z� 6�     5       .  $
 Time��6w   $	 125 6�    .   6%   �� *time+ 6T   Z� 6�   5      �� 5   
   -   5        
 ��Name$
 removeButton��5      $��Remove Event��6'   $��	0,0,24,50q�6>   $��Right=�6Q   $	��115��6m   $��30��6y   $��Bottom=�6�   $��Comic Sans MS)�6�   $��16(�6�   $
��Bold"�6�   ���	#FF078AF7$��3,.51,.51,2q�6�   ���	#FF383838
�������6;  �� 5   
   -   5        $
 silenceButton��5      $��Silence Event��6(   $��
0,0,675,50q�6@   $��Right=�6T   $	��115��6p   $��30��6|   $��Bottom=�6�   $��Comic Sans MS)�6�   $��16(�6�   $
��Bold"�6�   ���	#FF078AF7$��3,.51,.51,2q�6�   ���	#FF383838
�������6>  &   System.Windows.Controls.Calendar  5   
   -   5          Name$ eventCalendar��5      $
��Left=�6*   $��	10,86,0,0q�6E   $	��Top=�6X      SelectionMode$ 
SingleDate=�6p   6�   �� 5   
   -   5        $
 timerButton��5      $��Timer��6&   $
��Left=�66   $��
437,40,0,0q�6Q   $	��Top=�6e   $	��100��6}   $��30��6�   $��Comic Sans MS)�6�   $��16(�6�   $
��Bold"�6�   ���	#FF078AF7$��3,.51,.51,2q�6�   ���	#FF383838
�������60  �� 5   
   -   5        $
 clockButton��5      $��Clock��6&   $
��Left=�66   $��
262,40,0,0q�6Q   $	��Top=�6e   $	��100��6}   $��30��6�   $��Comic Sans MS)�6�   $��16(�6�   $
��Bold"�6�   ���	#FF078AF7$��3,.51,.51,2q�6�   ���	#FF383838
�������60  �� 5   
   -   5        $
 stopwatchButton��5      $��	Stopwatch��6*   $
��Left=�6>   $��
612,40,0,0q�6Y   $	��Top=�6m   $	��100��6�   $��30��6�   $��Comic Sans MS)�6�   $��16(�6�   $
��Bold"�6�   ���	#FF078AF7$��3,.51,.51,2q�6�   ���	#FF383838
�������68  �� 5   
   -	   5        $
 eventsButton��5      $��Events��6'   $
��Left=�68   $��	88,40,0,0q�6S   $	��Top=�6f   $	��100��6~   $��30��6�   $��Comic Sans MS)�6�   $��16(�6�   $
��Bold"�6�   ���	#FF078AF7$��3,.51,.51,2q�6�   ���	#FF383838
�������6  �� 5   
   -
   5        $
 addEventButton��5      $��	Add Event��6)   $
��Left=�6=   $��194,161,0,0q�6X   $	��Top=�6m   $	��100��6�   $��30��6�   $��Comic Sans MS)�6�   $��16(�6�   $
��Bold"�6�   ���	#FF078AF7$��3,.51,.51,2q�6�   ���	#FF383838
�������68  5      5      