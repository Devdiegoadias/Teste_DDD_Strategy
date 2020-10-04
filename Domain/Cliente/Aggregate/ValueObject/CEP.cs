using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Cliente.Aggregate.ValueObject
{
    public class CEP
    {
        public CEP()
        {

        }

        public CEP(string valor)
        {
            this.Valor = valor?.Replace("-", "") ?? throw new ArgumentNullException(nameof(CEP));
        }

        public string Valor { get; set; }
        public string Formatado => ValorFormatado(this.Valor);


        #region Private Methods
        private string ValorFormatado(string valor) => Convert.ToInt64(valor).ToString(@"00000\-000");
        #endregion

    }
}
