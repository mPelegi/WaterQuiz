using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
using WaterQuiz.Model.DAO;
using WaterQuiz.Model.Entidade;

namespace WaterQuiz.DAL
{
    public class RespostaDAL
    {
        private ConexaoDAO conexao;

        public RespostaDAL(ConexaoDAO conexao)
        {
            this.conexao = conexao;
        }

        public List<RespostaModel> SelectAll()
        {
            try
            {
                string query = string.Format("SELECT idResposta, idPergunta, descricao FROM resposta");
                List<RespostaModel> retorno = new List<RespostaModel>();
                using (SQLiteCommand cmd = new SQLiteCommand(query, conexao.Get()))
                {
                    SQLiteDataReader dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        RespostaModel resposta = new RespostaModel
                        {
                            IdResposta = Convert.ToInt32(dataReader["idResposta"]),
                            IdQuestao = Convert.ToInt32(dataReader["idPergunta"]),
                            Descricao = Convert.ToString(dataReader["descricao"])
                        };

                        retorno.Add(resposta);
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
