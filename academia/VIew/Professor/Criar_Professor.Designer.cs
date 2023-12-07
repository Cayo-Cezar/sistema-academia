namespace WillFit_System.VIew.Professor
{
    partial class Criar_Professor
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            btn_cadastrar_professor = new Button();
            btn_voltar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(19, 29);
            label1.Name = "label1";
            label1.Size = new Size(268, 31);
            label1.TabIndex = 0;
            label1.Text = "CADASTRAR PROFESSOR";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(12, 195);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 1;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(29, 278);
            label3.Name = "label3";
            label3.Size = new Size(33, 20);
            label3.TabIndex = 2;
            label3.Text = "CPF";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(12, 110);
            label4.Name = "label4";
            label4.Size = new Size(66, 20);
            label4.TabIndex = 3;
            label4.Text = "Telefone";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(93, 195);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(237, 27);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(93, 278);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(242, 27);
            textBox2.TabIndex = 5;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(93, 110);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(194, 27);
            textBox3.TabIndex = 6;
            // 
            // btn_cadastrar_professor
            // 
            btn_cadastrar_professor.Location = new Point(22, 383);
            btn_cadastrar_professor.Name = "btn_cadastrar_professor";
            btn_cadastrar_professor.Size = new Size(125, 36);
            btn_cadastrar_professor.TabIndex = 7;
            btn_cadastrar_professor.Text = "Cadastrar";
            btn_cadastrar_professor.UseVisualStyleBackColor = true;
            btn_cadastrar_professor.Click += btn_cadastrar_professor_Click;
            // 
            // btn_voltar
            // 
            btn_voltar.Location = new Point(179, 383);
            btn_voltar.Name = "btn_voltar";
            btn_voltar.Size = new Size(101, 36);
            btn_voltar.TabIndex = 8;
            btn_voltar.Text = "Voltar";
            btn_voltar.UseVisualStyleBackColor = true;
            btn_voltar.Click += btn_voltar_Click;
            // 
            // Criar_Professor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Goldenrod;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_voltar);
            Controls.Add(btn_cadastrar_professor);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Criar_Professor";
            Text = "Adicionar_Professor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button btn_cadastrar_professor;
        private Button btn_voltar;
    }
}