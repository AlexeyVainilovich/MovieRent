   M S B A M L   `   `   `  ����G  CMovieRentWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:MovieRentWPFMovieRentWPF  5   	   $    MovieRentWPF.ProducerAddWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:MovieRentWPF     5   	     � Title$  ProducerAddWindow��5   	   $	��240��6#   $	��650��60    � WindowStartupLocation$ CenterScreen=�5	   	   $	��240��5
   	   $	��650��6   .��5      �  � RowDefinitions 5   
   �� 5      $	��37* �6   �� 5      $	��62* �6   �� 5      $	��62* �6   �� 5      $	��62* �6   �� 5      $	��62* �6   �� 5      $	��78* �6   �� 5      $	��37* �6    � ColumnDefinitions 5   
   �� 5      $
��167* �6   �� 5      $
��375* �6   �� 5      $
��100* �6   .+�5   
   �� -   5         ��Name$ label��5      $)��#Добавить продюссер��6   $��0��6<   $��3��6L   $��Center=�6`   $��1��6~   $��2��6�   $��14(�6�   �� 5   
   -   5        $ label1��5      $��Имя��6    $��0��6.   $��Center=�6>   $��2��6[   $��12(�6h   $��Center=�6v   �� 5   
   -   5        $ label2��5      $!��Список фильмов��6    $��0��69   $��Center=�6I   $��3��6f   $��12(�6s   $��Center=�6�   �� 5   
   -   5         ��Name$ nameTextBox��5      $��1��6'   $��2��67    �� TextWrapping$
 Wrap=�6D   $��11(�6X   $��Center=�6g   ��6�   �� *$"ProducerView.SelectedProducer.Name+�� 5   
   -   5        $ posterTextBox��5      $��1��6)   $��3��69   $��2��6F   $��11(�6W   $
 Wrap=�6e   ��6y   �� *ProducerView.ListOfMovies+�� 5   
   -   5         ��Name$ button��5      $��Добавить��6!   $��0��64   $��Center=�6D   $��5��6b   $��3��6o   $��12(�6�   $��Center=�6�   ��6�   �� *ProducerView.SaveCommand+6�   5       5!      