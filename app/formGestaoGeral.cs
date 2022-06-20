using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.IO;
using System;
namespace ProjectodeDA.app
{
    public partial class formGestaoGeral : Form
    {
        private Model1Container dados;
        private Form prevForm;
        public formGestaoGeral(Model1Container crossData, string selecao, Form crossForm)
        {
            InitializeComponent();
            dados = crossData;
            prevForm = crossForm;
            switch (selecao)
            {
                case "empregados":
                    tabsControl.SelectedTab = tabEmpregados;
                    List<Trabalhador> empregados = new List<Trabalhador>();
                    foreach (Trabalhador pessoa in dados.Pessoas)
                    {
                        empregados.Add(pessoa);
                    }
                    bsEmpregados.DataSource = empregados;
                    break;
                case "items":
                    tabsControl.SelectedTab = tabMenuItems;
                    break;
                case "pagamento":
                    tabsControl.SelectedTab = tabMetodosPag;
                    bsMetodos.DataSource = dados.MetodosPagamento.ToList<MetodoPagamento>();
                    break;
            }
        }
        private void formGestaoGeral_FormClosing(object sender, FormClosingEventArgs e)
        {
            prevForm.Show();
            this.Dispose();
        }
        //Empregados
        private void btAddEmp_Click(object sender, System.EventArgs e)
        {
            formNewWorker novoEmp = new formNewWorker(dados, this, false, null);
            novoEmp.ShowDialog();
        }
        private void btEditEmp_Click(object sender, System.EventArgs e)
        {
            formNewWorker editEmp = new formNewWorker(dados, this, true, gvEmpregados.SelectedRows[0].DataBoundItem as Trabalhador);
            editEmp.ShowDialog();
        }
        private void formGestaoGeral_Activated(object sender, System.EventArgs e)
        {
            List<Trabalhador> empregados = new List<Trabalhador>();
            foreach (Trabalhador pessoa in dados.Pessoas)
            {
                empregados.Add(pessoa);
            }
            bsEmpregados.DataSource = empregados;
            gvEmpregados.DataSource = bsEmpregados;
            bsMetodos.DataSource = dados.MetodosPagamento.ToList<MetodoPagamento>();
            bsItems.DataSource = dados.ItemMenus.ToList<ItemMenu>();
        }
        private void btActEmp_Click(object sender, System.EventArgs e)
        {
            List<Trabalhador> empregados = new List<Trabalhador>();
            foreach (Trabalhador pessoa in dados.Pessoas)
            {
                empregados.Add(pessoa);
            }
            bsEmpregados.DataSource = empregados;
            gvEmpregados.DataSource = bsEmpregados;
        }
        private void btProcEmp_Click(object sender, System.EventArgs e)
        {
            if (tbPesqEmp.Text != null)
            {
                List<Trabalhador> empregadosSorted = new List<Trabalhador>();
                foreach (Trabalhador pessoa in dados.Pessoas)
                {
                    if (pessoa.Nome.Contains(tbPesqEmp.Text))
                    {
                        empregadosSorted.Add(pessoa);
                    }
                }
                bsEmpregados.DataSource = empregadosSorted;
            }
            else
            {
                List<Trabalhador> empregados = new List<Trabalhador>();
                foreach (Trabalhador pessoa in dados.Pessoas)
                {
                    empregados.Add(pessoa);
                }
                bsEmpregados.DataSource = empregados;
            }
        }
        private void tbPesqEmp_TextChanged(object sender, System.EventArgs e)
        {
            if (tbPesqEmp.Text != null)
            {
                List<Trabalhador> empregadosSorted = new List<Trabalhador>();
                foreach (Trabalhador pessoa in dados.Pessoas)
                {
                    if (pessoa.Nome.Contains(tbPesqEmp.Text) || pessoa.Posicao.Contains(tbPesqEmp.Text))
                    {
                        empregadosSorted.Add(pessoa);
                    }
                }
                bsEmpregados.DataSource = empregadosSorted;
            }
            else
            {
                List<Trabalhador> empregados = new List<Trabalhador>();
                foreach (Trabalhador pessoa in dados.Pessoas)
                {
                    empregados.Add(pessoa);
                }
                bsEmpregados.DataSource = empregados;
            }
        }
        private void btDeleteEmp_Click(object sender, System.EventArgs e)
        {
            dados.Pessoas.Remove(gvEmpregados.SelectedRows[0].DataBoundItem as Trabalhador);
        }
        //Métodos Pagamento
        private void toolStripButton1_Click(object sender, System.EventArgs e)
        {
            formNewMetodoPag metodoPag = new formNewMetodoPag(dados, false, null);
            metodoPag.ShowDialog();
        }
        private void toolStripButton2_Click(object sender, System.EventArgs e)
        {
            formNewMetodoPag metodoPag = new formNewMetodoPag(dados, true, gvMetodos.SelectedRows[0].DataBoundItem as MetodoPagamento);
            metodoPag.ShowDialog();
        }
        private void toolStripButton3_Click(object sender, System.EventArgs e)
        {
            dados.MetodosPagamento.Remove(gvMetodos.SelectedRows[0].DataBoundItem as MetodoPagamento);
            dados.SaveChanges();
            bsMetodos.DataSource = dados.MetodosPagamento.ToList<MetodoPagamento>();
        }
        private void toolStripButton4_Click(object sender, System.EventArgs e)
        {
            bsMetodos.DataSource = dados.MetodosPagamento.ToList<MetodoPagamento>();
        }
        private void toolStripButton5_Click(object sender, System.EventArgs e)
        {
            if (tbMetodosPesquisa.Text != null)
            {
                List<MetodoPagamento> metodosPesq = new List<MetodoPagamento>();
                foreach (MetodoPagamento pesq in dados.MetodosPagamento)
                {
                    if(pesq.Metodopagamento.Contains(tbMetodosPesquisa.Text))
                    {
                        metodosPesq.Add(pesq);
                    }
                }
            }
            else
            {
                bsMetodos.DataSource = dados.MetodosPagamento.ToList<MetodoPagamento>();
            }
        }
        private void tbMetodosPesquisa_TextChanged(object sender, System.EventArgs e)
        {
            if (tbMetodosPesquisa.Text != null)
            {
                List<MetodoPagamento> metodosPesq = new List<MetodoPagamento>();
                foreach (MetodoPagamento pesq in dados.MetodosPagamento)
                {
                    if (pesq.Metodopagamento.Contains(tbMetodosPesquisa.Text))
                    {
                        metodosPesq.Add(pesq);
                    }
                }
            }
            else
            {
                bsMetodos.DataSource = dados.MetodosPagamento.ToList<MetodoPagamento>();
            }
        }
        //Items
        private void toolStripButton6_Click(object sender, System.EventArgs e)
        {
            formNewItem newItem = new formNewItem(dados, false, null);
            newItem.ShowDialog();
        }
        private void toolStripButton7_Click(object sender, System.EventArgs e)
        {
            formNewItem newItem = new formNewItem(dados, true, gvItems.SelectedRows[0].DataBoundItem as ItemMenu);
            newItem.ShowDialog();
        }
        private void toolStripButton8_Click(object sender, System.EventArgs e)
        {
            dados.ItemMenus.Remove(gvItems.SelectedRows[0].DataBoundItem as ItemMenu);
            dados.SaveChanges();
            bsItems.DataSource = dados.ItemMenus.ToList<ItemMenu>();
        }
        private void tabsControl_TabIndexChanged(object sender, System.EventArgs e)
        {
            if(tabsControl.SelectedTab == tabMenuItems)
            {
                foreach (ItemMenu c in dados.ItemMenus)
                {

                }
            }
        }
        private void formGestaoGeral_Load(object sender, System.EventArgs e)
        {
            List<Trabalhador> empregados = new List<Trabalhador>();
            foreach (Trabalhador pessoa in dados.Pessoas)
            {
                empregados.Add(pessoa);
            }
            bsEmpregados.DataSource = empregados;
            bsMetodos.DataSource = dados.MetodosPagamento.ToList<MetodoPagamento>();
            bsItems.DataSource = dados.ItemMenus.ToList<ItemMenu>();
            foreach(Categoria c in dados.Categorias.ToList<Categoria>())
            {
                categoriasToolStripMenuItem.DropDownItems.Add(c.Nome, null);
            }
        }
        private void gvItems_SelectionChanged(object sender, System.EventArgs e)
        {
            if(gvItems.SelectedRows.Count > 0)
            {
                ItemMenu selected = gvItems.SelectedRows[0].DataBoundItem as ItemMenu;
                byte[] imagem = Convert.FromBase64String(selected.Fotografia);
                MemoryStream ms = new MemoryStream(imagem);
                pictureBox1.Image = Image.FromStream(ms);
                richTextBox1.Text = selected.Ingredientes;
            }
            else
            {
                pictureBox1.Image = null;
                richTextBox1.Text = null;
            }
        }
        private void gerirCategoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formCategorias catsd = new formCategorias(dados);
            catsd.ShowDialog();
        }
        private void todasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bsItems.DataSource = dados.ItemMenus.ToList<ItemMenu>();
        }
        private void categoriasToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Text != "Todas")
            {
                List<ItemMenu> categorisedItems = new List<ItemMenu>();
                foreach (ItemMenu c in dados.ItemMenus.ToList<ItemMenu>())
                {
                    if (e.ClickedItem.Text == c.Categoria.ToString())
                    {
                        categorisedItems.Add(c);
                    }
                }
                bsItems.DataSource = categorisedItems;
            }
        }
        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            tabsControl.SelectedTab = tabMetodosPag;
        }
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            tabsControl.SelectedTab = tabMenuItems;
        }
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            tabsControl.SelectedTab = tabEmpregados;
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            prevForm.Show();
            this.Dispose();
        }
    }
}
