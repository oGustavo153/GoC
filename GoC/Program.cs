using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GoC
{
    public class Program 
    {
        public static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();
            Partida par = new Partida(p1, p2);

            par.ColocaNome(par);
            par.Jogar();
        }        
    }
}