   M S B A M L   `   `   `  ����@  <lab_8, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:lab_8lab_8  5          lab_8.MainWindow   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      %localclr-namespace:lab_8     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5        � Title$  
MainWindow��5      $	��800��5	      $	��450��5
       � 	Resources 5         lab_8.NullImageConverter   nullImageConverter  MyImageRight  MyImageLeft��%�   &	        &	      &	 d       5   
   6#   �� 5   
   $��30��5      $��30��5      $��right-arrow.png��5      �� 5   
   $��30��5      $��30��5      $��left-arrow.png��5      5      .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   �� -   5         ��Name$ mainTab��5      .@�5      �� -   5         ��Name$ accountItem��5       $��Authors��5!      .��5#      &   System.Windows.Controls.DataGrid  -   5          Name$ 
AuthorGrid��5$      $��	0,0,0,0.4q�5%         AutoGenerateColumns .     CanUserAddRows .     CanUserResizeColumns .  	   CanUserResizeRows	 .  $
   HorizontalScrollBarVisibility$

 Auto=�5*      ��5,      �� 5-       �� ImageSource$ ./bg.jpg��6%      	CellStyle 5/      �� 50       �� 
TargetType*  $System.Windows.Controls.DataGridCell"  6    .�51      ��  �� Property � �� �� Value �	#FFF5D5AE6;   �� 52       � �� �	#FF2727276;   53         Columns 55      0  *System.Windows.Controls.DataGridTextColumn  56      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��58         
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn   Binding 57      �� *ID+   	CellStyle 5:      �� 5;   "   "  6(   .�5<   &   ��  � �� �	#FFEABB826C   �� 5=   &    � ��$
 Bold"�6C   �� 5>   &    � ��
 �����6C   5?   #   5A        5B      $ Имя��6F    6-   �� *NAME+6F     5C      $ Пол��6E    6-   �� *SEX+6E     5D      $ Дата рождения��6i    6-   �� *
BIRTHDAY+ �� StringFormat$ {0:MM/dd/yyyy}��6i     5E      $ Возраст��6E    6-   �� *AGE+6E   4  .System.Windows.Controls.DataGridTemplateColumn  5F      $ Фото��61    .     CellTemplate 5H      �� 5I   "   .R�5J   &   �� .+�5L   *   �� ._�5M   .   ��  ��Name$ 	LogoImage��5N   1   -   5        $��49��5O   1   $��50��5P   1   ��5R   2   �� 5S   6    �� Path$
 FOTO�6>    �� TargetNullValue 5T   :   �� 5U   >    �� 	UriSource$9 3https://cdn-icons-png.flaticon.com/512/21/21104.png?�6J   5W   7   5Y   /   5[   +   5_   '   5a   #   5c      5e      5f      �� 5g      -   5        $ 	BooksItem��5h      $��Books��5i      .��5k        -   5        $ 	BooksGrid��5l      $��	0,0,0,0.4q�5m       .   .   .  	 .  $
 Disabled=�5r      ��5s      �� 5t      $ ./bg.jpg��6%    5v      �� 5w      "  6    .�5x      ��  � �� �	#FFF5D5AE6;   �� 5y       � �� �	#FF2727276;   5z       5|        5}      $ ID��5       .  5~      �� *ID+ 5�      �� 5�   "   "  6(   .�5�   &   ��  � �� �	#FFEABB826C   �� 5�   &    � ��$
 Bold"�6C   �� 5�   &    � ��
 �����6C   5�   #   5�        5�      $ ID владельца��6J    6-   �� *
AuthorId+6J     5�      $ 
Книга��6J    6-   �� *
NameBook+6J     5�      $	 UDK��6G    6-   �� *Index+6G   5�      5�      5�      �� 5�   
   $��1��5�      $��Center=�5�       �� Orientation$ 
Horizontal=�5�      .+�5�      �� -   5         ��Name$ 
saveButton��5�      $��Сохранить��5�      �� 5�      -   5        $ updateButton��5�      $��Обновить��5�      �� 5�      -	   5        $
��Auto��5�      #��[ 5�      �� 5�      -
   5        $
��Auto��5�      #��[ 5�      �� 5�      -   5        $ deleteButton��5�      $��Удалить��5�      �� 5�      -   5        $ 	addButton��5�      $��Добавить��5�      5�      5�      5�      