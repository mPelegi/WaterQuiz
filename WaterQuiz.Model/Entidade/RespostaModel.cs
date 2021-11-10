using System;
using System.Collections.Generic;
using System.Text;

namespace WaterQuiz.Model.Entidade
{
    public class RespostaModel
    {
        public int IdResposta { get; set; }
        public int IdPergunta { get; set; }
        public string Descricao { get; set; }
        public PerguntaModel Questao { get; set; }
    }
}
