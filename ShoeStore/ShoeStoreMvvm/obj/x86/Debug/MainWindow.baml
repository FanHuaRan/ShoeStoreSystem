   M S B A M L   `   `   `  ����I  ESimpleMvvm-Wpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:ShoeStoreMvvm.ViewsShoeStoreMvvm.Views  5   	   -clr-namespace:ShoeStoreMvvmShoeStoreMvvm  5   	       ShoeStoreMvvm.MainWindow   5   	   +Views!clr-namespace:ShoeStoreMvvm.Views  R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   *myclr-namespace:ShoeStoreMvvm     5   	   c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   	   h dMicrosoft.Expression.Interactions, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bei9http://schemas.microsoft.com/expression/2010/interactions  5   	   -   5          �Name$  
mainWindow��5   	    � Title$ 
MainWindow��5   	   $
��1080��6   $
��1260��6*    � WindowState$ 	Maximized=�5
   	    � WindowStartupLocation$ CenterScreen=�5   	    � WindowStyle$
 None=�5   	      BackgroundBrush#��[  5   	    � DataContext 5	   	   ��   Locator �� Source# [  �� Path$ MainPageViewModel�.  (System.Windows.Interactivity.Interaction   Triggers 5      /  )System.Windows.Interactivity.EventTrigger  5   
   	   	EventName$	 Loaded��6   .  (System.Windows.Interactivity.TriggerBase
   Actions.
 5      6  0System.Windows.Interactivity.InvokeCommandAction     Command 6$   �� *LoadWindowCommand+5       � 	Resources 5      ��%    5      .��5      � $��0q�6    � RowDefinitions 5   
   �� 5      $��20 �6   �� 5      $��60 �6   �� 5      $��* �6   .+�5   
   � $��0��6   ���#26272b.+�5      �� $
��Left=�6   .+�5       ��   
TitleStyle#��[ 6   .��6<   XXX名鞋系统6E   5!      �� 5"      $��Right=�6    �� Orientation$ 
Horizontal=�65   .+�5#      �� $	��—��6     	MBtStyleG#��[ 6%    5$        5%      $	 Click��6)   .
 5&         64   �� *MinWindowCommand+   CommandParameter 6Y   ��  �� ElementName$ 
mainWindow��5'      5)      �� 5*      $	��口��6   #��[ 6%    5+        5,      $	 Click��6)   .
 5-         64   �� *MaxWindowCommand+ 6Y   �� $ 
mainWindow��5.      50      �� 51      $��X��6   #��[ 6%   
���Gc�� 53        54      $	 Click��6)   .
 55      >  8Microsoft.Expression.Interactivity.Core.CallMethodAction     
MethodName$
 Exit��57         TargetObject 56      �� 57      58      5:      5;      5<      � 5>   
   -   5         �Name$ disPlayTopView��5>      $��1��6'   .+�5?      � $��0,0,0,20q�6   #��[  6%    � ColumnDefinitions 5@      �� 5A      $
��Auto �6'   66   �� 5B      $��10 �6'   64   �� 5C      $��* �6'   63   �� 5D      $
��Auto �6'   66   .+�5F      �� -   5         ��Name$ GoBackBT��5F   )    �� IsCancel . $��0��5G      $��40��5H      $��
5,7,8.2,-7q�5I        BackButtonStyle#��[ 5J       5K        5L      $	 Click��6)   .
 5M         64   �� *ReturnCommand+5N      5P      �� 5Q      -   5         ��Name$ 	PageBlock��5Q      $��0q�5R      $��返回��6'   $��Microsoft Jhenghei)�5S      $��2��6<     PageHeaderTextStyle#��[ 5T      5U      5V      5W      � 5Y   
   -   5        $��ViewContiner��5Y      $��2��6#   5Z      5[      5\      