   M S B A M L   `   `   `  ����N  JInventoryAccounting, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:InventoryAccountingInventoryAccounting  5   	   !    InventoryAccounting.Profile   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:InventoryAccounting     5   	     � Title$  Profile��5   	   $	��450��6   $	��800��6&   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��365* �6   �� 5      $
��100* �6    � ColumnDefinitions 5   
   �� 5      $
��713* �6   �� 5      $
��100* �6   .+�5   
   � $��1��6    5      �� 5      6"   �� 5      6"   �� 5      6"   �� 5      6"   .+�5      �� -   5         ��Name$ Create��5      $��Добавить��6%   $��Center=�68   $��Center=�6U   $��20(�6p   $��96��6~   6�   �� 5      -   5        $ Update��5      $��Обновить��6%   $��Center=�68   $��Center=�6U   $��20(�6p   $��96��6~   $��1��6�   6�   �� 5      -   5        $ Delete��5      $��Удалить��6%   $��Center=�67   $��Center=�6T   $��20(�6o   $��96��6}   $��2��6�   6�   �� 5      -   5        $ Export��5      $��Экспорт��6%   $��Center=�67   $��Center=�6T   $��20(�6o   $��96��6}   $��3��6�   6�   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dg��5   <   $��20(�6   $��1,35,1,1q�6!      
IsReadOnly .    AutoGenerateColumns .   �� SelectedItem 6H   �� *AccountingInventory+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5       ,  &System.Windows.Controls.DataGridColumn	   Header$	 id��6%   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 61   �� *AccountingID+6T     5!      $	 
товар��6%   
 64   �� *Items.ItemName+6Y     5"      $	 дата��6%   
 63   �� *
Accounting+6T     5#      $	 
колво��6%   
 64   �� *
ItemQuanty+6U     5$      $	 сотрудник��6%   
 68   �� *Workers.WorkerSurname+6d   5&      �� 5'   
   $
��Left=�6   $��5,4,0,0q�6/   $
��Wrap=�6@   $��Поиск:��6T   $	��Top=�6b   $��20(�6z   �� 5(   
   -   5         ��Name$ search��5(      $
��Left=�6"   $��74,3,0,0q�6=    �� TextWrapping$
 Wrap=�6O   $�� ��6c   $	��Top=�6k   $	��618��6�   $��20(�6�   6�   �� 5)   
   -   5        $��Категории��5)      $
��Left=�6%   $��
152,10,0,0q�6@   $��1��6T   $	��Top=�6a   $��20(�6y   $	��113��6�   6�   �� 5*   
   $
��Left=�6   $��	10,12,0,0q�6/   $��1��6B   $
��Wrap=�6O   $��Справочники:��6c   $	��Top=�6w   $��20(�6�   �� 5+   
   $��Сотрудники��6   $
��Left=�6&   $��	18,52,0,0q�6A   $��1��6T   $	��Top=�6a   $��20(�6y   $	��113��6�   �� 5,   
   $��Склады��6   $
��Left=�6"   $��
152,52,0,0q�6=   $��1��6Q   $	��Top=�6^   $��20(�6v   $	��113��6�   �� 5-   
   -   5        $��1��5-      $��
Выйти��6!   $��	30,52,7,0q�61   $��1��6D   $	��Top=�6Q   ���	#FFE68585$��20(�6�   6�   �� 5.   
   -	   5         ��Name$ tbStat��5.      $
��Left=�6$   $��
298,10,0,0q�6?   $��1��6S   $
��Wrap=�6`   $�� ��6t   $	��Top=�6|   $��20(�6�   $	��204��6�   51      52      