   M S B A M L   `   `   `  ����F  BChemistShop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:ChemistShop.ViewChemistShop.View  5   	   '    !ChemistShop.View.TotalOrderWindow   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:ChemistShop.View     5   	     � Title$1  +Всё для вашего здоровья��5	   	   $	��650��6)   $
��1200��66   $
��1200��6D   $	��650��6T   .��5      � 
������� � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $��* �6   �� 5      $��30 �6   .+�5   
   � $��0��6   
����d� � ColumnDefinitions 5      �� 5      $��50 �6#   �� 5      $��2* �6#   �� 5      $��* �6#   .+�5      �� $��0��6   $��Resources/Logo.png��6$   �� 5      $��1��6   $'��!Оформление заказа��6(      TitleFormat#��[  5      �� 5      -   5         ��Name$ ButExit��5      $��2��6&   $��6q�5      $��Главное меню��65     TextFormatExit#��[ 6L   5       � 5#   
   $��1��6    5$      �� 5%      �� 5&      $��0.16* �6    .+�5*      &   System.Windows.Controls.DataGrid  -   5          Name$ dgOrder��5*         GridLinesVisibility$	 All=�6>   $��0��6X   $��10q�6e      CanUserResizeColumns .     CanUserAddRows .     CanUserReorderColumns .  	   AutoGenerateColumns	 .  ��6(   Z� 
   Columns
 5+      0  *System.Windows.Controls.DataGridTextColumn  5,      ,  &System.Windows.Controls.DataGridColumn   Header$ Название��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$ 2* 6\   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6;   �� *MedicineName+6\     5-      $ Цена��6)   $ * 6X    67   �� *MedicineCost+6X     5.      $" С учётом скидки��6)   $ * 6g    6B   �� *MedicineDiscount+6g     5/      $ Количество��6)   $ * 6W    6=   �� *Count+6W     50      $ 
Итого��6)   $ * 6T    68   �� *	Costing+6T   4  .System.Windows.Controls.DataGridTemplateColumn  51      $ Действия��6-   $ * 6?      CellTemplate 52      �� 53      .R�54   "   ��  �� Orientation$ 
Horizontal=�6-   .+�55   &   �� $ butInc��6-   -   5        $��+��55   =   $��30��6I   6T   �� 56   &   $ butDec��6-   -   5        $��-��56   =   $��30��6I   6T   �� 57   &   $ butDel��6-   -   5        $��x��57   =   $��30��6I   6T   58   #   59      5;      5=      �� 5@      -   5         ��Name$ tbOrderLast��5@        TextFormatApplication#��[ 6-   $��-500,20,0,0q�6\   $��2��6q   $��Center=�6~   $
��Wrap=�6�   
���   �$'��!Остаток от заказа:��6�   $	��Top=�6�   $	��411��6�   �� 5A      -   5        $ tb_summOrder��5A      $��Сумма заказа: ��6.   #��[ 6D   
���   �$��Center=�6�   $��
500,20,5,0q�6�   $��2��6�   $
��Wrap=�6�   $	��Top=�6�   �� 5D      -   5        $ Cataloge��5D      $
��Left=�6'   $��2��6B   $��10, 10q�6O   
�������$��50��6r   $	��Top=�6~   .��5E      �� $ 
Horizontal=�6   .+�5F      �� $��Каталог��6    #��[ 6/   $��10, 0, 10, 0q�6^   5G      5H      �� 5K      -	   5        $ Order��5K      $��Right=�6$   $��2��6@   
�������$��10, 10q�6`   $��50��6p   $	��Top=�6|   .��5L      �� $ 
Horizontal=�6   .+�5M      �� $!��Оформить заказ��6    #��[ 66   $��10, 0, 10, 0q�6e   5N      5O      5P      � 5S   
   $��2��6   
����d� 5T      �� 5U      $��* �6#   �� 5V      $��* �6#   .+�5Z      �� $��0��6   $��Васильев Д.С.��6(     TextFormatPageFooter#��[ 5[      �� 5\      $��1��6   $��tigerredfield@gmail.com��6(   #��[ 5]      5^      5_      5`      