using System;

namespace Senai.transacao.Models
{
    public class TrasacaoModel
    {
        public string Descricao { get; set; }

        public double Valor { get; set; }

        public string Tipo { get; set; }

        public DateTime DataTransacao { get; set; }



    }
}