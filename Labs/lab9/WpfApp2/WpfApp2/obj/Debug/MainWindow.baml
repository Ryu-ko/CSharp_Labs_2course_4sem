   M S B A M L   `   `   `  ����B  >WpfApp2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp2WpfApp2  5   	       WpfApp2.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp2     5   	   -   5          � WindowStartupLocation$  CenterScreen=�5       � Title$ 
MainWindow��5
   	   $	��800��6   $
��1400��6)    � 
ResizeMode$ NoResize=�5   	   .��5      �  � UseLayoutRounding .  ���	#FF92DFC0$��1434141��6<   $��134431��6P   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ table��5      $��
0,249,0,-1q�6"   ���	#FFBECFA5
�������   
IsReadOnly .    AutoGenerateColumns .  $��14(�5   /      CanUserAddRows .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 	ID PERSON��6%   
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 * 68   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6B   �� *	id_person+  5      $
	 NAME��6%   $
 * 63    6=   �� *
first_name+  5      $	 MIDDLE NAME��6%   $
 * 6:    6D   �� *middle_name+  5      $	 	LAST NAME��6%   $
 * 68    6B   �� *	last_name+  5      $		 AGE��6%   $
 * 62    6<   �� *age+  5      $	 PHONE��6%   $
 * 64    6>   �� *phone+  5      $	 
ID ADDRESS��6%   $
 * 69    6C   �� *
id_address+  5      $	 ID PASSPORT��6%   $
 * 6:    6D   �� *id_passport+  5      $	 COUNTRY��6%   $
 * 66    6@   �� *	country+  5      $
	 CITY��6%   $
 * 63    6=   �� *city+  5      $	 STREET��6%   $
 * 65    6?   �� *street+  5      $	 HOUSE��6%   $
 * 64    6>   �� *house+  5      $	 BUILD��6%   $
 * 64    6>   �� *build+  5      $
	 FLAT��6%   $
 * 63    6=   �� *flat+  5      $	 SERIAL��6%   $
 * 65    6?   �� *serial+  5       $	 NUMBER��6%   $
 * 65    6?   �� *number+  5!      $	 PHOTO��6%   $
 * 64    6>   �� *photo+5#      �� 5$   
   -   5         ��Name$ insertButton��5$      $��INSERT��6'   $
��Left=�68   $��65��6T   $��	30,23,0,0q�6`   $	��Top=�6s   $	��172��6�   
���   ����	#FFC8E3B2$��18(�6�   $
��Bold"�6�   ���	#FF5050506�   �� 5%   
   -   5        $ deleteButton��5%      $��DELETE��6'   $
��Left=�68   $��65��6S   $��
220,23,0,0q�6_   $	��Top=�6s   $	��172��6�   
���   ����	#FFC8E3B2$��18(�6�   $
��Bold"�6�   ���	#FF5050506�   �� 5&   
   -   5        $ updateButton��5&      $��UPDATE��6'   $
��Left=�68   $��65��6S   $��
410,23,0,0q�6_   $	��Top=�6s   $	��172��6�   
���   ����	#FFC8E3B2$��18(�6�   $
��Bold"�6�   ���	#FF5050506�   �� 5'   
   -   5        $ 
viewButton��5'      $
��VIEW��6%   $
��Left=�64   $��65��6O   $��
598,23,0,0q�6[   $	��Top=�6o   $	��172��6�   
���   ����	#FFC8E3B2$��18(�6�   $
��Bold"�6�   ���	#FF5050506�   �� 5(   
   -   5        $ selectButton��5(      $��SELECT��6'   $
��Left=�68   $��65��6S   $��
788,23,0,0q�6_   $	��Top=�6s   $	��172��6�   
���   ����	#FFC8E3B2$��18(�6�   $
��Bold"�6�   ���	#FF5050506�   �� 5)   
   $
��Left=�6   $	��139��6/   $��
788,98,0,0q�6<   
���   �$	��Top=�6_   $	��172��6w   ���	#FFC8E3B26�   �� 5*   
   $	��AGE��6   $
��Left=�6   $��
852,96,0,0q�69   $	��Top=�6M   ���	#FF505050$
��Bold"�6|   $��18(�6�   �� 5+   
   -   5         ��Name$ 
ageTextBox��5+      $
��Left=�6&   $��Center=�6A   $��822,124,0,0q�6c    �� TextWrapping$
 Wrap=�6x   $	��Top=�6�   $	��104��6�   $��32��6�   
�������
���   �$��16(�6�   �� 5,   
   $��COUNTRY��6   $
��Left=�6"   $��827,164,0,0q�6=   $	��Top=�6R   ���	#FF505050$
��Bold"�6�   $��18(�6�   �� 5-   
   -	   5        $ countryTextBox��5-      $
��Left=�6*   $��Center=�6E   $��822,192,0,0q�6g   $
 Wrap=�6|   $	��Top=�6�   $	��104��6�   $��32��6�   
�������
���   �$��16(�6�    J� RenderTransformOrigin$ -2.094,5.017&�6�   .��6  z�5.      V� 5/      .~�50      �� �� 51       �� AngleX$ 1.348Q�6$   �� 52      T� 53       T� X$ 3.025Q�6)   54      .��55   '   56      57      58      