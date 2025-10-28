

using ContaSantander;

public class ContaCorrente : ContaBancaria
{

    // a constante usamos UPPER_CASE -- para diferenciar de variáveis comuns
    private const decimal TAXA_SAQUE = 1.50m;
    public ContaCorrente(Cliente titular, Agencia agencia, int numero, decimal saldoInicial = 0) : base(titular, agencia, numero, saldoInicial)
    {

    }


    // override para sobrescrever o método da classe base
    public override bool Sacar(decimal valor)
    {
        var valorComTaxa = valor + TAXA_SAQUE;

        if (valorComTaxa > Saldo)

            return false;

        return base.Sacar(valorComTaxa);
    }
    
     public override string ToString()
    {
        return $"[Conta Corrente] {Titular.Nome} - Saldo: {Saldo:C}";
    }


}
