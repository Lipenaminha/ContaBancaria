public class Agencia
{
    
    public int Numero { get; private set; }
    public string Nome { get; private set; }

    public Agencia(int numero, string nome)
    {
        Numero = numero;
        Nome = nome;
    }

    public override string ToString()
    {
        return $"Agência {Numero} - {Nome}";
    }
}