using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorio88
{
    class ClaseConcretal : ClaseAbstracta
    {
        protected override string tomarValor()
        {
            return "Clase Concretal";
        }

        public override string prefixValor(string prefix)
        {
            return $"{prefix} Clase Concretal";
        }
    }
}
