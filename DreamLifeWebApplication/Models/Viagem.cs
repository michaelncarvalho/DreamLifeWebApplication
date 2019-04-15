using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DreamLifeWebApplication.Models
{
    public class Viagem
    {
        public int Id { get; set; }
        public Hotel Hotel { get; set; }
        public DateTime Data { get; set; }
        public int QuantidadePessoas { get; set; }
        public string ModalidadeViagem { get; set; }
    }
}