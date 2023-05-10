using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPIGeradorDeNomes.Regras;

namespace WebAPIGeradorDeNomes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GerarNomes : ControllerBase
    {
        [HttpGet(Name = "GeradorNomes")]
        public string GeraNomes()
        {
            GeredorDenomes geredor = new GeredorDenomes();

            string Nome = geredor.mulher();
            Nome = Nome + geredor.sobrenome();

            return Nome;
        }
    }
}
