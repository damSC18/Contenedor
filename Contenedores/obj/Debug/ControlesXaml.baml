   M S B A M L   `   `   `  ����G  CContenedores, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:ContenedoresContenedores  5   	        Contenedores.ControlesXaml   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Contenedores     5   	     � Title$  ControlesXaml��5   	   $	��450��6   $	��800��6,    � 	Resources 5	         Contenedores.Apuntes   data��%   &	          5
   
   6   5      .��5      �� .+�5   
   �� -   5        $��Botón Normal��5      $��50��6<   $	��100��6H   �� 5   
   -   5        $��Botón de repetición��5      $��50��6M    �� Left$	 125��6Y   $	��100��6k   �� 5   
   -   5         ��Name$ Mensajes��5      $��Mensajes��6"   $��35��65   
 �� Top$ 15��6A   $	��435��6Q   $	 255��6]   �� 5   
   -   5         ��Name$ RegistroApuntes��5      $	��170��6,   $ 35��69   $ 85��6J   $	��170��6Z   ��5      �� *data+ �� View 5      �� 5      .P�5      �� $��Ciclo��6%    �� DisplayMemberBinding 64   ��  �� Path$ Ciclo�5      5      �� 5   
   $	��Two��6   �� 5   
   -   5        $��Visualiza JSON��5      $ 35��6*   $	 260��6;   $	��170��6L   	 J� RenderTransformOrigin$	 -0.867,-1.75&�6m   R� 5   
   -   5        
 R�Name$
 listaEmpleados��5      $	��105��6+   $	 235��68   $ 86��6J   $	��235��6Z   .@�5      Q� $��Perico de Los Palotes��6   .@�5      Q� $��Burgos��6   Q� 5      $��Aranda de Duero��6   Q� 5      $��09400��6   5      Q� 5       $��Epifanio Peludo��6   .@�5!      Q� $��Segovia��6   Q� 5"      $��	Cantalejo��6   Q� 5#      $��08234��6   5$      5&      �� 5'   
   -   5         ��Name$ cajaEmpleado��5'      $��23��6(   $	 235��64    �� TextWrapping$
 Wrap=�6F   $��Empleado��6Z   $	 196��6j   $	��135��6{   �� 5(   
   -   5        $��AñadeEmpleado
��5(      $	 385��63   $	 199��6E   $��85��6V   $��20��6a   6m   �� 5)   
   -	   5        $!��Borra Elemento Seleccioando��5)      $	 235��67   $	 224��6I   $	��235��6Z   6f   5-      5.      