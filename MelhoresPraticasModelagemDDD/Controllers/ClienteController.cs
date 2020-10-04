using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationService.Cliente;
using Teste_DDD_Strategy.ViewModel.Request;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Teste_DDD_Strategy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private IClienteService ClienteService { get; set; }

        public ClienteController(IClienteService clienteService) 
        {
            this.ClienteService = clienteService;
        }

        [HttpPost]
        public IActionResult Post([FromBody] ClienteRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            this.ClienteService.Create(request.Nome, request.CPF, request.DataNascimento);

            return Ok();
        }
    }
}
