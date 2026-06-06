using System;

namespace SysCaixaEletronico;

using System;

public class ContaBancaria
{
    public string Titular { get; private set; }
    public double Saldo { get; private set; } = 0;

    public ContaBancaria(string titular)
    {
        Titular = titular;
    }

    public (bool sucesso, string message) Depositar(double valor)
    {
        if (valor <= 0)
        {
            return (false, "Valor de depósito deve ser maior que zero.");
        }

        Saldo += valor;
        return (true, $"Depósito de {valor:C} realizado! Saldo atual: {Saldo:C}");
    }

    public (bool sucesso, string mensagem) Sacar(double valor)
    {
        if (valor <= 0 || valor > Saldo)
        {
            return (false, "Valor inválido ou saldo insuficiente para o saque.");
        }

        Saldo -= valor;
        return (true, $"Saque de {valor:C} realizado com sucesso! Saldo atual: {Saldo:C}");
    }

    public string VerificarSaldo()
    {
        return Saldo.ToString("C");
    }
}