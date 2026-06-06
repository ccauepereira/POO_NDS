using System.Runtime.InteropServices.Marshalling;

namespace PaginaLogin.PaginaDeLogin.model;

public class Demo
{
    public static void Executar()
    {
        SistemaLogin login = new SistemaLogin();
        bool rodando = true;

        while (rodando)
        {
            Console.WriteLine("\t*** SISTEMA NUCLEO DE DESENVOLVIMENTO DE SOFTWARE ***\t");
            Console.WriteLine("1) Cadastrar");
            if (login.TemUsuarios() == true)
            {
                Console.WriteLine("2) Entrar");
            }

            Console.WriteLine("0) sair");
            string opcao = Console.ReadLine();
            switch (opcao)
            {
                case "1":
                    Console.WriteLine("Digite seu nome: ");
                    string nomeCadastrado = Console.ReadLine();
                    Console.WriteLine("Digite sua senha: ");
                    string senhaInserida = Console.ReadLine();
                    
                    Console.Write("Processando cadastro");
                    for (int i = 0; i < 3; i++)
                    {
                        System.Threading.Thread.Sleep(500);
                        Console.Write(".");
                    }
                    Console.WriteLine();
                    var resultadoCad = login.Cadastrar(nomeCadastrado, senhaInserida);
                    var s = resultadoCad.sucesso ? "■" : "□";
                    Console.WriteLine($"Resultado: {s} {resultadoCad.mensagem}");
                    System.Threading.Thread.Sleep(2000); 
                    break;
                
                case "2":
                        Console.WriteLine("Digite seu nome: ");
                        string? _nomeInserido = Console.ReadLine();
                        Console.WriteLine("Digite sua senha: ");
                        string? senhaCadastrado = Console.ReadLine();
                        Console.Write("Processando login");
                        for (int i = 0; i < 3; i++)
                        {
                            System.Threading.Thread.Sleep(500);
                            Console.Write(".");
                        }
                        Console.WriteLine();
                        var Resultado = login.Login(_nomeInserido, senhaCadastrado);
                        var x = Resultado.sucesso ? "■" : " □";
                        Console.WriteLine($"Resultado: {x} {Resultado.mensagem}");
                        System.Threading.Thread.Sleep(2000);
                        break;

                case "0":
                    Console.WriteLine("Desconectando do sistema...");
                    System.Threading.Thread.Sleep(1500);
                    Console.WriteLine("Até mais!");
                    rodando = false; 
                    break;
                
                default:
                    Console.WriteLine("Opção invalida");
                    break;
            }
        }
    }
}