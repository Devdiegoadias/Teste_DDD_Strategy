using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Teste_DDD_Strategy.ViewModel.Request
{
    public class ClienteRequest
    {
        [Required(ErrorMessage = "Campo Nome é Obrigatorio")]
        public String Nome { get; set; }

        [Required(ErrorMessage = "Campo CPF é Obrigatorio")]
        public String CPF { get; set; }

        [Required(ErrorMessage = "Campo Data Nascimento é Obrigatorio")]
        public DateTime DataNascimento { get; set; }
    }
}
