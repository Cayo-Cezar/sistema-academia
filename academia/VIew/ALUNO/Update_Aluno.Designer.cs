namespace WillFit_System.VIew.Aluno
{
    partial class Update_Aluno
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
            label10 = new Label();
            TXB_NOME_UPDATE = new TextBox();
            TXB_CPF_UPDATE = new TextBox();
            TXB_TELEFONE_UPDATE = new TextBox();
            TXB_MATRICULA_UPDATE = new TextBox();
            BTN_ATUALIZAR = new Button();
            btn_voltar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(21, 22);
            label1.Name = "label1";
            label1.Size = new Size(289, 31);
            label1.TabIndex = 0;
            label1.Text = "ATUALIZAÇÃO CADASTRAL";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(21, 83);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 1;
            label2.Text = "NOME";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(31, 184);
            label3.Name = "label3";
            label3.Size = new Size(33, 20);
            label3.TabIndex = 2;
            label3.Text = "CPF";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(12, 135);
            label4.Name = "label4";
            label4.Size = new Size(81, 20);
            label4.TabIndex = 3;
            label4.Text = "TELEFONE ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = SystemColors.ButtonHighlight;
            label10.Location = new Point(12, 235);
            label10.Name = "label10";
            label10.Size = new Size(88, 20);
            label10.TabIndex = 10;
            label10.Text = "MATRÍCULA";
            label10.Click += label10_Click;
            // 
            // TXB_NOME_UPDATE
            // 
            TXB_NOME_UPDATE.Location = new Point(106, 83);
            TXB_NOME_UPDATE.Name = "TXB_NOME_UPDATE";
            TXB_NOME_UPDATE.Size = new Size(233, 27);
            TXB_NOME_UPDATE.TabIndex = 11;
            TXB_NOME_UPDATE.TextChanged += TXB_NOME_UPDATE_TextChanged;
            // 
            // TXB_CPF_UPDATE
            // 
            TXB_CPF_UPDATE.Location = new Point(106, 184);
            TXB_CPF_UPDATE.Name = "TXB_CPF_UPDATE";
            TXB_CPF_UPDATE.Size = new Size(245, 27);
            TXB_CPF_UPDATE.TabIndex = 12;
            TXB_CPF_UPDATE.TextChanged += TXB_CPF_UPDATE_TextChanged;
            // 
            // TXB_TELEFONE_UPDATE
            // 
            TXB_TELEFONE_UPDATE.Location = new Point(106, 135);
            TXB_TELEFONE_UPDATE.Name = "TXB_TELEFONE_UPDATE";
            TXB_TELEFONE_UPDATE.Size = new Size(233, 27);
            TXB_TELEFONE_UPDATE.TabIndex = 13;
            TXB_TELEFONE_UPDATE.TextChanged += TXB_TELEFONE_UPDATE_TextChanged;
            // 
            // TXB_MATRICULA_UPDATE
            // 
            TXB_MATRICULA_UPDATE.Location = new Point(106, 235);
            TXB_MATRICULA_UPDATE.Name = "TXB_MATRICULA_UPDATE";
            TXB_MATRICULA_UPDATE.Size = new Size(245, 27);
            TXB_MATRICULA_UPDATE.TabIndex = 14;
            TXB_MATRICULA_UPDATE.TextChanged += TXB_MATRICULA_UPDATE_TextChanged;
            // 
            // BTN_ATUALIZAR
            // 
            BTN_ATUALIZAR.Location = new Point(12, 337);
            BTN_ATUALIZAR.Name = "BTN_ATUALIZAR";
            BTN_ATUALIZAR.Size = new Size(133, 29);
            BTN_ATUALIZAR.TabIndex = 19;
            BTN_ATUALIZAR.Text = "ATUALIZAR";
            BTN_ATUALIZAR.UseVisualStyleBackColor = true;
            BTN_ATUALIZAR.Click += BTN_ATUALIZAR_Click;
            // 
            // btn_voltar
            // 
            btn_voltar.Location = new Point(169, 337);
            btn_voltar.Name = "btn_voltar";
            btn_voltar.Size = new Size(114, 29);
            btn_voltar.TabIndex = 20;
            btn_voltar.Text = "Voltar";
            btn_voltar.UseVisualStyleBackColor = true;
            btn_voltar.Click += btn_voltar_Click;
            // 
            // Update_Aluno
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Goldenrod;
            ClientSize = new Size(818, 450);
            Controls.Add(btn_voltar);
            Controls.Add(BTN_ATUALIZAR);
            Controls.Add(TXB_MATRICULA_UPDATE);
            Controls.Add(TXB_TELEFONE_UPDATE);
            Controls.Add(TXB_CPF_UPDATE);
            Controls.Add(TXB_NOME_UPDATE);
            Controls.Add(label10);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Update_Aluno";
            Text = "Update_Aluno";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label10;
        private TextBox TXB_NOME_UPDATE;
        private TextBox TXB_CPF_UPDATE;
        private TextBox TXB_TELEFONE_UPDATE;
        private TextBox TXB_MATRICULA_UPDATE;
        private Button BTN_ATUALIZAR;
        private Button btn_voltar;
    }
}