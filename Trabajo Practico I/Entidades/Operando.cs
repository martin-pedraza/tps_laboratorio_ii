using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Operando
    {
        private double numero;
        public string Numero
        {
            set { this.numero = this.ValidarOperando(value); }
        }
        public string BinarioDecimal(string binario)
        {
            if (EsBinario(binario))
            {
                double numeroDecimal = 0;
                for (int i = 0; i < binario.Length; i++)
                {
                    if (binario[i] == '1')
                    {
                        numeroDecimal += Math.Pow(2, binario.Length - 1 - i);
                    }
                }
                return numeroDecimal.ToString();
            }
            return "Valor inválido";
        }
        public string DecimalBinario(double numero)
        {
            numero = Math.Abs(numero);
            numero = (int)numero;
            string binario = string.Empty;
            string binarioOrdenado = string.Empty;
            if (numero == 0)
            {
                return "0";
            }
            while (numero > 0)
            {
                if (numero % 2 == 0)
                {
                    binario += "0";
                }
                else
                {
                    binario += "1";
                    numero--;
                }
                numero /= 2;
            }
            for (int i = 1; i <= binario.Length; i++)
            {
                binarioOrdenado += binario[^i];
            }
            return binarioOrdenado;
        }
        public string DecimalBinario(string numero)
        {
            if (double.TryParse(numero, out double d))
            {
                return DecimalBinario(d);
            }
            return "Valor inválido";
        }
        private bool EsBinario(string binario)
        {
            foreach (char c in binario)
            {
                if (c != '0' && c != '1')
                {
                    return false;
                }
            }
            return true;
        }
        public Operando()
        {
            this.numero = 0;
        }
        public Operando(double numero)
        {
            this.numero = numero;
        }
        public Operando(string numero)
        {
            this.Numero = numero;
        }
        private double ValidarOperando(string strNumero)
        {
            if (double.TryParse(strNumero, out double d))
            {
                return d;
            }
            return 0;
        }
        public static double operator +(Operando num1, Operando num2)
        {
            return num1.numero + num2.numero;
        }
        public static double operator -(Operando num1, Operando num2)
        {
            return num1.numero - num2.numero;
        }
        public static double operator *(Operando num1, Operando num2)
        {
            return num1.numero * num2.numero;
        }
        public static double operator /(Operando num1, Operando num2)
        {
            if (num2.numero == 0)
            {
                return double.MinValue;
            }
            return num1.numero / num2.numero;
        }
    }

}
