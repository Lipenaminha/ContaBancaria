using System;
using System.Globalization;
using System.Threading.Tasks;
using ContaSantander;


var cliente = new Cliente("Ana Silva", "123.456.789-00");
var agencia = new Agencia(1234, "Agência Central");


IConta contaCorrente = new ContaCorrente(cliente, agencia, 1001, 500);
IConta contaPoupanca = new ContaPoupanca(cliente, agencia, 2001, 1000);

Console.WriteLine(contaCorrente);
Console.WriteLine(contaPoupanca);

// Testes
contaCorrente.Depositar(200);
contaCorrente.Sacar(100);

Console.WriteLine($"Após operações, saldo conta corrente: {contaCorrente.Saldo:C}");

var poupanca = (ContaPoupanca)contaPoupanca; // Cast para acessar RenderJuros()
poupanca.RenderJuros();
Console.WriteLine($"Após rendimento, saldo poupança: {poupanca.Saldo:C}");


var conta = new ContaBancaria(cliente, agencia, 123456, 0);
conta.Depositar(1000);
conta.Sacar(250);

Console.WriteLine(conta);



