using Domain.Cliente.Aggregate.Enum;
using Domain.Cliente.Aggregate.ValueObject;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Cliente.Aggregate.Entity
{
    public class Telefone
    {
        public int Id { get; set; }
        public Numero Numero { get; set; }
        public Tipo Tipo { get; set; }
    }
}
