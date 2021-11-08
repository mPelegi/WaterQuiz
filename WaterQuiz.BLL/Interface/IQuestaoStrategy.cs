using System;
using System.Collections.Generic;
using System.Text;
using WaterQuiz.Model.Entidade;

namespace WaterQuiz.BLL.Interface
{
    public interface IQuestaoStrategy
    {
        List<QuestaoModel> OrderQuestions(List<QuestaoModel> questions);
    }
}
