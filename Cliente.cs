public class Cliente
{
    public string Nome { get; private set; }

    public string Cpf { get; private set; }

    public Cliente(string nome, string cpf)
    {
        Nome = nome;
        Cpf = cpf;
    }
    
    public override string ToString()
    {
        return $"Nome: {Nome}, CPF: {Cpf}";
    }
}