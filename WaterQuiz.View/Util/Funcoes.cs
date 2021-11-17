using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace WaterQuiz.View.Util
{
    class Funcoes
    {
        public bool SingletonForms(string nomeForm)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.Name == nomeForm)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
