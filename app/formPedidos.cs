using System;
using System.Linq;
using System.Windows.Forms;
namespace ProjectodeDA.app
{
    public partial class formPedidos : Form
    {
        private Form formBase;
        private Restaurante restSel;
        private Model1Container dados;
        public formPedidos(Restaurante crossRest, Form crossForm, Model1Container crossDados)
        {
            InitializeComponent();
            restSel = crossRest;
            formBase = crossForm;
            dados = crossDados;
        }
        private void btRestaurantes_Click(object sender, EventArgs e)
        {
            this.Dispose();
            formBase.Show();
        }
        private void formPedidos_Load(object sender, EventArgs e)
        {
            bsDB.DataSource = dados.Pessoas.ToList<Pessoa>();
            this.Location = formBase.Location;
            tbRestSelec.Text = restSel.Nome;
        }

        private void formPedidos_FormClosing(object sender, FormClosingEventArgs e)
        {
            formBase.Dispose();
        }

        private void btSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
