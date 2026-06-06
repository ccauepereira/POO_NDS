namespace SysCaixaEletronico;

using System;

public class Demo
{
    public static void Executar()
    {
        SistemaLogin sistema = new SistemaLogin();
        ContaBancaria conta = null;
        bool rodando = true;

        while (rodando)
        {
            Console.Clear();
            Console.WriteLine("=== SYS CAIXA ELETRÔNICO NDS ===");
            Console.WriteLine("1) Cadastrar Usuário");
            Console.WriteLine("2) Entrar no Caixa");
            Console.WriteLine("0) Sair");
            Console.Write("Escolha uma opção: ");
            string opcao = Console.ReadLine();

            if (opcao == "1")
            {
                Console.Clear();
                Console.WriteLine("--- CADASTRO ---");
                Console.Write("Nome: ");
                string nomeCad = Console.ReadLine();
                Console.Write("Senha: ");
                string senhaCad = Console.ReadLine();

                var resCad = sistema.Cadastrar(nomeCad, senhaCad);
                Console.WriteLine(resCad.mensagem);
                Console.WriteLine("\nPressione qualquer tecla para voltar...");
                Console.ReadKey();
            }
            else if (opcao == "2")
            {
                Console.Clear();
                Console.WriteLine("--- LOGIN ---");
                Console.Write("Nome: ");
                string nomeLog = Console.ReadLine();
                Console.Write("Senha: ");
                string senhaLog = Console.ReadLine();

                Usuario user = sistema.Autenticar(nomeLog, senhaLog);

                if (user != null)
                {
                    conta = new ContaBancaria(user.Nome);
                    
                    bool logado = true;
                    while (logado)
                    {
                        Console.Clear();
                        Console.WriteLine($"=== CONTA DE: {conta.Titular.ToUpper()} ===");
                        Console.WriteLine("1) Verificar Saldo");
                        Console.WriteLine("2) Depositar");
                        Console.WriteLine("3) Sacar");
                        Console.WriteLine("0) Logout");
                        Console.Write("Escolha uma opção: ");
                        string subOpcao = Console.ReadLine();

                        if (subOpcao == "1")
                        {
                            Console.Clear();
                            Console.WriteLine($"Saldo atual: {conta.VerificarSaldo()}");
                            Console.WriteLine("\nPressione qualquer tecla para voltar...");
                            Console.ReadKey();
                        }
                        else if (subOpcao == "2")
                        {
                            Console.Clear();
                            Console.Write("Digite o valor para depósito: ");
                            double vDep = Convert.ToDouble(Console.ReadLine());
                            var resDep = conta.Depositar(vDep);
                            Console.WriteLine(resDep.message);
                            Console.WriteLine("\nPressione qualquer tecla para voltar...");
                            Console.ReadKey();
                        }
                        else if (subOpcao == "3")
                        {
                            Console.Clear();
                            Console.Write("Digite o valor para saque: ");
                            double vSaq = Convert.ToDouble(Console.ReadLine());
                            var resSaq = conta.Sacar(vSaq);
                            Console.WriteLine(resSaq.mensagem);
                            Console.WriteLine("\nPressione qualquer tecla para voltar...");
                            Console.ReadKey();
                        }
                        else if (subOpcao == "0")
                        {
                            logado = false;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Usuário ou senha incorretos.");
                    Console.WriteLine("\nPressione qualquer tecla para voltar...");
                    Console.ReadKey();
                }
            }
            else if (opcao == "0")
            {
                rodando = false;
            }
        }
    }
}