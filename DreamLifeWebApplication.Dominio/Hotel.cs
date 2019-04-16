using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamLifeWebApplication.Dominio
{
    [Table("hotel")]
    public class Hotel
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("nome")]
        public string Nome { get; set; }
        [Column("id_cidade")]
        public int CidadeId { get; set; }
        [Column("preco")]
        public double Preco { get; set; }
        [Column("classificacao")]
        public int Classificacao { get; set; }
        [Column("descricao")]
        public string Descricao { get; set; }
    }
}
