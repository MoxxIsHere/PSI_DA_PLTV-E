using System;
using System.Windows.Forms;
using System.Linq;
using System.Collections.Generic;
namespace ProjectodeDA.app
{
    public partial class formNewEstado : Form
    {
        private Model1Container dados;
        public formNewEstado(Model1Container crossDados)
        {
            InitializeComponent();
            dados = crossDados;
        }
        private void gvEstados_SelectionChanged(object sender, EventArgs e)
        {
            if(gvEstados.SelectedRows.Count > 0)
            {
                tbEstado.Text = (gvEstados.SelectedRows[0].DataBoundItem as Estado).estado;
            }
        }
        private void formNewEstado_Load(object sender, EventArgs e)
        {
            bsEstados.DataSource = dados.Estados.ToList<Estado>();
        }
        private void btOk_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void btAddEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbEstado.Text.Length > 0)
                {
                    Estado novoEstado = new Estado();
                    novoEstado.estado = tbEstado.Text;
                    dados.Estados.Add(novoEstado);
                    dados.SaveChanges();
                    bsEstados.DataSource = dados.Estados.ToList<Estado>();
                }
            }
            catch { }
        }
        private void btEdit_Click(object sender, EventArgs e)
        {
            if(gvEstados.SelectedRows.Count > 0)
            {
                if((gvEstados.SelectedRows[0].DataBoundItem as Estado).estado != tbEstado.Text)
                {
                    (gvEstados.SelectedRows[0].DataBoundItem as Estado).estado = tbEstado.Text;
                    dados.SaveChanges();
                    bsEstados.DataSource = dados.Estados.ToList<Estado>();
                }
            }
        }

        private void btApagar_Click(object sender, EventArgs e)
        {
            if (gvEstados.SelectedRows.Count > 0)
            {
                dados.Estados.Remove(gvEstados.SelectedRows[0].DataBoundItem as Estado);
                dados.SaveChanges();
                bsEstados.DataSource = dados.Estados.ToList<Estado>();
            }
        }
    }
}
