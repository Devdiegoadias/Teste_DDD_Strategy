using Domain.Cliente.Aggregate.Enum;
using Domain.Cliente.Aggregate.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain.Cliente.Aggregate.Entity
{
    public class Cliente
    {
        internal Cliente() { }

        internal Cliente(string nome, CPF cpf, DataNascimento dataNascimento)
        {
            this.DataNascimento = dataNascimento;
            this.CPF = cpf;
            this.Nome = nome;
        }

        internal Cliente(string nome, CPF cpf, DataNascimento dataNascimento, Filiacao pai, Filiacao mae) : this(nome, cpf, dataNascimento)
        {
            this.Mae = mae;
            this.Pai = pai;
        }

        public int Id { get; set; }
        public String Nome { get; set; }
        public CPF CPF { get; set; }
        public DataNascimento DataNascimento { get; set; }
        public Filiacao Mae { get; set; }
        public Filiacao Pai { get; set; }
        internal IList<Endereco> Enderecos { get; set; } = new List<Endereco>();
        internal IList<Telefone> Telefones { get; set; } = new List<Telefone>();
        public Password Password { get; private set; }

        public List<Conta> Contas { get; set; } = new List<Conta>();

        public void AdicionarConta(Conta conta)
        {
            this.Contas.Add(conta);
        }

        public Telefone ObterTelefone(Tipo tipo)
        {
            return this.Telefones.FirstOrDefault(x => x.Tipo == tipo);
        }

        public List<Telefone> ObterTelefones()
        {
            return this.Telefones.ToList();
        }

        public void AdicionarTelefone(Telefone telefone)
        {
            if (this.ObterTelefone(telefone.Tipo) != null)
            {
                throw new Exception("Não é permitido inserir o mesmo tipo de endereco");
            }

            this.Telefones.Add(telefone);
        }

        public List<Endereco> ObterEnderecos()
        {
            return this.Enderecos.ToList();
        }


        public Endereco ObterEndereco(Tipo tipo)
        {
            return this.Enderecos.FirstOrDefault(x => x.Tipo == tipo);
        }

        public void AdicionarEndereco(Endereco endereco)
        {
            if (this.ObterEndereco(endereco.Tipo) != null)
            {
                throw new Exception("Não é permitido inserir o mesmo tipo de endereco");
            }

            this.Enderecos.Add(endereco);
        }

        internal void AdicionarEndereco(IList<Endereco> enderecos)
        {
            enderecos.ToList().ForEach(e =>
            {
                this.AdicionarEndereco(e);
            });
        }

        public void GerarPassword()
        {
            this.Password = Password.GerarPassword();
        }

        public void AdicionarPassword(string password)
        {
            this.Password = new Password(password);
        }

    }
}
