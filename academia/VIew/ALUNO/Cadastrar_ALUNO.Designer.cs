namespace WillFit_System.VIew.Aluno
{
    partial class Cadastrar_ALUNO
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
            lbl_cad_aluno = new Label();
            lbl_cpf_aluno = new Label();
            lbl_cad_telefone = new Label();
            lbl_matricula_Cad = new Label();
            TXB_NOME_CAD = new TextBox();
            TXB_CPF_CAD = new TextBox();
            TXB_TELEFONE_CAD = new TextBox();
            TXB_MATRICULA_CAD = new TextBox();
            btn_cadastrar_aluno = new Button();
            btn_voltar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rockwell", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(31, 21);
            label1.Name = "label1";
            label1.Size = new Size(226, 31);
            label1.TabIndex = 0;
            label1.Text = "Cadastrar Aluno";
            // 
            // lbl_cad_aluno
            // 
            lbl_cad_aluno.AutoSize = true;
            lbl_cad_aluno.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_cad_aluno.Location = new Point(31, 83);
            lbl_cad_aluno.Name = "lbl_cad_aluno";
            lbl_cad_aluno.Size = new Size(66, 28);
            lbl_cad_aluno.TabIndex = 1;
            lbl_cad_aluno.Text = "Nome";
            // 
            // lbl_cpf_aluno
            // 
            lbl_cpf_aluno.AutoSize = true;
            lbl_cpf_aluno.Location = new Point(31, 230);
            lbl_cpf_aluno.Name = "lbl_cpf_aluno";
            lbl_cpf_aluno.Size = new Size(36, 20);
            lbl_cpf_aluno.TabIndex = 2;
            lbl_cpf_aluno.Text = "CPF:";
            // 
            // lbl_cad_telefone
            // 
            lbl_cad_telefone.AutoSize = true;
            lbl_cad_telefone.Location = new Point(31, 155);
            lbl_cad_telefone.Name = "lbl_cad_telefone";
            lbl_cad_telefone.Size = new Size(66, 20);
            lbl_cad_telefone.TabIndex = 3;
            lbl_cad_telefone.Text = "Telefone";
            // 
            // lbl_matricula_Cad
            // 
            lbl_matricula_Cad.AutoSize = true;
            lbl_matricula_Cad.Location = new Point(31, 297);
            lbl_matricula_Cad.Name = "lbl_matricula_Cad";
            lbl_matricula_Cad.Size = new Size(71, 20);
            lbl_matricula_Cad.TabIndex = 4;
            lbl_matricula_Cad.Text = "Matrícula";
            // 
            // TXB_NOME_CAD
            // 
            TXB_NOME_CAD.Location = new Point(115, 87);
            TXB_NOME_CAD.Name = "TXB_NOME_CAD";
            TXB_NOME_CAD.Size = new Size(196, 27);
            TXB_NOME_CAD.TabIndex = 10;
            TXB_NOME_CAD.TextChanged += TXB_NOME_CAD_TextChanged;
            // 
            // TXB_CPF_CAD
            // 
            TXB_CPF_CAD.Location = new Point(113, 227);
            TXB_CPF_CAD.Name = "TXB_CPF_CAD";
            TXB_CPF_CAD.Size = new Size(198, 27);
            TXB_CPF_CAD.TabIndex = 11;
            TXB_CPF_CAD.TextChanged += TXB_CPF_CAD_TextChanged;
            // 
            // TXB_TELEFONE_CAD
            // 
            TXB_TELEFONE_CAD.Location = new Point(115, 155);
            TXB_TELEFONE_CAD.Name = "TXB_TELEFONE_CAD";
            TXB_TELEFONE_CAD.Size = new Size(196, 27);
            TXB_TELEFONE_CAD.TabIndex = 12;
            TXB_TELEFONE_CAD.TextChanged += TXB_TELEFONE_CAD_TextChanged;
            // 
            // TXB_MATRICULA_CAD
            // 
            TXB_MATRICULA_CAD.Location = new Point(113, 297);
            TXB_MATRICULA_CAD.Name = "TXB_MATRICULA_CAD";
            TXB_MATRICULA_CAD.RightToLeft = RightToLeft.Yes;
            TXB_MATRICULA_CAD.Size = new Size(198, 27);
            TXB_MATRICULA_CAD.TabIndex = 13;
            TXB_MATRICULA_CAD.TextChanged += TXB_MATRICULA_CAD_TextChanged;
            // 
            // btn_cadastrar_aluno
            // 
            btn_cadastrar_aluno.ForeColor = Color.Black;
            btn_cadastrar_aluno.Location = new Point(113, 376);
            btn_cadastrar_aluno.Name = "btn_cadastrar_aluno";
            btn_cadastrar_aluno.Size = new Size(185, 45);
            btn_cadastrar_aluno.TabIndex = 19;
            btn_cadastrar_aluno.Text = "CADASTRAR";
            btn_cadastrar_aluno.UseVisualStyleBackColor = true;
            btn_cadastrar_aluno.Click += button1_Click;
            // 
            // btn_voltar
            // 
            btn_voltar.ForeColor = Color.DodgerBlue;
            btn_voltar.Location = new Point(331, 380);
            btn_voltar.Name = "btn_voltar";
            btn_voltar.Size = new Size(112, 41);
            btn_voltar.TabIndex = 20;
            btn_voltar.Text = "Voltar";
            btn_voltar.UseVisualStyleBackColor = true;
            btn_voltar.Click += btn_voltar_Click;
            // 
            // Cadastrar_ALUNO
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Goldenrod;
            ClientSize = new Size(824, 467);
            Controls.Add(btn_voltar);
            Controls.Add(btn_cadastrar_aluno);
            Controls.Add(TXB_MATRICULA_CAD);
            Controls.Add(TXB_TELEFONE_CAD);
            Controls.Add(TXB_CPF_CAD);
            Controls.Add(TXB_NOME_CAD);
            Controls.Add(lbl_matricula_Cad);
            Controls.Add(lbl_cad_telefone);
            Controls.Add(lbl_cpf_aluno);
            Controls.Add(lbl_cad_aluno);
            Controls.Add(label1);
            ForeColor = Color.GhostWhite;
            Name = "Cadastrar_ALUNO";
            Text = "Cadastrar ALUNO";
            Load += Cadastrar_ALUNO_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lbl_cad_aluno;
        private Label lbl_cpf_aluno;
        private Label lbl_cad_telefone;
        private Label lbl_matricula_Cad;
        private TextBox TXB_NOME_CAD;
        private TextBox TXB_CPF_CAD;
        private TextBox TXB_TELEFONE_CAD;
        private TextBox TXB_MATRICULA_CAD;
        private Button btn_cadastrar_aluno;
        private Button btn_voltar;
    }
}