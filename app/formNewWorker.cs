using System;
using System.Linq;
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
                lbRestaurantes.DataSource = dados.Restaurantes.ToList<Restaurante>();
            }
            catch { }
            if (editStatus)
            {
                this.Text = "Editar Empregado";
                tbNome.Text = crossEmp.Nome;

                tbTelefone.Text = crossEmp.Telemovel;
                nbSalario.Value = crossEmp.Salario;
                tbPosicao.Text = crossEmp.Posicao;
                lbRestaurantes.SelectedItem = crossEmp.Restaurante;
                tbRua.Text = crossEmp.Moradas.Rua;
                tbCidade.Text = crossEmp.Moradas.Cidade;
                tbCodigoPostalCol1.Text = crossEmp.Moradas.CodPostal.Remove(4);
                tbCodigoPostalCol2.Text = crossEmp.Moradas.CodPostal.Substring(5);
                tbPais.Text = crossEmp.Moradas.Pais;
            }
            if (dados.Restaurantes == null)
            {
                lblRestaurante.Text = "Não existem restaurantes.";
            }
        }
        private void btConfirm_Click(object sender, EventArgs e)
        {
            if (editStatus)
            {
                crossEmp.Nome = tbNome.Text;
                crossEmp.Moradas.Rua = tbRua.Text;
                crossEmp.Moradas.Cidade = tbCidade.Text;
                crossEmp.Moradas.CodPostal = (tbCodigoPostalCol1.Text + "-" + tbCodigoPostalCol2.Text);
                crossEmp.Moradas.Pais = tbPais.Text;
                crossEmp.Telemovel = tbTelefone.Text;
                crossEmp.Salario = nbSalario.Value;
                crossEmp.Posicao = tbPosicao.Text;
                crossEmp.Restaurante = lbRestaurantes.SelectedItem as Restaurante;
                crossEmp.Moradas.Pessoa = crossEmp;
                dados.SaveChanges();
                this.Dispose();
            }
            else
            {
                Trabalhador trbalhador = new Trabalhador();
                Morada mrda = new Morada();
                trbalhador.Nome = tbNome.Text;
                mrda.Rua = tbRua.Text;
                mrda.Cidade = tbCidade.Text;
                mrda.CodPostal = (tbCodigoPostalCol1.Text + "-" + tbCodigoPostalCol2.Text);
                mrda.Pais = tbPais.Text;
                trbalhador.Moradas = mrda;
                trbalhador.Telemovel = tbTelefone.Text;
                trbalhador.Salario = nbSalario.Value;
                trbalhador.Posicao = tbPosicao.Text;
                trbalhador.Restaurante = lbRestaurantes.SelectedItem as Restaurante;
                dados.Pessoas.Add(trbalhador);
                mrda.Pessoa = trbalhador;
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
