   M S B A M L   `   `   `  ����J  FPhoneDetailsApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:PhoneDetailsAppPhoneDetailsApp  5   	   '    !PhoneDetailsApp.PhoneDetailWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:PhoneDetailsApp     5   	     � Title$  PhoneDetailWindow��5   	   $	��450��6#   $	��800��60   .��5	      � .+�5
   
   �� $��30,30,30,100q�6   .��5      �  � ColumnDefinitions 5      �� 5      $��* �6'   �� 5      $��* �6'    � RowDefinitions 5      �� 5      $��* �6$   �� 5      $��* �6$   �� 5      $��* �6$   �� 5      $��* �6$   �� 5      $��* �6$   .+�5      �� $��Make: ��6   $��Right=�5      $��Center=�5      $��30(�5      �� 5      $��Model: ��6   $��Right=�5      $��Center=�5      $��30(�5      $��1��5      �� 5       $��	Display: ��6   $��Right=�5!      $��Center=�5"      $��30(�5#      $��2��5$      �� 5%      $��	Storage: ��6   $��Right=�5&      $��Center=�5'      $��30(�5(      $��3��5)      �� 5*      $��Price: ��6   $��Right=�5+      $��Center=�5,      $��30(�5-      $��4��5.      �� 5/      -   5         ��Name$ LblMake��5/      $��
Results...��6)   $
��Left=�50      $��Center=�51      $��1��52      $��0��53      $��30(�54      �� 55      -   5        $ LblModel��55      $��
Results...��6*   $
��Left=�56      $��Center=�57      $��1��58      $��1��59      $��30(�5:      �� 5;      -   5        $ 
LblDisplay��5;      $��
Results...��6,   $
��Left=�5<      $��Center=�5=      $��1��5>      $��2��5?      $��30(�5@      �� 5A      -   5        $ 
LblStorage��5A      $��
Results...��6,   $
��Left=�5B      $��Center=�5C      $��1��5D      $��3��5E      $��30(�5F      �� 5G      -   5        $ LblPrice��5G      $��
Results...��6*   $
��Left=�5H      $��Center=�5I      $��1��5J      $��4��5K      $��30(�5L      5N      5O      �� 5P   
   -   5         ��Name$ BtnClose��5T      $��Close��5P      $��Bottom=�5Q      $��30q�5R      $
��0,20q�5S      5U      5V      5W      