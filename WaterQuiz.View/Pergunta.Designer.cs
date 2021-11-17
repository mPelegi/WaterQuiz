
namespace WaterQuiz.View
{
    partial class Pergunta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pergunta));
            this.panelPergunta = new System.Windows.Forms.Panel();
            this.rTBPergunta = new System.Windows.Forms.RichTextBox();
            this.panelResposta = new System.Windows.Forms.Panel();
            this.btAltD = new System.Windows.Forms.Button();
            this.btAltC = new System.Windows.Forms.Button();
            this.btAltB = new System.Windows.Forms.Button();
            this.btAltA = new System.Windows.Forms.Button();
            this.panelAlternativas = new System.Windows.Forms.Panel();
            this.lblAlternativas = new System.Windows.Forms.Label();
            this.btConfirma = new System.Windows.Forms.Button();
            this.btVoltar = new System.Windows.Forms.Button();
            this.btFinalizar = new System.Windows.Forms.Button();
            this.panelPergunta.SuspendLayout();
            this.panelResposta.SuspendLayout();
            this.panelAlternativas.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPergunta
            // 
            this.panelPergunta.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelPergunta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelPergunta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelPergunta.Controls.Add(this.rTBPergunta);
            this.panelPergunta.Location = new System.Drawing.Point(13, 3);
            this.panelPergunta.Name = "panelPergunta";
            this.panelPergunta.Size = new System.Drawing.Size(759, 210);
            this.panelPergunta.TabIndex = 0;
            // 
            // rTBPergunta
            // 
            this.rTBPergunta.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.rTBPergunta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rTBPergunta.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rTBPergunta.Location = new System.Drawing.Point(3, 3);
            this.rTBPergunta.Name = "rTBPergunta";
            this.rTBPergunta.ReadOnly = true;
            this.rTBPergunta.Size = new System.Drawing.Size(749, 200);
            this.rTBPergunta.TabIndex = 0;
            this.rTBPergunta.Text = "";
            // 
            // panelResposta
            // 
            this.panelResposta.BackColor = System.Drawing.Color.LightGray;
            this.panelResposta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelResposta.Controls.Add(this.btAltD);
            this.panelResposta.Controls.Add(this.btAltC);
            this.panelResposta.Controls.Add(this.btAltB);
            this.panelResposta.Controls.Add(this.btAltA);
            this.panelResposta.Controls.Add(this.panelAlternativas);
            this.panelResposta.Location = new System.Drawing.Point(13, 219);
            this.panelResposta.Name = "panelResposta";
            this.panelResposta.Size = new System.Drawing.Size(759, 297);
            this.panelResposta.TabIndex = 1;
            // 
            // btAltD
            // 
            this.btAltD.BackColor = System.Drawing.Color.DodgerBlue;
            this.btAltD.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btAltD.FlatAppearance.BorderSize = 2;
            this.btAltD.FlatAppearance.CheckedBackColor = System.Drawing.Color.Blue;
            this.btAltD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAltD.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btAltD.Location = new System.Drawing.Point(575, 242);
            this.btAltD.Name = "btAltD";
            this.btAltD.Size = new System.Drawing.Size(147, 50);
            this.btAltD.TabIndex = 4;
            this.btAltD.Text = "D";
            this.btAltD.UseVisualStyleBackColor = false;
            this.btAltD.Click += new System.EventHandler(this.button4_Click);
            // 
            // btAltC
            // 
            this.btAltC.BackColor = System.Drawing.Color.DodgerBlue;
            this.btAltC.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btAltC.FlatAppearance.BorderSize = 2;
            this.btAltC.FlatAppearance.CheckedBackColor = System.Drawing.Color.Blue;
            this.btAltC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAltC.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btAltC.Location = new System.Drawing.Point(395, 242);
            this.btAltC.Name = "btAltC";
            this.btAltC.Size = new System.Drawing.Size(147, 50);
            this.btAltC.TabIndex = 3;
            this.btAltC.Text = "C";
            this.btAltC.UseVisualStyleBackColor = false;
            this.btAltC.Click += new System.EventHandler(this.button3_Click);
            // 
            // btAltB
            // 
            this.btAltB.BackColor = System.Drawing.Color.DodgerBlue;
            this.btAltB.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btAltB.FlatAppearance.BorderSize = 2;
            this.btAltB.FlatAppearance.CheckedBackColor = System.Drawing.Color.Blue;
            this.btAltB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAltB.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btAltB.Location = new System.Drawing.Point(215, 242);
            this.btAltB.Name = "btAltB";
            this.btAltB.Size = new System.Drawing.Size(147, 50);
            this.btAltB.TabIndex = 2;
            this.btAltB.Text = "B";
            this.btAltB.UseVisualStyleBackColor = false;
            this.btAltB.Click += new System.EventHandler(this.button2_Click);
            // 
            // btAltA
            // 
            this.btAltA.BackColor = System.Drawing.Color.DodgerBlue;
            this.btAltA.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btAltA.FlatAppearance.BorderSize = 2;
            this.btAltA.FlatAppearance.CheckedBackColor = System.Drawing.Color.Blue;
            this.btAltA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAltA.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btAltA.Location = new System.Drawing.Point(35, 242);
            this.btAltA.Name = "btAltA";
            this.btAltA.Size = new System.Drawing.Size(147, 50);
            this.btAltA.TabIndex = 1;
            this.btAltA.Text = "A";
            this.btAltA.UseVisualStyleBackColor = false;
            this.btAltA.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelAlternativas
            // 
            this.panelAlternativas.Controls.Add(this.lblAlternativas);
            this.panelAlternativas.Location = new System.Drawing.Point(10, 3);
            this.panelAlternativas.Name = "panelAlternativas";
            this.panelAlternativas.Size = new System.Drawing.Size(738, 233);
            this.panelAlternativas.TabIndex = 0;
            // 
            // lblAlternativas
            // 
            this.lblAlternativas.AutoSize = true;
            this.lblAlternativas.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAlternativas.Location = new System.Drawing.Point(12, 3);
            this.lblAlternativas.Name = "lblAlternativas";
            this.lblAlternativas.Size = new System.Drawing.Size(0, 25);
            this.lblAlternativas.TabIndex = 0;
            this.lblAlternativas.Click += new System.EventHandler(this.lblAlternativas_Click);
            // 
            // btConfirma
            // 
            this.btConfirma.BackColor = System.Drawing.Color.DodgerBlue;
            this.btConfirma.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btConfirma.FlatAppearance.BorderSize = 2;
            this.btConfirma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btConfirma.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btConfirma.Location = new System.Drawing.Point(648, 522);
            this.btConfirma.Name = "btConfirma";
            this.btConfirma.Size = new System.Drawing.Size(113, 32);
            this.btConfirma.TabIndex = 4;
            this.btConfirma.Text = "CONFIRMAR";
            this.btConfirma.UseVisualStyleBackColor = false;
            this.btConfirma.Click += new System.EventHandler(this.btConfirma_Click);
            // 
            // btVoltar
            // 
            this.btVoltar.BackColor = System.Drawing.Color.LightCoral;
            this.btVoltar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btVoltar.FlatAppearance.BorderSize = 2;
            this.btVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btVoltar.Location = new System.Drawing.Point(23, 522);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(113, 32);
            this.btVoltar.TabIndex = 5;
            this.btVoltar.Text = "VOLTAR";
            this.btVoltar.UseVisualStyleBackColor = false;
            // 
            // btFinalizar
            // 
            this.btFinalizar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btFinalizar.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btFinalizar.FlatAppearance.BorderSize = 2;
            this.btFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFinalizar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btFinalizar.Location = new System.Drawing.Point(529, 522);
            this.btFinalizar.Name = "btFinalizar";
            this.btFinalizar.Size = new System.Drawing.Size(113, 32);
            this.btFinalizar.TabIndex = 6;
            this.btFinalizar.Text = "FINALIZAR";
            this.btFinalizar.UseVisualStyleBackColor = false;
            this.btFinalizar.Visible = false;
            this.btFinalizar.Click += new System.EventHandler(this.btFinalizar_Click);
            // 
            // Pergunta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btFinalizar);
            this.Controls.Add(this.btVoltar);
            this.Controls.Add(this.btConfirma);
            this.Controls.Add(this.panelResposta);
            this.Controls.Add(this.panelPergunta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pergunta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pergunta";
            this.Load += new System.EventHandler(this.Pergunta_Load);
            this.Shown += new System.EventHandler(this.Pergunta_Shown);
            this.panelPergunta.ResumeLayout(false);
            this.panelResposta.ResumeLayout(false);
            this.panelAlternativas.ResumeLayout(false);
            this.panelAlternativas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPergunta;
        private System.Windows.Forms.Panel panelResposta;
        private System.Windows.Forms.Button btConfirma;
        private System.Windows.Forms.Button btVoltar;
        private System.Windows.Forms.Button btAltD;
        private System.Windows.Forms.Button btAltC;
        private System.Windows.Forms.Button btAltB;
        private System.Windows.Forms.Button btAltA;
        private System.Windows.Forms.Panel panelAlternativas;
        private System.Windows.Forms.Label lblAlternativas;
        private System.Windows.Forms.RichTextBox rTBPergunta;
        private System.Windows.Forms.Button btFinalizar;
    }
}