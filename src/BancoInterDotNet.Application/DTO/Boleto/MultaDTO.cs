﻿using System;

namespace BancoInterDotNet.Application.DTO.Boleto
{
    public class MultaDTO
    {
        public String codigoMulta { get; set; }
        public String data { get; set; }
        public Double taxa { get; set; }
        public Decimal valor { get; set; }
    }
}
