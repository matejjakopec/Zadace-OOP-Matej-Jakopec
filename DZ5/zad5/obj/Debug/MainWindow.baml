   M S B A M L   `   `   `  ����?  ;zad5, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:zad5zad5  5   	       zad5.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:zad5     5   	     � Title$  Series Search��5   	   $	��650��6   $	��800��6,   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��10 �6   �� 5      $
��0.5* �6   �� 5      $��10 �6   �� 5      $
��0.5* �6   �� 5      $��10 �6    � RowDefinitions 5   
   �� 5      $��10 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5       $
��auto �6   �� 5!      $
��auto �6   �� 5"      $��* �6   �� 5#      $��10 �6   .+�5%   
   �� -   5        $��
TitleLabel��5%      $��1��5&      $��1��6   $��Search for show:��5'      �� 5)   
   -   5        $��SearchInput��5)      $��1��5*      $��2��6   $�� ��5+      �� 5-   
   -   5        $��SearchSeries��5-      $��1��5.      $��3��6   $��100,5,100,5q�5/      $��Search��50      �� 51   
   -   5        $��ResultsLabel��51      $��3��52      $��1��6   $F��@List of seasons for show(Double click to show list of episodes):��53      �� 54   
   -   5        $��ResultsList��54      $��1��55      $��5��6   $��3��56      $��10(�57      $��Visible=�59      �� 5:   
   -   5        $��SeriesInfoLable��5:      $��1��5;      $��9��6   $��Information about series:��5<      �� 5=   
   -   5        $��
SeriesInfo��5=      $��1��5>      $��10��6   $
��Wrap=�5?      5@      �� 5A   
   -   5        $��EpisodeLable��5A      $��3��5B      $��7��6   $"��List of episodes for season:��5C      �� 5D   
   -	   5        $��
SeasonList��5D      $��3��5E      $��2��6   $��5��5F      $	��150��5G      $��Visible=�5H      5I      �� 5K   
   -
   5        $��EpisodeList��5K      $��3��5L      $��8��6   $��5��5M      $��Visible=�5N      5P      5S      