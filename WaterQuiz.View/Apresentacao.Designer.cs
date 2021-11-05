
namespace WaterQuiz.View
{
    partial class Apresentacao
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Apresentacao));
            this.label1 = new System.Windows.Forms.Label();
            this.tBNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btPlay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(267, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "WaterQuiz";
            // 
            // tBNome
            // 
            this.tBNome.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tBNome.Location = new System.Drawing.Point(275, 229);
            this.tBNome.Name = "tBNome";
            this.tBNome.Size = new System.Drawing.Size(234, 46);
            this.tBNome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(219, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(347, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Insira seu nome e vamos jogar!";
            // 
            // btPlay
            // 
            this.btPlay.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btPlay.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btPlay.Location = new System.Drawing.Point(293, 348);
            this.btPlay.Name = "btPlay";
            this.btPlay.Size = new System.Drawing.Size(216, 78);
            this.btPlay.TabIndex = 3;
            this.btPlay.Text = "PLAY";
            this.btPlay.UseVisualStyleBackColor = false;
            this.btPlay.Click += new System.EventHandler(this.btPlay_Click);
            // 
            // Apresentacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btPlay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tBNome);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Apresentacao";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btPlay;
    }
}

