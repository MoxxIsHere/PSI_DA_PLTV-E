using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using ProjectodeDA.app;
namespace ProjectodeDA
{
    public partial class formBase : Form
    {
        public int RestSelId;
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
        }
        private void btNewRest_Click(object sender, EventArgs e)
        {
            var diag = new formNewRest(false, null);
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
                    tbRestSelec.Text = restSel.ToString();
                else
                    tbRestSelec.Text = "Nenhum";
            }
            catch(Exception ex)
            {
                tbRestSelec.Text = "Error";
            }
        }
        private void btDeleteRest_Click(object sender, EventArgs e)
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
                tbRestSelec.Text = "Error";
            }
        }
        private void btEditRest_Click(object sender, EventArgs e)
        {
            try
            {
                Restaurante restSel = gvRestaurantes.SelectedRows[0].DataBoundItem as Restaurante;
                var diag = new formNewRest(true, restSel);
                diag.ShowDialog();
            }
            catch (Exception ex)
            {
                tbRestSelec.Text = "Error";
            }
        }
    }
}
