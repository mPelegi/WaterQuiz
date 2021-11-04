using System;
using System.Collections.Generic;
using System.Text;
using WaterQuiz.DAL;
using WaterQuiz.Model.DAO;
using WaterQuiz.Model.Entidade;


namespace WaterQuiz.BLL
{
    public class GabaritoBLL
    {
        private GabaritoDAL gabaritoDAL;
        private ConexaoDAO conexaoDao;

        public GabaritoBLL()
        {
            try
            {
                conexaoDao = new ConexaoDAO();
                gabaritoDAL = new GabaritoDAL(conexaoDao);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<GabaritoModel> ObterTodos()
        {
            try
            {
                conexaoDao.Abrir();
                return gabaritoDAL.SelectAll();
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
