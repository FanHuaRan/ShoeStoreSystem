   M S B A M L   `   `   `  ����  SimpleMvvm-Wpf     ShoeStoreMvvm.CustomerView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5      h dMicrosoft.Expression.Interactions, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bei9http://schemas.microsoft.com/expression/2010/interactions  5      .��5      � -   5          �Name$  
LayoutRoot��5      
�������$	��150��62   $	��300��6?    � DataContext 5      ��    Locator �� Source# [   �� Path$ CustomerViewModel� � ColumnDefinitions 5   
   �� 5      �� 5       � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      .+�5   
   �� $��Customer Id:��6   $��0��6'   �� 5   
   $��0��6   $��1��6   $��30��6/   ��5      �� $ Model.CustomerId��� 5   
   $��Customer Name:��6   $��1��6)   �� 5   
   $��1��6   $��1��6   $��30��6/   ��5      �� $ Model.CustomerName��� 5   
   $��Customer City:��6   $��2��6)   �� 5   
   $��2��6   $��1��6   $��30��6/   ��5      �� $ 
Model.City��� 5    
   $��New Customer��6   $��3��6(   $��2��65   $��30��5!      $	��100��6   .  (System.Windows.Interactivity.Interaction   Triggers 5"      /  )System.Windows.Interactivity.EventTrigger  5#         	EventName$ Click��6!   .  (System.Windows.Interactivity.TriggerBase   Actions. 5$      >  8Microsoft.Expression.Interactivity.Core.CallMethodAction  	   
MethodName$	 NewCustomer��5&      
   TargetObject
 5%      �� 5&      5'      5)      5*      6   