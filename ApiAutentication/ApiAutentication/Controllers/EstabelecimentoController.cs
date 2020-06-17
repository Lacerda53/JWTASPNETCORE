using ApiAutentication.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ApiAutentication.Controllers
{
    [Route("")]
    [ApiController]
    [Authorize]
    public class EstabelecimentoController : ControllerBase
    {
        private List<Estabelecimento> estabelecimentos = new List<Estabelecimento>()
        {
            new Estabelecimento
            {
                Nome = "Chiquinho Sorvetes",
                Estrelas= 5,
                Imagem = "https://static.tonolucro.com/images/empresa/B5b40ee4e810fa.jpg",
                Local = "Setor Anhangüera",
                Tipo = "Açaí",
                ValorEntrega= 4.99f
            },
            new Estabelecimento
            {
                Nome = "Açaiteria",
                Estrelas= 5,
                Imagem = "https://static.tonolucro.com/images/empresa/5b100e164e82e.jpg",
                Local = "Setor Anhangüera",
                Tipo = "Açaí",
                ValorEntrega= 4.99f
            },
            new Estabelecimento
            {
                Nome = "Churros do João",
                Estrelas= 5,
                Imagem = "https://static.tonolucro.com/images/empresa/5baa2801166ab.jpg",
                Local = "Jardim Filadélfia",
                Tipo = "Bolos & Tortas",
                ValorEntrega= 4.99f
            },
            new Estabelecimento
            {
                Nome = "Subway",
                Estrelas= 5,
                Imagem = "https://static.tonolucro.com/images/empresa/C5aa1f2f98b03eaaa.jpg",
                Local = "Setor Anhangüera",
                Tipo = "Fast-food",
                ValorEntrega= 4.99f
            },
            new Estabelecimento
            {
                Nome = "Black Sheep Saloon",
                Estrelas= 3,
                Imagem = "https://static.tonolucro.com/images/empresa/5c8870497184b.jpg",
                Local = "Senador",
                Tipo = "Burgers",
                ValorEntrega= 4.99f
            },
            new Estabelecimento
            {
                Nome = "Mais Coxinhas",
                Estrelas= 5,
                Imagem = "https://static.tonolucro.com/images/empresa/5c8261cb7d580.jpg",
                Local = "Jardim Filadélfia",
                Tipo = "Lanches",
                ValorEntrega= 4.99f
            },
            new Estabelecimento
            {
                Nome = "Baroli Restaurante",
                Estrelas= 5,
                Imagem = "https://static.tonolucro.com/images/empresa/5aece9bd9cb75.jpg",
                Local = "Setor Anhangüera",
                Tipo = "Carnes",
                ValorEntrega= 4.99f
            },
            new Estabelecimento
            {
                Nome = "Lampião Hamburgueria",
                Estrelas= 5,
                Imagem = "https://static.tonolucro.com/images/empresa/5af09c2f899d0.jpg",
                Local = "Jardim Filadélfia",
                Tipo = "Burgers",
                ValorEntrega= 4.99f
            },
            new Estabelecimento
            {
                Nome = "Torii Japanese Food",
                Estrelas= 5,
                Imagem = "https://static.tonolucro.com/images/empresa/5bd8c7e59786b.jpg",
                Local = "Jardim Filadélfia",
                Tipo = "Oriental",
                ValorEntrega= 4.99f
            },
            new Estabelecimento
            {
                Nome = "Andante",
                Estrelas= 4,
                Imagem = "https://static.tonolucro.com/images/empresa/5cc1fe70c49fa.jpg",
                Local = "Setor Oeste",
                Tipo = "Carnes",
                ValorEntrega= 4.99f
            },
            new Estabelecimento
            {
                Nome = "U Box",
                Estrelas= 5,
                Imagem = "https://static.tonolucro.com/images/empresa/5b11a2cadccb9.jpg",
                Local = "Setor Anhangüera",
                Tipo = "Burgers",
                ValorEntrega= 4.99f
            },
        };
        public IEnumerable<Estabelecimento> ListaEstabelecimentos()
        {
            return estabelecimentos;
        }
    }
}
