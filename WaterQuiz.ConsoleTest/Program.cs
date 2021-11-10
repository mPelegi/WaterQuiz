using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using WaterQuiz.BLL;
using WaterQuiz.Model.Entidade;
using WaterQuiz.Utils;

namespace WaterQuiz.ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //GetCaminhoDatabase();
            //GetPerguntasAleatoriamente();
            //GetPerguntasComRespostas();
            //GetGabaritoPerguntas();
            //GetPesoRespostas();
            CheckRespostas();

            Console.ReadKey();
        }

        static void GetCaminhoDatabase()
        {
            string dbPath = new DatabaseUtil().GetDatabasePath();
            Console.WriteLine(dbPath);
        }

        static void GetPerguntasAleatoriamente()
        {
            List<PerguntaModel> perguntas = new PerguntaBLL().ObterPerguntasAleatoriamente();

            foreach (PerguntaModel pergunta in perguntas)
            {
                Console.WriteLine("{0} - {1}: {2}\n", pergunta.Tipo, pergunta.IdPergunta, pergunta.Descricao);
            }
        }

        static void GetPerguntasComRespostas()
        {
            List<PerguntaModel> perguntas = new PerguntaBLL().ObterPerguntasAleatoriamente();
            List<RespostaModel> respostas = new List<RespostaModel>();

            foreach (PerguntaModel pergunta in perguntas)
            {
                respostas = new RespostaBLL().ObterPeloExemplo(new RespostaModel { IdPergunta = pergunta.IdPergunta });
                Console.WriteLine("{0} - {1}: {2}\n", pergunta.Tipo, pergunta.IdPergunta, pergunta.Descricao);

                foreach (RespostaModel resposta in respostas)
                {
                    Console.WriteLine("{0}: {1}", resposta.IdResposta, resposta.Descricao);
                }

                Console.WriteLine();
            }
        }

        static void GetGabaritoPerguntas()
        {
            List<PerguntaModel> perguntas = new PerguntaBLL().ObterPerguntasAleatoriamente();
            perguntas.RemoveAll(x => x.Tipo == "PE");

            GabaritoModel gabarito;
            RespostaModel respostaCorreta;

            foreach (PerguntaModel pergunta in perguntas)
            {
                gabarito = new GabaritoBLL().ObterPeloExemplo(new GabaritoModel { IdPergunta = pergunta.IdPergunta }).FirstOrDefault();
                Console.WriteLine("{0} - {1}: {2}\n", pergunta.Tipo, pergunta.IdPergunta, pergunta.Descricao);

                respostaCorreta = new RespostaBLL().ObterTodos().Find(x => x.IdResposta == gabarito.IdResposta);
                Console.WriteLine("{0}: {1}\n", respostaCorreta.IdResposta, respostaCorreta.Descricao);
            }
        }

        static void GetPesoRespostas()
        {
            List<PerguntaModel> perguntas = new PerguntaBLL().ObterPerguntasAleatoriamente();
            perguntas.RemoveAll(x => x.Tipo == "UN");

            List<RespostaModel> respostas = new List<RespostaModel>();
            PesoRespostaModel peso;

            foreach (PerguntaModel pergunta in perguntas)
            {
                respostas = new RespostaBLL().ObterPeloExemplo(new RespostaModel { IdPergunta = pergunta.IdPergunta });
                Console.WriteLine("{0} - {1}: {2}\n", pergunta.Tipo, pergunta.IdPergunta, pergunta.Descricao);

                foreach (RespostaModel resposta in respostas)
                {
                    peso = new PesoRespostaBLL().ObterPeloExemplo(new PesoRespostaModel { IdResposta = resposta.IdResposta }).FirstOrDefault();
                    Console.WriteLine("PESO[{0}] {1}: {2}", peso.Peso, resposta.IdResposta, resposta.Descricao);
                }

                Console.WriteLine();
            }
        }

        static void CheckRespostas()
        {
            List<PerguntaModel> perguntas = new PerguntaBLL().ObterPerguntasAleatoriamente();
            perguntas.RemoveAll(x => x.Tipo == "PE");

            List<RespostaModel> respostas = new List<RespostaModel>();
            bool isCorreto;

            foreach (PerguntaModel pergunta in perguntas)
            {
                respostas = new RespostaBLL().ObterPeloExemplo(new RespostaModel { IdPergunta = pergunta.IdPergunta });
                Console.WriteLine("{0} - {1}: {2}\n", pergunta.Tipo, pergunta.IdPergunta, pergunta.Descricao);

                foreach (RespostaModel resposta in respostas)
                {
                    isCorreto = new GabaritoBLL().VerificarRespostaCorreta(pergunta.IdPergunta, resposta.IdResposta);
                    Console.WriteLine("[{0}] {1}: {2}", isCorreto ? "V" : "X", resposta.IdResposta, resposta.Descricao);
                }

                Console.WriteLine();
            }


        }
    }
}
