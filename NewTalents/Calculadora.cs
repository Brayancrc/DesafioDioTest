using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewTalents
{
    public class Calculadora
    {
        private List<string> listahistorico;


        public Calculadora()
        {
            listahistorico = new List<string>();
        }
        
        public int somar(int val1, int val2)
        {
            int res = val1 + val2;
            listahistorico.Insert(0, "Valor 1: " + val1 + " + " + "Valor 2: " + val2 + "=" + res);
            return res;
        }

        public int subtrair(int val1, int val2)
        {
            int res = val1 - val2;
            listahistorico.Insert(0, "Valor 1: " + val1 + " - " + "Valor 2: " + val2 + "=" + res);
            return res;
        }

        public int multiplicar(int val1, int val2)
        {
            int res = val1 * val2;
            listahistorico.Insert(0, "Valor 1: " + val1 + " x " + "Valor 2: " + val2 + "=" + res);
            return res;
        }

        public int dividir(int val1, int val2)
        {
            int res = val1 / val2;
            listahistorico.Insert(0, "Valor 1: " + val1 + " / " + "Valor 2: " + val2 + "=" + res);
            return res;
        }

        public List<string> historico()
        {
            listahistorico.RemoveRange(3, listahistorico.Count - 3);
            return listahistorico;
        }
    }
}