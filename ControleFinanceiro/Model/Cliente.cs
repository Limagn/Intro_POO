using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Model
{
    public class Cliente
    {
        public string Nome {  get;  set; }
        public string Cpf { get; set; }
        public List<Conta> Conta { get; set; }
        public Cliente(string nome, string cpf)
        {
            Nome = nome;
            Cpf = cpf;
        }
        public override string ToString()
        {
            return Nome + " - " + Cpf;
        }
        public decimal SaldoDasContas()
        {
            decimal total = 0;
            foreach (Conta conta in Conta) {
                total += conta.Saldo;
            }
            return total;
        }
    }
}
