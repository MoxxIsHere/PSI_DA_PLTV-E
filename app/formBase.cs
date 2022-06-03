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
            tbRestSelec.Text = "Nenhum";
            dados = new Model1Container();
            bsBD.DataSource = dados.Restaurantes.ToList<Restaurante>();
            gvRestaurantes.ClearSelection();
        }
        private void btNewRest_Click(object sender, EventArgs e)
        {
            var diag = new formNewRest(false, null, dados);
            diag.ShowDialog();
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
                    tbRestSelec.Text = restSel.ToString();
                    btEditRest.Enabled = true;
                    btDeleteRest.Enabled = true;
                }
                else
                {
                    tbRestSelec.Text = "Nenhum";
                    btEditRest.Enabled = false;
                    btDeleteRest.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                tbRestSelec.Text = "ERROR";
                btEditRest.Enabled = false;
                btDeleteRest.Enabled = false;
            }
        }
        private void btDeleteRest_Click(object sender, EventArgs e)
        {
            try
            {
                Restaurante restSel = gvRestaurantes.SelectedRows[0].DataBoundItem as Restaurante;
                dados.Restaurantes.Remove(restSel);
                dados.SaveChanges();
            }
            catch (Exception ex)
            {
                tbRestSelec.Text = "ERROR";
            }
        }
        private void btEditRest_Click(object sender, EventArgs e)
        {
            try
            {
                Restaurante restSel = gvRestaurantes.SelectedRows[0].DataBoundItem as Restaurante;
                var diag = new formNewRest(true, restSel, dados);
                diag.ShowDialog();
            }
            catch (Exception ex)
            {
                tbRestSelec.Text = "ERROR";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            bsBD.DataSource = dados.Restaurantes.ToList<Restaurante>();
        }
        private void btPedidos_Click(object sender, EventArgs e)
        {
            try
            {
                restSel = gvRestaurantes.SelectedRows[0].DataBoundItem as Restaurante;
                var pedidos = new formPedidos(restSel, this, dados);
                pedidos.Show();
                this.Hide();
            }
            catch(Exception ex)
            {
                tbRestSelec.Text = "ERROR";
            }
        }
        private void btMenu_Click(object sender, EventArgs e)
        {

        }
    }
}
