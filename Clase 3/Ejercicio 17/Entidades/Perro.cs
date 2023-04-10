using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Perro
    {
        public string nombre;
        public int edad;
        public Persona duenio;

        public Perro(string nombre, int edad, Persona duenio) 
        {
            this.nombre = nombre;
            this.edad = edad;
            this.duenio = duenio;
        }
        public string Saludar() 
        {
            return $"Soy un perro, mi nombre es {this.nombre} y mi dueño es {this.duenio.nombre}";
        }
    }
}
