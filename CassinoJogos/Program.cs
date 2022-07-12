using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CassinoJogos
{
    public class Program
    {
        static Random rnd = new Random();
        static double saldo = 100;
        static string nome = "";
        static void Main(string[] args)
        {
            int op = 0;
            Console.WriteLine("Insira seu nome, por favor:");
            nome = Console.ReadLine();
            do
            {
                Console.Clear();
                Console.WriteLine("Seja bem vindo, " + nome + "\t\tSaldo: R$" + saldo);
                Console.WriteLine("Escolha uma das opções:");
                Console.WriteLine("1 - Loteria \n2 - Raspadinhas \n3 - Saques/Depósitos \n0 - Sair");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 0:
                        Console.WriteLine("Volte sempre!");
                        break;
                    case 1:
                        Loteria();
                        break;
                    case 2:
                        Raspadinhas();
                        break;
                    case 3:
                        Banca();
                        break;
                    default:
                        Console.WriteLine("Opção Inválida.");
                        Console.ReadKey();
                        break;
                }
            } while (op != 0);
        }

        private static void Banca()
        {
            int op = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Menu Levantamentos/Depósitos");
                Console.WriteLine("Saldo: R$" + saldo);
                Console.WriteLine("Escolha uma das opções: ");
                Console.WriteLine("1 - Saque \n2 - Depósito \n0 - Voltar ao menu principal");
                op = int.Parse(Console.ReadLine());
                
                switch (op)
                {
                    case 0:
                        break;
                    case 1:
                        Retirada();
                        break;
                    case 2:
                        Deposito();
                        break;
                    default:
                        Console.WriteLine("Opção Inválida.");
                        Console.ReadKey();
                        break;
                }
            } while (op != 0);
        }

        private static void Deposito()
        {
            Console.Clear();
            Console.WriteLine("Saldo: R$" + saldo);
            Console.WriteLine("Valor do depósito:");
            double valor = double.Parse(Console.ReadLine());

            saldo = saldo + valor;
            Console.WriteLine("Depósito feito com sucesso!");

            Console.WriteLine("Saldo atual: R$" + saldo);

            Console.ReadKey();
        }

        private static void Retirada()
        {
            Console.Clear();
            Console.WriteLine("Saldo: R$" + saldo);
            Console.WriteLine("Quanto deseja sacar?");
            double saque = double.Parse(Console.ReadLine());
            
            if(saque > saldo)
            {
                Console.WriteLine("saldo insuficiente.");
            }
            else
            {
                saldo = saldo - saque;
                Console.WriteLine("Saque feito com sucesso!");
                Console.WriteLine("Saldo atual: R$" + saldo);
            }
            Console.ReadKey();
        }

        //função Raspadinhas()
        private static void Raspadinhas()
        {
            int op = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Menu Raspadinhas");
                Console.WriteLine("Saldo: R$" + saldo);
                Console.WriteLine("Escolha:");
                Console.WriteLine("1 - Raspadinha A \n2 - Raspadinha B \n0 - Voltar ao Menu Principal");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 0:
                        Console.WriteLine("Retornando...");
                        break;
                    case 1:
                        RaspadinhaA();
                        break;
                    case 2:
                        RaspadinhaB();
                        break;
                    default:
                        Console.WriteLine("Opção Inválida.");
                        Console.ReadKey();
                        break;
                }
            } while (op != 0);
        }
        //função RaspadinhaB()
        private static void RaspadinhaB()
        {
            Console.Clear();
            if (saldo - 2 < 0)
            {
                Console.WriteLine("Saldo insuficiente.");
                Console.ReadKey();
                return;
            }
            saldo = saldo - 2;
            int pr = 0;
            int npremiado = rnd.Next(1, 11);
            int premio = rnd.Next(1, 101);

            int n1 = rnd.Next(1,11);
            int n2 = rnd.Next(1, 11);
            int n3 = rnd.Next(1, 11);
            int n4 = rnd.Next(1, 11);
            int n5 = rnd.Next(1, 11);
            int n6 = rnd.Next(1, 11);
            int n7 = rnd.Next(1, 11);
            int n8 = rnd.Next(1, 11);
            int n9 = rnd.Next(1, 11);

            if (n1 == npremiado)
            {
                pr++;
            }
            if (n2 == npremiado)
            {
                pr++;
            }
            if (n3 == npremiado)
            {
                pr++;
            }
            if (n4 == npremiado)
            {
                pr++;
            }
            if (n5 == npremiado)
            {
                pr++;
            }
            if (n6 == npremiado)
            {
                pr++;
            }
            if (n7 == npremiado)
            {
                pr++;
            }
            if (n8 == npremiado)
            {
                pr++;
            }
            if (n9 == npremiado)
            {
                pr++;
            }

            Console.WriteLine("Número Principal: " + npremiado + " ("+premio+")");
            Console.WriteLine(n1+ " " + n2 + " " + n3);
            Console.WriteLine(n4 + " " + n5 + " " + n6);
            Console.WriteLine(n7 + " " + n8 + " " + n9);

            if (pr >= 3)
            {
                Console.WriteLine("Parabéns! Ganhou R$" + premio);
                saldo = saldo + premio;
            }
            else
            {
                Console.WriteLine("Raspadinha não premiada.");
            }

            Console.ReadKey();
        }

        //função RaspadinhaA()
        private static void RaspadinhaA()
        {
            Console.Clear();
            if (saldo - 2 < 0)
            {
                Console.WriteLine("Saldo insuficiente.");
                Console.ReadKey();
                return;
            }
            saldo = saldo - 2;
            int premio = 0;
            int nprincipal = rnd.Next(1,11);
            int n1 = rnd.Next(1,11);
            int n2 = rnd.Next(1, 11);
            int n3 = rnd.Next(1, 11);
            int n4 = rnd.Next(1, 11);
            int n5 = rnd.Next(1, 11);
            int p1 = rnd.Next(1, 101); 
            int p2 = rnd.Next(1, 101);
            int p3 = rnd.Next(1, 101);
            int p4 = rnd.Next(1, 101);
            int p5 = rnd.Next(1, 101);

            Console.WriteLine("Número Principal: " + nprincipal);
            Console.WriteLine("Primeiro Número: " + n1 + " (R$"+p1+")");
            Console.WriteLine("Primeiro Número: " + n2 + " (R$"+p2+")");
            Console.WriteLine("Primeiro Número: " + n3 + " (R$"+p3+")");
            Console.WriteLine("Primeiro Número: " + n4 + " (R$"+p4+")");
            Console.WriteLine("Primeiro Número: " + n5 + " (R$"+p5+")");

            if (nprincipal == n1)
            {
                premio = premio + p1;
            }
            if (nprincipal == n2)
            {
                premio = premio + p2;
            }
            if (nprincipal == n3)
            {
                premio = premio + p3;
            }
            if (nprincipal == n4)
            {
                premio = premio + p4;
            }
            if (nprincipal == n5)
            {
                premio = premio + p5;
            }

            Console.WriteLine("Prêmio: R$" + premio);
            saldo = saldo + premio;

            Console.ReadKey();
        }

        //função Loteria()
        private static void Loteria()
        {
            Console.Clear();
            if (saldo - 5 < 0)
            {
                Console.WriteLine("Saldo insuficiente.");
                Console.ReadKey();
                return;
            }
            saldo = saldo - 5;
            int numEscolhido = 0;
            int npremio = rnd.Next(1000,10000);
            while (numEscolhido < 1000 || numEscolhido > 9999)
            {
                Console.WriteLine("Qual número deseja jogar? [1000 - 9999]");
                numEscolhido = int.Parse(Console.ReadLine());
            }
            if (numEscolhido == npremio)
            {
                Console.WriteLine("Parabéns!! Ganhou o primeiro prêmio!!");
                saldo = saldo + 10000;
            }
            else if (numEscolhido % 1000 == npremio % 1000)
            {
                Console.WriteLine("Ganhou o segundo prêmio!");
                saldo = saldo + 1000;
            }
            else if (numEscolhido % 100 == npremio % 100)
            {
                Console.WriteLine("Ganhou o terceiro prêmio!");
                saldo = saldo + 100;
            }
            else
            {
                Console.WriteLine("Seu bilhete não foi premiado.");
                Console.WriteLine("Bilhete Premiado: " + npremio);
            }
            Console.ReadKey();
        }
    }
}
