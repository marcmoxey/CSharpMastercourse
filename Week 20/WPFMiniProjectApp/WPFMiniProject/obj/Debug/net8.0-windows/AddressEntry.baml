   M S B A M L   `   `   `  ����I  EWPFMiniProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:WPFMiniProjectWPFMiniProject  5   	   !    WPFMiniProject.AddressEntry   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:WPFMiniProject     5   	   $��24(�5        � Title$  AddressEntry��5   	   $	��450��6   $	��800��6+   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   �� $��0,20,0,0q�6   $��1��6&   $��0��66   $��26(�6C   $
��Bold"�6Q   Address Entry6r   �� 5   
    �� Orientation$ 
Horizontal=�6   $��1��6.   $��1��6>   $��0,20,0,0q�6K   .+�5      �� $��0,0,5,0q�6   	Street:62   �� 5      -   5         ��Name$ streetAddressTextBox��5      $	��200��64   $	��300��6C   5      �� 5    
   $ 
Horizontal=�6   $��1��6.   $��2��6>   $��0,5,0,0q�6K   .+�5!      �� $��0,0,5,0q�6   City:60   �� 5"      -   5        $ cityTextBox��5"      $	��200��6+   $	��300��6:   5#      �� 5$   
   $ 
Horizontal=�6   $��1��6.   $��3��6>   $��0,5,0,0q�6K   .+�5%      �� $��0,0,5,0q�6   State:61   �� 5&      -   5        $ stateTextBox��5&      $	��200��6,   $	��300��6;   5'      �� 5(   
   $ 
Horizontal=�6   $��1��6.   $��4��6>   $��0,5,0,0q�6K   .+�5)      �� $��0,0,5,0q�6   	Zip Code:64   �� 5*      -   5        $ zipCodeTextBox��5*      $	��200��6.   $	��300��6=   5+      �� 5,   
   -   5         ��Name$ saveBtn��5,      $��1��6"   $��5��62   $��0,15,0,0q�6?   .��6g   Save6m   5-      5.      