using System;

namespace ContaSantander
{


    public class ContaBancaria
    {

        public string Titular { get; private set; }
        public int Numero { get; private set; }
        public decimal Saldo { get; private set; }

        public ContaBancaria(string titular, int numero, decimal saldoInicial = 0)
        {
            Titular = titular;
            Numero = numero;
            Saldo = saldoInicial;
        }

        public void Depositar(decimal valor)
        {

            if (valor <= 0)

                throw new ArgumentException("O valor do depósito deve ser maior que zero.");

            Saldo += valor;
        }

        public bool Sacar(decimal valor)
        {

            if (valor <= 0) return false;
            if (valor > Saldo) return false;
            Saldo -= valor;
            return true;



        }
        
        

    }














}