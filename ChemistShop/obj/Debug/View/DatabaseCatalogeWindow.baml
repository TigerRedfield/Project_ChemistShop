   M S B A M L   `   `   `  ����F  BChemistShop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:ChemistShop.ViewChemistShop.View  5   	   -    'ChemistShop.View.DatabaseCatalogeWindow   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:ChemistShop.View     5   	     � Title$1  +Всё для вашего здоровья��5	   	   $
��1000��6)   $
��1800��67   $
��1800��6E   $
��1000��6U   .��5      � 
������� � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $��* �6   �� 5      $��30 �6   .+�5   
   � $��0��6   
����d� � ColumnDefinitions 5      �� 5      $��50 �6#   �� 5      $��2* �6#   �� 5      $��* �6#   .+�5      �� $��0��6   $��Resources/Logo.png��6$   �� 5      $��1��6   $(��"Работа с каталогом��6(      TitleFormat#��[  5      �� 5      -   5         ��Name$ ButExit��5      $��2��6&   $��6q�5       $��Главное меню��65     TextFormatExit#��[ 6L   �� 5!      -   5        $ ButInfo��5!      $��
992,6,10,6q�5"      $��Справка��6(   #��[ 6:   $��1��6b   6r   5#      � 5&   
   $��1��6    5'      �� 5(      �� 5)      $��* �6    .+�5-      &   System.Windows.Controls.DataGrid  -   5          Name$ DataGridCateg��5-         GridLinesVisibility$	 All=�6D      
IsReadOnly .  �� DisplayMemberPath$ CategoryName��6p    �� SelectedValuePath$ 
CategoryId��6�   	   CanUserResizeColumns	 .  
   CanUserAddRows
 .     CanUserReorderColumns .     AutoGenerateColumns .  $
��Left=�6  $	��209��6:  $��	35,36,0,0q�6G  $��0��6Z  $	��Top=�6g  $	��365��6  ��6.   Z�    Columns 5.      0  *System.Windows.Controls.DataGridTextColumn  5/        FormatHeader,  &System.Windows.Controls.DataGridColumn   HeaderStyle# [ 6)      Header$ Код категории��6U      Width5  /System.Windows.Controls.DataGridLengthConverter$
 0.6* 6�   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6l   �� *
CategoryId+6�     50      # [ 6)   $) #Название категории��6U   $ 1* 6�    6q   �� *CategoryName+6�   52        55      -   5        $ DataGridCountries��55      $	 All=�6H   $ ManufacturerCountryName��6c   $ ManufacturerCountryId��6�   	 .   . 
 .   .   .  $
��Left=�69  $	��209��6T  $��
416,36,0,0q�6a  $��0��6u  $	��Top=�6�  $	��363��6�  ��62   Z�  56        57      # [ 6)   $4 .Код страны производителя��6U   $
 0.8* 6�    6w   �� *ManufacturerCountryId+6�     58      # [ 6)   $# Название страны��6U   $
 0.8* 6�    6n   �� *ManufacturerCountryName+6�   5:        5=      -   5        $ DataGridManufacturers��5=       . $	 All=�6^   	 .  
 .   .   .  $
��Left=�6�   $	��209��6  $��
797,36,0,0q�6  $��0��6"  $	��Top=�6/  $	��959��6G  ��6H   Z�  5>        5?      $' !Код производителя��6)   $ 1* 6o    6D   �� *MedicineManufacturerId+6o     5@      $4 .Код страны производителя��6)   $ 1* 6�    6K   �� *.,ManufacturersCountries.ManufacturerCountryId+6�     5A      $1 +Название производителя��6)   $ 1* 6n    6I   �� *ManufacturerName+6n   5C        5F      -   5        $ DataGridMedicines��5F       . $	 All=�6Z   	 .  
 .   .   .  $
��Left=�6�   $	��237��6�   $��	35,36,0,0q�6
  $	��Top=�6  $
��1721��65  $��1��6B  ��6D   Z�  5G        5H      # [ 6)   $ Код лекарства��6U   $
 0.1* 6�    6l   �� *
MedicineId+6�     5I      # [ 6)   $' !Код производителя��6U   $
 0.1* 6�    6p   �� *MedicineManufacturerId+6�     5J      # [ 6)   $) #Название лекарства��6U   $
 0.1* 6�    6q   �� *MedicineName+6�     5K      # [ 6)   $+ %Цена лекарства (руб.)��6U   $
 0.1* 6�    6t   �� *MedicineCost+6�     5L      # [ 6)   $ Скидка (%)��6U   $
 0.1* 6�    6i   �� *MedicineDiscount+6�     5M      # [ 6)   $- 'Рейтинг лекарства (1-5)��6U   $
 0.1* 6�    6v   �� *MedicineRank+ �� StringFormat$ N1��6�     5N      # [ 6)   $ Код категории��6U   $
 0.1* 6�    6l   �� *
CategoryId+6�     5O      # [ 6)   $ Дата поставки��6U   $
 0.1* 6�    6l   �� *MedicineDateManufacturing+$ {0:yyyy-MM-dd}��6�     5P      # [ 6)   $0 *Срок хранения (месяцев)��6U   $
 0.1* 6�    6v   �� *MedicineExpirationDate+6�   5R      �� 5U      -   5         ��Name$ Categ��5U       �� Orientation$ 
Horizontal=�6(   $
��Left=�6A   $��65��6\   $	��275��6h   $��
67,337,0,0q�6t   $	��Top=�6�   .+�5V      �� -   5        $ AcceptCateg��5V      $	��✔��6.   $��30(�6:   
�������$��64��6[   $��65��6g   $
��Left=�6r   $	��0,0q�6�   6�   �� 5W      -	   5        $ 	EditCateg��5W      $	��✎��6,   $��30(�68   
�������$��64��6Y   $��65��6e   $
��Left=�6p   $	��5,0q�6�   6�   �� 5X      -
   5        $ DeleteCateg��5X      $	��✖��6.   $��30(�6:   
�������$��64��6[   $��65��6g   $
��Left=�6r   $	��0,0q�6�   6�   �� 5Y      -   5        $ CancelCateg��5Y      $
��🛇��6.   $��30(�6;   
�������$��64��6\   $��65��6h   $
��Left=�6s   $	��5,0q�6�   6�   5Z      �� 5]      -   5        $ 	Countries��5]      $ 
Horizontal=�6,   $
��Left=�6E   $��459,337,0,0q�6a   $	��Top=�6v   $��65��6�   $	��276��6�   .+�5^      �� -   5        $ AcceptCountries��5^      $	��✔��62   $��30(�6>   
�������$��64��6_   $��65��6k   $
��Left=�6v   $	��0,0q�6�   6�   �� 5_      -   5        $ EditCountries��5_      $	��✎��60   $��30(�6<   
�������$��64��6]   $��65��6i   $
��Left=�6t   $	��5,0q�6�   6�   �� 5`      -   5        $ DeleteCountries��5`      $	��✖��62   $��30(�6>   
�������$��64��6_   $��65��6k   $
��Left=�6v   $	��0,0q�6�   6�   �� 5a      -   5        $ CancelCountries��5a      $
��🛇��62   $��30(�6?   
�������$��64��6`   $��65��6l   $
��Left=�6w   $	��5,0q�6�   6�   5b      �� 5e      -   5        $ Manuf��5e      $ 
Horizontal=�6(   $
��Left=�6A   $��65��6\   $	��275��6h   $��1076,337,0,0q�6t   $	��Top=�6�   .+�5f      �� -   5        $ AcceptManuf��5f      $	��✔��6.   $��30(�6:   
�������$��64��6[   $��65��6g   $
��Left=�6r   $	��0,0q�6�   6�   �� 5g      -   5        $ 	EditManuf��5g      $	��✎��6,   $��30(�68   
�������$��64��6Y   $��65��6e   $
��Left=�6p   $	��5,0q�6�   $	��Top=�6�   6�   �� 5h      -   5        $ DeleteManuf��5h      $	��✖��6.   $��30(�6:   
�������$��64��6[   $��65��6g   $
��Left=�6r   $	��0,0q�6�   $	��Top=�6�   6�   �� 5i      -   5        $ CancelManuf��5i      $
��🛇��6.   $��30(�6;   
�������$��65��6\   $
��Left=�6g   $��5,0,5,1q�6�   6�   5j      �� 5m      -   5        $ Medicine��5m      $ 
Horizontal=�6+   $
��Left=�6D   $��65��6_   $	��276��6k   $��685,359,0,0q�6w   $	��Top=�6�   $��1��6�   .+�5n      �� -   5        $ AcceptMedicine��5n      $	��✔��61   $��30(�6=   
�������$��64��6^   $��65��6j   $
��Left=�6u   $	��0,0q�6�   $	��Top=�6�   6�   �� 5o      -   5        $ EditMedicine��5o      $	��✎��6/   $��30(�6;   
�������$��64��6\   $��65��6h   $
��Left=�6s   $	��5,0q�6�   6�   �� 5p      -   5        $ DeleteMedicine��5p      $	��✖��61   $��30(�6=   
�������$��64��6^   $��65��6j   $
��Left=�6u   $	��0,0q�6�   6�   �� 5q      -   5        $ CancelMedicine��5q      $
��🛇��61   $��30(�6>   
�������$��64��6_   $��65��6k   $
��Left=�6v   $	��5,0q�6�   6�   5r      �� 5u      $	��Top=�6   $
��Left=�61   $��0��6L   $��0��6Y   $��Категории��6i     TextFormatDB#��[ 6z   $��35,6,1392,413q�6�   $	��365��6�   �� 5v      -   5         ��Name$ txtCatId��5v        TextBoxFormat#��[ 6l   $
��Left=�6�   $��35��6�   $��
35,285,0,0q�6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��140��6�   ��6(   �� *SelectedItem.CategoryId+ �� ElementName$ DataGridCateg��6�   �� 5w      $	��Top=�6   $
��Left=�61   $��0��6L   $��0��6Y   $��Код категории��6i   #��[ 6~   $��35,257,1617,163q�6�   $	��140��6�   �� 5x      -   5        $ 
txtCatName��5x      #��[ 6p   $
��Left=�6�   $��36��6�   $��180,284,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��220��6   ��6*   �� *SelectedItem.CategoryName+$ DataGridCateg��6   �� 5y      $	��Top=�6   $
��Left=�61   $��0��6L   $��0��6Y   $)��#Название категории��6i   #��[ 6�   $��180,257,1392,163q�6�   $	��220��6�   �� 5|      $	��Top=�6   $
��Left=�61   $��0��6L   $��0��6Y   $/��)Страны производителей��6i   #��[ 6�   $��	414,6,0,0q�6�   $	��365��6�   �� 5}      -   5        $ txtCountryId��5}      #��[ 6   $
��Left=�6�   $��36��6�   $��405,284,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��149��6  ��6,   �� *$"SelectedItem.ManufacturerCountryId+$ DataGridCountries��6  �� 5~      $��0��6   $	��Top=�6%   $
��Left=�6>   $��0��6Y   $��Код страны��6i   #��[ 6{   $��405,257,0,0q�6�   $	��149��6�   �� 5      -   5        $ txtCountryName��5      #��[ 6�   $
��Left=�6�   $��36��6�   $��559,284,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��220��6  ��6.   �� *&$SelectedItem.ManufacturerCountryName+$ DataGridCountries��6  �� 5�      $��0��6   $	��Top=�6%   $
��Left=�6>   $��0��6Y   $#��Название страны��6i   #��[ 6�   $��559,257,1013,160q�6�   $	��220��6�   �� 5�      $	��Top=�6   $
��Left=�61   $��0��6L   $��0��6Y   $ ��Производители��6i   #��[ 6~   $��	797,6,0,0q�6�   $	��959��6�   �� 5�      -   5        $ txtManufacturerId��5�      #��[ 6�   $
��Left=�6�   $��36��6�   $��810,283,0,0q�6�   $
 Wrap=�6�   $	��Top=�6   $	��191��6  ��61   �� *%#SelectedItem.MedicineManufacturerId+$ DataGridManufacturers��6  �� 5�      $��0��6   $��0��6%   $	��Top=�65   $
��Left=�6N   $��Код страны��6i   #��[ 6{   $��1006,257,0,0q�6�   $	��145��6�   �� 5�      -    5        $ txtManufacturerCountryId��5�      #��[ 6�   $
��Left=�6�   $��36��6�   $��1006,283,0,0q�6�   $
 Wrap=�6�   $	��Top=�6  $	��145��6  ��68   �� *$"SelectedItem.ManufacturerCountryId+$ DataGridManufacturers��6  �� 5�      $��0��6   $��0��6%   $	��Top=�65   $
��Left=�6N   $'��!Код производителя��6i   #��[ 6�   $��810,257,0,0q�6�   $	��191��6�   �� 5�      -!   5        $ txtManufacturerName��5�      #��[ 6�   $
��Left=�6�   $��36��6�   $��1156,283,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��600��6  ��63   �� *SelectedItem.ManufacturerName+$ DataGridManufacturers��6  �� 5�      $��0��6   $��0��6%   $	��Top=�65   $
��Left=�6N   $1��+Название производителя��6i   #��[ 6�   $��1156,257,0,0q�6�   $	��600��6�   �� 5�      $	��Top=�6   $
��Left=�60   $��1��6K   $��0��6X   $:��4Лечебные препараты/средства��6h   #��[ 6�   $��35,5,0,0q�6�   $
��1721��6�   �� 5�      -"   5        $ txtMedicineId��5�      #��[ 6u   $
��Left=�6�   $��36��6�   $��
35,304,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��140��6  $��1��6  ��6-   �� *SelectedItem.MedicineId+$ DataGridMedicines��6  �� 5�      $	��Top=�6   $
��Left=�61   $��1��6L   $��0��6Y   $��Код лекарства��6i   #��[ 6~   $��35,275,1617,144q�6�   $	��140��6�    J� RenderTransformOrigin$ 
0.382,0.52&�6�   �� 5�      -#   5        $ txtMedicineManufacturId��5�      #��[ 6�   $
��Left=�6�   $��36��6�   $��180,304,0,0q�6�   $
 Wrap=�6�   $	��Top=�6  $	��193��6  $��1��6&  ��67   �� *%#SelectedItem.MedicineManufacturerId+$ DataGridMedicines��6&  �� 5�      $	��Top=�6   $
��Left=�61   $��1��6L   $��0��6Y   $'��!Код производителя��6i   #��[ 6�   $��180,275,0,0q�6�   $	��193��6�   �� 5�      -$   5        $ txtMedicineName��5�      #��[ 6y   $
��Left=�6�   $��36��6�   $��378,304,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��260��6	  $��1��6  ��6/   �� *SelectedItem.MedicineName+$ DataGridMedicines��6  �� 5�      $	��Top=�6   $
��Left=�61   $��1��6L   $��0��6Y   $)��#Название лекарства��6i   #��[ 6�   $��378,275,0,0q�6�   $	��260��6�   �� 5�      -%   5        $ txtMedicineCost��5�      #��[ 6y   $
��Left=�6�   $��36��6�   $��643,304,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��206��6  $��1��6  ��6/   �� *SelectedItem.MedicineCost+$ DataGridMedicines��6  �� 5�      $	��Top=�6   $
��Left=�61   $��1��6L   $��0��6Y   $+��%Цена лекарства (руб.)��6i   #��[ 6�   $��643,275,0,0q�6�   $	��206��6�   �� 5�      -&   5        $ txtMedicineDiscount��5�      #��[ 6�   $
��Left=�6�   $��36��6�   $��854,305,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��114��6  $��1��6  ��63   �� *SelectedItem.MedicineDiscount+$ DataGridMedicines��6  �� 5�      $	��Top=�6   $
��Left=�61   $��1��6L   $��0��6Y   $-��'Рейтинг лекарства (1-5)��6i   #��[ 6�   $��973,275,0,0q�6�   $	��223��6�   �� 5�      -'   5        $ txtMedicineRank��5�      #��[ 6y   $
��Left=�6�   $��36��6�   $��973,306,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��223��6  $��1��6  ��6/   �� *SelectedItem.MedicineRank+$ DataGridMedicines��6  �� 5�      $	��Top=�6   $
��Left=�61   $��1��6L   $��0��6Y   $��Скидка (%)��6i   #��[ 6{   $��854,275,824,144q�6�   $	��114��6�   �� 5�      -(   5        $ txtMedicineCategoryId��5�      #��[ 6}   $
��Left=�6�   $��36��6�   $��1201,306,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��147��6  $��1��6  $ 0.503,0.847&�6&  ��65   �� *SelectedItem.CategoryId+$ DataGridMedicines��6&  �� 5�      $	��Top=�6   $
��Left=�61   $��1��6L   $��0��6Y   $��Дата поставки��6i   #��[ 6~   $��1344,275,268,144q�6�   $	��180��6�   �� 5�      -)   5        $ txtMedicineDateManuf��5�      #��[ 6�   $
��Left=�6�   $��36��6�   $��1353,306,0,0q�6�   $
 Wrap=�6  $	��Top=�6"  $	��171��6:  $��1��6F  ��64   �� *(&SelectedItem.MedicineDateManufacturing+$ DataGridMedicines��$ {0:yyyy-MM-dd}��6F  �� 5�      $	��Top=�6   $
��Left=�61   $��1��6L   $��0��6Y   $��Код категории��6i   #��[ 6~   $��1201,275,0,0q�6�   $	��147��6�   �� 5�      -*   5        $ txtMedicineDateExp��5�      #��[ 6�   $
��Left=�6�   $��36��6�   $��1529,306,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��227��6  $��1��6"  ��62   �� *%#SelectedItem.MedicineExpirationDate+$ DataGridMedicines��6"  �� 5�      $	��Top=�6   $
��Left=�61   $��1��6L   $��0��6Y   $0��*Срок хранения (месяцев)��6i   #��[ 6�   $��1529,275,0,0q�6�   $	��227��6�   5�      � 5�   
   $��2��6   
����d� 5�      �� 5�      $��* �6#   �� 5�      $��* �6#   .+�5�      �� $��0��6   $��Васильев Д.С.��6(     TextFormatPageFooter#��[ 5�      �� 5�      $��1��6   $��tigerredfield@gmail.com��6(   #��[ 5�      5�      5�      5�      