using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorio88
{
    class ClaseConcreta2 : ClaseAbstracta
    {
        protected override string tomarValor()
        {
            return "Clase Concreta2";
        }

        public override string prefixValor(string prefix)
        {
            return $"{prefix} Clase Concreta2";
        }
    }
}
