   M S B A M L   `   `   `  ����@  <Lab45, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:Lab45Lab45  5          Lab45.EditItem   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      %localclr-namespace:Lab45     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      -   5          � Title$  	Edit Book��5      $	��430��5	      $	��570��5
       	  WinBg#���   5      .��5      � $��Center=�6     CyanBgStyle3#���  5      
������ $	��395��6K    � RowDefinitions 5   
   �� 5      �� 5      �� 5      $	��100 �6   �� 5      �� 5      �� 5      �� 5      �� 5      $
��0.9* �6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   $	��130��6,   �� 5      .+�5!   
   �� -   5         ��Name$ 
titleInput��5"      $��1��5#      $��
0,16,15,17q�5$      �� 5%   
   -   5        $ 
autorInput��5&      $��1��5'      $��1��5(      $��
0,16,15,16q�5)      �� 5+   
   -   5        $ 
powerInput��5,      $��3��5-      $��1��5.      $��
0,16,15,16q�5/      � 52   
   $��1��6   $��1��6   $��	0,62,0,62q�6,   $��3��6?    53      �� 54      $
��0.5* �6#   �� 55      $
��0.5* �6#    57      �� 58      .+�5;      �� -   5         ��Name$ selectPhoto��5<      $��0��5=      $��0��5>      $��30��5?      $	��120��5@        btn_chooseFile#���  5B      ���	#FF9113E9
�������$��1��5E      
������� J� RenderTransformOrigin$ -0.235,0.59&�5G      �� 5H      -   5         ��Name$ ProductsPhoto��5I      $��0��5J      $��1��5K      $	��100��5L      $	��100��5M      $��0,0,10,0q�5N      5O      �� 5Q   
   -   5         ��Name$ comboboxInput��5R      $��4��5S      $��1��5T      $��	0,16,0,17q�5U      $��14(�5V       �� SelectedIndex$ 0��5W      
���������5X      �� 5Y      	 �� EndPoint$		 0,1&�6&   .��5Z      � 
 � Color$
 	#FFF0F0F0��6#   � 5[      $
 White��6#    � Offset$ 1Q�61   5\      .@�5^      ��   	binding_1#���  6   �� 5_        	binding_2#���  6   �� 5`        	binding_3#���  6   5a      �� 5c   
   -   5        $ 
pagesInput��5d      $��5��5e      $��1��5f      $��
0,16,15,16q�5g      �� 5j   
   $��5��5k      $��1��5l       �� Orientation$ 
Horizontal=�5m      $��3��6'   .+�5n      	� -	   5         	�Name$ 	radiobtn1��5o      $��1��5p       d� 	IsChecked$
 TrueY�5q        RatingRadioBox#���  5r      	� 5s      -
   5        $ 	radiobtn2��5t      $��2��5u      #���  5v      	� 5w      -   5        $ 	radiobtn3��5x      $��3��5y      #���  5z      	� 5{      -   5        $ 	radiobtn4��5|      $��4��5}      #���  5~      	� 5      -   5        $ 	radiobtn5��5�      $��5��5�      #���  5�      5�      �� 5�   
   -   5        $��7��5�      $��2��5�        
btn_submit#���  5�      $��Center=�5�      ���	#FF9113E9
�������$��36��5�      $��1,1,1,1q�5�      $��4,5,4,5q�5�      }�. 5�      �� 5�   
     
b_BookName#���  5�      $��Center=�5�      $��	0,16,0,17q�5�       	 SettingsLabelBlck#��� 	 5�      �� 5�   
   $��1��5�       
 b_Autor#��� 
 5�      $��Center=�5�      $��	0,16,0,16q�5�      #��� 	 5�      �� 5�   
   $��3��5�       
 b_Cost#���  5�      $��Center=�5�      $��	0,16,0,16q�5�      #��� 	 5�      �� 5�   
   $��2��5�        b_Photobook#���  5�      $��Center=�5�      $��Center=�5�      $��	0,16,0,17q�5�      #��� 	 5�      �� 5�   
   $��4��5�        b_Binding_type#���  5�      $��Center=�5�      $��	0,16,0,17q�5�      #��� 	 5�      �� 5�   
   $��5��5�        b_Pages#���  5�      $��Center=�5�      $��	0,16,0,16q�5�      #��� 	 5�      �� 5�   
   $��6��5�        b_Rating#���  5�      $��Center=�5�      $��	0,16,0,17q�5�      #��� 	 5�      5�      5�      