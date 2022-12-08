using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Text;

namespace AppWPF.dto
{
    public class Persona : INotifyPropertyChanged, ICloneable, IDataErrorInfo
    {
        private String nombre; 
        public String Nombre   //getter y setter personalizados
        {
            get { return nombre; }
            set { 
                this.nombre = value;
                this.PropertyChanged(this,new PropertyChangedEventArgs("Nombre")); //aviso de modificación y actualización
            }
        }
        public String Apellidos { get; set; } //getter y setter por defecto
        private DateTime fechaNac;
        public DateTime FechaNac
        {
            get
            {
                return fechaNac;
            }
            set
            {
                fechaNac = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("FechaNac"));
            }
        }

        public string Error
        {
            get { return ""; }
        }

        public string this[string columnName]
        {
            get
            {
                string result = "";
                if (columnName == "Nombre")
                {
                    if (string.IsNullOrEmpty(Nombre))
                        result = "Debe introducir un nombre";
                }
                if (columnName == "Apellidos")
                {
                    if (string.IsNullOrEmpty(Apellidos))
                        result = "Debe introducir los apellidos";
                }
                return result;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        
        public Persona()  //creo un constructor "vacio" para añadir registros nuevos sin datos que por defecto muestren la fecha actual
        {
            this.fechaNac = DateTime.Now;
        }
        public Persona(string nombre, string apellidos, DateTime fechaNac)  //constructor
        {
            this.nombre = nombre;
            Apellidos = apellidos;
            this.fechaNac = fechaNac;
        }


        public override string ToString()
        {
            return Nombre + " " + Apellidos;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
