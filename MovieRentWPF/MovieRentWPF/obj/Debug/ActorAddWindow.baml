   M S B A M L   `   `   `  ����G  CMovieRentWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:MovieRentWPFMovieRentWPF  5   	   !    MovieRentWPF.ActorAddWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:MovieRentWPF     5   	     � Title$  ActorAddWindow��5   	   $	��400��6    $	��650��6-    � WindowStartupLocation$ CenterScreen=�5	   	   $	��400��5
   	   $	��650��6   .��5      �  � RowDefinitions 5   
   �� 5      $	��15* �6   �� 5      $	��40* �6   �� 5      $	��40* �6   �� 5      $	��40* �6   �� 5      $	��40* �6   �� 5      $	��15* �6   �� 5      $	��65* �6   �� 5      $	��40* �6   �� 5      $	��40* �6   �� 5      $	��50* �6   �� 5      $	��15* �6    � ColumnDefinitions 5   
   �� 5      $
��167* �6   �� 5      $
��375* �6   �� 5      $
��100* �6   .+�5   
   �� -   5         ��Name$ label��5      $#��Добавить актера��6   $��0��69   $��3��6I   $��Center=�6]   $��1��6{   $��2��6�   $��14(�6�   �� 5   
   -   5        $ label1��5      $��Имя��6    $��0��6.   $��Center=�6>   $��2��6[   $��12(�6h   $��Center=�6v   �� 5    
   -   5        $ label2��5       $��Дата рождения��6    $��0��68   $��Center=�6H   $��3��6e   $��12(�6r   $��Center=�6�   �� 5!   
   -   5        $ label3��5!      $!��Список фильмов��6    $��0��69   $��Center=�6I   $��4��6f   $��12(�6s   $��Center=�6�   �� 5"   
   -   5        $ label4��5"      $'��!Краткая биография��6    $��0��6<   $��Center=�6L   $��6��6i   $��12(�6v   $��Center=�6�   �� 5#   
   -   5         ��Name$ nameTextBox��5#      $��1��6'   $��2��67   $��11(�6D    �� TextWrapping$
 Wrap=�6R   $��Center=�6g   ��6�   �� *ActorView.SelectedActor.Name+ �� UpdateSourceTrigger$ PropertyChanged=��� 5$   
   -   5        $ dateTextBox��5$      $��1��6'   $��3��67   $��11(�6D   $
 Wrap=�6R   $��Center=�6g   ��6�   �� *ActorView.SelectedActor.Date+$ PropertyChanged=��� 5%   
   -   5        $ filmlsTextBox��5%      $��1��6)   $��4��69   $��11(�6F   $
 Wrap=�6U   ��6i   �� *ActorView.ListOfMovies+$ PropertyChanged=��� 5&   
   -	   5        $ infoTextBox��5&      $��1��6'   $��6��67   $��3��6D   $��11(�6U   $
 Wrap=�6c   ��6w   �� *#!ActorView.SelectedActor.Biography+$ PropertyChanged=��� 5'   
   -
   5         ��Name$ 	AddButton��5'      $��Добавить��6$   $��0��67   $��Center=�6G   $��9��6e   $��3��6r   $��12(�6�   $��Center=�6�   ��6�   �� *ActorView.SaveCommand+5(      5)      