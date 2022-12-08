using AppWPF.dto;
using AppWPF.log;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AppWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private LogicaPersonas logicaPersonas;
        //public ObservableCollection<Persona> listaPersonas { get; set; }  //creo un atributo de una lista observable
        public MainWindow()
        {
            InitializeComponent();
            logicaPersonas = new LogicaPersonas();
            tablaPersonas1.DataContext = logicaPersonas;
            imagenMeme.Visibility = Visibility.Hidden;

            //List<Persona> listaPersonas1 = new List<Persona>(); //creamos una lista con List
            logicaPersonas.aniadirPersona(new Persona("Pablo", "Gonzalez", new DateTime(2003, 2, 15)));
            logicaPersonas.aniadirPersona(new Persona("Pedro", "Gonzalez", new DateTime(2004, 5, 13))); //añadimos manualmente dos personas

            foreach (Persona persona in logicaPersonas.listaPersonas)
            {                                             //recorremos la lista y añadimos cada persona al combobox
                ComboBoxItem cbi = new ComboBoxItem();
                cbi.Content = persona;
                comboBoxPersonas.Items.Add(cbi);
            }

            //    listaPersonas = new ObservableCollection<Persona>(); //creo un objeto de la lista observable
            //    listaPersonas.Add(new Persona("Pablo", "Gonzalez"));
            //    listaPersonas.Add(new Persona("Pedro", "Perez"));
            comboBoxPersonas2.DataContext = logicaPersonas; //defino el contexto de datos de donde va a coger los datos el comboBox
            tablaPersonas.DataContext = logicaPersonas;     //y de las tablas
            tablaPersonas1.DataContext = logicaPersonas;
        }

        private void comboBoxPersonas_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {                                                   //cuando cambias la seleccion, cambian los label
            ComboBoxItem cbi = (ComboBoxItem)comboBoxPersonas.SelectedItem;
            Persona persona = (Persona)cbi.Content;
            labelNombre.Content = persona.Nombre;
            labelApellidos.Content = persona.Apellidos;
        }

        private void botonNuevo_Click(object sender, RoutedEventArgs e)
        {
            logicaPersonas.aniadirPersona(new Persona("Nuevo", "Nuevos", new DateTime(2001, 7, 22))); //cuando se haga click en el botón se añade un registro de persona
        }

        private void botonModificar_Click(object sender, RoutedEventArgs e)
        {
            //logicaPersonas.listaPersonas.ElementAt(0).Nombre = "Juan";   //se modifica el campo 0 (nombre)
            if (tablaPersonas1.SelectedIndex != -1)
            {                                                              //cuando el usuario seleccione la persona que quiera y pulse el botón modificar
                Persona persona = (Persona)tablaPersonas1.SelectedItem;    //recogo la persona de la fila 0 
                DialogoPersonas dialogoPersonas = new DialogoPersonas(logicaPersonas, (Persona)persona.Clone(), tablaPersonas1.SelectedIndex);  //se lo paso al diálogo y muestro el diálogo
                dialogoPersonas.Show();
            }
            
            
        }

        private void botonAñadir_Click(object sender, RoutedEventArgs e)
            {
                DialogoPersonas dialogoPersonas = new DialogoPersonas(logicaPersonas); //creamos unobjeto de la clase dialogoPersonas
                dialogoPersonas.Show();
            }

        private void botonModificar_MouseEnter(object sender, MouseEventArgs e)
        {
            imagenMeme.Visibility = Visibility.Visible;
        }

        private void botonModificar_MouseLeave(object sender, MouseEventArgs e)
        {
            imagenMeme.Visibility = Visibility.Hidden;
        }
    }
    }

