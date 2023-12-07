namespace WillFit_System
{
    partial class Tela_aluno
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
            label1 = new Label();
            button1 = new Button();
            btn_voltar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Myanmar Text", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(32, 18);
            label1.Name = "label1";
            label1.Size = new Size(327, 53);
            label1.TabIndex = 0;
            label1.Text = "BEM VINDO ALUNO(A)";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(32, 100);
            button1.Name = "button1";
            button1.Size = new Size(167, 53);
            button1.TabIndex = 1;
            button1.Text = "VER TREINOS";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btn_voltar
            // 
            btn_voltar.Location = new Point(32, 203);
            btn_voltar.Name = "btn_voltar";
            btn_voltar.Size = new Size(164, 52);
            btn_voltar.TabIndex = 9;
            btn_voltar.Text = "Voltar";
            btn_voltar.UseVisualStyleBackColor = true;
            btn_voltar.Click += btn_voltar_Click;

            // 
            // Tela_aluno
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Goldenrod;
            ClientSize = new Size(875, 482);
            Controls.Add(btn_voltar);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Tela_aluno";
            Text = "Tela_aluno";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button btn_voltar;
    }
}