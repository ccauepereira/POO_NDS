using System.ComponentModel;

using System;
using System.Linq;
namespace PaginaLogin.PaginaDeLogin.model;

public class SistemaLogin
{
    private readonly List<Usuario> _usuarios = new();
    public bool TemUsuarios()
    {
        return _usuarios.Any();
    }
    
    public (bool sucesso, string mensagem) Cadastrar(string nome, string senha)
    {
        if (string.IsNullOrWhiteSpace(nome))
        {
            return (false, "Nome digitado não pode ser nulo");
        }
        else if (senha.Length < 4)
        {
            return (false, "Senha deve ter pelo menos 4 caracteres");
        }
        else if (_usuarios.Any(u => u.Nome == nome))
        {
            return (false, "nome não pode ser duplicado");
        }
        Usuario novoUsuario = new Usuario(nome, senha);
        _usuarios.Add(novoUsuario);
            
        return (true, "Cadastro realizado com sucesso!");
    }

    public (bool sucesso, string mensagem) Login(string nome, string senha)
    {
        if (!TemUsuarios())
        {
            return (false, "Não ha usuarios no sistema");
        }

        Usuario usuarioEncontrado = _usuarios.FirstOrDefault(u => u.Nome == nome);
        if (usuarioEncontrado == null)
        {
            return (false, "Usuario nao encontrado.");
        }
        
        if (!usuarioEncontrado.SenhaCorreta(senha))
        {
            return (false, "Senha incorreta");
        }
        return (true, "Login efetuado com sucesso");
    }
}

    
