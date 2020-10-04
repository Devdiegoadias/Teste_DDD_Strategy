using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Cliente.Aggregate.Repository
{
    public interface IClienteRepository
    {
        List<Entity.Cliente> GetAll();
        
        Entity.Cliente Get(int id);

        void Save(Entity.Cliente cliente);
        Domain.Cliente.Aggregate.Entity.Cliente GetByCpf(string CPF);
    }
}
