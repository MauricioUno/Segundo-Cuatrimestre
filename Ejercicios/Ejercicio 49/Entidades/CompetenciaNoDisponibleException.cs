﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CompetenciaNoDisponibleException: Exception
    {
        private string nombreClase;
        private string nombreMetodo;

        public string NombreClase 
        {
            get { return this.nombreClase; }
        }

        public string NombreMetodo 
        {
            get { return this.nombreMetodo; }
        }
        
        public CompetenciaNoDisponibleException(string mensaje, string clase, string metodo) : base(mensaje)
        {
            this.nombreClase = clase;
            this.nombreMetodo = metodo;
        }

        public CompetenciaNoDisponibleException(string mensaje, string clase, string metodo, Exception innerException) : base(mensaje, innerException)
        {
            this.nombreClase = clase;
            this.nombreMetodo = metodo;
        }

        public override string ToString() 
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendLine($"Excepcion en el metodo {this.nombreMetodo} de la clase {this.nombreClase}");
            datos.AppendLine(this.Message);
            Exception inner = this.InnerException;
            while(inner != null) 
            {
                datos.Append($"{inner.Message}\t");
                inner = inner.InnerException;
            }
            return datos.ToString();
        }

    }
}
