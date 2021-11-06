using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WaterQuiz.BLL.Interface;
using WaterQuiz.Model.Entidade;

namespace WaterQuiz.BLL
{
    public class QuestaoContext
    {
        private IQuestaoStrategy QuestaoStrategy;

        public QuestaoContext() { }

        public QuestaoContext(IQuestaoStrategy questaoStrategy)
        {
            QuestaoStrategy = questaoStrategy;
        }

        public void SetQuestaoContext(IQuestaoStrategy questaoStrategy)
        {
            QuestaoStrategy = questaoStrategy;
        }

        public List<QuestaoModel> GetQuestionSequence()
        {
            return QuestaoStrategy.OrderQuestions(new QuestaoBLL().ObterTodos());
        }
    }

    public class UniqueQuestionsFirstStrategy : IQuestaoStrategy
    {
        public List<QuestaoModel> OrderQuestions(List<QuestaoModel> questions)
        {
            List<QuestaoModel> result = new List<QuestaoModel>();
            result.AddRange(questions.FindAll(x => x.Tipo.Equals("Unica")));
            result.AddRange(questions.FindAll(x => x.Tipo.Equals("Peso")));

            return result;
        }
    }

    public class ValueQuestionsFirstStrategy : IQuestaoStrategy
    {
        public List<QuestaoModel> OrderQuestions(List<QuestaoModel> questions)
        {
            List<QuestaoModel> result = new List<QuestaoModel>();
            result.AddRange(questions.FindAll(x => x.Tipo.Equals("Peso")));
            result.AddRange(questions.FindAll(x => x.Tipo.Equals("Unica")));

            return result;
        }
    }
}
