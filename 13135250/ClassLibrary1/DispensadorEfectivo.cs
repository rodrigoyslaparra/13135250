using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class DispensadorEfectivo
    {
        public int NumDis { get; private set; }

        public DispensadorEfectivo(int numDis)
        {
            NumDis = numDis;
        }

        public DispensadorEfectivo()
        {
        }
    }
}
