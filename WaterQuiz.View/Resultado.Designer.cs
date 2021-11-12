
namespace WaterQuiz.View
{
    partial class Resultado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.rTBPontuacao = new System.Windows.Forms.RichTextBox();
            this.btTentarNovamente = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.rTBAcertos = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(103, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(578, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "SUA PONTUAÇÃO FOI DE:";
            // 
            // rTBPontuacao
            // 
            this.rTBPontuacao.BackColor = System.Drawing.Color.LightSkyBlue;
            this.rTBPontuacao.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.rTBPontuacao.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rTBPontuacao.ForeColor = System.Drawing.SystemColors.WindowText;
            this.rTBPontuacao.Location = new System.Drawing.Point(327, 133);
            this.rTBPontuacao.Multiline = false;
            this.rTBPontuacao.Name = "rTBPontuacao";
            this.rTBPontuacao.ReadOnly = true;
            this.rTBPontuacao.Size = new System.Drawing.Size(130, 71);
            this.rTBPontuacao.TabIndex = 1;
            this.rTBPontuacao.Text = "999";
            // 
            // btTentarNovamente
            // 
            this.btTentarNovamente.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btTentarNovamente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btTentarNovamente.FlatAppearance.BorderSize = 2;
            this.btTentarNovamente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTentarNovamente.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btTentarNovamente.Location = new System.Drawing.Point(291, 404);
            this.btTentarNovamente.Name = "btTentarNovamente";
            this.btTentarNovamente.Size = new System.Drawing.Size(202, 60);
            this.btTentarNovamente.TabIndex = 2;
            this.btTentarNovamente.Text = "Tentar Novamente";
            this.btTentarNovamente.UseVisualStyleBackColor = false;
            this.btTentarNovamente.Click += new System.EventHandler(this.btTentarNovamente_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(280, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 65);
            this.label2.TabIndex = 3;
            this.label2.Text = "ACERTOS";
            // 
            // rTBAcertos
            // 
            this.rTBAcertos.BackColor = System.Drawing.Color.LightSkyBlue;
            this.rTBAcertos.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.rTBAcertos.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rTBAcertos.ForeColor = System.Drawing.SystemColors.WindowText;
            this.rTBAcertos.Location = new System.Drawing.Point(369, 305);
            this.rTBAcertos.Multiline = false;
            this.rTBAcertos.Name = "rTBAcertos";
            this.rTBAcertos.ReadOnly = true;
            this.rTBAcertos.Size = new System.Drawing.Size(34, 71);
            this.rTBAcertos.TabIndex = 4;
            this.rTBAcertos.Text = "2";
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.richTextBox2.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBox2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.richTextBox2.Location = new System.Drawing.Point(411, 305);
            this.richTextBox2.Multiline = false;
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(46, 71);
            this.richTextBox2.TabIndex = 5;
            this.richTextBox2.Text = "/2";
            this.richTextBox2.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // Resultado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.rTBAcertos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btTentarNovamente);
            this.Controls.Add(this.rTBPontuacao);
            this.Controls.Add(this.label1);
            this.Name = "Resultado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resultado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rTBPontuacao;
        private System.Windows.Forms.Button btTentarNovamente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rTBAcertos;
        private System.Windows.Forms.RichTextBox richTextBox2;
    }
}