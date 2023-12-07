
using WillFit_System.VIew.Aluno;
using WillFit_System.VIew.ALUNO;
using WillFit_System.VIew.Treinos;

namespace WillFit_System.VIew.Professor
{
    public partial class Gerencial_Aluno : Form
    {
        public Gerencial_Aluno()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Cadastrar_ALUNO cadastrar_ALUNO = new Cadastrar_ALUNO();

            cadastrar_ALUNO.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Update_Aluno aluno = new Update_Aluno();

            aluno.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Delete_Aluno aluno = new Delete_Aluno();

            aluno.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Get_Aluno aluno = new Get_Aluno();

            aluno.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Criar_Treino treino = new Criar_Treino();

            treino.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Criar_Professor prof = new Criar_Professor();

            prof.ShowDialog();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ver_professores_Click(object sender, EventArgs e)
        {
            Get_Professores VerProf = new Get_Professores();

            VerProf.ShowDialog();
        }
    }
}
