using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Windows.Forms;
using WaterQuiz.BLL;
using WaterQuiz.Model.Entidade;
using WaterQuiz.View.Util;

namespace WaterQuiz.View
{
    public partial class Pergunta : Form
    {
        string alternativaSelecionada = "";
        int i = 0;
        PerguntaModel perguntaAtual = new PerguntaModel();
        GabaritoBLL gabaritoBLL = new GabaritoBLL();
        List<RespostaModel> respostasUsuario = new List<RespostaModel>();
        List<RespostaModel> listaRespostas = new List<RespostaModel>();
        List<PerguntaModel> listaPerguntas = new List<PerguntaModel>();
        List<PesoRespostaModel> listaPesos = new List<PesoRespostaModel>();
        PerguntaBLL perguntaBLL = new PerguntaBLL();
        Funcoes funcoes = new Funcoes();
        decimal pontuacao = 0;
        int acertos = 0;


        Som som = new Som();
        public Pergunta()
        {
            InitializeComponent();
            listaPesos = new PesoRespostaBLL().ObterTodos();
            listaPerguntas = perguntaBLL.ObterPerguntasAleatoriamente();
            ProximaPergunta();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btConfirma_Click(object sender, EventArgs e)
        {
            ConfirmaResposta();
            ValidaResposta(perguntaAtual);
        }

        private void ConfirmaResposta()
        {
            
            DialogResult dialogResult = MessageBox.Show($"Você selecionou Alternativa {alternativaSelecionada}\nConfirma sua resposta?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (dialogResult == DialogResult.Yes)
            {
                SalvaResposta();
                //validaResposta();
                CalculaNota();
                ProximaPergunta();
                
            }
            
        }

        private void Pergunta_Load(object sender, EventArgs e)
        {
        }


        private void Pergunta_Shown(object sender, EventArgs e)
        {

        }

        private void ProximaPergunta()
        {       
            List<string> alternativas = new List<string>{ "A. ", "B. ", "C. ", "D. " };
            
            int j = 0;

            listaRespostas = new RespostaBLL().ObterPeloExemplo(new RespostaModel { IdPergunta = listaPerguntas[i].IdPergunta });


            if (i+1 >= listaPerguntas.Count)
            {
                btConfirma.Visible = false;
                btFinalizar.Visible = true;

            }

            
            /*foreach (PerguntaModel pergunta in ListaPerguntas)
            {
                lblPergunta.Text = pergunta.Descricao;
            } */
            rTBPergunta.Text = listaPerguntas[i].Descricao;
            perguntaAtual = listaPerguntas[i];
            if(perguntaAtual.Tipo == "PE")
            {
            }
            i++;

            lblAlternativas.Text = "";

            foreach (RespostaModel resposta in listaRespostas)
            {
                lblAlternativas.Text += alternativas[j];
                btAltA.Tag = resposta.IdResposta;
                j++;
                lblAlternativas.Text += resposta.Descricao + "\n\n" ;

            }
        }

        private void ValidaResposta(PerguntaModel pergunta)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            som.Gota().Play();
            alternativaSelecionada = "A";
            SalvaResposta();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            som.Gota().Play();
            alternativaSelecionada = "B";
            SalvaResposta();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            som.Gota().Play();
            alternativaSelecionada = "C";
            SalvaResposta();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            som.Gota().Play();
            alternativaSelecionada = "D";
            SalvaResposta();
        }

        private void lblAlternativas_Click(object sender, EventArgs e)
        {

        }

        private void btFinalizar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show($"Você selecionou Alternativa {alternativaSelecionada}\nConfirma sua resposta?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (dialogResult == DialogResult.Yes)
            {
                TelaResultado();
                //TO DO calculaResultado();
            }
        }

        private void TelaResultado()
        {
            if (funcoes.SingletonForms("Resultado") == false)
            {
                new Resultado(pontuacao, acertos).Show();
            }

        }

        private void SalvaResposta()
        {

            RespostaModel respostaPergunta = respostasUsuario.Find(x => x.IdPergunta.Equals(perguntaAtual.IdPergunta));

            if (respostaPergunta != null)
            {
                respostasUsuario.Remove(respostaPergunta);
            }
            switch (alternativaSelecionada)
            {
                case "A":
                    respostasUsuario.Add(new RespostaModel { IdPergunta = perguntaAtual.IdPergunta, IdResposta = listaRespostas[0].IdResposta });
                    break;

                case "B":
                    respostasUsuario.Add(new RespostaModel { IdPergunta = perguntaAtual.IdPergunta, IdResposta = listaRespostas[1].IdResposta });
                    break;

                case "C":
                    respostasUsuario.Add(new RespostaModel { IdPergunta = perguntaAtual.IdPergunta, IdResposta = listaRespostas[2].IdResposta });
                    break;

                case "D":
                    respostasUsuario.Add(new RespostaModel { IdPergunta = perguntaAtual.IdPergunta, IdResposta = listaRespostas[3].IdResposta });
                    break;
            }
        }

        private void CalculaNota()
        {
            RespostaModel resposta = respostasUsuario.Last();

            if (perguntaAtual.Tipo == "PE")
            {
                pontuacao += listaPesos.Find(x => x.IdResposta.Equals(respostasUsuario.Last().IdResposta)).Peso;
            }
            else
            {
                if (gabaritoBLL.VerificarRespostaCorreta(resposta.IdPergunta, resposta.IdResposta))
                {
                    acertos++;
                }
            }
        }
    }
}
