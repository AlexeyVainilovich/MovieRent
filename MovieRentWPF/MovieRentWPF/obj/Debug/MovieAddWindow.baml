   M S B A M L   `   `   `  ����G  CMovieRentWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:MovieRentWPFMovieRentWPF  5   	   !    MovieRentWPF.MovieAddWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:MovieRentWPF     5   	     � Title$  MovieAddWindow��5   	   $	��400��6    $	��650��6-    � WindowStartupLocation$ CenterScreen=�5	   	   $	��400��6.   $	��650��6>    � 	Resources 5
         
LabelStyle �� Property �� Value  TextBoxStyle��%=  &	        &	 �     �� 5      .�5      ��  � ��$ Center=�6:   �� 5       � ��$ Center=�68   �� 5       � ��$ 12(�6/   5      �� 5   
   .�5      ��  �@��TextWrapping$ NoWrap=�65   �� 5       � ��$ Center=�6:   �� 5       � ��$ 11(�61   5      5      .��5      �  � RowDefinitions 5   
   �� 5      $	��15* �6   �� 5      $	��40* �6   �� 5      $	��40* �6   �� 5      $	��40* �6   �� 5      $	��40* �6   �� 5      $	��40* �6   �� 5      $	��40* �6   �� 5      $	��40* �6   �� 5       $	��40* �6   �� 5!      $	��50* �6   �� 5"      $	��15* �6    � ColumnDefinitions 5$   
   �� 5%      $
��167* �6   �� 5&      $
��375* �6   �� 5'      $
��100* �6   .+�5)   
   �� -   5         ��Name$ label��5)      $!��Добавить фильм��6   $��0��68   $��3��6H   $��Center=�6\   $��1��6z   $��2��6�   $��14(�6�   �� 5*   
   -   5        $ label1��5*      $��Название��6    $��0��63   $��2��6D   #��[  6Q   �� 5+   
   -   5        $ label2��5+      $��Постер��6    $��0��61   $��3��6B   #��[  6O   �� 5,   
   -   5        $ label3��5,      $��Жанр��6    $��0��6/   $��4��6@   #��[  6M   �� 5-   
   -   5        $ label4��5-      $��Возраст. огр.��6    $��0��68   $��5��6I   #��[  6V   �� 5.   
   -   5        $ label7��5.      $��Год выпуска��6    $��0��66   $��6��6G   #��[  6T   �� 5/   
   -   5        $ label6��5/      $��Режиссер��6    $��0��63   $��7��6D   #��[  6Q   �� 50   
   -   5        $ label5��50      $��Актеры��6    $��0��61   $��8��6B   #��[  6O   �� 52   
   -	   5         ��Name$ nameTextBox��52      $��1��6'   $��2��67   #��[ 6D   ��6j   �� *MovieView.SelectedMovie.Name+	 �� UpdateSourceTrigger$	 PropertyChanged=��� 53   
   -
   5        $ posterTextBox��53      $��1��6)   $��3��69   #��[ 6F   ��6l   �� * MovieView.SelectedMovie.Poster+$	 PropertyChanged=��� 54   
   -   5        $ genreTextBox��54      $��1��6(   $��4��68   #��[ 6E   ��6l   �� * MovieView.SelectedMovie.Genres+$	 PropertyChanged=��� 55   
   -   5        $ 
ageTextBox��55      $��1��6&   $��5��66   #��[ 6C   ��6i   �� *MovieView.SelectedMovie.Age+$	 PropertyChanged=��� 56   
   -   5        $ dateTextBox��56      $��1��6'   $��6��67   #��[ 6D   ��6j   �� *MovieView.SelectedMovie.Date+$	 PropertyChanged=��� 57   
   -   5        $ producerTextBox��57      $��1��6+   $��7��6;   #��[ 6H   ��6n   �� *'%MovieView.SelectedMovie.Producer.Name+$	 PropertyChanged=��� 58   
   -   5        $ actorsTextBox��58      $��1��6)   $��8��69   #��[ 6F   ��6l   �� *MovieView.ListOfActors+$	 PropertyChanged=��� 59   
   -   5        
 ��Name$
 	buttonAdd��59      $��Добавить��6$   $��0��67   $��Center=�6G   $��9��6e   $��3��6r   $��12(�6�   $��Center=�6�   ��6�   �� *MovieView.SaveCommand+5:      5;      