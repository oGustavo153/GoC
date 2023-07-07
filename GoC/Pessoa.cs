using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoC
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int CartaEscolha { get; set; }
        public List<Carta> BaralhoPessoa { get; set; }

        public int Pontos = 0;
        public Pessoa(string nome)
        {
            Nome = nome;
        }

        public List<Carta> VerCartas()
        {
            Console.WriteLine($"{Nome}, suas cartas são:");
            for (int i = 0; i < BaralhoPessoa.Count; i++)
            {
                Console.WriteLine($"[{i}]{BaralhoPessoa[i].Nome}, Tipo: {BaralhoPessoa[i].Tipo}, Atq: {BaralhoPessoa[i].Atq}, Def: {BaralhoPessoa[i].Def}, Mag: {BaralhoPessoa[i].Mag}, Res: {BaralhoPessoa[i].Res}.");
            }

            Console.Write($"\n{Nome} escolha sua carta: ");
            CartaEscolha = int.Parse(Console.ReadLine());
            Console.Clear();
            return BaralhoPessoa;
        }
    }
}
