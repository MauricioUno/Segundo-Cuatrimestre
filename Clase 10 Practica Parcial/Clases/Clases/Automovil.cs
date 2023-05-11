﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public sealed class Automovil: Vehiculo
    {
        private static double valorHora;
        private string marca;


        public static double ValorHora 
        {
            set
            {
                if (value > 0) 
                {
                    Automovil.valorHora = value;
                }      
            }
            
        }

        public override double CostoEstadia
        {
            get
            {
                return this.CargoDeEstacionamiento();
            }
        }

        public override string Descripcion
        {
            get 
            {
                return this.marca;
            }
        }

        static Automovil() 
        {
            Automovil.valorHora = 120;
        }

        public Automovil(string patente, DateTime horaIngreso, string marca): base(patente, horaIngreso)
        {
            this.marca = marca;
        }

        
        protected override double CargoDeEstacionamiento()
        {
            return base.CargoDeEstacionamiento() * Automovil.valorHora;
        }

        protected override string MostrarDatos()
        {
            StringBuilder datos = new StringBuilder();
            datos.Append(base.MostrarDatos());
            datos.AppendLine($"****AUTOMOVIL**** ");
            datos.AppendLine($"Marca: {this.Descripcion} ");

            return datos.ToString();
        }

        public override string ToString()
        {
            return this.MostrarDatos();
        }
    }


}
