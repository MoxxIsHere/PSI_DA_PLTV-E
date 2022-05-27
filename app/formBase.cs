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
            var diag = new formNewRest();
            diag.ShowDialog();
        }
    }
}
