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
                    var _resultado = login.Cadastrar(nomeCadastrado, senhaInserida);
                    var s = _resultado.sucesso ? "■" : "□";
                    Console.WriteLine($"{s} {_resultado.mensagem}");
                    break;

                case "2":
                        Console.WriteLine("Digite seu nome: ");
                        string? _nomeInserido = Console.ReadLine();
                        Console.WriteLine("Digite sua senha: ");
                        string? senhaCadastrado = Console.ReadLine();
                        var Resultado = login.Login(_nomeInserido, senhaCadastrado);
                        var x = Resultado.sucesso ? "■" : " □";
                        Console.WriteLine($"{x} {Resultado.mensagem}");
                        break;

                case "0":
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