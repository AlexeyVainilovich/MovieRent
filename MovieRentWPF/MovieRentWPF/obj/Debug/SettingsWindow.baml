   M S B A M L   `   `   `  ����G  CMovieRentWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:MovieRentWPFMovieRentWPF  5   	   !    MovieRentWPF.SettingsWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:MovieRentWPF     5   	     � Title$  SettingsWindow��5   	   $	��625��6    $	��900��6-    � WindowStartupLocation$ CenterScreen=�5	   	   $	��625��5
   	   $	��900��6   .��5      � -   5         �Name$ 
LayoutRoot��5      
������� � RowDefinitions 5   
   �� 5      $	��20* �6   �� 5      $	��25* �6   �� 5      $	��35* �6   �� 5      $	��35* �6   �� 5      $	��35* �6   �� 5      $
��475* �6    � ColumnDefinitions 5   
   �� 5      $	��15* �6   �� 5      $
��260* �6   �� 5      $
��100* �6   �� 5      $
��105* �6   �� 5      $
��200* �6   �� 5      $
��105* �6   �� 5      $
��100* �6   �� 5      $	��15* �6   .+�5   
   � $��1��6   $��2��6   $��3��6,   $��6��6=   
�������6Q   � 5    
   $��1��6   $��1��6   $��1��6,   $��6��6=   
�������6Q   �� 5!   
   -   5         ��Name$ actorAddButton��5!      $��Сохранить��6)   $��3��6=   $��3��6N   $��14(�6[   ��6i   �� *SaveCommand+�� 5"   
   -   5        $ movieAddButton��5"      $��Загрузить��6)   $��4��6=   $��3��6N   $��14(�6[   ��6i   �� *LoadCommand+�� 5#   
   -   5        $ produserAddButton��5#      $��Продюссера��6,   $��5��6A   $��3��6R   $��12(�6_   �� 5$   
   -   5         ��Name$ label2��5$      $+��%Меню администратора��6    $��1��6>   $��Center=�6P   $��1��6n   $��2��6{   $��12(�6�   
�������6�   �� 5%   
   -   5        $ label��5%      $��Добавить:��6   $��2��63   $��Center=�6C   $��3��6a   $��12(�6n   �� 5&   
   -   5        $ MainMenuButton��5&      $��1��6)   $��2��69   $��3��6F   6x   �� 5'   
   
�������$��2q�6$   $��1��68   $��1��6I   $��4��6V   $��6��6g   5(      5)      