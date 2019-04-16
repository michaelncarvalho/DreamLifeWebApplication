using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamLifeWebApplication.Dominio
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
