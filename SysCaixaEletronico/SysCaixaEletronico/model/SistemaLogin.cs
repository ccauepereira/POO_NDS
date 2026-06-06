namespace SysCaixaEletronico;

using System;
using System.Collections.Generic;
using System.Linq;

public class SistemaLogin
{
    public static void Executar()
    {
    }

    private readonly List<Usuario> _usuarios = new();

    public bool TemUsuarios()
    {
        return _usuarios.Any();
    }

    public (bool sucesso, string mensagem) Cadastrar(string nome, string senha)
    {
        if (string.IsNullOrWhiteSpace(nome))
        {
            return (false, "Nome digitado não pode ser nulo ou vazio.");
        }

        if (senha.Length < 4)
        {
            return (false, "Senha deve ter pelo menos 4 caracteres.");
        }

        if (_usuarios.Any(u => u.Nome == nome))
        {
            return (false, "Nome de usuário ja existe.");
        }

        Usuario novoUsuario = new Usuario(nome, senha);
        _usuarios.Add(novoUsuario);

        return (true, "Usuário cadastrado com sucesso");
    }

    public Usuario? Autenticar(string nome, string senha)
    {
        Usuario usuarioEncontrado = _usuarios.FirstOrDefault(u => u.Nome == nome);

        if (usuarioEncontrado != null && usuarioEncontrado.SenhaCorreta(senha))
        {
            return usuarioEncontrado;
        }

        return null;
    }
}