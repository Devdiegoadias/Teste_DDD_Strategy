using Domain.Cliente.Aggregate.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Cliente.Aggregate.Factory
{
    public class ContaFactory
    {
        public static Conta Criar(decimal valorInicial) => (valorInicial) switch
        {
            _ when (valorInicial < 99.99M) => new ContaPoupanca(valorInicial),
            _ when (valorInicial >= 100.00M && valorInicial <= 999.99M) => new ContaPoupanca(valorInicial),
            _ => new ContaInvestimento(valorInicial)
        };

    }
}
