using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Domain.Cliente.Aggregate.ValueObject
{
    public class Filiacao
    {
        public String Nome { get; set; }
        public DataNascimento DataNascimento { get; set; }
        public String NomeFormatado => ValorFormatado(this.Nome);

        private string ValorFormatado(string nome)
        {
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(nome);
        }

        public Filiacao()
        {
        }

        public Filiacao(string nome)
        {
            this.Nome = nome ?? throw new ArgumentNullException(nameof(Filiacao));
        }


    }
}
