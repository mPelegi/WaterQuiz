using System;
using System.Collections.Generic;
using System.Text;

namespace WaterQuiz.Model.Entidade
{
    public class GabaritoModel
    {
        public int IdGabarito { get; set; }
        public int IdPergunta { get; set; }
        public int IdResposta { get; set; }
        public QuestaoModel Questao { get; set; }
        public RespostaModel Resposta { get; set; }
    }
}
