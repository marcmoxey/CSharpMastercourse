   M S B A M L   `   `   `  ����D  @WPFBudget, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:WPFBudget	WPFBudget  5   	       WPFBudget.ExpenseEntry   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:WPFBudget     5   	   $��24(�5        � Title$  ExpenseEntry��5   	   $	��450��6   $	��800��6+   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��* �6   �� 5      $
��auto �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   .+�5   
   �� $��Monthly Expeneses��6   $��1��6-   $��0��6=   $��26(�6J   $
��Bold"�6X   6l   �� 5   
    �� Orientation$ Vertical=�6   $��1��6,   $��1��69   .+�5      �  5      �� 5      $
��Auto �6$   �� 5      $
��Auto �6$    5      �� 5       $��* �6'   �� 5!      $
��Auto �6'   .+�5%      �� $��0��6   $��0��6)   $��Expense Name��69   �� 5&      -   5         ��Name$ expenseNameTextBox��5&      $��0��66   $��1��6C   $��10,0,0,0q�6T   $	��200��6f   $	��300��6u   6�   �� 5)      $��1��6   $��0��6)   $��Expense Amount��69   �� 5*      -   5        $ expenseAmountTextBox��5*      $��1��68   $��1��6E   $��10,0,0,0q�6U   $	��200��6g   $	��300��6v   6�   5+      5,      �� 5-   
   -   5         ��Name$ saveBtn��5-      $��1��68   $��2��6H   $��15q�6U   .��6a   Save6g   5.      5/      