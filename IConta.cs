public interface IConta
{
    

    decimal Saldo { get; }
    void Depositar(decimal valor);
    bool Sacar(decimal valor);
    
}