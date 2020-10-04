using Domain.Cliente.Aggregate.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Cliente.Aggregate.Factory
{
    public static class ClienteFactory
    {
        public static Entity.Cliente Criar(string nome, string cpf, DateTime dataNascimento)
        {
            return new Entity.Cliente(nome, new ValueObject.CPF(cpf), new ValueObject.DataNascimento(dataNascimento));
        }

        public static Entity.Cliente Criar(string nome, string cpf, DateTime dataNascimento, string nomePai, string nomeMae)
        {
            return new Entity.Cliente(nome,
                                      new ValueObject.CPF(cpf),
                                      new ValueObject.DataNascimento(dataNascimento),
                                      new ValueObject.Filiacao(nomePai),
                                      new ValueObject.Filiacao(nomeMae));
        }

        public static Entity.Cliente Criar(string nome, string cpf, DateTime dataNascimento, string nomePai, string nomeMae, IList<Endereco> enderecos)
        {
            var cliente = new Entity.Cliente(nome,
                                             new ValueObject.CPF(cpf),
                                             new ValueObject.DataNascimento(dataNascimento),
                                             new ValueObject.Filiacao(nomePai),
                                             new ValueObject.Filiacao(nomeMae));

            cliente.AdicionarEndereco(enderecos);


            return cliente;
        }



    }
}
