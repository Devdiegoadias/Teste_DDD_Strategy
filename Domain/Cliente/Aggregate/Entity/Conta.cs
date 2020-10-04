using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Cliente.Aggregate.Entity
{
    public abstract class Conta
    {
        public String Numero { get; set; }
        public String Agencia { get; set; }
        public String Banco { get; set; }
        public Decimal Saldo { get; set; }

        public abstract void Transferir(Conta contaDestino);

    }
}
