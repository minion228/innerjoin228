   M S B A M L   `   `   `  ����N  JInventoryAccounting, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:InventoryAccountingInventoryAccounting  5   	   #    InventoryAccounting.AddOrEdit   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:InventoryAccounting     5   	     � Title$  	AddOrEdit��5   	   $	��600��6   $	��500��6(    � WindowStartupLocation$ CenterScreen=�64   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $	��49* �6   �� 5      $
��203* �6   �� 5      $
��199* �6   �� 5      $	��49* �6    � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $
��100* �6   �� 5      $
��100* �6   �� 5      $
��100* �6   �� 5      $
��100* �6   �� 5      $��50 �6   .+�5   
   �� -   5         ��Name$ cmxItem��5      $��1��6$   $��Center=�64   $��2��6Q   $��Center=�6^   $	��183��6y   $��20(�6�   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$
 date��5      $��2��6#   $
��Left=�63   $��	10,39,0,0q�6N   $��2��6a   $	��Top=�6n   $��20(�6�   $	��188��6�   �� 5   
   -   5         ��Name$ 	tbxAmount��5      $��2��6%   $
��Left=�65   $��	10,46,0,0q�6P   $��3��6c    �� TextWrapping$
 Wrap=�6p   $�� ��6�   $	��Top=�6�   $	��188��6�   $��20(�6�   �� 5   
   -   5        $ 	cmxWorker��5      $��1��6'   $��Center=�67   $��0,44,0,0q�6T   $��3��6f   $	��Top=�6s   $	��183��6�   $��20(�6�   �� 5   
   -   5        $��1��5      $��Сохранить��6!   $��Center=�65   $��4��6R   $��Center=�6_   $��20(�6z   $��2��6�   $��47��6�   $	��160��6�   6�   5      5      