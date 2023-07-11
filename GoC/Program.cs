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
            Console.WriteLine("[|= Game Of Cards =|]\n\n");
            List<Carta> Baralho = new List<Carta>();

            Pessoa p1 = new Pessoa("");
            Pessoa p2 = new Pessoa("");

            bool erronome = true;
            while (erronome)
            {                      
                try
                {
                    Console.Write("Jogador 1, digite seu nome: ");
                    p1.Nome = Console.ReadLine();

                    if (p1.Nome == "")
                    {
                        throw new Excecao("Nome inválido!");
                    }
                    else
                        erronome = false;
                    Console.Clear();
                }
                catch (Excecao ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.Write("Digite uma tecla pra continuar...\n");
                    Console.ReadKey();
                    erronome = true;
                    Console.Clear();
                }
                catch (FormatException)
                {
                    Console.WriteLine("Selecione uma opção válida!");
                    Console.Write("Digite uma tecla pra continuar...\n");
                    Console.ReadKey();
                    erronome = true;
                    Console.Clear();
                }
            }

            erronome = true;
            while (erronome)
            {
                try
                {
                    Console.Write("Jogador 2, digite seu nome: ");
                    p2.Nome = Console.ReadLine();

                    if (p2.Nome == "")
                    {
                        throw new Excecao("Nome inválido!");
                    }
                    else
                        erronome = false;
                    Console.Clear();
                }
                catch (Excecao ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.Write("Digite uma tecla pra continuar...\n");
                    Console.ReadKey();
                    erronome = true;
                    Console.Clear();
                }
                catch (FormatException)
                {
                    Console.WriteLine("Selecione uma opção válida!");
                    Console.Write("Digite uma tecla pra continuar...\n");
                    Console.ReadKey();
                    erronome = true;
                    Console.Clear();
                }
            }

            p1.BaralhoPessoa = new List<Carta>();
            p2.BaralhoPessoa = new List<Carta>();
            int vez = new Random().Next(0, 2);
            int rodada = 1;
            bool op = true;

            Espada Alondeg = new Espada("Alondeg", "Espada", 5, 4, 6, 5);
            Espada Amatsu = new Espada("Amatsu", "Espada", 5, 6, 5, 8);
            Espada Belmarg = new Espada("Belmarg", "Espada", 5, 2, 5, 6);
            Espada Kaducho = new Espada("Kaducho", "Espada", 5, 4, 7, 6);
            Espada Rapison = new Espada("Rapison", "Espada", 6, 2, 7, 3);
            Espada Scimaut = new Espada("Scimaut", "Espada", 9, 1, 5, 1);
            Espada Venoma = new Espada("Venoma", "Espada", 5, 4, 9, 8);
            Lanca Crasher = new Lanca("Crasher", "Lanca", 8, 5, 5, 6);
            Lanca Hoenigo = new Lanca("Hoenigo", "Lanca", 6, 5, 5, 3);
            Lanca Ketsu = new Lanca("Ketsu", "Lanca", 6, 6, 5, 7);
            Lanca Nepma = new Lanca("Nepma", "Lanca", 6, 4, 8, 5);
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

            while (op)
            {
                for (int i = 0; i < 10; i++)
                {
                    int index = new Random().Next(Baralho.Count);
                    p1.BaralhoPessoa.Add(Baralho[index]);
                    Baralho.Remove(Baralho[index]);

                    if (p1.BaralhoPessoa.Count == 10)
                    {
                        for (i = 0; i < 10; i++)
                        {
                            index = new Random().Next(Baralho.Count);
                            p2.BaralhoPessoa.Add(Baralho[index]);
                            Baralho.Remove(Baralho[index]);
                        }
                    }
                }

                while (p1.BaralhoPessoa.Count > 0 || p2.BaralhoPessoa.Count > 0)
                {
                    bool erro = true;

                    //Jogador 1
                    if (vez == 0)
                    {
                        Rodada();
                        p1.VerCartas();
                        Rodada();
                        p2.VerCartas();
                        p1.BaralhoPessoa[p1.CartaEscolha].Dano(p1, p2);
                        rodada++;
                        vez = 1;
                    }
                    //Jogador 2
                    else if (vez == 1)
                    {
                        Rodada();
                        p2.VerCartas();
                        Rodada();
                        p1.VerCartas();
                        p2.BaralhoPessoa[p2.CartaEscolha].Dano(p2, p1);
                        rodada++;
                        vez = 0;
                    }

                    //p1 ganhou
                    if (p2.BaralhoPessoa.Count == 0)
                    {
                        while (erro)
                        {
                            try
                            {
                                Console.WriteLine($"Jogador {p1.Nome} ganhou! Deseja jogar novamente?\n[0]Sim\n[1]Não\n");
                                int decisao = int.Parse(Console.ReadLine());

                                if (decisao < 0 || decisao > 1 || decisao == null)
                                {
                                    throw new Excecao("Selecione uma opção válida!");
                                }

                                else if (decisao == 0)
                                {
                                    for (int i = 0; i < p1.BaralhoPessoa.Count; i++)
                                    {
                                        Baralho.Add(p1.BaralhoPessoa[i]);
                                    }
                                    p1.BaralhoPessoa.Clear();
                                    rodada = 1;
                                    p1.Pontos = 0; p2.Pontos = 0;
                                    Console.Clear();
                                    erro = false;
                                    continue;
                                }
                                else if (decisao == 1)
                                {
                                    op = false;
                                    break;
                                }
                            }
                            catch (Excecao ex)
                            {
                                Console.WriteLine(ex.Message);
                                Console.Write("Digite uma tecla pra continuar...\n");
                                Console.ReadKey();
                                erro = true;
                                Console.Clear();
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Selecione uma opção válida!");
                                Console.Write("Digite uma tecla pra continuar...\n");
                                Console.ReadKey();
                                erro = true;
                                Console.Clear();
                            }
                        }
                    }

                    //p2 ganhou
                    else if (p1.BaralhoPessoa.Count == 0)
                    {
                        while (erro)
                        {
                            try
                            {
                                Console.WriteLine($"Jogador {p2.Nome} ganhou! Deseja jogar novamente?\n[0]Sim\n[1]Não\n");
                                int decisao = int.Parse(Console.ReadLine());

                                if (decisao < 0 || decisao > 1 || decisao == null)
                                {
                                    throw new Excecao("Selecione uma opção válida!");
                                }

                                else if (decisao == 0)
                                {
                                    for (int i = 0; i < p2.BaralhoPessoa.Count; i++)
                                    {
                                        Baralho.Add(p2.BaralhoPessoa[i]);
                                    }
                                    p2.BaralhoPessoa.Clear();
                                    rodada = 1;
                                    p1.Pontos = 0; p2.Pontos = 0;
                                    Console.Clear();
                                    erro = false;
                                    continue;
                                }
                                else if (decisao == 1)
                                {
                                    op = false;
                                    break;
                                }
                            }
                            catch (Excecao ex)
                            {
                                Console.WriteLine(ex.Message);
                                Console.Write("Digite uma tecla pra continuar...\n");
                                Console.ReadKey();
                                erro = true;
                                Console.Clear();
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Selecione uma opção válida!");
                                Console.Write("Digite uma tecla pra continuar...\n");
                                Console.ReadKey();
                                erro = true;
                                Console.Clear();
                            }
                            // erro = true;
                        }
                    }
                }
            }
            void Rodada()
            {
                Console.WriteLine("[|= Game Of Cards =|]\n\n");
                Console.WriteLine($"=-=-=-= Rodada {rodada} =-=-=-=");
                Console.WriteLine($"{p1.Nome} tem {p1.BaralhoPessoa.Count} cartas;\n{p2.Nome} tem {p2.BaralhoPessoa.Count} cartas;\n");
                Console.WriteLine($"Placar\n{p1.Nome}: {p1.Pontos} | {p2.Nome}: {p2.Pontos}\n");
            }
        }
    }
}