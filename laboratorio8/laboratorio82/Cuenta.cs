using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorio82
{
    internal class Cuenta
    {
        private string idCuenta;
        public Cuenta(string prmIdCuenta)
        {
            this.idCuenta = prmIdCuenta;
            System.Console.WriteLine(
                "Constructor clase base para cuenta {0}", prmIdCuenta );
        }
        public virtual void CalcularInterese()
        {
            System.Console.WriteLine(
                "cuenta.CalcularIntereses( efectuando para la cuuenta {0}",
                this,idCuenta);
        }
        public string getIdCuenta()
        {
            return this.idCuenta;
        }
    }
}
