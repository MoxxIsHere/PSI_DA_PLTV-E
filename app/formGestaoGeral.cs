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
    }
}
