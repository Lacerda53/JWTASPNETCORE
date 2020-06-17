using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiAutentication.Models
{
    public class Estabelecimento
    {
        public Estabelecimento()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Imagem { get; set; }
        public string Tipo { get; set; }
        public float Estrelas { get; set; }
        public string Local { get; set; }
        public float ValorEntrega { get; set; }
    }
}
