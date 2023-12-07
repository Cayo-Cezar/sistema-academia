namespace WillFit_System.VIew.Professor
{
    partial class Get_Professores
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
            lbl_consulta_profs = new Label();
            txb_Cosulta_PROFS = new TextBox();
            btn_consulta_prof = new Button();
            dataGridView1 = new DataGridView();
            btn_voltar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(250, 9);
            label1.Name = "label1";
            label1.Size = new Size(284, 34);
            label1.TabIndex = 0;
            label1.Text = "Consultar Professores";
            // 
            // lbl_consulta_profs
            // 
            lbl_consulta_profs.AutoSize = true;
            lbl_consulta_profs.ForeColor = SystemColors.ButtonHighlight;
            lbl_consulta_profs.Location = new Point(353, 379);
            lbl_consulta_profs.Name = "lbl_consulta_profs";
            lbl_consulta_profs.Size = new Size(425, 20);
            lbl_consulta_profs.TabIndex = 1;
            lbl_consulta_profs.Text = "Informe o CPF do Professor ou Aperte no Botão Para Ver Todos";
            // 
            // txb_Cosulta_PROFS
            // 
            txb_Cosulta_PROFS.Location = new Point(353, 411);
            txb_Cosulta_PROFS.Name = "txb_Cosulta_PROFS";
            txb_Cosulta_PROFS.Size = new Size(425, 27);
            txb_Cosulta_PROFS.TabIndex = 2;
            txb_Cosulta_PROFS.TextChanged += txb_Cosulta_PROFS_TextChanged;
            // 
            // btn_consulta_prof
            // 
            btn_consulta_prof.Location = new Point(196, 406);
            btn_consulta_prof.Name = "btn_consulta_prof";
            btn_consulta_prof.Size = new Size(134, 29);
            btn_consulta_prof.TabIndex = 3;
            btn_consulta_prof.Text = "Pesquisar";
            btn_consulta_prof.UseVisualStyleBackColor = true;
            btn_consulta_prof.Click += btn_consulta_prof_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = SystemColors.Info;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(26, 46);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(752, 320);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btn_voltar
            // 
            btn_voltar.Location = new Point(64, 407);
            btn_voltar.Name = "btn_voltar";
            btn_voltar.Size = new Size(110, 27);
            btn_voltar.TabIndex = 5;
            btn_voltar.Text = "Voltar";
            btn_voltar.UseVisualStyleBackColor = true;
            btn_voltar.Click += btn_voltar_Click;
            // 
            // Get_Professores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGoldenrod;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_voltar);
            Controls.Add(dataGridView1);
            Controls.Add(btn_consulta_prof);
            Controls.Add(txb_Cosulta_PROFS);
            Controls.Add(lbl_consulta_profs);
            Controls.Add(label1);
            Name = "Get_Professores";
            Text = "Get_Professores";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lbl_consulta_profs;
        private TextBox txb_Cosulta_PROFS;
        private Button btn_consulta_prof;
        private DataGridView dataGridView1;
        private Button btn_voltar;
    }
}