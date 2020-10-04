using Domain.Cliente.Aggregate.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Cliente
{
    public class ClienteRepository : IClienteRepository
    {
        private static List<Domain.Cliente.Aggregate.Entity.Cliente> Persistencia { get; set; } = new List<Domain.Cliente.Aggregate.Entity.Cliente>(); 

        public Domain.Cliente.Aggregate.Entity.Cliente Get(int id)
        {
            return Persistencia.FirstOrDefault(x => x.Id == id);
        }

        public List<Domain.Cliente.Aggregate.Entity.Cliente> GetAll()
        {
            return Persistencia;
        }

        public Domain.Cliente.Aggregate.Entity.Cliente GetByCpf(string CPF)
        {
            return Persistencia.FirstOrDefault(x => x.CPF.Valor == CPF);
        }

        public void Save(Domain.Cliente.Aggregate.Entity.Cliente cliente)
        {
            Persistencia.Add(cliente);
        }

        public void Update(Domain.Cliente.Aggregate.Entity.Cliente cliente)
        {
            throw new NotImplementedException();
        }

    }
}
