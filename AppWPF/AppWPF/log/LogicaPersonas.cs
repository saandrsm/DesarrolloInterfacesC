using AppWPF.dto;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace AppWPF.log
{
    public class LogicaPersonas
    {
        public ObservableCollection<Persona> listaPersonas { get; set; }

        public LogicaPersonas() 
        {
            listaPersonas = new ObservableCollection<Persona>();
            listaPersonas.Add(new Persona("Sandra", "Soleto", DateTime.Now));
        }

        public void aniadirPersona (Persona persona)
        {
            listaPersonas.Add(persona);  
        }

        public void modificarPersona (Persona persona, int posicion)
        {
            listaPersonas[posicion] = persona;  
        }
    }
}
