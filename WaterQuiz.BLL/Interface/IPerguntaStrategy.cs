using System;
using System.Collections.Generic;
using System.Text;
using WaterQuiz.Model.Entidade;

namespace WaterQuiz.BLL.Interface
{
    public interface IPerguntaStrategy
    {
        List<PerguntaModel> OrderQuestions(List<PerguntaModel> questions);
    }
}
