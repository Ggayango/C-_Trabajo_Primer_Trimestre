   M S B A M L   `   `   `  ����R  NProyectoPrimerTrimestre, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:ProyectoPrimerTrimestreProyectoPrimerTrimestre  5   	   1    +ProyectoPrimerTrimestre.Registro_de_Usuario   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:ProyectoPrimerTrimestre     5   	     � Title$  Registro de Usuario��5   	   $	��380��6%   $��726.853��62   $	��380��6B   $��726.853��6R   
���   � � WindowStartupLocation$ CenterScreen=�6x   .��5
      � D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    6   :x,http://schemas.microsoft.com/winfx/2006/xaml     5      -   5        $��rootElement��5      $��20,24,3.8,27.8q�6   
���   � � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   $��32��6*   �� 5      $
��Auto �6   $
��23.2��6*   �� 5      $
��Auto �6   $
��17.6��6*   �� 5      $
��Auto �6   $
��57.6��6*   �� 5      $
��Auto �6   $
��13.6��6*   .+�5    
   �� -   5        $��	nombreBox��5    -   $��0��6   $��1��6    $��0,0.2q�6>   $��Lucida Console)�6M   ���	#FF0FFA00.��6�   	Nombre:6�   �� 5!   
   -   5        $��	nombretxt��5!   &   $��4��6   $��82,0,0,5q�67   $��2��6I    �� SelectionBrush �	#FF0FFA00���	#FF0FFA00 �� 
CaretBrush �	#FF0FFA00���	#FF0FFA00
���   �6�   �� 5#   
   -   5        $��apellidosBox��5#   -   $��0��6   $��2��6    $��0,0,0.4,9.8q�6A   $��Lucida Console)�6V   ���	#FF0FFA00.��6�   
Apellidos:6�   �� 5$   
   -   5        $��apellidostxt��5$   3   $��2��6   $��4��6   $��
82,2,0,9.8q�6G   
���   ����	#FF0FFA00 �	#FF0FFA00���	#FF0FFA00 �	#FF0FFA006�   �� 5&   
   -   5        $��dniBox��5&   -   $��0��6   $��3��6    $��0,0.2,0.4,5.6q�6;   $��Lucida Console)�6R   ���	#FF0FFA00.��6�   DNI:6�   �� 5'   
   -   5        $��dnitxt��5'   =   $��1��6    �� 	MaxLength$ 9��6"   $��3��60   $��0.6,0.2,97,9.6q�6K   $��3��6c   ���	#FF0FFA00
���   � �	#FF0FFA00���	#FF0FFA00 �	#FF0FFA006�   �� 5)   
   $��3��6   $��3��6    $��88.4,0.2,-62,2.6q�6-   $��Lucida Console)�6G   ���	#FF0FFA00.��6z   Fecha de ancimiento:6�   (  "System.Windows.Controls.DatePicker  5*   
   -   5        $��fechaBox��5*   ^   $��3��6   $��238,0,-337.6,17.2q�6%   $��3��6@   $��2��6M   
���   �
���   ����	#FF0FFA006�   �� 5,   
   -	   5        $��pesoBox��5,   -   $��0��6   $��5��6    $��0,0,0.4,62.6q�6<   $��Lucida Console)�6R   ���	#FF0FFA00.��6�   Peso:6�   �� 5-   
   -
   5        $��pesotxt��5-   -   $��5��6   $ 2��6   $��0��6<   $��82,0,0.8,62.6q�6E   $��2��6\   
���   ����	#FF0FFA00 �	#FF0FFA00���	#FF0FFA00 �	#FF0FFA006�   �� 5/   
   -   5        $��	alturaBox��5/   -   $��0��6   $��5��6    $��0,0,0.4,36.6q�6>   $��Lucida Console)�6T   $��19��6p   $��Bottom=�6|   ���	#FF0FFA00.��6�   	Altura:6�   �� 50   
   -   5        $��	alturatxt��50      $��5��6   $ 4��60   $��0��6>   $��82,30,0.8,36.6q�6G   $��2��6_   
���   ����	#FF0FFA00 �	#FF0FFA00 �	#FF0FFA00���	#FF0FFA006�   �� 52   
   -   5        $��sexoBox��52   -   $��0��6   $��5��6    $��0,53.8,0.4,0.8q�6<   $��Lucida Console)�6T   ���	#FF0FFA00.��6�   Sexo:6�   	� 53   
   -   5        $��
sexoHombre��53   #   $��5��6   $��82,59,1.8,4.6q�65   $��Hombre��6L   $��Lucida Console)�54      ���	#FF0FFA00���	#FF0FFA00���	#FF0FFA00$��2��6x   	� 55   
   -   5        $��	sexoMujer��55   3   $��1��6   $��6��6&   $��0,0.2,1.8,0q�6D   $��Right=�56      $��72��62   $��Mujer��6=   $��Lucida Console)�6M   ���	#FF0FFA00���	#FF0FFA00���	#FF0FFA006�   �� 58   
   -   5        $��registro��58   i   $��3��6   $��160,78.6,-133.6,-99.4q�6!   $��6��6@   $��Registrar Usuario��6M   $��Lucida Console)�6y   
���   ����	#FF0FFA00���	#FF0FFA00 J� OpacityMask �	#FFDD0B0B6�   �� 5:   
   -   5        $��cancelar��5:   �   $��3��6   $��321.4,78.2,-227,-99q�6!   $��6��6>   $��Salir��6K   
���   �$��Lucida Console)�6n   ���	#FF0FFA00���	#FF0FFA006�   5<      5>      