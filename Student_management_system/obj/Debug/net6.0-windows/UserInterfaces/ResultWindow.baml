   M S B A M L   `   `   `  ����T  PStudent_management_system, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullc6clr-namespace:Student_management_system.UserInterfaces(Student_management_system.UserInterfaces  5   	   ;    5Student_management_system.UserInterfaces.ResultWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Hlocal6clr-namespace:Student_management_system.UserInterfaces     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title$ ResultWindow��5	   	   $	��450��6   $	��800��6+    � DataContext 5
      =   7Student_management_system.UserInterfaces.ResultWindowVM  5   
   .��5      � ���#455A64.+�5   
   �� $��20q�6   ���#EFEFEF���#CCCCCC$��1q�6H    �� CornerRadius$ 5��6\   ._�5      � .+�5      �� ���#455A64$��Student Results��61   $��25(�6H   $
��Bold"�6V   $��	30 20 0 0q�6h   �� 5      $	��Top=�6    �� Orientation$ 
Horizontal=�65   $��
30 80 20 0q�6N   $��Center=�6b   .+�5      �� $��12(�6    $
��Bold"�6.   $��Student Name :��6@   $	��100��6V   �� 5      $	��100��6p   
������ ��6    �� *SelectedStudent3.FirstName+ �� UpdateSourceTrigger$ PropertyChanged=�6|   �� 5      $��12(�6    $
��Bold"�6.   $��Student Reg.No :��6@   $	��100��6X   $��5 0 0 0q�6d   �� 5      $	��100��6o   
������ ��6    �� *SelectedStudent3.StuRegNo+$ PropertyChanged=�6{   �� 5      $��12(�6    $
��Bold"�6.   $��GPA Value :��6@   $��80��6S   $��5 0 0 0q�6^   �� 5      $��50��6v   
������ ��6    �� *SelectedStudent3.Gpa+$ PropertyChanged=� �� Mode$ TwoWay=�6�   5      �� 5      $��Center=�6   $	��Top=�6:   $ 
Horizontal=�6R   $��
30 80 20 0q�6k   $��20��6   $	��700��6�   .+�5      �� $��12(�6    $
��Bold"�6.   $	��177��6�   $��10 0 0 0q�6�   
������ $��20��6�   ��6@   �� *SelectedStudent2.FirstName+$ PropertyChanged=�6�   �� 5      $��12(�6    $
��Bold"�6.   $	��355��6�   $��0 0 0 0q�6�   
������ $��20��6�   ��6@   �� *SelectedStudent2.StuRegNo+$ PropertyChanged=�6�   5      � 5      $��10 110 10 10q�6   .+�5      � $��10q�6   $��Center=�6'    � ColumnDefinitions 5       �� 5!      $	��300 �6/   �� 5"      $	��100 �6/   .+�5%      � $��0��6   $��0q�6/   .+�5&      �� $	��300��6'   
���������6F   �� *
ListEnrMod+$ PropertyChanged=� �� View 5'   "   �� 5(   &   P�5)   *   �� 5*   .   	 �� Width$		 100��6=   $��Module Code��6I   
 �� DisplayMemberBinding
 6^   �� *	ModCode+�� 5+   .   $		 200��6=   $��Module Name��6I   
 6^   �� *	ModName+5-   '   5/      50      � 52      $��1��6   $��0q�6/   .+�53      �� $	��100��6'   ��63   �� *	ListGrade+$ PropertyChanged=� 54   "   �� 55   &   P�56   *   �� 57   .   $		 100��6=   $��Grade��6J   
 6Y   �� *Grade+59   '   5;      5<      5=      5>      5@      5B      5C      5D      