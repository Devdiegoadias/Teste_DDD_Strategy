using System;

namespace ApplicationService.Cliente
{
    public interface IClienteService
    {
        void Create(string nome, string CPF, DateTime dtNascimento);
    }
}