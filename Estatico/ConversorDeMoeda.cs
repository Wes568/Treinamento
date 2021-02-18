using System;
using System.Collections.Generic;
using System.Text;


namespace Estatico
{
    class ConversorDeMoeda
    {
        public static double iof = 6;
        static double reais;

        public static double Conversao(double cota, double valor)
        {
            reais = (cota * valor);
            return reais + reais *iof/100 ;
        }
    }
}
