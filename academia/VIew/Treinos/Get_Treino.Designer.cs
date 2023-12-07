namespace WillFit_System.VIew.Treinos
{
    partial class Get_Treino
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
            TXB_GET_TREINO = new TextBox();
            BTN_PESQU_TREINOS = new Button();
            dataGridView_TREINO = new DataGridView();
            btn_voltar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView_TREINO).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(280, 29);
            label1.Name = "label1";
            label1.Size = new Size(148, 28);
            label1.TabIndex = 0;
            label1.Text = "MEUS TREINOS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(45, 372);
            label2.Name = "label2";
            label2.Size = new Size(190, 20);
            label2.TabIndex = 1;
            label2.Text = "INFORME SUA MATRÍCULA:";
            label2.Click += label2_Click;
            // 
            // TXB_GET_TREINO
            // 
            TXB_GET_TREINO.Location = new Point(45, 395);
            TXB_GET_TREINO.Name = "TXB_GET_TREINO";
            TXB_GET_TREINO.Size = new Size(342, 27);
            TXB_GET_TREINO.TabIndex = 2;
            // 
            // BTN_PESQU_TREINOS
            // 
            BTN_PESQU_TREINOS.Location = new Point(403, 395);
            BTN_PESQU_TREINOS.Name = "BTN_PESQU_TREINOS";
            BTN_PESQU_TREINOS.Size = new Size(94, 29);
            BTN_PESQU_TREINOS.TabIndex = 3;
            BTN_PESQU_TREINOS.Text = "PESQUISAR";
            BTN_PESQU_TREINOS.UseVisualStyleBackColor = true;
            BTN_PESQU_TREINOS.Click += BTN_PESQU_TREINOS_Click;
            // 
            // dataGridView_TREINO
            // 
            dataGridView_TREINO.BackgroundColor = SystemColors.Info;
            dataGridView_TREINO.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_TREINO.Location = new Point(25, 72);
            dataGridView_TREINO.Name = "dataGridView_TREINO";
            dataGridView_TREINO.RowHeadersWidth = 51;
            dataGridView_TREINO.RowTemplate.Height = 29;
            dataGridView_TREINO.Size = new Size(684, 280);
            dataGridView_TREINO.TabIndex = 4;
            // 
            // btn_voltar
            // 
            btn_voltar.Location = new Point(503, 395);
            btn_voltar.Name = "btn_voltar";
            btn_voltar.Size = new Size(105, 31);
            btn_voltar.TabIndex = 5;
            btn_voltar.Text = "Voltar";
            btn_voltar.UseVisualStyleBackColor = true;
            btn_voltar.Click += btn_voltar_Click;
            // 
            // Get_Treino
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGoldenrod;
            ClientSize = new Size(734, 450);
            Controls.Add(btn_voltar);
            Controls.Add(dataGridView_TREINO);
            Controls.Add(BTN_PESQU_TREINOS);
            Controls.Add(TXB_GET_TREINO);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Get_Treino";
            Text = "Get_Treino";
            ((System.ComponentModel.ISupportInitialize)dataGridView_TREINO).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox TXB_GET_TREINO;
        private Button BTN_PESQU_TREINOS;
        private DataGridView dataGridView_TREINO;
        private Button btn_voltar;
    }
}