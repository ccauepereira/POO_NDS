using System.Reflection.Metadata;

namespace PaginaLogin.PaginaDeLogin.model;

public class Usuario
{
    public string Nome { get; private set; }
    private string _senha;

    public Usuario(string nome, string senha)
    {
        this.Nome = nome;
        this._senha = senha;
    }

    public bool SenhaCorreta(string senha)
    {
        if (senha == _senha)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
