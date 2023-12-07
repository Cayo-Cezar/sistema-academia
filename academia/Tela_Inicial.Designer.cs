namespace WillFit_System
{
    partial class Tela_Inicial
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
            BTN_Professor = new Button();
            BTN_Aluno = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Mongolian Baiti", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(161, 27);
            label1.Name = "label1";
            label1.Size = new Size(493, 43);
            label1.TabIndex = 0;
            label1.Text = "BEM VINDO AO SISTEMA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(25, 103);
            label2.Name = "label2";
            label2.Size = new Size(299, 25);
            label2.TabIndex = 1;
            label2.Text = "ESCOLHA A ÁREA DESEJADA";
            // 
            // BTN_Professor
            // 
            BTN_Professor.Location = new Point(25, 163);
            BTN_Professor.Name = "BTN_Professor";
            BTN_Professor.Size = new Size(201, 47);
            BTN_Professor.TabIndex = 2;
            BTN_Professor.Text = "PROFESSOR";
            BTN_Professor.UseVisualStyleBackColor = true;
            BTN_Professor.Click += BTN_Professor_Click;
            // 
            // BTN_Aluno
            // 
            BTN_Aluno.Location = new Point(25, 253);
            BTN_Aluno.Name = "BTN_Aluno";
            BTN_Aluno.Size = new Size(198, 47);
            BTN_Aluno.TabIndex = 3;
            BTN_Aluno.Text = "ALUNO";
            BTN_Aluno.UseVisualStyleBackColor = true;
            BTN_Aluno.Click += BTN_Aluno_Click;
            // 
            // Tela_Inicial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Goldenrod;
            ClientSize = new Size(836, 475);
            Controls.Add(BTN_Aluno);
            Controls.Add(BTN_Professor);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Tela_Inicial";
            Text = "Tela_Inicial";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button BTN_Professor;
        private Button BTN_Aluno;
    }
}