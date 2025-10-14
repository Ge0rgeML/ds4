using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorio12
{
    public class DistRecorrida
    {
        public double velocidad { get; set; }
        public double tiempo { get; set; }

        public DistRecorrida(double v,double t)
        {
            if(v < 0 || t < 0)
            {
                throw new ArgumentException("los datos deben ser positivos mayores a 0");
            }
            velocidad = v;
            tiempo = t;
        }
        public double ObtenerDistancia()
        {
            return velocidad * tiempo;
        }
    }
}
