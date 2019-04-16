using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamLifeWebApplication.Dominio
{
    [Table("cidade")]
    public class Cidade
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("nome")]
        public string Nome { get; set; }
        [Column("pais")]
        public string Pais { get; set; }
        [Column("estado")]
        public string Estado { get; set; }
    }
}
