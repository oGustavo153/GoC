using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoC
{
    public class Carta
    {
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public int Atq { get; set; }
        public int Def { get; set; }
        public int Mag { get; set; }
        public int Res { get; set; }
        public int TipoDano { get; set; }

        public Carta(string nome, string tipo, int atq, int def, int mag, int res)
        {
            Nome = nome;
            Tipo = tipo;
            Atq = atq;
            Def = def;
            Mag = mag;
            Res = res;
            return;
        }

        public void Dano(Pessoa a, Pessoa b)
        {
            Console.Write($"{a.Nome}, selecione o tipo de dano que deseja causar:\n[0]Físico\n[1]Mágico\n");
            TipoDano = int.Parse(Console.ReadLine());

            //DanoFisico
            if (TipoDano == 0)
            {
                Console.Clear();
                if (a.BaralhoPessoa[a.CartaEscolha].Atq == b.BaralhoPessoa[b.CartaEscolha].Def || a.BaralhoPessoa[a.CartaEscolha].Mag == b.BaralhoPessoa[b.CartaEscolha].Res)
                {
                    //a
                    if (a.BaralhoPessoa[a.CartaEscolha].Tipo == "Espada" && b.BaralhoPessoa[b.CartaEscolha].Tipo == "Machado")
                    {
                        Console.WriteLine($"{a.Nome} ganhou, pois a Espada {a.BaralhoPessoa[a.CartaEscolha].Nome} vence o Machado {b.BaralhoPessoa[b.CartaEscolha].Nome}!");
                        a.BaralhoPessoa.Capacity++;
                        a.BaralhoPessoa.Add(b.BaralhoPessoa[b.CartaEscolha]);
                        b.BaralhoPessoa.Remove(b.BaralhoPessoa[b.CartaEscolha]);
                    }

                    //b
                    else if (b.BaralhoPessoa[b.CartaEscolha].Tipo == "Espada" && a.BaralhoPessoa[a.CartaEscolha].Tipo == "Machado")
                    {
                        Console.WriteLine($"{b.Nome} ganhou, pois a Espada {b.BaralhoPessoa[b.CartaEscolha].Nome} vence o Machado {a.BaralhoPessoa[a.CartaEscolha].Nome}!");
                        b.BaralhoPessoa.Capacity++;
                        b.BaralhoPessoa.Add(a.BaralhoPessoa[a.CartaEscolha]);
                        a.BaralhoPessoa.Remove(a.BaralhoPessoa[a.CartaEscolha]);
                    }

                    //a
                    else if (a.BaralhoPessoa[a.CartaEscolha].Tipo == "Machado" && b.BaralhoPessoa[b.CartaEscolha].Tipo == "Lanca")
                    {
                        Console.WriteLine($"{a.Nome} ganhou, pois o Machado {a.BaralhoPessoa[a.CartaEscolha].Nome} vence a Lanca {b.BaralhoPessoa[b.CartaEscolha].Nome}!");
                        a.BaralhoPessoa.Capacity++;
                        a.BaralhoPessoa.Add(b.BaralhoPessoa[b.CartaEscolha]);
                        b.BaralhoPessoa.Remove(b.BaralhoPessoa[b.CartaEscolha]);
                    }

                    //b
                    else if (b.BaralhoPessoa[b.CartaEscolha].Tipo == "Machado" && a.BaralhoPessoa[a.CartaEscolha].Tipo == "Lanca")
                    {
                        Console.WriteLine($"{b.Nome} ganhou, pois o Machado {b.BaralhoPessoa[b.CartaEscolha].Nome} vence a Lanca {a.BaralhoPessoa[a.CartaEscolha].Nome}!");
                        b.BaralhoPessoa.Capacity++;
                        b.BaralhoPessoa.Add(a.BaralhoPessoa[a.CartaEscolha]);
                        a.BaralhoPessoa.Remove(a.BaralhoPessoa[a.CartaEscolha]);
                    }

                    //a
                    else if (a.BaralhoPessoa[a.CartaEscolha].Tipo == "Lanca" && b.BaralhoPessoa[b.CartaEscolha].Tipo == "Espada")
                    {
                        Console.WriteLine($"{a.Nome} ganhou, pois a Lanca {a.BaralhoPessoa[a.CartaEscolha].Nome} vence a Espada {b.BaralhoPessoa[b.CartaEscolha].Nome}!");
                        a.BaralhoPessoa.Capacity++;
                        a.BaralhoPessoa.Add(b.BaralhoPessoa[b.CartaEscolha]);
                        b.BaralhoPessoa.Remove(b.BaralhoPessoa[b.CartaEscolha]);
                    }

                    //b
                    else if (b.BaralhoPessoa[b.CartaEscolha].Tipo == "Lanca" && a.BaralhoPessoa[a.CartaEscolha].Tipo == "Espada")
                    {
                        Console.WriteLine($"{b.Nome} ganhou, pois a Lanca {b.BaralhoPessoa[b.CartaEscolha].Nome} vence a Espada {a.BaralhoPessoa[a.CartaEscolha].Nome}!");
                        b.BaralhoPessoa.Capacity++;
                        b.BaralhoPessoa.Add(a.BaralhoPessoa[a.CartaEscolha]);
                        a.BaralhoPessoa.Remove(a.BaralhoPessoa[a.CartaEscolha]);
                    }
                }

                else if (a.BaralhoPessoa[a.CartaEscolha].Atq > b.BaralhoPessoa[b.CartaEscolha].Def)
                {
                    Console.WriteLine($"{a.Nome} ganhou graças ao ataque da carta {a.BaralhoPessoa[a.CartaEscolha].Nome}!\nATQ de {a.Nome}: {a.BaralhoPessoa[a.CartaEscolha].Atq} VS DEF de {b.Nome}: {b.BaralhoPessoa[b.CartaEscolha].Def}\n");
                    a.BaralhoPessoa.Capacity++;
                    a.BaralhoPessoa.Add(b.BaralhoPessoa[b.CartaEscolha]);
                    b.BaralhoPessoa.Remove(b.BaralhoPessoa[b.CartaEscolha]);
                }
                else if (b.BaralhoPessoa[b.CartaEscolha].Def > a.BaralhoPessoa[a.CartaEscolha].Atq)
                {
                    Console.Clear();
                    Console.WriteLine($"{b.Nome} ganhou graças a defesa da carta {b.BaralhoPessoa[b.CartaEscolha].Nome}!\nDEF de {b.Nome}: {b.BaralhoPessoa[b.CartaEscolha].Def} VS ATQ de {a.Nome}: {a.BaralhoPessoa[a.CartaEscolha].Atq}\n");
                    b.BaralhoPessoa.Capacity++;
                    b.BaralhoPessoa.Add(a.BaralhoPessoa[a.CartaEscolha]);
                    a.BaralhoPessoa.Remove(a.BaralhoPessoa[a.CartaEscolha]);
                }
            }

            //Dano Mágico
            if (TipoDano == 1)
            {
                Console.Clear();
                if (a.BaralhoPessoa[a.CartaEscolha].Atq == b.BaralhoPessoa[b.CartaEscolha].Def || a.BaralhoPessoa[a.CartaEscolha].Mag == b.BaralhoPessoa[b.CartaEscolha].Res)
                {
                    //a
                    if (a.BaralhoPessoa[a.CartaEscolha].Tipo == "Espada" && b.BaralhoPessoa[b.CartaEscolha].Tipo == "Machado")
                    {
                        Console.WriteLine($"{a.Nome} ganhou, pois a Espada {a.BaralhoPessoa[a.CartaEscolha].Nome} vence o Machado {b.BaralhoPessoa[b.CartaEscolha].Nome}!");
                        a.BaralhoPessoa.Capacity++;
                        a.BaralhoPessoa.Add(b.BaralhoPessoa[b.CartaEscolha]);
                        b.BaralhoPessoa.Remove(b.BaralhoPessoa[b.CartaEscolha]);
                    }

                    //b
                    else if (b.BaralhoPessoa[b.CartaEscolha].Tipo == "Espada" && a.BaralhoPessoa[a.CartaEscolha].Tipo == "Machado")
                    {
                        Console.WriteLine($"{b.Nome} ganhou, pois a Espada {b.BaralhoPessoa[b.CartaEscolha].Nome} vence o Machado {a.BaralhoPessoa[a.CartaEscolha].Nome}!");
                        b.BaralhoPessoa.Capacity++;
                        b.BaralhoPessoa.Add(a.BaralhoPessoa[a.CartaEscolha]);
                        a.BaralhoPessoa.Remove(a.BaralhoPessoa[a.CartaEscolha]);
                    }

                    //a
                    else if (a.BaralhoPessoa[a.CartaEscolha].Tipo == "Machado" && b.BaralhoPessoa[b.CartaEscolha].Tipo == "Lanca")
                    {
                        Console.WriteLine($"{a.Nome} ganhou, pois o Machado {a.BaralhoPessoa[a.CartaEscolha].Nome} vence a Lanca {b.BaralhoPessoa[b.CartaEscolha].Nome}!");
                        a.BaralhoPessoa.Capacity++;
                        a.BaralhoPessoa.Add(b.BaralhoPessoa[b.CartaEscolha]);
                        b.BaralhoPessoa.Remove(b.BaralhoPessoa[b.CartaEscolha]);
                    }

                    //b
                    else if (b.BaralhoPessoa[b.CartaEscolha].Tipo == "Machado" && a.BaralhoPessoa[a.CartaEscolha].Tipo == "Lanca")
                    {
                        Console.WriteLine($"{b.Nome} ganhou, pois o Machado {b.BaralhoPessoa[b.CartaEscolha].Nome} vence a Lanca {a.BaralhoPessoa[a.CartaEscolha].Nome}!");
                        b.BaralhoPessoa.Capacity++;
                        b.BaralhoPessoa.Add(a.BaralhoPessoa[a.CartaEscolha]);
                        a.BaralhoPessoa.Remove(a.BaralhoPessoa[a.CartaEscolha]);
                    }

                    //a
                    else if (a.BaralhoPessoa[a.CartaEscolha].Tipo == "Lanca" && b.BaralhoPessoa[b.CartaEscolha].Tipo == "Espada")
                    {
                        Console.WriteLine($"{a.Nome} ganhou, pois a Lanca {a.BaralhoPessoa[a.CartaEscolha].Nome} vence a Espada {b.BaralhoPessoa[b.CartaEscolha].Nome}!");
                        a.BaralhoPessoa.Capacity++;
                        a.BaralhoPessoa.Add(b.BaralhoPessoa[b.CartaEscolha]);
                        b.BaralhoPessoa.Remove(b.BaralhoPessoa[b.CartaEscolha]);
                    }

                    //b
                    else if (b.BaralhoPessoa[b.CartaEscolha].Tipo == "Lanca" && a.BaralhoPessoa[a.CartaEscolha].Tipo == "Espada")
                    {
                        Console.WriteLine($"{b.Nome} ganhou, pois a Lanca {b.BaralhoPessoa[b.CartaEscolha].Nome} vence a Espada {a.BaralhoPessoa[a.CartaEscolha].Nome}!");
                        b.BaralhoPessoa.Capacity++;
                        b.BaralhoPessoa.Add(a.BaralhoPessoa[a.CartaEscolha]);
                        a.BaralhoPessoa.Remove(a.BaralhoPessoa[a.CartaEscolha]);
                    }
                }
                else if (a.BaralhoPessoa[a.CartaEscolha].Mag > b.BaralhoPessoa[b.CartaEscolha].Res)
                {
                    Console.Clear();
                    Console.WriteLine($"{a.Nome} ganhou graças a magia da carta {a.BaralhoPessoa[a.CartaEscolha].Nome}!\nMAG de {a.Nome}: {a.BaralhoPessoa[a.CartaEscolha].Mag} VS RES de {b.Nome}: {b.BaralhoPessoa[b.CartaEscolha].Res}\n");
                    a.BaralhoPessoa.Capacity++;
                    a.BaralhoPessoa.Add(b.BaralhoPessoa[b.CartaEscolha]);
                    b.BaralhoPessoa.Remove(b.BaralhoPessoa[b.CartaEscolha]);
                }
                else if (b.BaralhoPessoa[b.CartaEscolha].Res > a.BaralhoPessoa[a.CartaEscolha].Mag)
                {
                    Console.Clear();
                    Console.WriteLine($"{b.Nome} ganhou graças a resistencia da carta {b.BaralhoPessoa[b.CartaEscolha].Nome}!\nRES de {b.Nome}: {b.BaralhoPessoa[b.CartaEscolha].Res} VS MAG de {a.Nome}: {a.BaralhoPessoa[a.CartaEscolha].Mag}\n");
                    b.BaralhoPessoa.Capacity++;
                    b.BaralhoPessoa.Add(a.BaralhoPessoa[a.CartaEscolha]);
                    a.BaralhoPessoa.Remove(a.BaralhoPessoa[a.CartaEscolha]);
                }
            }
        }
    }

    public class Espada : Carta
    {
        public Espada(string nome, string tipo, int atq, int def, int mag, int res) : base(nome, tipo, atq, def, mag, res)
        {

        }
    }

    public class Lanca : Carta
    {
        public Lanca(string nome, string tipo, int atq, int def, int mag, int res) : base(nome, tipo, atq, def, mag, res)
        {

        }

    }

    public class Machado : Carta
    {
        public Machado(string nome, string tipo, int atq, int def, int mag, int res) : base(nome, tipo, atq, def, mag, res)
        {

        }
    }
}
