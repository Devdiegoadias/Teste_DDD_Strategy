using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Cliente.Aggregate.Entity
{
    public class ContaInvestimento : Conta
    {
        public ContaInvestimento(decimal valor)
        {
            this.Saldo = valor;
        }



        public override void Transferir(Conta contaDestino)
        {
            if (contaDestino is ContaPoupanca)
                throw new Exception("Transferencia de conta investimento somente pode ser feito para conta do tipo corrente ou investimento");

            contaDestino.Saldo += Saldo;
            Saldo = 0M;
        }
    }
}
