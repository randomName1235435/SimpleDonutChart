   M S B A M L   `   `   `  ����K  GSimpleDonutChart, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:SimpleDonutChart.DonutChartSimpleDonutChart.DonutChart  5      ,    &SimpleDonutChart.DonutChart.DonutChart   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      c _Microsoft.Expression.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35=ed4http://schemas.microsoft.com/expression/2010/drawing  5      5local)clr-namespace:SimpleDonutChart.DonutChart  5      -   5          >�Name$  UserControl��5
      $��50��6   $��50��6#    � 	Resources 5      5   /SimpleDonutChart.DonutChart.PercentageConverter   	converter8   2SimpleDonutChart.DonutChart.PercentStringConverter  PercentStringConverter��%:   &	        &	        5   
   6$     5   
   6'   5      .��5      �  � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $
��Auto �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   %  Microsoft.Expression.Shapes.Arc  -   5          Name$ outer��5      $��0��6    $��0��6-   $��3��6=   $��3��6N      EndAngle$	 360Q�6�   $��	0.0,0,0,0q�6�    �� Stretch$
 None=�6     
StartAngle$ 0Q�6N   �� StrokeDashArray$	 1 0R�6]  	 �� StrokeDashOffset$	 1Q�6s  
   ArcThickness
 6b   ��  �� Path$ ArcThickness� �� ElementName$ UserControl����6�   �� $ 	FillColor�$ UserControl����6  �� $ 	FillColor�$ UserControl��6s    5   
   -   5        $ inner��5      $��0��6    $��0��6-   $��3��6=   $��3��6N   $	 360Q�6�   $��0,0,0,0q�6�   $
 None=�6  $	 1 0R�6�  $	 1Q�6�  
 6b   �� $ ArcThickness�$ UserControl����6�   �� $ ContentColor�$ UserControl����6  �� $ ContentColor�$ UserControl�� 6S  �� $ Percent�$ UserControl�� �� 	Converter# [   �� ConverterParameter$	 0.8��6�  �� 5   
   -   5         ��Name$ InnererTextblock��5      $��1��6.   $��1��6;   $��Center=�6K   $��0,0,0,0q�6h   $
��Wrap=�6y   $��Center=�6�   ��6�   �� $ Percent�$ UserControl��# [ ��6  �� $ 	FontColor�$ UserControl��5      5      