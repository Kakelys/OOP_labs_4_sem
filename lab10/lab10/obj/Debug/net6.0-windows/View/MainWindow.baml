   M S B A M L   `   `   `  ����@  <lab10, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:lab10lab10  5   	   1clr-namespace:lab10.ViewModellab10.ViewModel  5   	       lab10.MainWindow   5   	   Z VDevExpress.Mvvm.UI, Version=21.1.0.0, Culture=neutral, PublicKeyToken=382ad28f6ae31f30W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:lab10     5   	   3	viewModelclr-namespace:lab10.ViewModel     5   	     � Title$  
MainWindow��5	   	   $	��450��6   $	��800��6)    � 	Resources 5
       �� 
TargetType �� Property �� Value��%�   '��       �� 5   
   " ��6   �5      �� 5       � ��$ 75��6*   �� 5       � ��$ 25��6+   �� 5       � ��$ 5q�6+   �� 5       � ��$	 Top=�66   5      5       � DataContext 5      !  lab10.ViewModel.ElementList  5   
   .��5      � ���#313131 � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $��* �6   .+�5   
   �� $��0��6    �� Orientation$ 
Horizontal=�6"   .+�5       �� $
��Load��6   ��6$   �� *
LoadInfo+�� 5!      $��Previous��6   ��6(   �� *
PrevUser+�� 5"      $
��Next��6   ��6$   �� *
NextUser+�� 5#      $��Add User��6   ��6(   �� *	AddUser+5$      �� 5%   
   $��1��6   .+�5&      �� $��Hidden=�6   .��5'      �� .+�5(      �� $ 
Horizontal=�6!   .+�5)      �� $��30��6    $��30��6,   $��10,0,0,0q�67   $
��Left=�6`   ��6I   �� *Img+6`   �� 5*      $��15,0,0,0q�6>   
�������$��16(�6c    �� TextAlignment$ Center=�6q   $��Center=�6�   ��6$   �� *
UserName+6�   �� 5+      $��Add Post��6!   $��Right=�64   ��6P   �� *	AddPost+y�6l   �� *AddButtonVisibility+�� 5,      $��Delete User��6!   $��Right=�67   ��6S   �� *
DeleteUser+y�6r   �� *UserVisibility+5-      �� 5.      ��6#   �� *
CurPosts+��5/      �� 50      .R�51   "   � .+�52   &   �� 
�������$��20(�6\   ��60   �� *	Message+6\   �� 53   &   $��Delete��6-   $��8(�6^   $��30��6k   $��14��6v   ��6>   �� *
DeletePost+6v   54   #   55      57      58      59      5:      5<      5=      