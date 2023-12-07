namespace WillFit_System
{
    partial class Tela_professor
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
            btn_Crud_Alunos = new Button();
            btn_voltar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(50, 33);
            label1.Name = "label1";
            label1.Size = new Size(358, 38);
            label1.TabIndex = 0;
            label1.Text = "BEM VINDO PROFESSOR(A)";
            // 
            // btn_Crud_Alunos
            // 
            btn_Crud_Alunos.Location = new Point(50, 127);
            btn_Crud_Alunos.Name = "btn_Crud_Alunos";
            btn_Crud_Alunos.Size = new Size(178, 80);
            btn_Crud_Alunos.TabIndex = 1;
            btn_Crud_Alunos.Text = "Gerenciamento";
            btn_Crud_Alunos.UseVisualStyleBackColor = true;
            btn_Crud_Alunos.Click += button1_Click;
            // 
            // btn_voltar
            // 
            btn_voltar.Location = new Point(50, 275);
            btn_voltar.Name = "btn_voltar";
            btn_voltar.Size = new Size(178, 84);
            btn_voltar.TabIndex = 8;
            btn_voltar.Text = "Voltar";
            btn_voltar.UseVisualStyleBackColor = true;
            btn_voltar.Click += btn_voltar_Click;
            // 
            // Tela_professor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Goldenrod;
            ClientSize = new Size(865, 488);
            Controls.Add(btn_voltar);
            Controls.Add(btn_Crud_Alunos);
            Controls.Add(label1);
            Name = "Tela_professor";
            Text = "Tela_professor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn_Crud_Alunos;
        private Button btn_voltar;
    }
}