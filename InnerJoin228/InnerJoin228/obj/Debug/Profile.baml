   M S B A M L   `   `   `  ����G  CInnerJoin228, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:InnerJoin228InnerJoin228  5   	       InnerJoin228.Profile   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:InnerJoin228     5   	     � Title$  Profile��5   	   $	��450��6   $	��800��6&   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $
��637* �6   6.   �� 5      $
��163* �6   6.    � RowDefinitions 5   
   �� 5      $
��309* �6   6,   �� 5      $
��125* �6   6,   .+�5   
   � $��1��6    5      �� 5      6"   �� 5      6"   �� 5      6"   �� 5      6"   �� 5      6"   .+�5      �� -   5        $��Добавить��5      $��Center=�6(   $��1��6E   $��Center=�6R   $��20(�6m   6{   �� 5      -   5        $��Обновить��5      $��Center=�6(   $��2��6E   $��Center=�6R   $��20(�6m   6{   �� 5      -   5        $��Удалить��5      $��Center=�6'   $��3��6D   $��Center=�6Q   $��20(�6l   $��92��6z   6�   �� 5      -   5        $��Экспорт��5      $��Center=�6'   $��4��6D   $��Center=�6Q   $��20(�6l   $��92��6z   6�   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dgUsers��5   !   $��25(�6      AutoGenerateColumns .     
IsReadOnly .  �� SelectedItem 6`   �� *Users+   Columns 5       0  *System.Windows.Controls.DataGridTextColumn  5!      ,  &System.Windows.Controls.DataGridColumn   Header$ id��6%   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 61   �� *UserID+6N     5"      $ login��6%   	 64   �� *	UserLogin+6T     5#      $ password��6%   	 67   �� *UserPassword+6Z     5$      $
 role��6%   	 63   �� *Roles.RoleName+6X   5&      �� 5'   
   -   5        
 ��Name$
 search��5'      $
��Left=�6"   $��	10,10,0,0q�6=   $��1��6P    �� TextWrapping$
 Wrap=�6]   $�� ��6q   $	��Top=�6y   $	��207��6�   $��20(�6�   6�   �� 5(   
   -   5        $��1��5(      $��
назад��6!   $
��Left=�61   $��	81,85,0,0q�6L   $��1��6_   $	��Top=�6l   $��20(�6�   $��76��6�   6�   �� 5)   
   -   5        $��Список ролей��5)      $��Center=�6(   $��0,17,0,0q�6E   $	��Top=�6W   $��1��6o   $��20(�6   $	��151��6�   6�   5*      5+      