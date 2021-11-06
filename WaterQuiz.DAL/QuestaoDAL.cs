using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
using WaterQuiz.Model.DAO;
using WaterQuiz.Model.Entidade;

namespace WaterQuiz.DAL
{
    public class QuestaoDAL
    {
        private ConexaoDAO conexao;

        public QuestaoDAL(ConexaoDAO conexao)
        {
            this.conexao = conexao;
        }

        public List<QuestaoModel> SelectAll()
        {
            try
            {
                string query = string.Format("SELECT idPergunta, descricao FROM tb_pergunta");
                List<QuestaoModel> retorno = new List<QuestaoModel>();
                using (SQLiteCommand cmd = new SQLiteCommand(query, conexao.Get()))
                {
                    SQLiteDataReader dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        QuestaoModel questao = new QuestaoModel
                        {
                            IdPergunta = Convert.ToInt32(dataReader["idPergunta"]),
                            Descricao = Convert.ToString(dataReader["descricao"]),
                            Tipo = Convert.ToString(dataReader["tipo"])
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
