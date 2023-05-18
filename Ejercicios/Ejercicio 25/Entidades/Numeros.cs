using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class NumeroBinario
    {
        private string numero = "0";
        private NumeroBinario(string numero)
        {
            this.numero = numero;
        }

        public static implicit operator NumeroBinario(string numero)
        {
            return new NumeroBinario(numero);
        }

        public static explicit operator string(NumeroBinario bin)
        {
            return bin.numero;
        }

        public static explicit operator NumeroDecimal(NumeroBinario num)
        {
            NumeroDecimal numeroDec;
            numeroDec = Conversor.BinarioADecimal(num.numero);
            return numeroDec;
        }

        public string GetNumber() 
        {
            return this.numero;
        }

        public static string operator +(NumeroBinario bin, NumeroDecimal dec) 
        {
            double numero = Conversor.BinarioADecimal(bin.numero) + dec.GetNumber();
            return Conversor.DecimalABinario((int)numero);
        }

        public static string operator -(NumeroBinario bin, NumeroDecimal dec) 
        {
            double numero = Conversor.BinarioADecimal(bin.numero) - dec.GetNumber();
            return Conversor.DecimalABinario((int)numero);
        }

        public static bool operator ==(NumeroBinario bin, NumeroDecimal dec) 
        {
            return Conversor.BinarioADecimal(bin.numero) == dec.GetNumber();
        }

        public static bool operator !=(NumeroBinario bin, NumeroDecimal dec)
        {
            return !(bin == dec);
        }
    }

    public class NumeroDecimal 
    {
        private double numero;

        private NumeroDecimal(double numero) 
        {
            this.numero = numero;
        }

        public static implicit operator NumeroDecimal(double numero)
        {
            return new NumeroDecimal(numero);
        }

        public static explicit operator double(NumeroDecimal dec)
        {
            return dec.numero;
        }

        public double GetNumber() 
        {
            return this.numero;
        }

        public static explicit operator NumeroBinario(NumeroDecimal num) 
        {
            NumeroBinario numeroBin;
            numeroBin = Conversor.DecimalABinario((int)num.numero);
            return numeroBin;
        }

        public static double operator +(NumeroDecimal dec, NumeroBinario bin) 
        {
            return Conversor.BinarioADecimal(bin + dec);
        }

        public static double operator -(NumeroDecimal dec, NumeroBinario bin)
        {

            return dec.GetNumber() - Conversor.BinarioADecimal(bin.GetNumber());
        }

        public static bool operator ==(NumeroDecimal dec, NumeroBinario bin) 
        {
            return bin == dec;
        }

        public static bool operator !=(NumeroDecimal dec, NumeroBinario bin)
        {
            return !(bin == dec);
        }
    }
}
