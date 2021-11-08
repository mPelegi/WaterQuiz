using System;
using System.Collections.Generic;
using System.Text;
using WaterQuiz.DAL;
using WaterQuiz.Model.DAO;
using WaterQuiz.Model.Entidade;

namespace WaterQuiz.BLL
{
    public class PesoRespostaBLL
    {
        private PesoRespostaDAL pesoDal;
        private ConexaoDAO conexaoDao;

        public PesoRespostaBLL()
        {
            try
            {
                conexaoDao = new ConexaoDAO();
                pesoDal = new PesoRespostaDAL(conexaoDao);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<PesoRespostaModel> ObterPeloExemplo(PesoRespostaModel pesoResposta)
        {
            try
            {
                conexaoDao.Abrir();
                return pesoDal.SelectByExample(pesoResposta);
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
