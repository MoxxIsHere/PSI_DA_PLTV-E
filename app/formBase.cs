using ProjectodeDA.app;

using System;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;
namespace ProjectodeDA
{
    public partial class formBase : Form
    {
        private Restaurante restSel;
        private Model1Container dados;
        public formBase()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dados = new Model1Container();
            bsBD.DataSource = dados.Restaurantes.ToList<Restaurante>();
            gvRestaurantes.ClearSelection();
            if(bsBD.List.Count == 0)
            {
                pedidosToolStripMenuItem.Enabled = false;
                clientesToolStripMenuItem.Enabled = false;
                menuToolStripMenuItem.Enabled = false;
            }
        }
        private void formBase_Activated(object sender, EventArgs e)
        {
            bsBD.DataSource = dados.Restaurantes.ToList<Restaurante>();
        }
        private void gvRestaurantes_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                Restaurante restSel = gvRestaurantes.SelectedRows[0].DataBoundItem as Restaurante;
                if (restSel != null)
                {
                    btEditarRest.Enabled = true;
                    btApagarRest.Enabled = true;
                    pedidosToolStripMenuItem.Enabled = true;
                    clientesToolStripMenuItem.Enabled = true;
                    menuToolStripMenuItem.Enabled = true;
                }
                else
                {
                    btEditarRest.Enabled = false;
                    btApagarRest.Enabled = false;
                    pedidosToolStripMenuItem.Enabled = false;
                    clientesToolStripMenuItem.Enabled = false;
                    menuToolStripMenuItem.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                btEditarRest.Enabled = false;
                btApagarRest.Enabled = false;
                pedidosToolStripMenuItem.Enabled = false;
                clientesToolStripMenuItem.Enabled = false;
                menuToolStripMenuItem.Enabled = false;
            }
        }
        private void btPedidos_Click(object sender, EventArgs e)
        {
            try
            {
                restSel = gvRestaurantes.SelectedRows[0].DataBoundItem as Restaurante;
            }
            catch(Exception ex)
            {
            }
        }
        private void btNovoRest_Click(object sender, EventArgs e)
        {
            var diag = new formNewRest(false, null, dados);
            diag.ShowDialog();
        }

        private void btEditarRest_Click(object sender, EventArgs e)
        {
            try
            {
                Restaurante restSel = gvRestaurantes.SelectedRows[0].DataBoundItem as Restaurante;
                var diag = new formNewRest(true, restSel, dados);
                diag.ShowDialog();
            }
            catch (Exception ex)
            {
            }
        }
        private void btApagarRest_Click(object sender, EventArgs e)
        {
            try
            {
                Restaurante restSel = gvRestaurantes.SelectedRows[0].DataBoundItem as Restaurante;
                dados.Restaurantes.Remove(restSel);
                dados.SaveChanges();
                bsBD.DataSource = dados.Restaurantes.ToList<Restaurante>();
            }
            catch (Exception ex)
            {
            }
        }
        private void btRefresh_Click(object sender, EventArgs e)
        {
            toolStripTextBox1.Text = null;
            bsBD.DataSource = dados.Restaurantes.ToList<Restaurante>();
        }
        private void Pesquisa(string query)
        {
            if (query != null)
            {
                List<Restaurante> subLista = new List<Restaurante>();
                foreach (Restaurante a in dados.Restaurantes.ToList<Restaurante>())
                {
                    if (a.Nome.Contains(query))
                    {
                        subLista.Add(a);
                    }
                }
                bsBD.DataSource = subLista;
            }
            else
            {
                bsBD.DataSource = dados.Restaurantes.ToList<Restaurante>();
            }
        }
        private void btSearch_Click(object sender, EventArgs e)
        {
            Pesquisa(toolStripTextBox1.Text);
        }
        private void restaurantesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //não faz nada no contexto
        }
        private void toolStripTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                Pesquisa(toolStripTextBox1.Text);
            }
        }
        private void empregadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form gestao = new formGestaoGeral(dados, "empregados", this);
            gestao.Show();
            this.Hide();
        }
        private void itemsDeVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form gestao = new formGestaoGeral(dados, "items", this);
            gestao.Show();
            this.Hide();
        }
        private void métodosDePagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form gestao = new formGestaoGeral(dados, "pagamento", this);
            gestao.Show();
            this.Hide();
        }
        private void verPedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formIndividuais indv = new formIndividuais(this, "vPedido", dados, gvRestaurantes.SelectedRows[0].DataBoundItem as Restaurante);
            indv.Show();
            this.Hide();
        }
        private void novoPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formIndividuais indv = new formIndividuais(this, "nPedido", dados, gvRestaurantes.SelectedRows[0].DataBoundItem as Restaurante);
            indv.Show();
            this.Hide();
        }
        private void gvRestaurantes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            formIndividuais indv = new formIndividuais(this, null, dados, gvRestaurantes.SelectedRows[0].DataBoundItem as Restaurante);
            indv.Show();
            this.Hide();
        }
    }
}
