   M S B A M L   `   `   `  ����  SimpleMvvm-Wpf,    &ShoeStoreMvvm.Views.SubSystemMenusView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5      h dMicrosoft.Expression.Interactions, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bei9http://schemas.microsoft.com/expression/2010/interactions  5      :d2http://schemas.microsoft.com/expression/blend/2008  5        � DataContext  5
      ��    Locator �� Source# [   �� Path$ SubSystemMenusViewModel� � 	Resources 5        LoadedStoryboard g� FillBehavior �� TargetProperty �� 
TargetName O� KeyTime O� Value  BorderBrushHideStoryboard	 �� KeyTime
 �� Value  BorderBrushShowStoryboard  ListBoxItemStyle1 �� 
TargetType �� Property �� Value �� 
TargetType �� Triggers :� 
SourceName :� RoutedEvent J� Opacity J� Effect3  -System.Windows.Media.Effects.DropShadowEffect   RenderingBias   Opacity   
BlurRadius   ShadowDepth   Color �Name � RowDefinitions��%�  &	       &	 �     &	 �    &	 �    7  7  �� 5   
   $ HoldEnd=�6.   .��5      U� $ Opacity�6,   $ BorderBT��6Q   .\�5      �� $ 00:00:00��6(   $ 0Q�6;   6G   �� 5      $ 	00:00:0.2��6(   $ 1Q�6<   6H   5      5      �� 5   
   $ HoldEnd=�67   .��5      �� $2 ,(Border.BorderBrush).(SolidColorBrush.Color)�6+   $ BorderBT��6t   .g�5      �� $	 00:00:00��6&   $
 #3B8DBD��69   6K   �� 5      $	 	00:00:0.1��6&   $
 Transparent��6:   6P   5      5      �� 5   
   $ HoldEnd=�67   .��5      �� $2 ,(Border.BorderBrush).(SolidColorBrush.Color)�6+   $ BorderBT��6t   .g�5      �� $	 00:00:00��6&   $
 Transparent��69   6O   �� 5      $	 	00:00:0.1��6&   $
 #3B8DBD��6:   6L   5      5      �� 5"   
   " ��6*   .�5#      ��  � �� 5$      �� 5%      " ��6'    5&      :� 5(      $ BorderBT��6+   $ 
MouseEnter��6A   [�5)   "   �� 5*   &   8��  6p   5,      :� 5.      $ BorderBT��6+   $ 
MouseLeave��6A   [�5/   "   �� 50   &   8�� 6p   52      .R�55      �� $��BorderBT��6.   $ 1Q�6"   $	��200��6>   $	��350��6K   
������ $��25q�6q   
������ $��5q�6�    56        57   "   $ Quality=�63   $ 1Q�6K   $ 10Q�6W   $ 5Q�6g   $ #C2C2C2��6w   6�   ._�59      � $ Grid1��6$   ���#EFEBEF$��0q�6H    5:   "   �� 5;   &   $��3* �64   6B   �� 5<   &   $��* �64   6A   .+�5>   "   �� $��Image1��6)   $��0��6\   $��Uniform=�6i   $��10q�6{   ��67   �� $ ModuleImage�6�   �� 5?   "   $��Label1��6(   $��1��6Z   $��Center=�6g   $��BankGothic Md BT)�6�   $��20(�6�   ��66   �� $ 
ModuleName�6�   5@      5A      5B      5D      5E      5F      .��5H      �� -   5         ��Name$ moduleListBox��5H      
������ $��Center=�5I      $��Center=�63     BackgroundBrush#��[ 5J      #��[ 6D   ��5H   ?   �� $ 
ModuleList���5K   
   �� 5L      .R�5M      �  � Orientation$ Vertical=�6   $	��600��63   $��0q�6@   6N   5N      .  (System.Windows.Interactivity.Interaction   Triggers 5P   
   /  )System.Windows.Interactivity.EventTrigger  5Q         	EventName$ SelectionChanged��6   .  (System.Windows.Interactivity.TriggerBase   Actions. 5R      6  0System.Windows.Interactivity.InvokeCommandAction      Command  6(   �� *SelectCommand+!   CommandParameter! 6J   �� " �� ElementName$" moduleListBox��5S      5U      5V      