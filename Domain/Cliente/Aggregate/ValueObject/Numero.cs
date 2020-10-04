using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Cliente.Aggregate.ValueObject
{
    public class Numero
    {
        public String Valor { get; set; }
        public String Formatado => ValorFormatado(Valor);

        public Numero()
        {

        }

        public Numero(string numero)
        {
            this.Valor = numero;
        }

        private string ValorFormatado(string valor) => Convert.ToInt64(valor).ToString(@"(00) 00000-0000");





    }
}
