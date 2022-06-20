using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test01
{
    internal abstract class Structure
    {
        public void Initiate()
        {
            ReadInput();
            Compute();
            WriteOutput();
        }
        abstract protected void ReadInput();
        abstract protected void Compute();
        abstract protected void WriteOutput();
    }
}
