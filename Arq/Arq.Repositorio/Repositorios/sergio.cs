using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arq.Repositorio.Repositorios
{
    public class sergio
    {
        private int myVar;
        private readonly int arg;

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }

        public sergio(int arg)
        {
            this.arg = arg;
        }

    }
}
