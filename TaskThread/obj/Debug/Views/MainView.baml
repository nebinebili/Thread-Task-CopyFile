   M S B A M L   `   `   `  ����E  ATaskThread, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:TaskThread.ViewsTaskThread.Views  5   	       TaskThread.Views.MainView   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:TaskThread.Views     5   	     � Title$  MainView��5   	   $	��230��5	   	   $	��650��5
   	    � WindowStartupLocation$ CenterScreen=�5   	   .��5      � .+�5   
   �� $
��From��5      $��18(�5      $��30��5      $	��100��5      $��0,0,500,110q�5      5      �� 5   
   $��To��5      $��18(�5      $��30��5      $	��100��5      $��	0,0,500,0q�5      5      �� 5    
   -   5        $��txb_from��5$      $��28��5!      $	��450��5"      $��	0,0,0,100q�5#      .��5$      5&      �� 5(   
   -   5        $��txb_to��5,      $��28��5)      $	��450��5*      $��0,0,0,0q�5+      .��5,      5.      �� 52   
   -   5        $��btn_filefrom��56      $��26��53      $��80��54      $��18(�55      $��550,0,0,100q�57      $��File...��58      ��59      �� *FileFromCommand+5;      �� 5=   
   -   5        $��btn_to��5B      $��26��5>      $��80��5?      $��18(�5@      $��	550,0,0,0q�5A      $��File...��5C      ��5D      �� *FileToCommand+5F      � 5H   
   -   5         �Name$ progressbar��5L      $��26��5I      $	��515��5J      $��
-63,80,0,0q�5K      5N      �� 5P   
   -   5        $��btn_copy��5V      $��26��5Q      $��80��5R      $��18(�5S      $��550,0,0,-75q�5T      $
��Copy��5U      ��5W      �� *CopyCommand+5Y      �� 5[   
   -   5        $��
btn_resume��5a      $��26��5\      $��80��5]      $��18(�5^      $��-500,0,0,-150q�5_      $��Resume��5`      ��5b      �� *ResumeCommand+5d      �� 5f   
   -   5        $��btn_suspend��5l      $��26��5g      $��80��5h      $��18(�5i      $��-300,0,0,-150q�5j      $��Suspend��5k      ��5m      �� *SuspendCommand+5o      5q      5r      