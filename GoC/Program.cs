using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoC
{
    public class Program
    {
        public static void Main(string[] args)
        {

            List<Carta> Baralho = new List<Carta>();
            Pessoa a = new Pessoa("Gustavo");
            Pessoa b = new Pessoa("Julio");
            a.BaralhoPessoa = new List<Carta>();
            b.BaralhoPessoa = new List<Carta>();
            int vez = new Random().Next(0, 2);
            int rodada = 1;
            bool bl = true;

            Espada Alondeg = new Espada("Alondeg", "Espada", 5, 4, 6, 5);
            Espada Amatsu = new Espada("Amatsu", "Espada", 5, 6, 5, 8);
            Espada Belmarg = new Espada("Belmarg", "Espada", 5, 2, 5, 6);
            Espada Kaducho = new Espada("Kaducho", "Espada", 5, 4, 7, 6);
            Espada Rapison = new Espada("Rapison", "Espada", 6, 2, 7, 3);
            Espada Scimaut = new Espada("Scimaut", "Espada", 9, 1, 5, 1);
            Espada Venoma = new Espada("Venoma", "Espada", 5, 4, 9, 8);
            Lanca Crasher = new Lanca("Crasher", "Lanca", 8, 5, 5, 6);
            Lanca Hoenigo = new Lanca("Hoenigo", "Lanca", 6, 5, 5, 3);
            Lanca Ketsu = new Lanca("Ketsu", "Lanca", 5, 6, 5, 7);
            Lanca Nepma = new Lanca("Nepma", "Lanca", 5, 4, 8, 5);
            Lanca Pioptu = new Lanca("Pioptu", "Lanca", 6, 2, 5, 6);
            Lanca Setka = new Lanca("Setka", "Lanca", 7, 3, 6, 5);
            Lanca Tunigola = new Lanca("Tunigola", "Lanca", 9, 5, 5, 8);
            Machado Capie = new Machado("Capie", "Machado", 8, 5, 6, 3);
            Machado Duotsu = new Machado("Duotsu", "Machado", 6, 5, 6, 4);
            Machado Evinoa = new Machado("Evinoa", "Machado", 7, 6, 5, 5);
            Machado Fermita = new Machado("Fermita", "Machado", 7, 5, 6, 5);
            Machado Gotsau = new Machado("Gotsau", "Machado", 9, 5, 7, 5);
            Machado Qiudeb = new Machado("Qiudeb", "Machado", 6, 8, 9, 5);

            Baralho.Add(Alondeg);
            Baralho.Add(Amatsu);
            Baralho.Add(Belmarg);
            Baralho.Add(Kaducho);
            Baralho.Add(Rapison);
            Baralho.Add(Scimaut);
            Baralho.Add(Venoma);
            Baralho.Add(Crasher);
            Baralho.Add(Hoenigo);
            Baralho.Add(Ketsu);
            Baralho.Add(Nepma);
            Baralho.Add(Pioptu);
            Baralho.Add(Setka);
            Baralho.Add(Tunigola);
            Baralho.Add(Capie);
            Baralho.Add(Duotsu);
            Baralho.Add(Evinoa);
            Baralho.Add(Fermita);
            Baralho.Add(Gotsau);
            Baralho.Add(Qiudeb);

            for (int i = 0; i < 10; i++)
            {
                int index = new Random().Next(Baralho.Count);
                a.BaralhoPessoa.Add(Baralho[index]);
                Baralho.Remove(Baralho[index]);

                if (a.BaralhoPessoa.Count == 10)
                {
                    for (i = 0; i < 10; i++)
                    {
                        index = new Random().Next(Baralho.Count);
                        b.BaralhoPessoa.Add(Baralho[index]);
                        Baralho.Remove(Baralho[index]);
                    }
                }
            }

            while (a.BaralhoPessoa.Count != 0 || b.BaralhoPessoa.Count != 0)
            {
                Console.WriteLine($"=-=-=-= Rodada {rodada} =-=-=-=");
                //Jogador 1
                if (vez == 0)
                {
                    a.VerCartas();
                    b.VerCartas();

                    a.BaralhoPessoa[a.CartaEscolha].Dano(a, b);
                    vez = 1;
                }

                //Jogador 2   
                else
                {
                    b.VerCartas();
                    a.VerCartas();

                    b.BaralhoPessoa[b.CartaEscolha].Dano(b, a);
                    vez = 0;
                }

                if (a.BaralhoPessoa.Count == 0)
                {
                    Console.WriteLine($"Jogador {b.Nome} ganhou!");
                    break;
                }

                else if (b.BaralhoPessoa.Count == 0)
                {
                    Console.WriteLine($"Jogador {a.Nome} ganhou!");
                    break;
                }
                rodada++;
            }
        }
    }
}
