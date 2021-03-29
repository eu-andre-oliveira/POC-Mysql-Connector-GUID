using System;
using System.Globalization;

namespace ConsoleApp1
{
    class Program
    {


        public static int find(int one, int two, int three)
        {
            return (one>two? 1: 2);
        }

        public static decimal FormataDecimal(string valor)
        {
            var valorInteiro = valor.Substring(0, (valor.Length - 2));
            var valorCentavos = valor.Substring(valorInteiro.Length, 2);
            valor = valorInteiro + "." + valorCentavos;

            return Convert.ToDecimal(valor, CultureInfo.InvariantCulture);
        }
        static void Main(string[] args)
        {
            var valor = FormataDecimal("10422");

            Console.WriteLine("Hello World!" + valor.ToString());
            //  find(-1, -2);
            // Console.WriteLine("Hello World!" + find(-1, -2).ToString());
        }

    }
}
