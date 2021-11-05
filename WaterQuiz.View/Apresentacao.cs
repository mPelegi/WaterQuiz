using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WaterQuiz.View
{
    public partial class Apresentacao : Form
    {
        Pergunta FormPergunta = new Pergunta();
        public Apresentacao()
        {
            InitializeComponent();
        }

        private void btPlay_Click(object sender, EventArgs e)
        {
            string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
            SoundPlayer simpleSound = new SoundPlayer(projectDirectory + "\\Resources\\Show-do-Milhão-Musica-de-Seleção-de-Perguntas-1999_128k.wav");
            simpleSound.Play();

            //Application.Exit(Apresentacao);
            FormPergunta.Show();

        }
    }
}
