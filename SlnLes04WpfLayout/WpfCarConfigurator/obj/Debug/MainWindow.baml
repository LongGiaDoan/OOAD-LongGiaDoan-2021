   M S B A M L   `   `   `  ����M  IWpfCarConfigurator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:WpfCarConfiguratorWpfCarConfigurator  5   	   #    WpfCarConfigurator.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:WpfCarConfigurator     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��model & kleur��6   $��0��6,   $��0��6<   $
��Bold"�6I   �� 5   
    �� Orientation$ Vertical=�6   $��1��6,   $��0��6<   .+�5      �� -   5         ��Name$ cmbModel��5      $
��Left=�6)   $	��176��6D   $��0,0,0,50q�6P   .@�5      �� $!��continental V8 (85000 euro)��6    �� 
IsSelected . 6A   �� 5      $��convertible (72000 euro)��6   �� 5      $��mulsanne (65300 euro)��6   5      	� 5      -   5         	�Name$ rbtnKleurBlauw1��5      $��blauw��63    	� 	GroupName$ kleur��6C   6W   	� 5      -   5        $ rbtnKleurGroen��5      $��groen (+250 euro)��62   $ kleur��6N   6b   	� 5      -   5        $ rbtnKleurRood��5      $��rood(+700 euro)��61   $ kleur��6K   6_   5      �� 5   
   -   5         ��Name$ imgAuto��5      $��images/model1_blauw.jpg��6!   $��3��6B   $��0��6R   $	��150��6_   $��50,0,0,0q�6l   6�   �� 5    
   $��accessoires ��6   $��1��6'   $
��Bold"�64   6H   �� 5!   
   $ Vertical=�6   $��1��6,   $��1��6<   .+�5"      �� -   5        	 ��Name$	 	cboxAudio��5"      $&�� Bose audio speakers (+1250 euro)��6*   6X   �� 5#      -   5        $	 
cboxMatjes��5#      $ ��Deluxe matjess (+150 euro)��6+   6R   �� 5$      -   5        $	 
cboxVelgen��5$      $"��Aluminium velgen (+300 euro)��6+   6T   5%      �� 5&   
   $ Vertical=�6   $��1��6,   $��2��69   .+�5'      �� -	   5        $ imgAudio��5'      $��images/opties_audio.jpg��6&   
 J� Opacity$	
 0.3Q�6G   6W   �� 5(      -
   5        $ 	imgMatjes��5(      $��images/opties_matjes.jpg��6'   $	
 0.3Q�6I   6Y   �� 5)      -   5        $ 	imgVelgen��5)      $��images/opties_velgen.jpg��6'   $	
 0.3Q�6I   6Y   5*      �� 5+   
   $��2��6   $��0��6   $��Totaalprijs��6-   $
��Bold"�6C   $��Italic$�6U   6j   �� 5,   
   -   5         ��Name$ lblTotaalPrijs��5,      $��2��6(   $��1��65   $��35��6E   6S   5-      5.      