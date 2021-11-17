using System;
using System.Collections.Generic;
using System.IO;
using System.Media;
using System.Text;
using System.Windows.Forms;

namespace WaterQuiz.View.Util
{
    class Som
    {
        static string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;

        public SoundPlayer ShowDoMilhao()
        {
            return new SoundPlayer(projectDirectory + "\\Resources\\Show-do-Milhão-Musica-de-Seleção-de-Perguntas-1999_128k.wav");
        }

        public SoundPlayer Gota()
        {
            return new SoundPlayer(projectDirectory + "\\Resources\\SomGota.wav");
        }

        
    }
}
