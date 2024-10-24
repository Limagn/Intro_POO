using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Model
{
    public class ContaEspecial : Conta
    {
        public  decimal Limite { get; set; }
        public decimal Saldo { get; set; }
        public override void Deposito(decimal valor)
        {
            throw new NotImplementedException();
        }

        public override void Saque(decimal valor)
        {
            if (valor > 0)
            {
                Saldo -= valor;
            }
            throw new NotImplementedException();
        }

        public override void Transferencia(decimal valor, Conta contaDestino)
        {
            throw new NotImplementedException();
        }
    }
}
