using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamLifeWebApplication.Dominio
{
    [Table("viagem")]
    public class Viagem
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("id_hotel")]
        public int HotelId { get; set; }
        [Column("data_viagem")]
        public DateTime Data { get; set; }
        [Column("quantidade_pessoas")]
        public int QuantidadePessoas { get; set; }
        [Column("modalidade_viagem")]
        public string ModalidadeViagem { get; set; }
    }
}
