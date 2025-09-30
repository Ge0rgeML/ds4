using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace laboratorio82
{
    internal class CuentaAhorro : Cuenta
    {
        public CuentaAhorro(string prmIdCuenta) : base(prmIdCuenta) 
        { 
        }
        public override void CalcularInterese()
        {
            System.Console.WriteLine(
                "CuentaAhorro.CalularIntereses() efectuando para" +
                "la cuenta {0}", getIdCuenta());
        }
    }
}
