   M S B A M L   `   `   `  ????A  =AppWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:AppWPFAppWPF  5   	       AppWPF.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:AppWPF     5   	     ? Title$  
MainWindow??5   	   $	??512??6   $	??866??6)   .??5	      ? .+?5
   
   ?? -   5         ??Name$ comboBoxPersonas??5
      $
??Left=?6-   $??	37,50,0,0q?6H   $	??Top=?6[   $	??120??6s   6   ?? 5   
   $
??Left=?6   $	??100??6/   $??	37,94,0,0q?6<   
???   ?$	??Top=?6^   $	??274??6v   ?? 5   
   -   5         ??Name$ labelNombre??5      $?? ??6%   $
??Left=?60   $??109,131,0,0q?6K   $	??Top=?6`   ?? 5   
   -   5        $ labelApellidos??5      $?? ??6(   $
??Left=?63   $??205,131,0,0q?6N   $	??Top=?6c    J? RenderTransformOrigin$ -0.053,-0.233&?6{   ?? 5   
   $1??+Ejemplo de mostrar elementos de un comboBox??6   $
??Left=?6F   $??	37,19,0,0q?6a   $	??Top=?6t   ?? 5   
   -   5        $ labelPrueba??5      $
??Left=?6^   $??
37,293,0,0q?6y   $	??Top=?6?   $	??143??6?   $??16(?6?   $
??Bold"?6?   $??88??6?   ??6%   ??  ?? ElementName$ textBoxPrueba?? ?? Path$
 Text?6?   ?? 5   
   -   5        $ labelEjemplo2??5      $8??2Ejemplo de Binding entre dos componentes gráficos??6'   $
??Left=?6c   $??
37,217,0,0q?6~   $	??Top=?6?   ?? 5   
   -   5         ??Name$ textBoxPrueba??5      $
??Left=?6)    ?? TextWrapping$
 Wrap=?6D   $?? ??6X   $	??Top=?6`   $	??143??6x   $??23??6?   $??
37,265,0,0q?6?   ?? 5   
   -   5        $ labelEjemplo3??5      $9??3Ejemplo de ComboBox con Binding (componente-objeto)??6'   $
??Left=?6e   $??
389,19,0,0q?6?   $	??Top=?6?   ?? 5   
   -   5        $ comboBoxPersonas2??5      $
??Left=?6Y   $??
400,50,0,0q?6t   $	??Top=?6?   $	??120??6?   ??6.   ?? $ listaPersonas?6?   ?? 5   
   -	   5         ??Name$ 
botonNuevo??5      $??Nuevo??6%   $
??Left=?65   $??
400,79,0,0q?6P   $	??Top=?6d   6|   ?? 5   
   $!??Ejemplo de DataGrid (tabla)??6   $
??Left=?66   $??382,131,0,0q?6Q   $	??Top=?6f   &   System.Windows.Controls.DataGrid  5   
   -
   5        	  Name$	 tablaPersonas??5      
   AutoGenerateColumns$

 True??6U   $??382,157,190,208q?6p   ??6*   ?? $ listaPersonas?6p   ?? 5   
   -   5        $ tablaPersonas2??5      $/??)Ejemplo de DataGrid personalizada (tabla)??6(   $
??Left=?6\   $??382,281,0,0q?6w   $	??Top=?6?     5   
   -   5        $	 tablaPersonas1??5      $
 False??6V   $??380,312,190,47q?6r   ??6+   ?? $ listaPersonas?   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Nombre??6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 65   ?? $ Nombre?5      ?? 5   
   -   5        $ botonModificar??5      $??	Modificar??6)   $
??Left=?6=   $??433,442,0,0q?6X   $	??Top=?6m   6?   ?? 5   
   -   5        $ botonAñadir??5      $??Añadir Persona??6&   $
??Left=?6?   $??546,442,0,0q?6Z   $	??Top=?6o   6?   ?? 5   
   $??Ejemplo Dialogo??6   $
??Left=?6*   $??689,337,0,0q?6E   $	??Top=?6Z   ?? 5    
   -   5         ??Name$ 
imagenMeme??5       $
??Left=?6$   $4??.https://cdn.memegenerator.es/descargar/4141182??6?   $	??117??6w   $??205,312,0,0q?6?   $	??Top=?6?   $	??155??6?   5"      5#      