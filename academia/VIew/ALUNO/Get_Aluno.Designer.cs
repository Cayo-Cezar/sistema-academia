namespace WillFit_System.VIew.ALUNO
{
    partial class Get_Aluno
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            TXB_CPF_DELETE_ALUNO = new TextBox();
            btn_pesq_delete_aluno = new Button();
            btn_voltar_Aluno = new Button();
            dataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cpfDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            phoneDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            matriculaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            cpfDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            phoneDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            matriculaDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            alunosBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)alunosBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(465, 248);
            label1.Name = "label1";
            label1.Size = new Size(264, 20);
            label1.TabIndex = 0;
            label1.Text = "Informe o CPF do Aluno Para Pesquisar";
            // 
            // TXB_CPF_DELETE_ALUNO
            // 
            TXB_CPF_DELETE_ALUNO.Location = new Point(516, 294);
            TXB_CPF_DELETE_ALUNO.Name = "TXB_CPF_DELETE_ALUNO";
            TXB_CPF_DELETE_ALUNO.Size = new Size(213, 27);
            TXB_CPF_DELETE_ALUNO.TabIndex = 1;
            // 
            // btn_pesq_delete_aluno
            // 
            btn_pesq_delete_aluno.Location = new Point(378, 293);
            btn_pesq_delete_aluno.Name = "btn_pesq_delete_aluno";
            btn_pesq_delete_aluno.Size = new Size(94, 29);
            btn_pesq_delete_aluno.TabIndex = 3;
            btn_pesq_delete_aluno.Text = "Pesquisar ";
            btn_pesq_delete_aluno.UseVisualStyleBackColor = true;
            btn_pesq_delete_aluno.Click += btn_pesq_delete_aluno_Click;
            // 
            // btn_voltar_Aluno
            // 
            btn_voltar_Aluno.Location = new Point(261, 293);
            btn_voltar_Aluno.Name = "btn_voltar_Aluno";
            btn_voltar_Aluno.Size = new Size(94, 29);
            btn_voltar_Aluno.TabIndex = 4;
            btn_voltar_Aluno.Text = "Voltar";
            btn_voltar_Aluno.UseVisualStyleBackColor = true;
            btn_voltar_Aluno.Click += btn_voltar_Aluno_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.BackgroundColor = SystemColors.Info;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, cpfDataGridViewTextBoxColumn, phoneDataGridViewTextBoxColumn, matriculaDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn1, cpfDataGridViewTextBoxColumn1, phoneDataGridViewTextBoxColumn1, matriculaDataGridViewTextBoxColumn1 });
            dataGridView1.DataSource = alunosBindingSource;
            dataGridView1.GridColor = SystemColors.Info;
            dataGridView1.Location = new Point(28, 21);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(701, 212);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "_name";
            nameDataGridViewTextBoxColumn.HeaderText = "_name";
            nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // cpfDataGridViewTextBoxColumn
            // 
            cpfDataGridViewTextBoxColumn.DataPropertyName = "_cpf";
            cpfDataGridViewTextBoxColumn.HeaderText = "_cpf";
            cpfDataGridViewTextBoxColumn.MinimumWidth = 6;
            cpfDataGridViewTextBoxColumn.Name = "cpfDataGridViewTextBoxColumn";
            cpfDataGridViewTextBoxColumn.ReadOnly = true;
            cpfDataGridViewTextBoxColumn.Width = 125;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            phoneDataGridViewTextBoxColumn.DataPropertyName = "_phone";
            phoneDataGridViewTextBoxColumn.HeaderText = "_phone";
            phoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            phoneDataGridViewTextBoxColumn.ReadOnly = true;
            phoneDataGridViewTextBoxColumn.Width = 125;
            // 
            // matriculaDataGridViewTextBoxColumn
            // 
            matriculaDataGridViewTextBoxColumn.DataPropertyName = "_matricula";
            matriculaDataGridViewTextBoxColumn.HeaderText = "_matricula";
            matriculaDataGridViewTextBoxColumn.MinimumWidth = 6;
            matriculaDataGridViewTextBoxColumn.Name = "matriculaDataGridViewTextBoxColumn";
            matriculaDataGridViewTextBoxColumn.ReadOnly = true;
            matriculaDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            nameDataGridViewTextBoxColumn1.DataPropertyName = "name";
            nameDataGridViewTextBoxColumn1.HeaderText = "name";
            nameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            nameDataGridViewTextBoxColumn1.ReadOnly = true;
            nameDataGridViewTextBoxColumn1.Width = 125;
            // 
            // cpfDataGridViewTextBoxColumn1
            // 
            cpfDataGridViewTextBoxColumn1.DataPropertyName = "cpf";
            cpfDataGridViewTextBoxColumn1.HeaderText = "cpf";
            cpfDataGridViewTextBoxColumn1.MinimumWidth = 6;
            cpfDataGridViewTextBoxColumn1.Name = "cpfDataGridViewTextBoxColumn1";
            cpfDataGridViewTextBoxColumn1.ReadOnly = true;
            cpfDataGridViewTextBoxColumn1.Width = 125;
            // 
            // phoneDataGridViewTextBoxColumn1
            // 
            phoneDataGridViewTextBoxColumn1.DataPropertyName = "phone";
            phoneDataGridViewTextBoxColumn1.HeaderText = "phone";
            phoneDataGridViewTextBoxColumn1.MinimumWidth = 6;
            phoneDataGridViewTextBoxColumn1.Name = "phoneDataGridViewTextBoxColumn1";
            phoneDataGridViewTextBoxColumn1.ReadOnly = true;
            phoneDataGridViewTextBoxColumn1.Width = 125;
            // 
            // matriculaDataGridViewTextBoxColumn1
            // 
            matriculaDataGridViewTextBoxColumn1.DataPropertyName = "matricula";
            matriculaDataGridViewTextBoxColumn1.HeaderText = "matricula";
            matriculaDataGridViewTextBoxColumn1.MinimumWidth = 6;
            matriculaDataGridViewTextBoxColumn1.Name = "matriculaDataGridViewTextBoxColumn1";
            matriculaDataGridViewTextBoxColumn1.ReadOnly = true;
            matriculaDataGridViewTextBoxColumn1.Width = 125;
            // 
            // alunosBindingSource
            // 
            alunosBindingSource.DataSource = typeof(Models.Alunos);
            // 
            // Get_Aluno
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Goldenrod;
            ClientSize = new Size(741, 337);
            Controls.Add(dataGridView1);
            Controls.Add(btn_voltar_Aluno);
            Controls.Add(btn_pesq_delete_aluno);
            Controls.Add(TXB_CPF_DELETE_ALUNO);
            Controls.Add(label1);
            Name = "Get_Aluno";
            Text = "Get_Aluno";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)alunosBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TXB_CPF_DELETE_ALUNO;
        private Button btn_pesq_delete_aluno;
        private Button btn_voltar_Aluno;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cpfDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn matriculaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn cpfDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn matriculaDataGridViewTextBoxColumn1;
        private BindingSource alunosBindingSource;
    }
}