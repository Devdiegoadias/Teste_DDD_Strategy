using Domain.Cliente.Aggregate.Builder;
using Domain.Cliente.Aggregate.Entity;
using Domain.Cliente.Aggregate.Factory;
using Domain.Cliente.Aggregate.ValueObject;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new ClienteBuilder()
                                 .Criar("Diego A. Dias", "090454656", new DateTime(2020, 09, 20))
                                 .AdicionarEndereco(new Endereco())
                                 .AdicionarTelefone(new Telefone() { Numero = new Numero("99999"), Tipo = Domain.Cliente.Aggregate.Enum.Tipo.Comercial })
                                 .Build();



            Conta contaOrigem = ContaFactory.Criar(99);

            Conta contaDestino = ContaFactory.Criar(999);

            contaOrigem.Transferir(contaDestino);

            cliente.AdicionarConta(contaOrigem);

            cliente.AdicionarConta(contaDestino);

            Console.WriteLine(contaDestino.Saldo);

            Console.ReadKey();
        }
    }
}
