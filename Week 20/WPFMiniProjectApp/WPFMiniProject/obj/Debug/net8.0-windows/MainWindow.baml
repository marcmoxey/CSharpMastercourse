   M S B A M L   `   `   `  ����I  EWPFMiniProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:WPFMiniProjectWPFMiniProject  5   	       WPFMiniProject.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:WPFMiniProject     5   	   $��24(�5        � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $
��auto �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��1��6.   $��0��6>   $��	0,20,0,10q�6K   .+�5      �� $��0,0,5,0q�6   First Name:66   �� 5      -   5         ��Name$ firstNameTextBox��5      $	��200��60   $	��300��6?   5      �� 5   
   $ 
Horizontal=�6   $��1��6.   $��1��6>   .+�5      �� $��0,0,5,0q�6   
Last Name:65   �� 5      -   5        $ lasttNameTextBox��5      $	��200��60   $	��300��6?   5       �� 5!   
   $ 
Horizontal=�6   $��1��6.   $��2��6>   $��0,50,0,5q�6K   .+�5"      �� 	Addresses6#   �� 5#      -   5         ��Name$ addAddressBtn��5#      $��5q�6H   $��	165,0,0,0q�6T   .��6g   Add6l   �� 5$      -   5        $ editAddressBtn��5$      $��15,0,0,0q�6J   $��5q�6\   .��6h   Edit6n   �� 5%      -   5        $ deleteAddressBtn��5%      $��15,0,0,0q�6O   $��4q�6a   .��6n   Delete6v   5&      �� 5)   
   -   5         ��Name$ addressesListBox��5)      $��3��6,   $��1��69   $��0,5,0,5q�6I   ��5*      �� 5+      .R�5,      �� $ Vertical=�6!   .+�5-      �� ��6$   ��  �� Path$ StreetAddress��� 5.      $ 
Horizontal=�6%   .+�5/      �� $��12(�6C   ��6(   �� $
 City�6C   �� 50      $��, ��6(   $��12(�62   �� 51      $��12(�6D   ��6(   �� $ State�6D   �� 52      $��  ��6(   $��12(�62   �� 53      $��12(�6F   ��6(   �� $ ZipCode�6F   54      55      56      58      �� 5:   
   -   5        $ saveBtn��5:      $��1��6"   $��4��62   $	��0,5q�6U   .��6c   Save6i   5<      5=      