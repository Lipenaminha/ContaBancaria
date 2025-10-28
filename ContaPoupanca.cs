using ContaSantander;

public class ContaPoupanca : ContaBancaria
{

    private const decimal TAXA_RENDIMENTO = 0.005m;
    public ContaPoupanca(Cliente titular, Agencia agencia, int numero, decimal saldoInicial = 0) : base(titular, agencia, numero, saldoInicial)
    {
    }

    public void RenderJuros()
    {
        var juros = Saldo * TAXA_RENDIMENTO;
        Depositar(juros);
    }

    public override string ToString()
    {
        return $"[Conta Poupança] {Titular.Nome} - Saldo: {Saldo:C}";
    }
}





