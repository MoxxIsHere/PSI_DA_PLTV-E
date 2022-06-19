using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
namespace ProjectodeDA.app
{
    public partial class formCategorias : Form
    {
        private Model1Container dados;
        public formCategorias(Model1Container crossDados)
        {
            InitializeComponent();
            dados = crossDados;
        }
        private void formCategorias_Load(object sender, EventArgs e)
        {
            bsCategorias.DataSource = dados.Categorias.ToList<Categoria>();
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if(tbNome.Text.Length > 0)
            {
                Categoria cat = new Categoria();
                cat.Nome = tbNome.Text;
                cat.Ativo = checkBox1.Checked;
                dados.Categorias.Add(cat);
                dados.SaveChanges();
            }
            bsCategorias.DataSource = dados.Categorias.ToList<Categoria>();
            dataGridView1.Refresh();
        }
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            dados.Categorias.Remove(dataGridView1.SelectedRows[0].DataBoundItem as Categoria);
            bsCategorias.DataSource = dados.Categorias.ToList<Categoria>();
            dataGridView1.Refresh();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Categoria edit = dataGridView1.SelectedRows[0].DataBoundItem as Categoria;
            edit.Ativo = checkBox1.Checked;
            bsCategorias.DataSource = dados.Categorias.ToList<Categoria>();
            dataGridView1.Refresh();
        }
    }
}
