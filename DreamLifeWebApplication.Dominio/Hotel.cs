using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamLifeWebApplication.Dominio
{
    public class Hotel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Cidade Cidade { get; set; }
        public double Preco { get; set; }
        public int Classificacao { get; set; }
        public string Descricao { get; set; }
    }
}
