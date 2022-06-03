using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectodeDA.app
{
    public partial class pessoasMoradas : Form
    {
        private TextBox content;
        private Model1Container dados;
        private Morada morada;
        public pessoasMoradas(TextBox textBox, Model1Container crossDB)
        {
            InitializeComponent();
            content = textBox;
            dados = crossDB;
        }
        private void pessoasMoradas_Load(object sender, EventArgs e)
        {
            bsDB.DataSource = dados.Moradas;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btConfirm_Click(object sender, EventArgs e)
        {
            prevForm.
        }
    }
}
