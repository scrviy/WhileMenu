using System;
using System.Threading;
using WhileMenu.Common.Models;

Pessoa pessoa1 = new Pessoa();
pessoa1.Nome = "Junior";
pessoa1.Idade = 18;
pessoa1.Apresentar();

    public class MenuWhile
    {
        static void Main(string[] args)
        {
            string? opcao;
            bool exibirMenu = true;

            while(exibirMenu)
            {
                Console.Clear();
                Thread.Sleep(200);

                Console.WriteLine("Digite a sua opcao:");
                Console.WriteLine("1 - Cadastrar cliente");
                Console.WriteLine("2 - Buscar cliente");
                Console.WriteLine("3 - Apagar cliente");
                Console.WriteLine("4 - Encerrar");

                opcao = Console.ReadLine();

                switch(opcao)
                {
                    case "1": 
                        Console.WriteLine("Cadastro de cliente.");
                        break;

                    case "2":
                        Console.WriteLine("Busca de cliente.");
                        break;

                    case "3":
                        Console.WriteLine("Apagar cliente.");
                        break;

                    case "4":
                        Console.WriteLine("Encerrar.");
                        exibirMenu = false;
                        //Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Opção Inválida.");
                        break;
                }
            }
    Console.WriteLine("O programa se encerrou.");
        }
    }       
