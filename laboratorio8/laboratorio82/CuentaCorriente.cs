using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorio82
{
    internal class CuentaCorriente : Cuenta
    {
        public CuentaCorriente(string prmIdCuenta) : base(prmIdCuenta)
        { 
        }
        public override void CalcularInterese()
        {
            System.Console.WriteLine(
                "CuentaCorriente.CalcularIntereses() efectuando para" +
                "La cuenta {0}", getIdCuenta());
        }
    }
}
