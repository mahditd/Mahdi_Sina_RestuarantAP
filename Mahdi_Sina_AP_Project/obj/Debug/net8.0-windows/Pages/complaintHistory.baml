   M S B A M L   `   `   `  ����P  LMahdi_Sina_AP_Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:Mahdi_Sina_AP_Project.PagesMahdi_Sina_AP_Project.Pages  5      2    ,Mahdi_Sina_AP_Project.Pages.complaintHistory   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ;local)clr-namespace:Mahdi_Sina_AP_Project.Pages     5        N� Title$  complaintHistory��5	       � 	Resources 5
         ScrollThumbs �� 
TargetType �� Property �� Value �Name ��Name �� CornerRadius �� Triggers	 P� Property
 P� Value �� 
TargetName �� 
TargetType ]�Name ]� Thumb n�Name ]� IncreaseRepeatButton ��Name J� Opacity ]� DecreaseRepeatButton P� 
SourceName  ButtonSelectBrush  	DarkBrush �� Angle�� 5   
   %$	  &	        '�� M    �� 5      " n�6)   .�5      ��  � �� 5      �� 5      .R�5      � $
 Grid��6#   .+�5   "   �� $��Stretch=�6,   $��Stretch=�6J   $
��Auto��6f   $
��Auto��5   %   
������ 63   �� 5   "   $ 
Rectangle1��6)   $ 	10 0 0 10��6=   $��Stretch=�6V   $��Stretch=�5   "   $
��Auto��6>   $
��Auto��6K   #��z��5   "   5       5      P� 5   "   	 �@�Tag$
 
Horizontal��69   . �5   &   �� $ 
Rectangle1��6-    � ��$
 Auto��6V   �� 5   &   $ 
Rectangle1��6-    � ��$ 7��6W   5   #   5      5      5       �� 5#      " ��6/   .�5$      ��  �@��IsFlicksEnabled$ False��6;   �� 5%       � �� �	#AAA8341A6/   �� 5&       � ��
 �����6/   �� 5'       � ��$ 10��6*   �� 5(       � �� 5)      �� 5*      " ��6*   .R�5+      � $ GridRoot��6#   $��12��65   ��6@   Z� .+�5,   "   ]� $ 
PART_Track��6(   $��0��6<   $
��true��6I   $|�False��6d    5-   &   n� 5.   *   $ Thumb��60   #��z��6?   #���   5/   )    51   &   �� 52   *   $ PageUp��67   $��ScrollBar.PageDownCommand��6G   $ 0Q�6k   $|�False��6w    54   &   �� 55   *   $ PageDown��67   $��ScrollBar.PageUpCommand��6I   $ 0Q�6k   $|�False��6w   57   #   58       5:      P� 5;   "   $ Thumb��6*   	 �@J�IsMouseOver$

 true��6T   . �5<   &   �� # �  6-   $ Thumb��5=   &    � ��69   5>   #   P� 5?   "   $ Thumb��6*   	 �@n�
IsDragging$

 true��6S   . �5@   &   �� # �  6-   $ Thumb��6Q    � ��6d   5A   #   P� 5C   "   	 � {�$
 false��6?   . �5D   &   �� $ Thumb��6-    � y�$ 	Collapsed=�6V   5E   #   P� 5F   "   	 �@��Orientation$
 
Horizontal=�6A   . �5G   &   �� $ GridRoot��6-    �@�LayoutTransform 5H   *   �� 5I   .   $	 -90Q�6>   5K   '   �� 5L   &   $ 
PART_Track��6-    �@�LayoutTransform 5M   *   �� 5N   .   $	 -90Q�6>   5P   '   �� 5Q   &    � ��$
 Auto��6>   �� 5R   &    � ��$ 12��6?   �� 5S   &   $ Thumb��6-    �@�Tag$ 
Horizontal��6O   �� 5T   &   $ PageDown��6-    � ��$ ScrollBar.PageLeftCommand��6V   �� 5U   &   $ PageUp��6-    � ��$  ScrollBar.PageRightCommand��6T   5V   #   5X      5Z      5[      5\      .��5^      � ���	#FF222222 � ColumnDefinitions 5_   
   �� 5`      �� 5a      .+�5c   
   �� $��0��6   .��5d      �� -   5         ��Name$ 
stackPanel��5d      5e      �� 5f   
   -   5        $��content��5f   )   $��1��6   6)   �� 5g   
     NoHoverButtonStyle#��[ 6    � Cursor$
 Hand��6=   $	��⬅��6K   $��30(�6W   $#��NavigationCommands.BrowseBack��6f   $��5q�6�   $��0q�6�   $
��Left=�6�   $	��Top=�6�   $��53��6�   $��45��6�   
������ 6�   5i      5j      