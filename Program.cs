using System;
using System.Globalization;
using System.Threading.Tasks;
using ContaSantander;


var cliente = new Cliente("Ana Silva", "123.456.789-00");
var agencia = new Agencia(1234, "Agência Central");


var conta = new ContaBancaria(cliente, agencia, 123456, 0);
conta.Depositar(1000);
conta.Sacar(250);

Console.WriteLine(conta);



