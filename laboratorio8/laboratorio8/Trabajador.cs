using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorio8
{
    internal class Trabajador : Persona
    {
        public int Sueldo;
        Trabajador(string nombre, int edad, string nif, int sueldo)
            : base(nombre, edad, nif)
        {
            Sueldo = sueldo;
        }
    }
}
