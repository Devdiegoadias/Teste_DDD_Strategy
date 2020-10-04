using Domain.Cliente.Aggregate.Factory;
using Domain.Cliente.Aggregate.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationService.Cliente
{
    public class ClienteService : IClienteService
    {
        private IClienteRepository Repository { get; set; }

        public ClienteService(IClienteRepository clienteRepository)
        {
            this.Repository = clienteRepository;
        }

        public void Create(string nome, string CPF, DateTime dtNascimento)
        {
            if (this.Repository.GetByCpf(CPF) != null)
                throw new Exception($"Cliente já existente na base com este cpf {CPF}");

            var cliente = ClienteFactory.Criar(nome, CPF, dtNascimento);

            this.Repository.Save(cliente);
        }

    }
}
