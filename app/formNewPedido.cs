using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Drawing;
namespace ProjectodeDA.app
{
    public partial class formNewPedido : Form
    {
        private Model1Container dados;
        private Restaurante restaurante;
        public formNewPedido(Model1Container crossDados, Restaurante crossRest)
        {
            InitializeComponent();
            dados = crossDados;
            restaurante = crossRest;
        }
        private void btAccept_Click(object sender, EventArgs e)
        {
            if (restaurante != null && gvEstados.SelectedRows.Count > 0 && gvTrabalhadores.SelectedRows.Count > 0 && lvSelectedItems.Items.Count > 0 && gvClientes.SelectedRows.Count > 0)
            {
                Pedido nPedido = new Pedido();
                nPedido.Restaurantes = restaurante;
                nPedido.Estado = gvEstados.SelectedRows[0].DataBoundItem as Estado;
                nPedido.Trabalhadors = gvTrabalhadores.SelectedRows[0].DataBoundItem as Trabalhador;
                nPedido.Clientes = gvClientes.SelectedRows[0].DataBoundItem as Cliente;
                List<int> ids = new List<int>();
                foreach(ListViewItem lvi in lvSelectedItems.Items)
                {
                    ids.Add(Convert.ToInt32(lvi.SubItems[3].Text));
                }
                List<ItemMenu> pedidoMenus = new List<ItemMenu>();
                foreach(int id in ids)
                {
                    pedidoMenus.Add(dados.ItemMenus.Find(id));
                }
                nPedido.ItemMenu = pedidoMenus;
                nPedido.ValorTotal = Convert.ToDecimal(lblTotal.Text.Remove(lblTotal.Text.IndexOf('€')));
                dados.Pedidos.Add(nPedido);
                dados.SaveChanges();
                this.Dispose();
            }
        }
        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text == null)
            {
                List<Cliente> clienteList = new List<Cliente>();
                foreach (Cliente c in dados.Pessoas.OfType<Cliente>().ToList<Cliente>())
                {
                    clienteList.Add(c);
                }
                bsClientes.DataSource = clienteList;
            }
            else
            {
                List<Cliente> clienteList = new List<Cliente>();
                foreach (Cliente c in dados.Pessoas.OfType<Cliente>().ToList<Cliente>())
                {
                    if(c.Nome.Contains(textBox1.Text) || c.NumContribuinte.Contains(textBox1.Text))
                    {
                        clienteList.Add(c);
                    }
                }
                bsClientes.DataSource = clienteList;
            }
        }
        private void formNewPedido_Load(object sender, EventArgs e)
        {
            List<Cliente> clienteList = new List<Cliente>();
            foreach(Cliente c in dados.Pessoas.OfType<Cliente>().ToList<Cliente>())
            {
                clienteList.Add(c);
            }
            bsClientes.DataSource = clienteList;
            List<Trabalhador> trabalhadorList = new List<Trabalhador>();
            foreach (Trabalhador t in restaurante.Trabalhadors.ToList<Trabalhador>())
            {
                trabalhadorList.Add(t);
            }
            bsTrabalhadores.DataSource = trabalhadorList;
            bsEstados.DataSource = dados.Estados.ToList<Estado>();
            List<ItemMenu> itemsActivos = new List<ItemMenu>();
            foreach (ItemMenu im in restaurante.ItemMenu.ToList<ItemMenu>())
            {
                if(im.Ativo == true)
                {
                    itemsActivos.Add(im);
                }
            }
            bsItems.DataSource = itemsActivos;
        }
        private void gvItems_SelectionChanged(object sender, EventArgs e)
        {
            if(gvItems.SelectedRows.Count > 0)
            {
                ItemMenu selItem = gvItems.SelectedRows[0].DataBoundItem as ItemMenu;
                MemoryStream ms = new MemoryStream(Convert.FromBase64String(selItem.Fotografia));
                pbItems.Image = Image.FromStream(ms);
                tbIngredientes.Text = selItem.Ingredientes;
            }
        }
        private void btAdicionar_Click(object sender, EventArgs e)
        {
            decimal total = Convert.ToDecimal(lblTotal.Text.Remove(lblTotal.Text.IndexOf('€')));
            if(gvItems.SelectedRows.Count > 0)
            {
                bool exists = false;
                ItemMenu selItem = gvItems.SelectedRows[0].DataBoundItem as ItemMenu;
                foreach(ListViewItem item in lvSelectedItems.Items)
                {
                    if(item.Text == selItem.Nome)
                    {
                        exists = true;
                        int quantidade = Convert.ToInt32(item.SubItems[1].Text);
                        ++quantidade;
                        item.SubItems[1].Text = Convert.ToString(quantidade);
                        item.SubItems[2].Text = Convert.ToString((selItem.Preco * quantidade));
                    }
                }
                if(!exists)
                {
                    string[] objecto = new string[]
                    {
                        selItem.Nome,
                        "1",
                        Convert.ToString(selItem.Preco),
                        Convert.ToString(selItem.Id)
                    };
                    ListViewItem itm = new ListViewItem(objecto);
                    lvSelectedItems.Items.Add(itm);
                }
                total += selItem.Preco;
                lblTotal.Text = Convert.ToString(total) + '€';
            }
        }
        private void btRemover_Click(object sender, EventArgs e)
        {
            decimal total = Convert.ToDecimal(lblTotal.Text.Remove(lblTotal.Text.IndexOf('€')));
            if(lvSelectedItems.Items.Count > 0)
            {
                ListViewItem item = lvSelectedItems.Items[0];
                int quantidade = Convert.ToInt32(item.SubItems[1].Text);
                --quantidade;
                total -= dados.ItemMenus.Find(Convert.ToInt32(lvSelectedItems.Items[0].SubItems[3].Text)).Preco;
                if (quantidade == 0)
                {
                    lvSelectedItems.Items.Remove(item);
                }
                else
                {
                    item.SubItems[1].Text = Convert.ToString(quantidade);
                    item.SubItems[2].Text = Convert.ToString((dados.ItemMenus.Find(Convert.ToInt32(item.SubItems[3].Text))).Preco * quantidade);
                }
            }
            lblTotal.Text = Convert.ToString(total) + '€';
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text.Length > 0)
            {
                List<ItemMenu> itemsActivos = new List<ItemMenu>();
                foreach (ItemMenu im in restaurante.ItemMenu.ToList<ItemMenu>())
                {
                    if (im.Ativo == true && (im.Nome.Contains(textBox2.Text) || im.Categoria.Nome.Contains(textBox2.Text)))
                    {
                        itemsActivos.Add(im);
                    }
                }
                bsItems.DataSource = itemsActivos;
            }
            else
            {
                List<ItemMenu> itemsActivos = new List<ItemMenu>();
                foreach (ItemMenu im in restaurante.ItemMenu.ToList<ItemMenu>())
                {
                    if (im.Ativo == true)
                    {
                        itemsActivos.Add(im);
                    }
                }
                bsItems.DataSource = itemsActivos;
            }
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text.Length > 0)
            {
                List<Trabalhador> trabalhadorList = new List<Trabalhador>();
                foreach (Trabalhador t in restaurante.Trabalhadors.ToList<Trabalhador>())
                {
                    if (t.Nome.Contains(textBox3.Text))
                    {
                        trabalhadorList.Add(t);
                    }
                }
                bsTrabalhadores.DataSource = trabalhadorList;
            }
            else
            {
                List<Trabalhador> trabalhadorList = new List<Trabalhador>();
                foreach (Trabalhador t in restaurante.Trabalhadors.ToList<Trabalhador>())
                {
                    trabalhadorList.Add(t);
                }
                bsTrabalhadores.DataSource = trabalhadorList;
            }
        }
        private void btNovoCliente_Click(object sender, EventArgs e)
        {
            formNewCliente fnc = new formNewCliente(dados, false, null);
            fnc.ShowDialog();
        }
    }
}
