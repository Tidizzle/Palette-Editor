   M S B A M L   `   `   `  ����H  DPaletteEditor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:PaletteEditorPaletteEditor  5   	       PaletteEditor.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:PaletteEditor     5   	     � Title$  Palette Editor��5   	   $	��350��6    $	��550��6-    � 
ResizeMode$ NoResize=�69   .��5	      � .+�5
   
   ]� $��	0,0,0,292q�6   .+�5      o� $	��Top=�6   $��25��6(   .@�5      m� $��_File��6   .@�5      m� -   5        $
��_New��5      6-   m� 5      -   5        $��_Open��5      6.   m� 5      -   5        $��_Save��5      6.   m� 5      -   5        $��Save _As��5      61   5      m� 5      $��_Edit��6   .@�5      m� -   5        $��
_Add Color��5      63   m� 5      -   5        $��_Remove Color��5      66   5      m� 5      $
��Info��6   .@�5      m� -   5        $��About��5      6.   m� 5      -   5        $��Creator��5      60   5      5      5      � 5   
   $	��292��6   $��Bottom=�6    � ColumnDefinitions 5      �� 5      $
��.03* �6#   �� 5       $��1* �6#   �� 5!      $
��.03* �6#   �� 5"      $��1* �6#   �� 5#      $
��.03* �6#    � RowDefinitions 5%      �� 5&      $
��.05* �6    �� 5'      $��1* �6    �� 5(      $��1* �6    �� 5)      $
��.05* �6    .+�5,      �� $��1��6   $��1��6$   $��Palette Info��65   .��5-      �  5.      �� 5/      $��1* �6(   �� 50      $��1* �6(    52      �� 53      $	��.3* �6+   �� 54      $	��.7* �6+   .+�57      �� $��Name :��6   $��Center=�6-   $��15(�6J   $
��Bold"�6X   $��Center=�6j   �� 58      -	   5         ��Name$ NameBox��58   .   $��1��6   $��25��6?   $��Center=�6K   $	��150��6h   $��Center=�6t   $��Center=�6�    �� 
IsReadOnly . 6�   �� 5:      $��Count :��6   $��Center=�6.   $��15(�6K   $
��Bold"�6Y   $��Center=�6k   $��1��6�   �� 5;      -
   5        $ CountBox��5;      $��1��60   $��1��6@   $��25��6M   $��Center=�6Y   $	��150��6v   $��Center=�6�   $��Center=�6�    . 6�   5<      5=      �� 5?      $��2��6   $��1��6$   $��Options��64   .��5@      �  5A      �� 5B      $��1* �6(   �� 5C      $��1* �6(   .+�5F      �� -   5        $��0��5F      $��	Add Color��6*   $
��Bold"�6>   $��15(�6P   $��45��6^   $	��200��6j   6v   �� 5G      -   5        $��1��5G      $��Remove Color��6*   $
��Bold"�6A   $��15(�6S   $��45��6a   $	��200��6m   6y   5H      5I      �� 5K      $��1��6   $��2��6$   $��3��65   $��
Color List��6E   .��5M      �  5N      �� 5O      $
��.05* �6(   �� 5P      $��1* �6(   �� 5Q      $
��.05* �6(    5S      �� 5T      $
��.05* �6+   �� 5U      $��1* �6+   �� 5V      $
��.05* �6+   .+�5\      �� -   5         ��Name$
 List��5\      $��1��6-   $��1��6=   $	��232��6J   $	��225��6W    �� SelectionMode$ Single=�6c   $��Visible=�6z    �� View 5]      �� 5^      .P�5`   "   �� 	 �� Width$	 75��61   
 �� DisplayMemberBinding
 6<   ��  �� Path$
 Name���5a   &   �� 5b   *   
 � Tag$
 Name��6?   $
��Name��6J   5d   #   �� 5f   "   $	 25��61   
 6<   �� $ ID���5g   &   �� 5h   *   $ ID��6?   $	��ID ��6H   5j   #   �� 5l   "   $	 25��61   
 6<   �� $ r���5m   &   �� 5n   *   $ R��6?   $��R��6G   5p   #   �� 5r   "   $	 25��62   
 6=   �� $ g���5s   &   �� 5t   *   $ G��6?   $��G��6G   5v   #   �� 5x   "   $	 25��63   
 6>   �� $ b���5y   &   �� 5z   *   $ B��6?   $��B��6G   5|   #   �� 5~   "   $	 25��61   
 6<   �� $ a���5   &   �� 5�   *   $ A��6?   $��A��6G   5�   #   5�      5�      5�      5�      5�      5�      5�      