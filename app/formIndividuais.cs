using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
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
            switch (input)
            {
                case "vPedido":
                    tabControl.SelectedTab = tabPedidos;
                    break;

                case "nPedido":
                    tabControl.SelectedTab = tabPedidos;
                    formNewPedido fnp = new formNewPedido(dados, restaurante);
                    fnp.ShowDialog();
                    break;

                case "vCliente":
                    tabControl.SelectedTab = tabClientes;
                    break;

                case "nCliente":
                    tabControl.SelectedTab = tabClientes;
                    formNewCliente fnc = new formNewCliente(dados, false, null);
                    fnc.ShowDialog();
                    break;

                case "vMenu":
                    tabControl.SelectedTab = tabMenu;
                    break;

                default:
                    //nada mesmo
                    break;
            }
        }
        private void formIndividuais_Load(object sender, EventArgs e)
        {
            bsClientes.DataSource = dados.Pessoas.OfType<Cliente>().ToList<Cliente>();
            bsMenuGlobal.DataSource = dados.ItemMenus.ToList<ItemMenu>();
            bsMenuIndividual.DataSource = restaurante.ItemMenu.ToList<ItemMenu>();
            foreach (Estado es in dados.Estados.ToList<Estado>())
            {
                cbEstado.Items.Add(es);
                cbFiltro.Items.Add(es);
            }
            if (cbFiltro.Text != "Todos")
            {
                List<Pedido> thisPedidos = new List<Pedido>();
                foreach (Pedido p in restaurante.Pedido.ToList<Pedido>())
                {
                    if (p.Estado == cbFiltro.SelectedItem)
                    {
                        thisPedidos.Add(p);
                    }
                }
                bsPedidosActivos.DataSource = thisPedidos;
            }
            else
            {
                List<Pedido> thisPedidos = new List<Pedido>();
                foreach (Pedido p in restaurante.Pedido.ToList<Pedido>())
                {
                    thisPedidos.Add(p);
                }
                bsPedidosActivos.DataSource = thisPedidos;
            }
        }
        private void formIndividuais_FormClosing(object sender, FormClosingEventArgs e)
        {
            prevForm.Dispose();
            this.Dispose();
        }
        private void btNovoPedido_Click(object sender, EventArgs e)
        {
            formNewPedido fnp = new formNewPedido(dados, restaurante);
            fnp.ShowDialog();
        }
        private void cbFiltro_TextChanged(object sender, EventArgs e)
        {
            if (cbFiltro.Text != "Todos")
            {
                List<Pedido> thisPedidos = new List<Pedido>();
                foreach (Pedido p in restaurante.Pedido.ToList<Pedido>())
                {
                    if (p.Estado == cbFiltro.SelectedItem)
                    {
                        thisPedidos.Add(p);
                    }
                }
                bsPedidosActivos.DataSource = thisPedidos;
            }
            else
            {
                List<Pedido> thisPedidos = new List<Pedido>();
                foreach (Pedido p in restaurante.Pedido.ToList<Pedido>())
                {
                    thisPedidos.Add(p);
                }
                bsPedidosActivos.DataSource = thisPedidos;
            }
        }
        private void gvPedidos_SelectionChanged(object sender, EventArgs e)
        {
            if (gvPedidos.SelectedRows.Count > 0)
            {
                Pedido selped = gvPedidos.SelectedRows[0].DataBoundItem as Pedido;
                cbEstado.SelectedItem = selped.Estado;
                tbPedidoInfo.Text = $" Cliente:\n   {selped.Clientes}\n\n Items:\n";
                foreach(ItemMenu im in selped.ItemMenu.ToList<ItemMenu>())
                {
                    tbPedidoInfo.Text += $"   {im.Nome}\n";
                }
                tbPedidoInfo.Text += $"\n Empregado:\n   {selped.Trabalhadors}";
            }
        }
        private void verPedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabPedidos;
        }
        private void novoPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabPedidos;
            formNewPedido fnp = new formNewPedido(dados, restaurante);
            fnp.ShowDialog();
        }
        private void formIndividuais_Activated(object sender, EventArgs e)
        {
            bsClientes.DataSource = dados.Pessoas.OfType<Cliente>().ToList<Cliente>();
            if (gvPedidos.SelectedRows.Count > 0)
            {
                Pedido selped = gvPedidos.SelectedRows[0].DataBoundItem as Pedido;
                cbEstado.SelectedItem = selped.Estado;
                tbPedidoInfo.Text = $" Cliente:\n   {selped.Clientes}\n\n Items:\n";
                foreach (ItemMenu im in selped.ItemMenu.ToList<ItemMenu>())
                {
                    tbPedidoInfo.Text += $"   {im.Nome}\n";
                }
                tbPedidoInfo.Text += $"\n Empregado:\n   {selped.Trabalhadors}";
            }
            cbEstado.Items.Clear();
            cbFiltro.Items.Clear();
            cbFiltro.Items.Add("Todos");
            foreach (Estado es in dados.Estados.ToList<Estado>())
            {
                cbEstado.Items.Add(es);
                cbFiltro.Items.Add(es);
            }
            if (cbFiltro.Text != "Todos")
            {
                List<Pedido> thisPedidos = new List<Pedido>();
                foreach (Pedido p in restaurante.Pedido.ToList<Pedido>())
                {
                    if (p.Estado == cbFiltro.SelectedItem)
                    {
                        thisPedidos.Add(p);
                    }
                }
                bsPedidosActivos.DataSource = thisPedidos;
            }
            else
            {
                List<Pedido> thisPedidos = new List<Pedido>();
                foreach (Pedido p in restaurante.Pedido.ToList<Pedido>())
                {
                    thisPedidos.Add(p);
                }
                bsPedidosActivos.DataSource = thisPedidos;
            }
        }
        private void btConfigurar_Click(object sender, EventArgs e)
        {
            formNewEstado fne = new formNewEstado(dados);
            fne.ShowDialog();
        }
        private void cbEstado_TextChanged(object sender, EventArgs e)
        {
            if (gvPedidos.SelectedRows.Count > 0)
            {
                (gvPedidos.SelectedRows[0].DataBoundItem as Pedido).Estado = cbEstado.SelectedItem as Estado;
                if (cbFiltro.Text != "Todos")
                {
                    List<Pedido> thisPedidos = new List<Pedido>();
                    foreach (Pedido p in restaurante.Pedido.ToList<Pedido>())
                    {
                        if (p.Estado == cbFiltro.SelectedItem)
                        {
                            thisPedidos.Add(p);
                        }
                    }
                    bsPedidosActivos.DataSource = thisPedidos;
                }
                else
                {
                    List<Pedido> thisPedidos = new List<Pedido>();
                    foreach (Pedido p in restaurante.Pedido.ToList<Pedido>())
                    {
                        thisPedidos.Add(p);
                    }
                    bsPedidosActivos.DataSource = thisPedidos;
                }
            }
        }
        private void menuMenu_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabMenu;
        }
        private void novoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabClientes;
        }
        private void editarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabClientes;
        }
        private void btPagar_Click(object sender, EventArgs e)
        {
            if (gvPedidos.SelectedRows.Count > 0)
            {
                formPagar fp = new formPagar(gvPedidos.SelectedRows[0].DataBoundItem as Pedido, dados);
                fp.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nenhum Pedido Selecionado", "Aviso", MessageBoxButtons.OK);
            }
        }
        private void tbPesquisar_TextChanged(object sender, EventArgs e)
        {
            if (tbPesquisar.Text.Length > 0)
            {
                List<ItemMenu> globalFilt = new List<ItemMenu>();
                List<ItemMenu> indivFilt = new List<ItemMenu>();
                foreach (ItemMenu im in dados.ItemMenus.ToList<ItemMenu>())
                {
                    if ((im.Nome.Contains(tbPesquisar.Text)) || (im.Categoria.Nome.Contains(tbPesquisar.Text)))
                    {
                        globalFilt.Add(im);
                    }
                }
                foreach (ItemMenu im in restaurante.ItemMenu.ToList<ItemMenu>())
                {
                    if ((im.Nome.Contains(tbPesquisar.Text)) || (im.Categoria.Nome.Contains(tbPesquisar.Text)))
                    {
                        indivFilt.Add(im);
                    }
                }
                bsMenuGlobal.DataSource = globalFilt;
                bsMenuIndividual.DataSource = indivFilt;
            }
            else
            {
                bsMenuGlobal.DataSource = dados.ItemMenus.ToList<ItemMenu>();
                bsMenuIndividual.DataSource = restaurante.ItemMenu.ToList<ItemMenu>();
            }
        }
        private void btRemover_Click(object sender, EventArgs e)
        {
            if (gvMenuIndividual.SelectedRows.Count > 0)
            {
                restaurante.ItemMenu.Remove(gvMenuIndividual.SelectedRows[0].DataBoundItem as ItemMenu);
                dados.SaveChanges();
                bsMenuGlobal.DataSource = dados.ItemMenus.ToList<ItemMenu>();
                bsMenuIndividual.DataSource = restaurante.ItemMenu.ToList<ItemMenu>();
            }
        }
        private void btAdicionar_Click_1(object sender, EventArgs e)
        {
            if(gvMenuGlobal.SelectedRows.Count > 0)
            {
                ItemMenu im = gvMenuGlobal.SelectedRows[0].DataBoundItem as ItemMenu;
                if (!(restaurante.ItemMenu.Contains(im)))
                {
                    restaurante.ItemMenu.Add(im);
                    dados.SaveChanges();
                    bsMenuGlobal.DataSource = dados.ItemMenus.ToList<ItemMenu>();
                    bsMenuIndividual.DataSource = restaurante.ItemMenu.ToList<ItemMenu>();
                }
            }
        }
        private void restaurantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            prevForm.Show();
            this.Dispose();
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            formNewCliente fnc = new formNewCliente(dados, false, null);
            fnc.ShowDialog();
        }
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if(gvClientes.SelectedRows.Count > 0)
            {
                formNewCliente fnc = new formNewCliente(dados, true, gvClientes.SelectedRows[0].DataBoundItem as Cliente);
                fnc.ShowDialog();
            }
        }
        private void tbProcurarCliente_TextChanged(object sender, EventArgs e)
        {
            if (tbProcurarCliente.Text.Length > 0)
            {
                List<Cliente> sortClientes = new List<Cliente>();
                foreach (Cliente cli in dados.Pessoas.OfType<Cliente>().ToList<Cliente>())
                {
                    if((cli.Nome.Contains(tbProcurarCliente.Text)) || (cli.NumContribuinte.Contains(tbProcurarCliente.Text)))
                    {
                        sortClientes.Add(cli);
                    }
                }
                bsClientes.DataSource = sortClientes;
            }
            else
            {
                bsClientes.DataSource = dados.Pessoas.OfType<Cliente>().ToList<Cliente>();
            }
        }
    }
}
