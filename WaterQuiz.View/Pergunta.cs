using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Media;
using System.Text;
using System.Windows.Forms;

namespace WaterQuiz.View
{
    public partial class Pergunta : Form
    {
       

        public Pergunta()
        {
            InitializeComponent();
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
        }

        private void ConfirmaResposta()
        {
            DialogResult dialogResult = MessageBox.Show("Você tem certeza?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (dialogResult == DialogResult.Yes)
            {
                //validaResposta();
                //proximaPergunta();
            }

        }

        private void Pergunta_Load(object sender, EventArgs e)
        {

        }

        private void rBAlt1_CheckedChanged(object sender, EventArgs e)
        {
            string projectDirectaory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
            SoundPlayer somGota = new SoundPlayer(projectDirectaory + "\\Resources\\SomGota.wav");
            somGota.Play();
        }
    }
}
