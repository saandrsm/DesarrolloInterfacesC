   M S B A M L   `   `   `  ????A  =AppWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:AppWPFAppWPF  5   	       AppWPF.DialogoPersonas   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:AppWPF     5   	     ? Title$  DialogoPersonas??5   	   $	??312??6!   $	??399??6.   .??5	      ? .+?5
   
   ?? -   5         ??Name$ labelNombre??5
      $??Nombre??6%   $
??Left=?66   $??	50,53,0,0q?6Q   $	??Top=?6d   ?? 5   
   -   5        $ labelApellidos??5      $??	Apellidos??6(   $
??Left=?6<   $??
50,101,0,0q?6W   $	??Top=?6k   ?? 5   
   -   5        $ labelFechaNac??5      $??Fecha de nacimiento??6'   $
??Left=?6E   $??
50,155,0,0q?6`   $	??Top=?6t   ?? 5   
   -   5         ??Name$ 
textNombre??5      $
??Left=?6&   $??
147,57,0,0q?6A    ?? TextWrapping$
 Wrap=?6U   $	??Top=?6?   $	??187??6?   ??6?   ??  ?? Path$ Nombre? ?? NotifyOnValidationError$
 True?? ?? ValidatesOnDataErrors$
 True??6?   ?? 5   
   -   5        $ textApellidos??5      $
??Left=?6)   $??147,105,0,0q?6D   $
 Wrap=?6Y   $	??Top=?6?   $	??187??6  ??6?   ?? $ 	Apellidos?$
 True??$
 True??6  (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ pickerFecha??5      $
??Left=?6*   $??189,156,0,0q?6E   $	??Top=?6Z      SelectedDate 6r   ?? $ FechaNac??? 5   
   -   5        	 ??Name$	 botonAceptar??5      $??Aceptar??6'   $
??Left=?69   $??104,228,0,0q?6T   $	??Top=?6i   6?   ?? 5   
   -   5        $	 botonCancelar??5      $??Cancelar??6(   $
??Left=?6;   $??226,228,0,0q?6V   $	??Top=?6k   6?   5      5      