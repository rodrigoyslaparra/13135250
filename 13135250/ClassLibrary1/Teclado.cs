using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Teclado
    {
        public int NumRetir{ get; private set;}
        
        public Teclado (int numReti)
        {
            NumRetir = numReti;
        }

        public Teclado()
        {
        }
    }
}
