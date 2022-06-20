using System;
using System.Windows.Forms;
namespace ProjectodeDA
{
    public partial class formNewMetodoPag : Form
    {
        private Model1Container dados;
        private bool edit;
        private MetodoPagamento metodoPagamentoEdit;
        public formNewMetodoPag(Model1Container crossDados, bool editStatus, MetodoPagamento crossMet)
        {
            InitializeComponent();
            dados = crossDados;
            edit = editStatus;
            metodoPagamentoEdit = crossMet;
        }
        private void btAccept_Click(object sender, EventArgs e)
        {
            if (Filled())
            {
                if (edit)
                {
                    metodoPagamentoEdit.Metodopagamento = tbNome.Text;
                    metodoPagamentoEdit.Ativo = cbActivo.Checked;
                    dados.SaveChanges();
                }
                else
                {
                        MetodoPagamento metodo = new MetodoPagamento();
                        metodo.Metodopagamento = tbNome.Text;
                        metodo.Ativo = cbActivo.Checked;
                        dados.MetodosPagamento.Add(metodo);
                        dados.SaveChanges();
                }
                this.Dispose();
            }
        }
        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void formNewMetodoPag_Load(object sender, EventArgs e)
        {
            if(edit)
            {
                tbNome.Text = metodoPagamentoEdit.Metodopagamento;
                cbActivo.Checked = metodoPagamentoEdit.Ativo;
            }
        }
        private bool Filled()
        {
            if(tbNome.Text.Length > 0)
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
