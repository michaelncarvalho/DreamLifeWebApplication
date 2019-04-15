using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DreamLifeWebApplication.Models
{
    public interface IRepositorioHotel
    {
       Hotel Salvar(Hotel hotel);
        bool Excluir(Hotel hotel);
        Hotel GetCidade(int id);
        Hotel[] GetHoteis();
        Hotel[] GetCidades(Func<Hotel, bool> expressao);
    }
}