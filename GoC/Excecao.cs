using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoC
{
    public class Excecao : Exception
    {
        public Excecao(string msg) : base(msg) { }
    }
}