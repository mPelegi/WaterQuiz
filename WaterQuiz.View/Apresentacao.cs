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
using WaterQuiz.View.Util;

namespace WaterQuiz.View
{
    public partial class Apresentacao : Form
    {
        Pergunta FormPergunta;
        Som som = new Som();
        Funcoes funcoes = new Funcoes();
        public Apresentacao()
        {
            InitializeComponent();
        }

        private void btPlay_Click(object sender, EventArgs e)
        {
            FormPergunta = new Pergunta();
            

            if (!funcoes.SingletonForms("Pergunta"))
            {
                som.ShowDoMilhao().Play();
                //Application.Exit(Apresentacao);
                FormPergunta.Show();
            }



        }
    }
}
