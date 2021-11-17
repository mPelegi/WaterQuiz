using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
using WaterQuiz.Model.DAO;
using WaterQuiz.Model.Entidade;

namespace WaterQuiz.DAL
{
    public class PesoRespostaDAL
    {
        private ConexaoDAO conexao;
        public PesoRespostaDAL(ConexaoDAO conexao)
        {
            this.conexao = conexao;
        }

        public List<PesoRespostaModel> SelectByExample(PesoRespostaModel exemplo)
        {
            try
            {
                StringBuilder query = new StringBuilder();
                query.AppendLine("SELECT idpeso, idresposta, peso FROM tb_peso_resposta WHERE 1 = 1");

                if (exemplo.IdResposta > 0)
                {
                    query.AppendLine(" AND idresposta = @IdResposta ");
                }
                List<PesoRespostaModel> retorno = new List<PesoRespostaModel>();
                using (SQLiteCommand cmd = new SQLiteCommand(query.ToString(), conexao.Get()))
                {
                    cmd.Parameters.AddWithValue("@IdResposta", exemplo.IdResposta);
                    SQLiteDataReader dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        PesoRespostaModel peso = new PesoRespostaModel
                        {
                            IdPeso = Convert.ToInt32(dataReader["idPeso"]),
                            IdResposta = Convert.ToInt32(dataReader["idResposta"]),
                            Peso = Convert.ToDecimal(dataReader["peso"])
                        };
                        retorno.Add(peso);
                    }
                }
                return retorno;
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public List<PesoRespostaModel> SelectAll()
        {
            try
            {
                string query = string.Format("SELECT idPeso, idResposta, peso FROM tb_peso_resposta");
                List<PesoRespostaModel> retorno = new List<PesoRespostaModel>();
                using (SQLiteCommand cmd = new SQLiteCommand(query, conexao.Get()))
                {
                    SQLiteDataReader dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        PesoRespostaModel questao = new PesoRespostaModel
                        {
                            IdPeso = Convert.ToInt32(dataReader["idPeso"]),
                            IdResposta = Convert.ToInt32(dataReader["idResposta"]),
                            Peso = Convert.ToInt32(dataReader["peso"])
                        };
                        retorno.Add(questao);
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
