using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Cliente.Aggregate.Entity
{
    public class ContaCorrente : Conta
    {
        public ContaCorrente(decimal valor)
        {
            this.Saldo = valor;
        }

        public override void Transferir(Conta contaDestino)
        {
            if (contaDestino is ContaInvestimento)
                throw new Exception("Transferencia de conta somente pode ser feito para conta do tipo poupanca ou corrente");

            contaDestino.Saldo += Saldo;
            Saldo = 0M;

        }
    }
}
