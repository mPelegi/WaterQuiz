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
        Dictionary<int, int> perguntaResposta = new Dictionary<int, int>();
        List<RespostaModel> respostasUsuario = new List<RespostaModel>();
        List<RespostaModel> listaRespostas = new List<RespostaModel>();
        Resultado formResultado = new Resultado();
        Funcoes funcoes = new Funcoes();


        Som som = new Som();
        public Pergunta()
        {
            InitializeComponent();
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
                //validaResposta();
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
            List<PerguntaModel> listaPerguntas;
            PerguntaBLL perguntaBLL = new PerguntaBLL();
            
            listaPerguntas = perguntaBLL.ObterPerguntasAleatoriamente();
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
            RespostaModel respostaPergunta = respostasUsuario.Find(x => x.IdPergunta.Equals(perguntaAtual.IdPergunta));
            if (respostaPergunta != null)
            {
                respostasUsuario.Remove(respostaPergunta);
            }
            respostasUsuario.Add(new RespostaModel { IdPergunta = perguntaAtual.IdPergunta, IdResposta = listaRespostas[0].IdResposta });  

        }

        private void button2_Click(object sender, EventArgs e)
        {
            som.Gota().Play();
            alternativaSelecionada = "B";
            RespostaModel respostaPergunta = respostasUsuario.Find(x => x.IdPergunta.Equals(perguntaAtual.IdPergunta));
            if (respostaPergunta != null)
            {
                respostasUsuario.Remove(respostaPergunta);
            }
            respostasUsuario.Add(new RespostaModel { IdPergunta = perguntaAtual.IdPergunta, IdResposta = listaRespostas[1].IdResposta });
        }

        private void button3_Click(object sender, EventArgs e)
        {
            som.Gota().Play();
            alternativaSelecionada = "C";
            RespostaModel respostaPergunta = respostasUsuario.Find(x => x.IdPergunta.Equals(perguntaAtual.IdPergunta));
            if (respostaPergunta != null)
            {
                respostasUsuario.Remove(respostaPergunta);
            }
            respostasUsuario.Add(new RespostaModel { IdPergunta = perguntaAtual.IdPergunta, IdResposta = listaRespostas[2].IdResposta });
        }

        private void button4_Click(object sender, EventArgs e)
        {
            som.Gota().Play();
            alternativaSelecionada = "D";
            RespostaModel respostaPergunta = respostasUsuario.Find(x => x.IdPergunta.Equals(perguntaAtual.IdPergunta));
            if (respostaPergunta != null)
            {
                respostasUsuario.Remove(respostaPergunta);
            }
            respostasUsuario.Add(new RespostaModel { IdPergunta = perguntaAtual.IdPergunta, IdResposta = listaRespostas[3].IdResposta });
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
                formResultado.Show();
            }

        }
    }
}
