public class Cliente
{
    public string Nome { get; private set; }

    public int Cpf { get; private set; }

    public Cliente(string nome, int cpf)
    {
        Nome = nome;
        Cpf = cpf;
    }
    
    public override string ToString()
    {
        return $"Nome: {Nome}, CPF: {Cpf}";
    }
}