   M S B A M L   `   `   `  ����B  >WpfApp2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:WpfApp2.ViewModelsWpfApp2.ViewModels  5          WpfApp2.Views.MainWindow   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:WpfApp2.ViewModels     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5        � Title$  
MainWindow��5      $	��800��5	      $	��450��5
      ���	#FF4CEDB8 � 	Resources 5      .   (WpfApp2.ViewModels.MyMultiValueConverter   MyMultiValueConverter��%   &	          5   
   6&   5       � DataContext 5      &    WpfApp2.ViewModels.MainViewModel  5   
   .��5      �  � ColumnDefinitions 5   
   �� 5      �� 5      $
��Auto �6   $	��317��6,    � RowDefinitions 5   
   �� 5      $
��0.1* �6   �� 5      $
��0.5* �6   �� 5      $
��0.5* �6   �� 5      $
��0.2* �6   .+�5   
   � $��0��6   $��0��6   .+�5       �� $��10,0,0,0q�5!      $��Bottom=�5"      $��18(�5#      $��SemiBold"�5$      $��Disciplines��5%      5&      � 5'   
   $��0��6   $��1��6   .+�5(      �� $��0,0,0,0q�5)      $��Bottom=�5*      $��18(�5+      $��SemiBold"�5,      $��Students��5-      5.      &   System.Windows.Controls.DataGrid  5/   
   -   5        $��DisciplinesGrid��50      $��1��51         AutoGenerateColumns .     
IsReadOnly . ��54      �� *Disciplines+   Columns 55      0  *System.Windows.Controls.DataGridTextColumn  56      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6<   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6%   �� *Id+6<     57      $
 Name��6>   	 6%   �� *Name+6>     58      $ Hours��6G   	 6%   �� *QuantityHours+6G     59      $ Lector��6@   	 6%   �� *Lector+6@     5:      $ Quantity��6B   	 6%   �� *
Quantity+6B   5<      �� 5=   
   $��1��5>      $��2��5?      $��1��5@      .+�5A      �� $��Add Student to Course��6=   ���	#FFFFDF0C��6   �� *AddToStudentCommand+��5B      `� 5C      
 `� 	Converter#
 [  6#   .1�5D      ��  �� ElementName$ DisciplinesGrid��6"    �� Path$ SelectedItem�6@   �� 5E      $ StudentGrid��6"   $ SelectedItem�6<   5F      5H      �� 5I      $ ��Remove Student from Course��5L      ���	#FFFFDD00��5J      �� *RemoveFromStudentCommand+��5K      �� *SelectedItem+$ CourseTableGrid��5L   6     5M      -   5        $��StudentGrid��5N       .   . ��5Q      �� *	Student+ 5R        5S      $ Id��6@   	 6)   �� *Id+6@     5T      $
 Name��6B   	 6)   �� *Name+6B     5U      $ Surname��6E   	 6)   �� *	Surname+6E     5V      $	 Age��6A   	 6)   �� *Age+6A   5X      5Z        5\   
   -   5        $��CourseTableGrid��5]      $��2��5^       .   . ��5a      �� *CourseTable+ 5b        5c      $ Id��6<   	 6%   �� *Id+6<     5d      $ idDiscipline��6F   	 6%   �� *idDiscipline+6F     5e      $ 	idStudent��6C   	 6%   �� *	idStudent+6C     5f      $
 Name��6>   	 6%   �� *Name+6>     5g      $ Lector��6@   	 6%   �� *Lector+6@     5h      $ Surname��6A   	 6%   �� *	Surname+6A   5j      �� 5k   
   $��3��5l      $��2��5m       �� Orientation$ 
Horizontal=�5n      .+�5o      �� $��40��5p      $��10,0,0,0q�5q      $
��20,5q�5r      $��Add Discipline��5t      ���	#FFFABA43��5s      �� *AddDiscCommand+5t   *   �� 5u      $��40��5v      $��20,0,0,0q�5w      $
��20,5q�5x      $��Delete Discipline��5{      ���	#FFFFC65D��5y      �� *RemoveFromDisciplineCommand+��5z      �� *SelectedItem+$ DisciplinesGrid��5{   -   �� 5|      $��40��5}      $��20,0,0,0q�5~      $
��20,5q�5      $��Add Student��5�      ���	#FF2CABFF��5�      �� *AddStudentCommand+5�   '   �� 5�      $��40��5�      $��20,0,0,0q�5�      $
��20,5q�5�      $��Delete Student��5�      ���	#FF48B6FF��5�      �� *RemoveStudentCommand+��5�      �� *SelectedItem+$ StudentGrid��5�   *   5�      5�      5�      