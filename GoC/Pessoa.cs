using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Permissions;
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

            bool erro = true;

            while (erro)
            {
                try
                {
                    //Mostra as cartas do player
                    Console.WriteLine($"{Nome}, suas cartas são:");
                    for (int i = 0; i < BaralhoPessoa.Count; i++)
                    {
                        Console.WriteLine($"[{i}]{BaralhoPessoa[i].Nome}, Tipo: {BaralhoPessoa[i].Tipo}, Atq: {BaralhoPessoa[i].Atq}, Def: {BaralhoPessoa[i].Def}, Mag: {BaralhoPessoa[i].Mag}, Res: {BaralhoPessoa[i].Res}.");
                    }

                    Console.Write($"\n{Nome} escolha sua carta: ");
                    CartaEscolha = int.Parse(Console.ReadLine());

                    if (CartaEscolha >= BaralhoPessoa.Count || CartaEscolha < 0 || CartaEscolha == null)
                    {
                        throw new Excecao("Selecione uma opção válida!");
                    }
                    else
                        Console.Clear();
                    erro = false;
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
            return BaralhoPessoa;
        }
    }
}