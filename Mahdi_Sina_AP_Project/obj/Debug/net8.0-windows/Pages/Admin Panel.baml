   M S B A M L   `   `   `  ����P  LMahdi_Sina_AP_Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:Mahdi_Sina_AP_ProjectMahdi_Sina_AP_Project  5      I)clr-namespace:Mahdi_Sina_AP_Project.PagesMahdi_Sina_AP_Project.Pages  5      -    'Mahdi_Sina_AP_Project.Pages.Admin_Panel   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ;userControl#clr-namespace:Mahdi_Sina_AP_Project     5      ;local)clr-namespace:Mahdi_Sina_AP_Project.Pages     5        N� Title$  Admin_Panel��5
       � 	Resources 5         CustomButtonStyle �� 
TargetType �� Property �� Value �� 
StartPoint �� EndPoint � Color � Offset	 �� 
TargetType
 ��Name �� CornerRadius �� Triggers P� Property P� Value �� 
TargetName  NoHoverButtonStyle��%�  &	        &	 �    �� 5   
   " ��6*   .�5      ��  � �� 5      �� 5      $	 0,0&�6*   $	 1,1&�6;   .��5      � $ 	#FF45A2FF��6'   $ 0Q�69   � 5      $ 	#FF3B8EEB��6'   $ 1Q�69   5      5      �� 5       � ��
 �   �6+   �� 5       � ��$
 Bold"�6+   �� 5       � ��
 ���� 6,   �� 5       � ��$ 1q�60   �� 5       � ��$
 10,5q�6(   �� 5       � ��$ 5q�6'   �� 5       � �� 5      �� 5      "	 ��6&   .R�5       � .+�5!      �� $
 border��6%   #��z��5"   %   #��z��5#   %   #��z��5$   %   $ 15��5%   %   ._�5&   "   �� $��Center=�63   $��Center=�6P   5'      5(       5)      P� 5*       �@J�IsMouseOver$
 True��6=   . �5+   "   �� $ border��6)    � �� 5,   &   �� 5-   *   $	 0,0&�6>   $	 1,1&�6O   .��5.   .   � $ 	#FF69B2FF��6;   $ 0Q�6M   � 5/   .   $ 	#FF5897E6��6;   $ 1Q�6M   50   +   52   #   53      P� 54       � ��$
 True��6;   . �55   "   �� $ border��6)    � �� 56   &   �� 57   *   $	 0,0&�6>   $	 1,1&�6O   .��58   .   � $ 	#FF2376C7��6;   $ 0Q�6M   � 59   .   $ 	#FF1F67B1��6;   $ 1Q�6M   5:   +   5<   #   5=      P� 5>       � {�$ False��6;   . �5?   "   �� $ border��6)    � �� �	#FFC0C0C06S   �� 5@   "    � �� �	#FF9A9A9A6?   5A      5C      5E      5F      �� 5G   
   " ��6+   .�5H      ��  � ��
 ���� 6+   �� 5I       � ��
 ���� 6,   �� 5J       � �� 5K      �� 5L      "	 ��6&   .R�5M      �� #��z��6!   #��z��6K   $��0q�6w   ._�5N      �� $��Center=�6/   $��Center=�6L   5O      5P      5R      5S      5T      .��5U      �  � ColumnDefinitions 5V   
   �� 5W      �� 5X      �� 5Y      �� 5Z      $
��1.5* �6   �� 5[       � RowDefinitions 5^   
   �� 5_      �� 5`      �� 5a      �� 5b      �� 5c      ��5f   
   �� 5g       �� ImageSource$D >\food_photos\tasty-tortilla-pieces-with-dips-fried-chicken.jpg��6    �� Opacity$ 1Q�6f   .+�5k   
   �� -   5        #��[  5k      
���   �$��17(�6P   
��� ���$��3��6p   $��1��6�   $��	5 15 5 15q�6�   .��6�   Adding Restaurant5m      �� 5n   
   -   5        #��[  5n      
���   �$��17(�6P   
��� ���$��3��6q   $��2��6�   $��	5 15 5 15q�6�   .��6�   All Restaurants5p      �� 5q   
   -   5        #��[  5q      
���   �$��17(�6P   
��� ���$��3��6q   $��3��6�   $��	5 15 5 15q�6�   .��6�   
Complaints � Triggers 5s      5u      �� 5v   
   #��[ 6    � Cursor$
 Hand��6=   $	��⬅��6K   $��30(�6W   $#��NavigationCommands.BrowseBack��6f   $��5q�6�   $��0q�6�   $
��Left=�6�   $	��Top=�6�   $��53��6�   $��45��6�   
������ 5x      5y      5z      