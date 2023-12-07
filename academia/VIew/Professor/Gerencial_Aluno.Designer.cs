namespace WillFit_System.VIew.Professor
{
    partial class Gerencial_Aluno
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
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            btn_voltar = new Button();
            btn_ver_professores = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(240, 30);
            label1.Name = "label1";
            label1.Size = new Size(272, 31);
            label1.TabIndex = 0;
            label1.Text = "GERENCIAMENTO GERAL";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(71, 175);
            button1.Name = "button1";
            button1.Size = new Size(153, 29);
            button1.TabIndex = 1;
            button1.Text = "Cadastrar Aluno";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(68, 244);
            button2.Name = "button2";
            button2.Size = new Size(156, 29);
            button2.TabIndex = 2;
            button2.Text = "Atualizar Aluno";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(68, 311);
            button3.Name = "button3";
            button3.Size = new Size(156, 29);
            button3.TabIndex = 3;
            button3.Text = "Deletar Aluno";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(64, 379);
            button4.Name = "button4";
            button4.Size = new Size(160, 29);
            button4.TabIndex = 4;
            button4.Text = "Ver Alunos";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(466, 175);
            button5.Name = "button5";
            button5.Size = new Size(194, 29);
            button5.TabIndex = 5;
            button5.Text = "Criar Treinos";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(470, 284);
            button6.Name = "button6";
            button6.Size = new Size(190, 29);
            button6.TabIndex = 6;
            button6.Text = "Cadastrar Professores";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // btn_voltar
            // 
            btn_voltar.Location = new Point(701, 420);
            btn_voltar.Name = "btn_voltar";
            btn_voltar.Size = new Size(119, 34);
            btn_voltar.TabIndex = 7;
            btn_voltar.Text = "Voltar";
            btn_voltar.UseVisualStyleBackColor = true;
            btn_voltar.Click += btn_voltar_Click;
            // 
            // btn_ver_professores
            // 
            btn_ver_professores.Location = new Point(466, 379);
            btn_ver_professores.Name = "btn_ver_professores";
            btn_ver_professores.Size = new Size(184, 30);
            btn_ver_professores.TabIndex = 8;
            btn_ver_professores.Text = "Ver Professores";
            btn_ver_professores.UseVisualStyleBackColor = true;
            btn_ver_professores.Click += btn_ver_professores_Click;
            // 
            // Gerencial_Aluno
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Goldenrod;
            ClientSize = new Size(854, 478);
            Controls.Add(btn_ver_professores);
            Controls.Add(btn_voltar);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Gerencial_Aluno";
            Text = "Gerencial_Aluno";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button btn_voltar;
        private Button btn_ver_professores;
    }
}