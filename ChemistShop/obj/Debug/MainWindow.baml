   M S B A M L   `   `   `  ����F  BChemistShop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:ChemistShopChemistShop  5   	       ChemistShop.MainWindow   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:ChemistShop     5   	     � Title$1  +Всё для вашего здоровья��5	   	   $	��400��6)   $	��400��66   $	��400��6B   $	��400��6Q   .��5      � 
������� � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $��* �6   �� 5      $��30 �6   .+�5   
   � $��0��6   
����d� � ColumnDefinitions 5      �� 5      $��50 �6#   �� 5      $��2* �6#   �� 5      $��* �6#   .+�5      �� $��0��6   $��Resources/Logo.png��6$   �� 5      $��1��6   $��Главное меню��6(      TitleFormat#��[  5      �� 5      -   5         ��Name$ 
ButtonExit��5      $��2��6*   $��8q�5      $��
Выход��6     TextFormatExit#��[ 6/   6W   5       � 5#   
   $��1��6    5$      �� 5%      $
��0.5* �6    �� 5&      $��* �6    �� 5'      $��* �6    �� 5(      $
��0.5* �6    .+�5,      �� -   5        $ 	ButtonBuy��5,      $��40, 20q�6(   $��1��68   
�������.��5.      ��  �� Orientation$ 
Horizontal=�6   .+�5/      �� $��Resources/Picture.png��6   $��Uniform=�6;   �� 50      $��Сделать заказ��6      
TextFormat#��[ 65   $�� 20, 0, 20, 0q�6Y   51      52      �� 55      -   5        $ ButtonCataloge��55      $��40, 20q�6-   $��2��6=   
�������.��56      �� $ 
Horizontal=�6   .+�57      �� $��Resources/Cataloge.png��6   $��Uniform=�6<   �� 58      $(��"Работа с каталогом��6    #��[ 6:   $�� 20, 0, 20, 0q�6^   59      5:      5;      � 5>   
   $��2��6   
����d� 5?      �� 5@      $��* �6#   �� 5A      $��* �6#   .+�5E      �� $��0��6   $��Васильев Д.С.��6(     TextFormatPageFooter#��[ 5F      �� 5G      $��1��6   $��tigerredfield@gmail.com��6(   #��[ 5H      5I      5J      5K      