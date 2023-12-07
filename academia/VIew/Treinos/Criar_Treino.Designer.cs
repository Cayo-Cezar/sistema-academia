namespace WillFit_System.VIew.Treinos
{
    partial class Criar_Treino
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            BTN_CRIAR_TREINO = new Button();
            TXB_NOME_TREINO = new TextBox();
            TXB_REPETICOES = new TextBox();
            TXB_EQUIPAMENTOS = new TextBox();
            TXB_MAT_ALUNO_TREINO = new TextBox();
            btn_voltar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(245, 36);
            label1.Name = "label1";
            label1.Size = new Size(161, 31);
            label1.TabIndex = 0;
            label1.Text = "CRIAR TREINO";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 87);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(93, 104);
            label3.Name = "label3";
            label3.Size = new Size(107, 20);
            label3.TabIndex = 2;
            label3.Text = "NOME TREINO";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(93, 215);
            label4.Name = "label4";
            label4.Size = new Size(90, 20);
            label4.TabIndex = 3;
            label4.Text = "REPETIÇÕES";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(401, 104);
            label5.Name = "label5";
            label5.Size = new Size(117, 20);
            label5.TabIndex = 4;
            label5.Text = "EQUIPAMENTOS";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(401, 215);
            label6.Name = "label6";
            label6.Size = new Size(141, 20);
            label6.TabIndex = 5;
            label6.Text = "MATRÍCULA ALUNO";
            // 
            // BTN_CRIAR_TREINO
            // 
            BTN_CRIAR_TREINO.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BTN_CRIAR_TREINO.Location = new Point(222, 323);
            BTN_CRIAR_TREINO.Name = "BTN_CRIAR_TREINO";
            BTN_CRIAR_TREINO.Size = new Size(184, 34);
            BTN_CRIAR_TREINO.TabIndex = 6;
            BTN_CRIAR_TREINO.Text = "CRIAR TREINO";
            BTN_CRIAR_TREINO.UseVisualStyleBackColor = true;
            BTN_CRIAR_TREINO.Click += BTN_CRIAR_TREINO_Click;
            // 
            // TXB_NOME_TREINO
            // 
            TXB_NOME_TREINO.Location = new Point(75, 136);
            TXB_NOME_TREINO.Name = "TXB_NOME_TREINO";
            TXB_NOME_TREINO.Size = new Size(165, 27);
            TXB_NOME_TREINO.TabIndex = 7;
            // 
            // TXB_REPETICOES
            // 
            TXB_REPETICOES.Location = new Point(77, 252);
            TXB_REPETICOES.Name = "TXB_REPETICOES";
            TXB_REPETICOES.Size = new Size(125, 27);
            TXB_REPETICOES.TabIndex = 8;
            // 
            // TXB_EQUIPAMENTOS
            // 
            TXB_EQUIPAMENTOS.Location = new Point(401, 136);
            TXB_EQUIPAMENTOS.Name = "TXB_EQUIPAMENTOS";
            TXB_EQUIPAMENTOS.Size = new Size(125, 27);
            TXB_EQUIPAMENTOS.TabIndex = 9;
            // 
            // TXB_MAT_ALUNO_TREINO
            // 
            TXB_MAT_ALUNO_TREINO.Location = new Point(401, 262);
            TXB_MAT_ALUNO_TREINO.Name = "TXB_MAT_ALUNO_TREINO";
            TXB_MAT_ALUNO_TREINO.Size = new Size(125, 27);
            TXB_MAT_ALUNO_TREINO.TabIndex = 10;
            // 
            // btn_voltar
            // 
            btn_voltar.Location = new Point(490, 323);
            btn_voltar.Name = "btn_voltar";
            btn_voltar.Size = new Size(108, 32);
            btn_voltar.TabIndex = 11;
            btn_voltar.Text = "Voltar";
            btn_voltar.UseVisualStyleBackColor = true;
            btn_voltar.Click += btn_voltar_Click;
            // 
            // Criar_Treino
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Goldenrod;
            ClientSize = new Size(633, 386);
            Controls.Add(btn_voltar);
            Controls.Add(TXB_MAT_ALUNO_TREINO);
            Controls.Add(TXB_EQUIPAMENTOS);
            Controls.Add(TXB_REPETICOES);
            Controls.Add(TXB_NOME_TREINO);
            Controls.Add(BTN_CRIAR_TREINO);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Criar_Treino";
            Text = "Criar_Treino";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button BTN_CRIAR_TREINO;
        private TextBox TXB_NOME_TREINO;
        private TextBox TXB_REPETICOES;
        private TextBox TXB_EQUIPAMENTOS;
        private TextBox TXB_MAT_ALUNO_TREINO;
        private Button btn_voltar;
    }
}