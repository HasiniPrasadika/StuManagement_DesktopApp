   M S B A M L   `   `   `  ����T  PStudent_management_system, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullc6clr-namespace:Student_management_system.UserInterfaces(Student_management_system.UserInterfaces  5   	   >    8Student_management_system.UserInterfaces.AddModuleWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Hlocal6clr-namespace:Student_management_system.UserInterfaces     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title$ AddModuleWindow��5	   	   $	��450��6!   $	��800��6.    � DataContext 5
      @   :Student_management_system.UserInterfaces.AddModuleWindowVM  5   
   .��5      � ���#455A64.+�5   
   �� $��20q�6   ���#EFEFEF���#CCCCCC$��1q�6H    �� CornerRadius$ 5��6\   ._�5      � .+�5      �� ���#455A64$��Module Enrollment��61   $��25(�6J   $
��Bold"�6X   $��	30 20 0 0q�6j   �� 5      
������ $��Center=�66   $	��Top=�6S    �� Orientation$ 
Horizontal=�6k   $��
30 80 20 0q�6�   $��20��6�   $	��700��6�   .+�5      �� $��12(�6    $
��Bold"�6.   $	��202��6�   $��10 0 0 0q�6�   
������ $��20��6�   ��6@   �� *SelectedStudent1.FirstName+ �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5      $��12(�6    $
��Bold"�6.   $	��355��6�   $��0 0 0 0q�6�   
������ $��20��6�   ��6@   �� *SelectedStudent1.StuRegNo+$ PropertyChanged=�6�   5      �� 5      $��Center=�6   $��	0 120 0 0q�6:   .+�5      � .+�5      �� $ 
Horizontal=�6%   .+�5      �� .+�5   "   �� $
��Bold"�6,   $��15(�6>   $��Center=�6L   $��All Modules��6i   �� 5   "   $	��200��6*   $	��250��6�   ��67   �� *ListAllModule+ �� SelectedItem 6]   �� *SelectedModule+��5   &   �� 5   *   .R�5   .   �� ���	#FFD3D3D3$ 
Horizontal=�6P   $
��Left=�6i   $	��250��6�   .+�5   2   �� 
���   �
������ $��50��6h   $��5q�6s   ��6~   �� *	ModCode+�� 5    2   
���   �
������ $	��200��6h   $��5q�6t   ��6   �� *	ModName+5!   /   5"   +   5$   #   5%      �� 5'      $ Vertical=�6)   $��10q�6@   $��Center=�6L   .+�5(   "   �� $��Enroll��6)   $	��100��6:   $��10q�6F   ���#455A64
���������6R   �� *EnrollCommand+6�   �� 5)   "   $��Delete��6)   $	��100��6:   $��10q�6F   ���#455A64
���������6R   �� *DeleteCommand+6�   5*      �� 5,      .+�5-   "   �� $
��Bold"�6,   $��15(�6>   $��Center=�6L   $��Enrolled Modules��6i   �� 5.   "   $	��200��6*   $	��250��6�   ��67   �� *ListEnrollModules+$ PropertyChanged=� 6�   �� *SelectedModule1+��5/   &   �� 50   *   .R�51   .   �� ���	#FFD3D3D3$ 
Horizontal=�6P   $
��Left=�6i   $	��250��6�   .+�52   2   �� 
���   �
������ $��50��6h   $��5q�6s   ��6~   �� *	ModCode+�� 53   2   
���   �
������ $	��200��6h   $��5q�6t   ��6   �� *	ModName+54   /   55   +   57   #   58      59      5:      5;      5=      5>      5?      5@      