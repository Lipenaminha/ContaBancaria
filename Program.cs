using System;
using System.Globalization;
using System.Threading.Tasks;
using ContaSantander;


var conta = new ContaBancaria("Joseph", 1234, 100);
conta.Depositar(50);
var ok = conta.Sacar(30);
Console.WriteLine($"Saldo atual: {conta.Saldo} - Saque OK {ok}");

