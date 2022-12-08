using AppWPF.dto;
using AppWPF.log;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace AppWPF
{
    /// <summary>
    /// Lógica de interacción para DialogoPersonas.xaml
    /// </summary>
    public partial class DialogoPersonas : Window
    {
        private LogicaPersonas logicaPersonas;
        public Persona persona;
        private int posicion;
        private Boolean modificar;
        private int errores;
        public DialogoPersonas(LogicaPersonas logicaPersonas)
        {
            InitializeComponent();
            this.logicaPersonas = logicaPersonas;   
            persona = new Persona();
            this.DataContext = persona; //el data context de todos los componentes de esta ventana es Persona
            modificar = false;  
        }
                                    //el método DialogoPersonas está sobrecargado porque tienen distintos parámetros
        public DialogoPersonas(LogicaPersonas logicaPersonas, Persona modificarPersona, int posicion)
        {
            InitializeComponent();
            this.logicaPersonas = logicaPersonas;
            persona = new Persona();
            this.persona = modificarPersona; 
            this.posicion = posicion;   
            this.DataContext = persona;
            modificar = true;
        }

        private void botonCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close(); //el botón cierra esta ventana 
        }

        private void botonAceptar_Click(object sender, RoutedEventArgs e)
        {
            if (modificar)    //si cogemos el constructor de persona para modificar la persona
            {
                logicaPersonas.modificarPersona(persona, posicion);
            }
            else         //sino, cogemos el de añadirla y creamos una nueva
            {
                logicaPersonas.aniadirPersona(persona);
            }
            this.Close();
        }

        private void Validation_Error(object sender, ValidationErrorEventArgs e)
        {
            if (e.Action == ValidationErrorEventAction.Added)
                errores++;
            else
                errores--;

            if (errores == 0)
                botonAceptar.IsEnabled = true;
            else
                botonAceptar.IsEnabled = false;
        }
    }
}
