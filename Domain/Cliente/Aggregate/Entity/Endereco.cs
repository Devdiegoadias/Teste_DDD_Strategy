using Domain.Cliente.Aggregate.Enum;
using Domain.Cliente.Aggregate.ValueObject;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Cliente.Aggregate.Entity
{
    public class Endereco
    {
        public int Id { get; set; }

        public String Logradouro { get; set; }

        public String Bairro { get; set; }

        public String Complemento { get; set; }

        public String Cidade { get; set; }

        public String Estado { get; set; }

        public CEP CEP { get; set; }

        public Tipo Tipo { get; set; }


    }
}
