using Microsoft.AspNetCore.Mvc;
using QuemSouEuAPI.Models;

namespace QuemSouEuAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class QuemSouEuController : ControllerBase
    {
        [HttpGet]
        public PessoaModel Get()
        {
            PessoaModel Eu = new PessoaModel();

            Eu.Nome = "Vinicius";
            Eu.Sobrenome = "Honorio";
            Eu.UsuarioGitHub = "ViniciusHonorio";

            return Eu;
        }
    }
}