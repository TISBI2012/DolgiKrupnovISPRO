   M S B A M L   `   `   `  ����A  =Cinema, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Cinema.PagesCinema.Pages  5          Cinema.Pages.FilmPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:Cinema.Pages     5        N� Title$  FilmPage��5	      .��5      �  � ColumnDefinitions 5   
   �� 5      $	��150 �6   �� 5      .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ DGFilms��5         AutoGenerateColumns .     
IsReadOnly . $��10q�5      $��1��5         Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Название��6%      MinWidth$ 80Q�5   %      Width5  /System.Windows.Controls.DataGridLengthConverter$
 auto 5   %   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 5   %   �� *Name+5   %     5      $ Описание��6%   $ 80Q�5   %   $ * 5   %   	 5   %   �� *Description+5   %     5      $ Дата показа��6%   $ 80Q�5    %   $
 auto 5!   %   	 5   %   �� *
DataRelize+5!   %     5"      $ Жанр��6%   $ 50Q�5$   %   $
 auto 5%   %   	 5#   %   �� *Genre+5%   %     5&      $6 0Доступна Пушкинская карта��6%   $	 100Q�5(   %   $
 auto 5)   %   	 5'   %   �� *PushkinCardDostup+5)   %   5+      �� 5-   
   .+�5.      �� -   5        
 ��Name$
 	BAddFilms��5.      $!��Добавить фильм��6(   $��10q�6Y   �� 5/      -   5        $
 
BEditFilms��5/      $)��#Редактиовать фильм��6)   $��10q�6_   50      52      53      