using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
using WaterQuiz.Model.DAO;
using WaterQuiz.Model.Entidade;

namespace WaterQuiz.DAL
{
    public class GabaritoDAL
    {
        private ConexaoDAO conexao;

        public GabaritoDAL(ConexaoDAO conexao)
        {
            this.conexao = conexao;
        }

        public List<GabaritoModel> SelectAll()
        {
            try
            {
                string query = string.Format("SELECT idGabarito, idPergunta, idResposta FROM tb_gabarito");
                List<GabaritoModel> retorno = new List<GabaritoModel>();
                using (SQLiteCommand cmd = new SQLiteCommand(query, conexao.Get()))
                {
                    SQLiteDataReader dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        GabaritoModel gabarito = new GabaritoModel
                        {
                            IdGabarito = Convert.ToInt32(dataReader["idGabarito"]),
                            IdPergunta = Convert.ToInt32(dataReader["idPergunta"]),
                            IdResposta = Convert.ToInt32(dataReader["idResposta"])
                        };
                        retorno.Add(gabarito);
                    }
                }
                return retorno;
            }
            catch (Exception e)
            {
                throw;
            }
        }
    }
}
