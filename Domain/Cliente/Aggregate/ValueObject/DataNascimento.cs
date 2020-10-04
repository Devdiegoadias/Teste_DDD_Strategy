using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Cliente.Aggregate.ValueObject
{
    public class DataNascimento
    {
        public DataNascimento(DateTime dateTime)
        {
            this.Data = dateTime;

        }

        public DateTime Data { get; set; }

        public int Idade => Valor(Data);

        private int Valor(DateTime data)
        {
            return new DateTime((DateTime.Now.Date - data).Ticks).Year;
        }
    }

}
