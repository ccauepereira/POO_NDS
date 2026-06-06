namespace SysCaixaEletronico;

public class Usuario
{
    public string Nome { get; private set; }
    private readonly string _senha;

    public Usuario(string nome, string senha)
    {
        Nome = nome;
        _senha = senha;
    }

    public bool SenhaCorreta(string senha)
    {
        return _senha == senha;
    }
}