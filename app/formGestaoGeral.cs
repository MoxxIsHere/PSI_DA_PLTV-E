using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
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
        private void restaurantesToolStripMenuItem1_Click(object sender, System.EventArgs e)
        {
            prevForm.Show();
            this.Dispose();
        }
        private void formGestaoGeral_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
            prevForm.Dispose();
        }
        private void empregadosToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            tabsControl.SelectedTab = tabEmpregados;
        }
        private void itemsDeVendaToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            tabsControl.SelectedTab = tabMenuItems;
        }
        private void métodosDePagamentoToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            tabsControl.SelectedTab = tabMetodosPag;
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

        }
        private void toolStripButton8_Click(object sender, System.EventArgs e)
        {

        }
        private void toolStripComboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            List<ItemMenu> itemsCategoriaEscolhida = new List<ItemMenu>();
            if(toolStripComboBox1.Text == "Todas")
            {
                bsItems.DataSource = dados.ItemMenus.ToList<ItemMenu>();
            }
            else
            {
                foreach(ItemMenu im in dados.ItemMenus.ToList<ItemMenu>())
                {
                    if(im.Categoria == toolStripComboBox1.SelectedItem)
                    {
                        itemsCategoriaEscolhida.Add(im); //PRECISO DE IR BUSCAR TUDO E METER MANUALMENTE E ACHO QUE A FOTO NÃO ESTA A GRAVAR NOS ITEM MENU
                    }
                }
                bsItems.DataSource = itemsCategoriaEscolhida;
            }
        }
        private void tabsControl_TabIndexChanged(object sender, System.EventArgs e)
        {
            if(tabsControl.SelectedTab == tabMenuItems)
            {
                toolStripComboBox1.Items.Add("Todas");
                toolStripComboBox1.Text = "Todas";
                foreach(Categoria c in dados.Categorias.ToList<Categoria>())
                {
                    toolStripComboBox1.Items.Add(c);
                }
            }
            List<ItemMenu> itemsCategoriaEscolhida = new List<ItemMenu>();
            if (toolStripComboBox1.Text == "Todas")
            {
                bsItems.DataSource = dados.ItemMenus.ToList<ItemMenu>();
            }
            else
            {
                foreach (ItemMenu im in dados.ItemMenus.ToList<ItemMenu>())
                {
                    if (im.Categoria == toolStripComboBox1.SelectedItem)
                    {
                        itemsCategoriaEscolhida.Add(im);
                    }
                }
                bsItems.DataSource = itemsCategoriaEscolhida;
            }
        }
        private void toolStripButton9_Click(object sender, System.EventArgs e)
        {
            formCategorias catsd = new formCategorias(dados);
            catsd.ShowDialog();
        }
    }
}
