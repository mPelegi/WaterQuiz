using System;
using System.Collections.Generic;
using System.Text;
using WaterQuiz.DAL;
using WaterQuiz.Model.DAO;
using WaterQuiz.Model.Entidade;

namespace WaterQuiz.BLL
{
    public class PerguntaBLL
    {
        private PerguntaDAL questaoDal;
        private ConexaoDAO conexaoDao;

        public PerguntaBLL()
        {
            try
            {
                conexaoDao = new ConexaoDAO();
                questaoDal = new PerguntaDAL(conexaoDao);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<PerguntaModel> ObterTodos()
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

        public List<PerguntaModel> ObterPerguntasAleatoriamente()
        {
            PerguntaContext perguntaContext = new PerguntaContext();
            Random random = new Random();

            if(random.Next(2) == 0)
            {
                perguntaContext.SetPerguntaContext(new UniqueQuestionsFirstStrategy());
            }
            else
            {
                perguntaContext.SetPerguntaContext(new ValueQuestionsFirstStrategy());
            }

            return perguntaContext.GetQuestionSequence();
        }

    }
}
