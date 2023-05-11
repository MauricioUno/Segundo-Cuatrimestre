using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Estacionamiento
    {
        private int capacidad;
        private static Estacionamiento estacionamiento;
        private List<Vehiculo> listadoVehiculos;
        private string nombre;

        public List<Vehiculo> ListadoVehiculos 
        { 
            get
            {  
                return this.listadoVehiculos; 
            } 
        }

        public string Nombre 
        {
            get 
            {
                return this.nombre;
            }
        }

        private Estacionamiento(string nombre, int capacidad) 
        {
            this.nombre = nombre;
            this.capacidad = capacidad;
            this.listadoVehiculos = new List<Vehiculo>();
        }

        public static Estacionamiento GetEstacionamiento(string nombre, int capacidad) 
        {
            if (Estacionamiento.estacionamiento is null)
            {
                Estacionamiento.estacionamiento = new Estacionamiento(nombre, capacidad);
            }
            else if (capacidad > 0) 
            {
                Estacionamiento.estacionamiento.capacidad = capacidad;
            }
            return Estacionamiento.estacionamiento;
        }

        public string InformarSalida(Vehiculo vehiculo) 
        {
            StringBuilder informe = new StringBuilder();
            informe.AppendLine($"Estacionamiento: {this.Nombre}");
            informe.AppendLine(vehiculo.ToString());
            informe.AppendLine($"Hora de salida: {vehiculo.HoraEgreso}");
            informe.AppendLine($"Costo de estadia: {vehiculo.CostoEstadia:0.00}");
            return informe.ToString();
        }

        public static bool operator ==(Estacionamiento estacionamiento, Vehiculo vehiculo) 
        {
            foreach(Vehiculo vehiculo2 in estacionamiento.ListadoVehiculos) 
            {
                if (vehiculo == vehiculo2) 
                {
                    return true;
                }
            }
            //estacionamiento.listadoVehiculos.Exists(value => value == vehiculo);
            return false;
        }

        public static bool operator !=(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            return !(estacionamiento == vehiculo);
        }

        public static bool operator +(Estacionamiento estacionamiento, Vehiculo vehiculo) 
        {
            if (estacionamiento.ListadoVehiculos.Count < estacionamiento.capacidad && estacionamiento != vehiculo) 
            {
                estacionamiento.listadoVehiculos.Add(vehiculo);
                return true;
            }
            return false;
        }

        public static bool operator -(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            if (estacionamiento == vehiculo)
            {
                vehiculo.HoraEgreso = DateTime.Now;
                estacionamiento.listadoVehiculos.Remove(vehiculo);
                return true;
            }
            return false;
        }
    }
}
