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

        public List<GabaritoModel> SelectByExample(GabaritoModel exemplo)
        {
            try
            {
                StringBuilder query = new StringBuilder();
                query.AppendLine("SELECT idGabarito, idPergunta, idResposta FROM tb_gabarito WHERE 1 = 1");

                if (exemplo.IdPergunta > 0)
                {
                    query.AppendLine(" AND idPergunta = @IdPergunta ");
                }

                if (exemplo.IdResposta > 0)
                {
                    query.AppendLine(" AND idResposta = @IdResposta");
                }

                List<GabaritoModel> retorno = new List<GabaritoModel>();

                using (SQLiteCommand cmd = new SQLiteCommand(query.ToString(), conexao.Get()))
                {
                    cmd.Parameters.AddWithValue("@IdPergunta", exemplo.IdPergunta);
                    cmd.Parameters.AddWithValue("@IdResposta", exemplo.IdResposta);

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
