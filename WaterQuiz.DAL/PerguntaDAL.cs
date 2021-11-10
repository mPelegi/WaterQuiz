using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
using WaterQuiz.Model.DAO;
using WaterQuiz.Model.Entidade;

namespace WaterQuiz.DAL
{
    public class PerguntaDAL
    {
        private ConexaoDAO conexao;

        public PerguntaDAL(ConexaoDAO conexao)
        {
            this.conexao = conexao;
        }

        public List<PerguntaModel> SelectAll()
        {
            try
            {
                string query = string.Format("SELECT idPergunta, descricao, tipo FROM tb_pergunta");
                List<PerguntaModel> retorno = new List<PerguntaModel>();
                using (SQLiteCommand cmd = new SQLiteCommand(query, conexao.Get()))
                {
                    SQLiteDataReader dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        PerguntaModel questao = new PerguntaModel
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
