using System;
using System.Collections.Generic;
using System.Text;
using WaterQuiz.DAL;
using WaterQuiz.Model.DAO;
using WaterQuiz.Model.Entidade;

namespace WaterQuiz.BLL
{
    public class RespostaBLL
    {
        private RespostaDAL respostaDal;
        private ConexaoDAO conexaoDao;

        public RespostaBLL()
        {
            try
            {
                conexaoDao = new ConexaoDAO();
                respostaDal = new RespostaDAL(conexaoDao);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<RespostaModel> ObterTodos()
        {
            try
            {
                conexaoDao.Abrir();
                return respostaDal.SelectAll();
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
    }
}
