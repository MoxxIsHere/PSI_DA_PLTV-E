using System;
using System.Linq;
using System.Windows.Forms;
namespace ProjectodeDA.app
{
    public partial class formPagar : Form
    {
        private Pedido pedido;
        private Model1Container dados;
        public formPagar(Pedido crossPedido, Model1Container crossData)
        {
            InitializeComponent();
            pedido = crossPedido;
            dados = crossData;
        }
        private void formPagar_Load(object sender, EventArgs e)
        {
            lblTotal.Text = Convert.ToString(pedido.ValorTotal) + "€";
            foreach (MetodoPagamento mp in dados.MetodosPagamento.ToList<MetodoPagamento>())
            {
                if (mp.Ativo == true)
                {
                    cbMetodos.Items.Add(mp);
                }
            }
            foreach (Estado es in dados.Estados.ToList<Estado>())
            {
                cbEstado.Items.Add(es);
            }
        }
        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void btAccept_Click(object sender, EventArgs e)
        {
            if (cbEstado.Text != null && cbMetodos != null)
            {
                Pagamento pagamento = new Pagamento();
                pagamento.Valor = pedido.ValorTotal;
                pagamento.Pedido = pedido;
                pagamento.MetodoPagamento = cbMetodos.SelectedItem as MetodoPagamento;
                dados.Pagamentos.Add(pagamento);
                pedido.Pagamentos.Add(pagamento);
                pedido.Estado = cbEstado.SelectedItem as Estado;
                pedido.Clientes.TotalGasto += pedido.ValorTotal;
                dados.SaveChanges();
            }
            this.Dispose();
        }
    }
}
