using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorio95
{
    class Aleatorios
    {
        private Random random;

        public Aleatorios()
        {
            random = new Random();
        }

        public int GenerarNumero(int min, int max)
        {
            return random.Next(min, max + 1);
        }

        public int[] GenerarArreglo(int min, int max, int tamano)
        {
            int[] numeros = new int[tamano];
            for (int i = 0; i < tamano; i++)
            {
                numeros[i] = random.Next(min, max + 1);
            }
            return numeros;
        }
    }
}
