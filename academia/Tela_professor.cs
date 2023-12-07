using WillFit_System.VIew.Professor;

namespace WillFit_System
{
    public partial class Tela_professor : Form
    {
        public Tela_professor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Gerencial_Aluno gerencial = new Gerencial_Aluno();



            gerencial.ShowDialog();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
