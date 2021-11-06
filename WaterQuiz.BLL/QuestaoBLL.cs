using System;
using System.Collections.Generic;
using System.Text;
using WaterQuiz.DAL;
using WaterQuiz.Model.DAO;
using WaterQuiz.Model.Entidade;

namespace WaterQuiz.BLL
{
    public class QuestaoBLL
    {
        private QuestaoDAL questaoDal;
        private ConexaoDAO conexaoDao;

        public QuestaoBLL()
        {
            try
            {
                conexaoDao = new ConexaoDAO();
                questaoDal = new QuestaoDAL(conexaoDao);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<QuestaoModel> ObterTodos()
        {
            try
            {
                conexaoDao.Abrir();
                return questaoDal.SelectAll();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conexaoDao.Fechar();
            }
        }

        public List<QuestaoModel> ObterQuestoesAleatoriamente()
        {
            QuestaoContext questaoContext = new QuestaoContext();
            Random random = new Random();

            if(random.Next(2) == 0)
            {
                questaoContext.SetQuestaoContext(new UniqueQuestionsFirstStrategy());
            }
            else
            {
                questaoContext.SetQuestaoContext(new ValueQuestionsFirstStrategy());
            }

            return questaoContext.GetQuestionSequence();
        }

    }
}
