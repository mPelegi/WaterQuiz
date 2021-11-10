using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WaterQuiz.BLL.Interface;
using WaterQuiz.Model.Entidade;

namespace WaterQuiz.BLL
{
    public class PerguntaContext
    {
        private IPerguntaStrategy PerguntaStrategy;

        public PerguntaContext() { }

        public PerguntaContext(IPerguntaStrategy perguntaStrategy)
        {
            PerguntaStrategy = perguntaStrategy;
        }

        public void SetPerguntaContext(IPerguntaStrategy perguntaStrategy)
        {
            PerguntaStrategy = perguntaStrategy;
        }

        public List<PerguntaModel> GetQuestionSequence()
        {
            return PerguntaStrategy.OrderQuestions(new PerguntaBLL().ObterTodos());
        }
    }

    public class UniqueQuestionsFirstStrategy : IPerguntaStrategy
    {
        public List<PerguntaModel> OrderQuestions(List<PerguntaModel> questions)
        {
            List<PerguntaModel> result = new List<PerguntaModel>();
            result.AddRange(questions.FindAll(x => x.Tipo.Equals("UN")));
            result.AddRange(questions.FindAll(x => x.Tipo.Equals("PE")));

            return result;
        }
    }

    public class ValueQuestionsFirstStrategy : IPerguntaStrategy
    {
        public List<PerguntaModel> OrderQuestions(List<PerguntaModel> questions)
        {
            List<PerguntaModel> result = new List<PerguntaModel>();
            result.AddRange(questions.FindAll(x => x.Tipo.Equals("PE")));
            result.AddRange(questions.FindAll(x => x.Tipo.Equals("UN")));

            return result;
        }
    }
}
