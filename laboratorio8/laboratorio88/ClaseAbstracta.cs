using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorio88
{
    abstract class ClaseAbstracta
    {
        protected abstract string tomarValor();

        public abstract string prefixValor(string prefix);

        public void printOut()
        {
            Console.WriteLine(tomarValor());
        }
    }
}
