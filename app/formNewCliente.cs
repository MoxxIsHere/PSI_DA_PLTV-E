using System;
using System.Windows.Forms;
namespace ProjectodeDA.app
{
    public partial class formNewCliente : Form
    {
        private Model1Container dados;
        private Cliente editClient;
        private bool EditStatus;
        public formNewCliente(Model1Container crossData, bool crossEdit, Cliente crossCliente)
        {
            InitializeComponent();
            dados = crossData;
            EditStatus = crossEdit;
            editClient = crossCliente;
        }
        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void btAccept_Click(object sender, EventArgs e)
        {
            if (EditStatus)
            {
                if (CheckFilled())
                {
                    editClient.Nome = tbNome.Text;
                    editClient.Telemovel = tbTelefone.Text;
                    editClient.NumContribuinte = tbNC.Text;
                    editClient.Moradas.Cidade = tbCidade.Text;
                    editClient.Moradas.Rua = tbRua.Text;
                    editClient.Moradas.Pais = tbPais.Text;
                    editClient.Moradas.CodPostal = tbCodigoPostalCol1.Text + "-" + tbCodigoPostalCol2.Text;
                    dados.SaveChanges();
                    this.Dispose();
                }
            }
            else
            {
                if (CheckFilled())
                {
                    Cliente nCliente = new Cliente();
                    Morada nMorada = new Morada();
                    nCliente.Nome = tbNome.Text;
                    nCliente.Telemovel = tbTelefone.Text;
                    nCliente.NumContribuinte = tbNC.Text;
                    nMorada.Rua = tbRua.Text;
                    nMorada.Cidade = tbCidade.Text;
                    nMorada.CodPostal = tbCodigoPostalCol1 + "-" + tbCodigoPostalCol2.Text;
                    nMorada.Pais = tbPais.Text;
                    nCliente.Moradas = nMorada;
                    dados.Pessoas.Add(nCliente);
                    nMorada.Pessoa = nCliente;
                    dados.SaveChanges();
                    this.Dispose();
                }
            }
        }
        private void formNewCliente_Load(object sender, EventArgs e)
        {
            if (EditStatus)
            {
                tbNome.Text = editClient.Nome;
                tbTelefone.Text = editClient.Telemovel;
                tbNC.Text = editClient.NumContribuinte;
                tbRua.Text = editClient.Moradas.Rua;
                tbCidade.Text = editClient.Moradas.Cidade;
                tbPais.Text = editClient.Moradas.Pais;
                tbCodigoPostalCol1.Text = editClient.Moradas.CodPostal.Remove(4);
                tbCodigoPostalCol2.Text = editClient.Moradas.CodPostal.Substring(5);
            }
        }
        private bool CheckFilled()
        {
            if (tbNome.Text.Length > 0 && tbTelefone.Text.Length > 0 && tbNC.Text.Length > 0 && tbRua.Text.Length > 0 && tbPais.Text.Length > 0 && tbCidade.Text.Length > 0 && tbCodigoPostalCol1.Text.Length > 0 && tbCodigoPostalCol2.Text.Length > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
