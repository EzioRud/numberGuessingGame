   M S B A M L   `   `   `  ����P  Lguess_game_by_Rudolph, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:guess_game_by_Rudolphguess_game_by_Rudolph  5   	   &     guess_game_by_Rudolph.GameItSelf   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:guess_game_by_Rudolph     5   	   -   5          � Title$%  Number Guessing game by rudolph��5   	   $	��600��61   $	��500��6>   ��5	      �� 5
   
   .��5      � $��0,0,2,0q�6    � ColumnDefinitions 5   
   �� 5      $
��144* �6   �� 5      $
��101* �6   ��5   
   �� 5       �� ImageSource$6 0mass_effect_andromeda_n7-wallpaper-5120x2880.jpg��6    j� Stretch$ UniformToFill=�6X   .+�5   
   �� $
��Left=�6   $	��117��6,   $��	10,10,0,0q�69   $	��Top=�6L   $	��470��6d   $��2��6p   ��5      �� 5      $- 'blue_ball_macro-wallpaper-5120x2880.jpg��6   $ UniformToFill=�6S    j� TileMode$ FlipXY=�6k   .+�5      �� -   5        $��guess ��5      $
��Left=�6&   $	��Top=�6A   $��70��6Y   $��24��6y    J� RenderTransformOrigin$ 0.827,0.083&�6�    �� Left$	 172��6�   $��Global Sans Serif)�6�   $
��Bold"�6�   ��5      �� 5      $: 4water_reflection_photography-wallpaper-3840x2160.jpg��6!   5      �� 5      $��Total guesses :��6   $
��Left=�6.   $	��Top=�6I   $	��101��6a   $��23��6m   $	 301��6y   $
��Bold"�6�   $��Rockwell)�6�   
 �� Top$ 1��6�   
�������$��11(�6�   �� 5      -   5         ��Name$ taken��5      $
��Left=�6%   $��23��6@   	 �� TextWrapping$
	 Wrap=�6L   $	��Top=�6`   $��32��6x   $	 407��6�   $ 1��6�   �� 5      $
��hint��6   $
��Left=�6$   $	��Top=�6?   $��45��6W   $ 27��6b   $ 87��6s   $
��Bold"�6�   ��5       �� 5!      $: 4water_reflection_photography-wallpaper-3840x2160.jpg��6!   $ UniformToFill=�6d   5#      �� 5$      -   5        $ chance��5$      $
��Left=�6&   $��24��6A   $
	 Wrap=�6M   $	��Top=�6a   $��30��6y   $	 137��6�   $��5��6�   �� 5%      $��guesses left :��6   $ 27��6-   $	��105��6>   $
��Bold"�6J   ���	#FFFDF6F6$��24��6s   $��11(�6   �� 5&      -   5        $ levell��5&      $��23��6&   $	 407��62   $
	 Wrap=�6D   $ 29��6X   $��32��6h   $��1��6s   �� 5'      $��level :��6   $	 346��6&   $ 29��68   $��56��6H   $��Rockwell)�6S   
�������$��14(�6|   $
��Bold"�6�   $��23��6�   �� 5(      -   5        
 ��Name$
 label1��5(      $��	Auto Play��6$   $	 198��68   $ 31��6J   $��59��6Z   $��26��6{   $��10(�6�   $
��Bold"�6�   ��6e   Z� 6�   �� 5)      -   5        $ guess1��5)      $��24��6&   $	 247��62   $
	 Wrap=�6D   $��39��6X   $��5��6c   �� 5*      $��57��6   $ 54��6!   $	��187��61   $	 137��6=   ��5+      �� 5,      $* $deep_space_2-wallpaper-2560x1440.jpg��6!   $ UniformToFill=�6T   .+�5.      �� -   5         ��Name$
 ranl��5.      $��Random with limits��6'   $ 63��6D   $	��124��6U   $
��Bold"�6x   $��Italic$�6�   ��5/      �� 50      $: 4water_reflection_photography-wallpaper-3840x2160.jpg��6%   $ UniformToFill=�6h   52      �� 53      -	   5        $	 bin��53      $��Binary��6&   $��58��67   $
��Bold"�6Y   $��Italic$�6k   ��54      �� 55      $: 4water_reflection_photography-wallpaper-3840x2160.jpg��6%   57      �� 58      -
   5        $	 ran��58      $��Random��6&   $ 27��67   $��75��6G   $	 112��6i   $��Italic$�6{   $
��Bold"�6�   ��59      �� 5:      $: 4water_reflection_photography-wallpaper-3840x2160.jpg��6%   5<      5=      5>      �� 5?   
   -   5         ��Name$
 home��5?      $
��Left=�6   $	��346��6:   $��
25,149,0,0q�6G   $	��Top=�6[   $	��445��6s   $��2��6   ��5@      �� 5A      $- 'blue_ball_macro-wallpaper-5120x2880.jpg��6    J� OpacityMask 5C      �� 5D      $6 0mass_effect_andromeda_n7-wallpaper-5120x2880.jpg��6   5F      �� 5G   
   $
��Left=�6   $��48��6,   $��
10,511,0,0q�68   $	��Top=�6L   $	��470��6d   $��2��6p   ��5H      �� 5I      $- 'blue_ball_macro-wallpaper-5120x2880.jpg��6   $ UniformToFill=�6S   .+�5K      �� -   5        $��Restart��5K      $ 18��6'   $��56��67   $ 19��6Y   $
��Bold"�6j   $��Italic$�6|   ��5L      �� 5M      $: 4water_reflection_photography-wallpaper-3840x2160.jpg��6!   5O      �� 5P      -   5        $��End game��5P      $	 395��6(   $ 18��6:   $��65��6J   $
��Bold"�6l   $��Italic$�6~   ��5Q      �� 5R      $: 4water_reflection_photography-wallpaper-3840x2160.jpg��6!   5T      �� 5U      -   5        $ outbox��5U      $
��Left=�6&   $��23��6A   $
	 Wrap=�6M   $	��Top=�6a   $	��267��6y   $ 95��6�   $ 15��6�   5V      5X      5Y      