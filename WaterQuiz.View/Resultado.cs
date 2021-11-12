using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WaterQuiz.View
{
    public partial class Resultado : Form
    {
        Apresentacao apresentacao = new Apresentacao();
        decimal pontuacao;
        int acertos;
        public Resultado(decimal pontuacao, int acertos)
        {
            InitializeComponent();
            this.pontuacao = pontuacao;
            this.acertos = acertos;
            MostraPontuacao();

        }

        private void btTentarNovamente_Click(object sender, EventArgs e)
        {
            apresentacao.Show();

            for (int intIndex = Application.OpenForms.Count - 1; intIndex >= 0; intIndex--)
            {
                if (Application.OpenForms[intIndex] != this)
                    Application.OpenForms[intIndex].Close();
            }
        }

        private void MostraPontuacao()
        {
            rTBPontuacao.Text = pontuacao.ToString();
            rTBAcertos.Text = acertos.ToString();

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
