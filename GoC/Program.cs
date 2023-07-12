using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GoC
{
    public class Program : Partida
    {
            public static void Main(string[] args)
            {
            //List<Carta> Baralho = new List<Carta>();
            //int vez = new Random().Next(0, 2);
            //bool op = true;

            Partida par = new Partida();
            par.ColocaNome();
            par.Jogar();

            //Espada Alondeg = new Espada("Alondeg", "Espada", 5, 4, 6, 5);
            //Espada Amatsu = new Espada("Amatsu", "Espada", 5, 6, 5, 8);
            //Espada Belmarg = new Espada("Belmarg", "Espada", 5, 2, 5, 6);
            //Espada Kaducho = new Espada("Kaducho", "Espada", 5, 4, 7, 6);
            //Espada Rapison = new Espada("Rapison", "Espada", 6, 2, 7, 3);
            //Espada Scimaut = new Espada("Scimaut", "Espada", 9, 1, 5, 1);
            //Espada Venoma = new Espada("Venoma", "Espada", 5, 4, 9, 8);
            //Lanca Crasher = new Lanca("Crasher", "Lanca", 8, 5, 5, 6);
            //Lanca Hoenigo = new Lanca("Hoenigo", "Lanca", 6, 5, 5, 3);
            //Lanca Ketsu = new Lanca("Ketsu", "Lanca", 6, 6, 5, 7);
            //Lanca Nepma = new Lanca("Nepma", "Lanca", 6, 4, 8, 5);
            //Lanca Pioptu = new Lanca("Pioptu", "Lanca", 6, 2, 5, 6);
            //Lanca Setka = new Lanca("Setka", "Lanca", 7, 3, 6, 5);
            //Lanca Tunigola = new Lanca("Tunigola", "Lanca", 9, 5, 5, 8);
            //Machado Capie = new Machado("Capie", "Machado", 8, 5, 6, 3);
            //Machado Duotsu = new Machado("Duotsu", "Machado", 6, 5, 6, 4);
            //Machado Evinoa = new Machado("Evinoa", "Machado", 7, 6, 5, 5);
            //Machado Fermita = new Machado("Fermita", "Machado", 7, 5, 6, 5);
            //Machado Gotsau = new Machado("Gotsau", "Machado", 9, 5, 7, 5);
            //Machado Qiudeb = new Machado("Qiudeb", "Machado", 6, 8, 9, 5);

            //Baralho.Add(Alondeg);
            //Baralho.Add(Amatsu);
            //Baralho.Add(Belmarg);
            //Baralho.Add(Kaducho);
            //Baralho.Add(Rapison);
            //Baralho.Add(Scimaut);
            //Baralho.Add(Venoma);
            //Baralho.Add(Crasher);
            //Baralho.Add(Hoenigo);
            //Baralho.Add(Ketsu);
            //Baralho.Add(Nepma);
            //Baralho.Add(Pioptu);
            //Baralho.Add(Setka);
            //Baralho.Add(Tunigola);
            //Baralho.Add(Capie);
            //Baralho.Add(Duotsu);
            //Baralho.Add(Evinoa);
            //Baralho.Add(Fermita);
            //Baralho.Add(Gotsau);
            //Baralho.Add(Qiudeb);

            //while (op)
            //{
            //    for (int i = 0; i < 10; i++)
            //    {
            //        int index = new Random().Next(Baralho.Count);
            //        par.p1.BaralhoPessoa.Add(Baralho[index]);
            //        Baralho.Remove(Baralho[index]);

            //        if (par.p1.BaralhoPessoa.Count == 10)
            //        {
            //            for (i = 0; i < 10; i++)
            //            {
            //                index = new Random().Next(Baralho.Count);
            //                par.p2.BaralhoPessoa.Add(Baralho[index]);
            //                Baralho.Remove(Baralho[index]);
            //            }
            //        }
            //    }

            //    while (par.p1.BaralhoPessoa.Count > 0 || par.p2.BaralhoPessoa.Count > 0)
            //    {
            //        bool erro = true;

            //        //Jogador 1
            //        if (vez == 0)
            //        {
            //            par.Rod(par.rodada, par.p1, par.p2);
            //            par.p1.VerCartas();
            //            par.Rod(par.rodada, par.p1, par.p2);
            //            par.p2.VerCartas();
            //            par.Rod(par.rodada, par.p1, par.p2);
            //            par.p1.BaralhoPessoa[par.p1.CartaEscolha].Dano(par.p1, par.p2);
            //            //rodada++;
            //            par.rodada++;
            //            vez = 1;
            //        }
            //        //Jogador 2
            //        else if (vez == 1)
            //        {
            //            par.Rod(par.rodada, par.p1, par.p2);
            //            par.p2.VerCartas();
            //            par.Rod(par.rodada, par.p1, par.p2);
            //            par.p1.VerCartas();
            //            par.Rod(par.rodada, par.p1, par.p2);
            //            par.p2.BaralhoPessoa[par.p2.CartaEscolha].Dano(par.p2, par.p1);
            //            //rodada++;
            //            par.rodada++;
            //            vez = 0;
            //        }

            //        //p1 ganhou
            //        if (par.p2.BaralhoPessoa.Count == 0)
            //        {
            //            while (erro)
            //            {
            //                try
            //                {
            //                    Console.WriteLine($"Jogador {par.p1.Nome} ganhou! Deseja jogar novamente?\n[0]Sim\n[1]Não\n");
            //                    int decisao = int.Parse(Console.ReadLine());

            //                    if (decisao < 0 || decisao > 1 || decisao == null)
            //                    {
            //                        throw new Excecao("Selecione uma opção válida!");
            //                    }

            //                    else if (decisao == 0)
            //                    {
            //                        for (int i = 0; i < par.p1.BaralhoPessoa.Count; i++)
            //                        {
            //                            Baralho.Add(par.p1.BaralhoPessoa[i]);
            //                        }
            //                        par.p1.BaralhoPessoa.Clear();
            //                        par.rodada = 1;
            //                        par.p1.Pontos = 0; par.p2.Pontos = 0;
            //                        Console.Clear();
            //                        erro = false;
            //                        continue;
            //                    }
            //                    else if (decisao == 1)
            //                    {
            //                        op = false;
            //                        break;
            //                    }
            //                }
            //                catch (Excecao ex)
            //                {
            //                    Console.WriteLine(ex.Message);
            //                    Console.Write("Digite uma tecla pra continuar...\n");
            //                    Console.ReadKey();
            //                    erro = true;
            //                    Console.Clear();
            //                }
            //                catch (FormatException)
            //                {
            //                    Console.WriteLine("Selecione uma opção válida!");
            //                    Console.Write("Digite uma tecla pra continuar...\n");
            //                    Console.ReadKey();
            //                    erro = true;
            //                    Console.Clear();
            //                }
            //            }
            //        }

            //        //p2 ganhou
            //        else if (par.p1.BaralhoPessoa.Count == 0)
            //        {
            //            while (erro)
            //            {
            //                try
            //                {
            //                    Console.WriteLine($"Jogador {par.p2.Nome} ganhou! Deseja jogar novamente?\n[0]Sim\n[1]Não\n");
            //                    int decisao = int.Parse(Console.ReadLine());

            //                    if (decisao < 0 || decisao > 1 || decisao == null)
            //                    {
            //                        throw new Excecao("Selecione uma opção válida!");
            //                    }

            //                    else if (decisao == 0)
            //                    {
            //                        for (int i = 0; i < par.p2.BaralhoPessoa.Count; i++)
            //                        {
            //                            Baralho.Add(par.p2.BaralhoPessoa[i]);
            //                        }
            //                        par.p2.BaralhoPessoa.Clear();
            //                        par.rodada = 1;
            //                        par.p1.Pontos = 0; par.p2.Pontos = 0;
            //                        Console.Clear();
            //                        erro = false;
            //                        continue;
            //                    }
            //                    else if (decisao == 1)
            //                    {
            //                        op = false;
            //                        break;
            //                    }
            //                }
            //                catch (Excecao ex)
            //                {
            //                    Console.WriteLine(ex.Message);
            //                    Console.Write("Digite uma tecla pra continuar...\n");
            //                    Console.ReadKey();
            //                    erro = true;
            //                    Console.Clear();
            //                }
            //                catch (FormatException)
            //                {
            //                    Console.WriteLine("Selecione uma opção válida!");
            //                    Console.Write("Digite uma tecla pra continuar...\n");
            //                    Console.ReadKey();
            //                    erro = true;
            //                    Console.Clear();
            //                }
            //            }
            //        }
            //    }
            //}
        }        
    }
}