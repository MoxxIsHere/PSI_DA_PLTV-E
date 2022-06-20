using System;
using System.Windows.Forms;
namespace ProjectodeDA.app
{
    public partial class formIndividuais : Form
    {
        private Model1Container dados;
        private formBase prevForm;
        private Restaurante restaurante;
        public formIndividuais(formBase crossForm, string input, Model1Container crossDados, Restaurante crossRest)
        {
            InitializeComponent();
            dados = crossDados;
            restaurante = crossRest;
            prevForm = crossForm;
            this.Text = crossRest.Nome;
            switch(input)
            {
                case "vPedido":
                    tabControl.SelectedTab = tabPedidos;
                    break;

                case "nPedido":
                    tabControl.SelectedTab = tabPedidos;
                    //fazer o mesmo que o botão de novo pedido
                    break;

                case "vCliente":
                    tabControl.SelectedTab = tabClientes;
                    break;

                case "nCliente":
                    tabControl.SelectedTab = tabClientes;
                    //fazer o mesmo que o botão de novo cliente
                    break;

                case "vMenu":
                    tabControl.SelectedTab = tabMenu;
                    break;

                case "nMenu":
                    tabControl.SelectedTab = tabMenu;
                    //fazer o mesmo que o botão de novo menu
                    break;

                default:
                    //nada mesmo
                    break;
            }
        }
        private void restaurantesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            prevForm.Show();
            this.Dispose();
        }
        private void formIndividuais_Load(object sender, EventArgs e)
        {

        }
        private void formIndividuais_FormClosing(object sender, FormClosingEventArgs e)
        {
            prevForm.Dispose();
            this.Dispose();
        }
        private void btNovoPedido_Click(object sender, EventArgs e)
        {

        }
        private void btApagarPedido_Click(object sender, EventArgs e)
        {

        }
        private void btActivo_Click(object sender, EventArgs e)
        {

        }
    }
}
