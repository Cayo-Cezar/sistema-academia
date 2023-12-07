namespace WillFit_System.VIew.ALUNO
{
    partial class Delete_Aluno
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
            lbl_delete_aluno = new Label();
            txb_cpf_delete_aluno = new TextBox();
            btn_deletar_aluno = new Button();
            btn_pesquisar_aluno = new Button();
            dataGridView1 = new DataGridView();
            btn_voltar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lbl_delete_aluno
            // 
            lbl_delete_aluno.AutoSize = true;
            lbl_delete_aluno.ForeColor = SystemColors.ButtonHighlight;
            lbl_delete_aluno.Location = new Point(485, 303);
            lbl_delete_aluno.Name = "lbl_delete_aluno";
            lbl_delete_aluno.Size = new Size(304, 20);
            lbl_delete_aluno.TabIndex = 0;
            lbl_delete_aluno.Text = "Informe o nome do aluno para ser removido";
            // 
            // txb_cpf_delete_aluno
            // 
            txb_cpf_delete_aluno.Location = new Point(474, 330);
            txb_cpf_delete_aluno.Name = "txb_cpf_delete_aluno";
            txb_cpf_delete_aluno.Size = new Size(301, 27);
            txb_cpf_delete_aluno.TabIndex = 1;
            // 
            // btn_deletar_aluno
            // 
            btn_deletar_aluno.Location = new Point(360, 328);
            btn_deletar_aluno.Name = "btn_deletar_aluno";
            btn_deletar_aluno.Size = new Size(94, 29);
            btn_deletar_aluno.TabIndex = 2;
            btn_deletar_aluno.Text = "Deletar";
            btn_deletar_aluno.UseVisualStyleBackColor = true;
            btn_deletar_aluno.Click += btn_deletar_aluno_Click;
            // 
            // btn_pesquisar_aluno
            // 
            btn_pesquisar_aluno.Location = new Point(239, 328);
            btn_pesquisar_aluno.Name = "btn_pesquisar_aluno";
            btn_pesquisar_aluno.Size = new Size(94, 29);
            btn_pesquisar_aluno.TabIndex = 3;
            btn_pesquisar_aluno.Text = "Pesquisar";
            btn_pesquisar_aluno.UseVisualStyleBackColor = true;
            btn_pesquisar_aluno.Click += btn_pesquisar_aluno_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Info;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(763, 276);
            dataGridView1.TabIndex = 4;
            // 
            // btn_voltar
            // 
            btn_voltar.Location = new Point(107, 328);
            btn_voltar.Name = "btn_voltar";
            btn_voltar.Size = new Size(108, 28);
            btn_voltar.TabIndex = 5;
            btn_voltar.Text = "Voltar";
            btn_voltar.UseVisualStyleBackColor = true;
            btn_voltar.Click += btn_voltar_Click;
            // 
            // Delete_Aluno
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Goldenrod;
            ClientSize = new Size(800, 369);
            Controls.Add(btn_voltar);
            Controls.Add(dataGridView1);
            Controls.Add(btn_pesquisar_aluno);
            Controls.Add(btn_deletar_aluno);
            Controls.Add(txb_cpf_delete_aluno);
            Controls.Add(lbl_delete_aluno);
            Name = "Delete_Aluno";
            Text = "Delete_Aluno";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_delete_aluno;
        private TextBox txb_cpf_delete_aluno;
        private Button btn_deletar_aluno;
        private Button btn_pesquisar_aluno;
        private DataGridView dataGridView1;
        private Button btn_voltar;
    }
}