   M S B A M L   `   `   `  ����H  DLibrary_Final, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Library_FinalLibrary_Final  5   	       Library_Final.AdminPanel   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:Library_Final     5   	     � Title$  
AdminPanel��5   	   $	��450��6   $	��800��6)    � 
ResizeMode$ NoResize=�65    � WindowStyle$
 None=�6K    � WindowStartupLocation$ CenterScreen=�6^   .��5	      �  � RowDefinitions 5
   
   �� 5      .+�5   
   �� $��Center=�6   $	��458��6-   $	��Top=�6:   $	��800��6R   $��/admin_panel.webp��6^   �� 5   
   -   5         ��Name$ gbox_Member��5      $��Member:��6(   $��220,88,314,274q�69   $��14(�6Q   $��Segoe UI Black)�6_   .��5      �� .+�5      �� -   5         ��Name$ btn_AddMember��5      $��
Add Member��60   
 �� Top$ 9��6E    �� Left$ 10��6T   $	��234��6e   6q   �� 5      -   5        $ btn_ListMember��5      $��List Member��61   $ 37��6G   $ 10��6W   $	��234��6h   6t   5      5      �� 5   
   -   5        $ 
gbox_Books��5      $��Books:��6'   $��220,181,314,181q�67   $��14(�6P   $��Segoe UI Black)�6^   .��5      �� .+�5      �� -   5        $ btn_AddBook��5      $��Add Book��6.   $ 10��6A   $ 9��6R   $	��234��6a   6m   �� 5      -   5        $ btn_ListBook��5      $��	List Book��6/   $ 10��6C   $ 37��6T   $	��234��6d   6p   5      5      �� 5   
   -   5        $ gbox_DepositBook��5      $��Deposit Book:��6-   $��220,291,314,71q�6D   $��14(�6\   $��Segoe UI Black)�6j   .��5      �� .+�5      �� -   5        $ btn_GiveBook��5      $��	Give Book��6/   $ 9��6C   $	��254��6R   6^   �� 5      -	   5        $ btn_ListDepositBooks��5      $��List Deposit Books��67   $ 37��6T   $	��254��6d   6p   5      5       �� 5!   
   �� 5"   
   -
   5        $ btn_Close_AdminPanel��5"      $��CLOSE��6/   $
��Left=�6?   $��645,383,0,0q�6Z   $	��Top=�6o   $��57��6�   $	��100��6�   $��Segoe UI Black)�6�   $��24(�6�   
���������5#      �� 5$      	 �� EndPoint$	 0.5,1&�6&   
 �� 
StartPoint$
 0.5,0&�67   .��5%      �  � Color$	 Red��6#   � 5&      $	 Red��6#    � Offset$ 1Q�6/   � 5'      $ Black��6#   $ 0.559Q�61   5(      5*      �� 5+   
   -   5        $&  btn_ReturnDepositBook_AdminPanel��5+      $��Return Deposit Book��6;   $
��Left=�6Y   $��502,320,0,0q�6t   $	��Top=�6�   $��30��6�   $	��243��6�   $��Segoe UI Black)�6�   $��18(�6�   ��5,      �� 5-      $	 0.5,1&�6&   $
 0.5,0&�67   .��5.      � $ 	#FF00FFAE��6#   � 5/      $ 	#FF00DCFF��6#   $ 1Q�65   � 50      $ White��6#   $ 0.556Q�61   51      53      55      56      