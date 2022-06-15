using System;
using System.Windows.Forms;
namespace ProjectodeDA.app
{
    public partial class formNewWorker : Form
    {
        private Model1Container dados;
        private Form prevForm;
        private bool editStatus;
        private Trabalhador crossEmp;
        public formNewWorker(Model1Container crossData, Form crossForm, bool edit, Trabalhador editEmp)
        {
            InitializeComponent();
            dados = crossData;
            prevForm = crossForm;
            editStatus = edit;
            crossEmp = editEmp;
        }
        private void formNewWorker_Load(object sender, EventArgs e)
        {
            try
            {
                lbRestaurantes.DataSource = dados.Restaurantes;
            }
            catch { }
            if (editStatus)
            {
                this.Text = "Editar Empregado";
                tbNome.Text = crossEmp.Nome;
                tbMorada.Text = crossEmp.Moradas.ToString();
                tbTelefone.Text = crossEmp.Telemovel;
                nbSalario.Value = crossEmp.Salario;
                tbPosicao.Text = crossEmp.Posicao;
                lbRestaurantes.SelectedItem = crossEmp.Restaurante;
            }
            if (dados.Restaurantes == null)
            {
                lblRestaurante.Text = "Não existem restaurantes.";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            pessoasMoradas pickMorada = new pessoasMoradas(tbMorada, dados, this);
            pickMorada.ShowDialog();
        }
        private void btConfirm_Click(object sender, EventArgs e)
        {
            if (editStatus)
            {
                crossEmp.Nome = tbNome.Text;
                crossEmp.Moradas = moradaEmp;
                crossEmp.Telemovel = tbTelefone.Text;
                crossEmp.Salario = nbSalario.Value;
                crossEmp.Posicao = tbPosicao.Text;
                crossEmp.Restaurante = lbRestaurantes.SelectedItem as Restaurante;
                moradaEmp.Pessoa = crossEmp;
                dados.SaveChanges();
                this.Dispose();
            }
            else
            {
                Trabalhador trbalhador = new Trabalhador();
                trbalhador.Nome = tbNome.Text;
                trbalhador.Moradas = moradaEmp;
                trbalhador.Telemovel = tbTelefone.Text;
                trbalhador.Salario = nbSalario.Value;
                trbalhador.Posicao = tbPosicao.Text;
                trbalhador.Restaurante = lbRestaurantes.SelectedItem as Restaurante;
                dados.Pessoas.Add(trbalhador);
                moradaEmp.Pessoa = trbalhador;
                dados.SaveChanges();
                this.Dispose();
            }
        }
        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
