   M S B A M L   `   `   `  ����K  GPanuon.UI.Silver, Version=1.1.3.4, Culture=neutral, PublicKeyToken=nullM8clr-namespace:Panuon.UI.Silver;assembly=Panuon.UI.SilverPanuon.UI.Silver  5   	   U QLiveCharts.Wpf, Version=0.9.7.0, Culture=neutral, PublicKeyToken=0bc1f845d1ebb8dfG4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.WpfLiveCharts.Wpf 5   	   Y U学生助学贷款管理系统, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:学生助学贷款管理系统学生助学贷款管理系统 5   	   *   $学生助学贷款管理系统.admin   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Gpu8clr-namespace:Panuon.UI.Silver;assembly=Panuon.UI.Silver     5   	   Dlvc4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.Wpf     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   >local,clr-namespace:学生助学贷款管理系统     5   	     � Title$  管理员端��5
   	   $	��450��6   $	��800��6#    � WindowStartupLocation$ CenterScreen=�6/   .��5      � .+�5   
   � $��0,0,633.6,0q�6   .+�5      �� -   5        $��学生管理��5      #   Panuon.UI.Silver.ButtonHelper   
ClickStyle$
 Sink=�5         FontAwesome#��[  5         ButtonStyle$ Hollow=�5      ���	#FF002BFF���	#FF002BFF   
HoverBrush �#002BFF$��10,125,10,250q�5   &   6=   �� 5      -   5        $��贷款审批��5      $
 Sink=�5      #��[  5      $ Hollow=�5      ���	#FF002BFF���	#FF002BFF �#002BFF$��10,195,10,180q�5   &   6=   �� 5      -   5        $��资金记录��5      $
 Sink=�5      #��[  5       $ Hollow=�5!      ���	#FF002BFF���	#FF002BFF �#002BFF$��10,265,10,110q�5$   &   6=   5%      � 5&   
   -   5        $��grid1��5&      $��165,0,-0.4,0q�6   $y�	Collapsed=�62   .+�5'      �� $��22(�6   $��10,10,454,365q�6"   .��69   学生管理6?   &   System.Windows.Controls.DataGrid  5(      -   5          Name$ 	datagrid1��5(      $��10,55,10,135q�6*      AutoGenerateColumns .     Columns 5)      0  *System.Windows.Controls.DataGridTextColumn  5*      ,  &System.Windows.Controls.DataGridColumn   Header$ 学号��6)   	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 * 65   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6?   �� *id+  5+      $ 初始密码��6)   $	 * 67   
 6A   �� *
password+5-      �� 5.      -   5        $��增加��5/      $
 Sink=�50      #��[  51      ���	#C8000000 �#000000$��39,325,454,50q�53   &   6=   �� 54      -   5        $��修改��55      $
 Sink=�56      #��[  57      ���	#C8000000 �#000000$��244,325,249,50q�59   &   6>   �� 5:      -   5        $��删除��5;      $
 Sink=�5<      #��[  5=      ���	#C8000000 �#000000$��440,325,53,50q�5?   &   6=   5@      � 5A   
   -	   5         �Name$ grid2��5A      $��165,0,-0.4,0q�6   $y�	Collapsed=�64   .+�5B      �� $��22(�6   $��10,10,454,365q�6"   .��69   贷款审批6?   �� 5C      $��22(�6   $��10,230,454,145q�6"   .��6:   所有订单6@     5D      -
   5        $ 	datagrid2��5D      $��10,55,10,250q�6*    .   5E        5F      $ 	订单号��6)   $
	 1.8* 66   
 6C   �� *	orderno+  5G      $ 学号��6)   $
	 0.8* 65   
 6B   �� *id+  5H      $ 申请理由��6)   $	 * 67   
 6A   �� *reason+  5I      $ 金额��6)   $	 * 65   
 6?   �� *price+  5J      $ 申请时间��6)   $
	 1.5* 67   
 6D   �� *time+5L        5M      -   5        $ 	datagrid3��5M      $��10,280,10,10q�6*    .   5N        5O      $ 	订单号��6)   $
	 1.8* 66   
 6C   �� *	orderno+  5P      $ 学号��6)   $
	 0.8* 65   
 6B   �� *id+  5Q      $ 申请理由��6)   $	 * 67   
 6A   �� *reason+  5R      $ 金额��6)   $	 * 65   
 6?   �� *price+  5S      $ 状态��6)   $	 * 65   
 6?   �� *	condition+  5T      $ 申请时间��6)   $
	 1.5* 67   
 6D   �� *time+5V      �� 5W      -   5        $	��150��5X      $��通过审核��5Y      $
 Sink=�5Z      #��[  5[      ���	#C8000000 �#000000$��75,181,404,199q�5]   &   6>   5^      � 5_   
   -   5        $ grid3��5_      $��165,0,-0.4,0q�6   .+�5`      �� $��22(�6   $��10,10,454,365q�6"   .��69   资金审批记录6A   #  LiveCharts.Wpf.CartesianChart  5a      &   LiveCharts.Wpf.Charts.Base.Chart   LegendLocation$ Bottom=�6E   $��10,105,10,50q�6]      Series 6!   �� *SeriesCollection+   AxisX 5c      	  LiveCharts.Wpf.Axis	   	  Title$ 每月审批金额总数��6    	  LabelFormatter 60   �� *	Formatter+6W      AxisY 5f      	  $ 月份��6    	  Labels 6*   �� *Labels+6F      DataTooltip 5h      #
  LiveCharts.Wpf.DefaultTooltip
  5i       
  SelectionMode$ SharedYValuesX�6)   6I   5k      5l      5m      5n      