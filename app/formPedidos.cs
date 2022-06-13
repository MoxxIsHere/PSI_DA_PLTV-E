using System.Windows.Forms;
namespace ProjectodeDA.app
{
    public partial class formPedidos : Form
    {
        private Restaurante restSel;
        private Model1Container dados;
        private Form mainForm;
        public formPedidos(Restaurante prevRest, Form crossForm, Model1Container crossData)
        {
            InitializeComponent();
            restSel = prevRest;
            mainForm = crossForm;
            dados = crossData;
        }
    }
}
