namespace WillFit_System
{
    public partial class Tela_Inicial : Form
    {
        public Tela_Inicial()
        {
            InitializeComponent();
        }

        private void BTN_Aluno_Click(object sender, EventArgs e)
        {
            Tela_aluno tela_Aluno = new Tela_aluno();
            tela_Aluno.Show();
        }

        private void BTN_Professor_Click(object sender, EventArgs e)
        {
            Tela_professor tela_Professor = new Tela_professor();

            tela_Professor.ShowDialog();
        }
    }
}
