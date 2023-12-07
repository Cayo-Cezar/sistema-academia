using WillFit_System.Data;
using WillFit_System.Models;

namespace WillFit_System.VIew.Aluno;


public partial class Cadastrar_ALUNO : Form
{

    public Cadastrar_ALUNO()
    {
        InitializeComponent();
    }


    private void Cadastrar_ALUNO_Load(object sender, EventArgs e)
    {

    }


    private void button1_Click(object sender, EventArgs e)
    {

        try
        {


            var db = new GMYContext();

            string nome = TXB_NOME_CAD.Text;
            string cpf = TXB_CPF_CAD.Text;
            string telefone = TXB_TELEFONE_CAD.Text;
            string matricula = TXB_MATRICULA_CAD.Text;

            Alunos Alunos = new Alunos(nome, cpf, telefone, matricula);

            db.Add(Alunos);

            db.SaveChanges();

            MessageBox.Show("Aluno Cadastrado Com Sucesso !");




        }
        catch (Exception)
        {

        }
    }

    private void TXB_CEP_CAD_TextChanged(object sender, EventArgs e)
    {

    }

    private void lbl_cep_cad_Click(object sender, EventArgs e)
    {
    }

    private void TXB_NOME_CAD_TextChanged(object sender, EventArgs e)
    {

    }

    private void TXB_TELEFONE_CAD_TextChanged(object sender, EventArgs e)
    {

    }

    private void TXB_CPF_CAD_TextChanged(object sender, EventArgs e)
    {

    }

    private void TXB_MATRICULA_CAD_TextChanged(object sender, EventArgs e)
    {

    }

    private void btn_voltar_Click(object sender, EventArgs e)
    {
        this.Close();
    }
}
