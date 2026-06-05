using System.Runtime.InteropServices.Marshalling;

namespace PaginaLogin.PaginaDeLogin.model;
//3. Crie uma classe de execução Demo com as seguintes especificações:
// a) Instancie SistemaLogin e declare uma variável bool rodando = true.
// b) Implemente um laço while(rodando) que exiba o menu: sempre mostre a opção
// 1-Cadastrar; mostre a opção 2-Entrar somente se TemUsuarios() retornar true; mostre a
// opção 0-Sair
//c) Utilize switch/case para tratar cada opção. No case "1", leia nome e senha e exiba o
// resultado da tupla retornada por Cadastrar. No case "2", verifique TemUsuarios() antes de
// prosseguir, leia nome e senha e exiba o resultado da tupla retornada por Login.
// d) Utilize o operador ternário para exibir ■ quando sucesso == true e ■ quando false em
// todas as saídas.
// e) No case "0", atribua false a rodando para encerrar o laço. Trate entradas inválidas com
// default no switch.

//switch (op) {
// case 1:
//     System.out.print("Site: ");
//     String s = sc.nextLine();
//     System.out.print("Usuario: ");
//     String u = sc.nextLine();
//     System.out.print("Senha: ");
//     String p = sc.nextLine();
//     cofre.adicionar(new Crendecial(s, u, p));
//     System.out.println("Credencial cadastrada! ID: " +
//             (Crendecial.getProximoId() - 1));
//     break;

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