﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DreamLifeWeb_api.Models
{
    public class BalancoComercialPorContinente
    {
        public int AnoBase { get; set; }
        public string Continente { get; set; }
        public double ValorExportado { get; set; }
        public double ValorImportado { get; set; }
    }
}