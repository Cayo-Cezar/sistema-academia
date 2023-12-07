using WillFit_System.Data;

namespace WillFit_System.VIew.Professor
{
    public partial class Criar_Professor : Form
    {
        public Criar_Professor()
        {
            InitializeComponent();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_cadastrar_professor_Click(object sender, EventArgs e)
        {
            GMYContext db = new GMYContext();

            var nome = textBox1.Text;
            var cpf = textBox2.Text;
            var telefone = textBox3.Text;

            Professores prof = new Professores(nome, cpf, telefone);

            db.Professores.Add(prof);

            db.SaveChanges();

            MessageBox.Show("Professor Cadastrado com sucesso");


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
