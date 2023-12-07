using WillFit_System.VIew.Treinos;

namespace WillFit_System
{
    public partial class Tela_aluno : Form
    {
        public Tela_aluno()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Get_Treino treino = new Get_Treino();
            treino.ShowDialog();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
