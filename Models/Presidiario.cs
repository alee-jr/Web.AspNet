using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _07_Fiap.WebAspNEt.Models
{
    public class Presidiario
    {
        [HiddenInput]
        public int PresidiarioId { get; set; }
        public string Nome { get; set; }
        [Display(Name="Data Entrada")]
        public DateTime DataEntrada { get; set; }
        [Display(Name = "Data Saida")]
        public DateTime DataSaida { get; set; }
        public NivelEscolaridade NivelEscolaridade { get; set; }
        public bool SaidaTemporarias { get; set; }
        public Cela Cela { get; set; }
        public int CelaId { get; set; }
    }
}
