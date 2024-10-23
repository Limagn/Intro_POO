using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Model
{
    public class Conta
    {
        public long Numero { get; set; }
        public decimal Saldo { get; private set; }
        public Cliente Titular { get; set; }
        public Conta(long numero)
        {
            Numero = numero;
        }
        public Conta(long numero, decimal saldo, Cliente titular)
        {
            Numero = numero;
            Saldo = saldo;
            Titular = titular;
        }

        public void Saque (decimal valor)
        {
            if (valor <= Saldo && valor > 0)
                Saldo -= valor;
        }
        public void Deposito (decimal valor)
        {
            if (valor > 0) 
                Saldo += valor;
        }
        public void Transferencia(decimal valor, Conta contaDestino)
        {
            if (valor <= Saldo && valor > 0)
            {
                Saldo -= valor;
                contaDestino.Deposito(valor);
            }
        }
    }
}
