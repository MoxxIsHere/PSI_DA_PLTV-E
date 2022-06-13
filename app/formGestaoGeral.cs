using System.Windows.Forms;
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
                    break;
                case "items":
                    tabsControl.SelectedTab = tabMenuItems;
                    break;
                case "pagamento":
                    tabsControl.SelectedTab = tabMetodosPag;
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
            prevForm.Show();
            this.Dispose();
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
    }
}
