using System;
using System.Collections.Generic;
using System.Text;

namespace WaterQuiz.Model.Entidade
{
    public class PesoRespostaModel
    {
        public int IdPeso { get; set; }
        public int IdResposta { get; set; }
        public decimal Peso { get; set; }
        public RespostaModel Resposta { get; set; }
    }
}
