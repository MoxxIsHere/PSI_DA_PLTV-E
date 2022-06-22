using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
namespace ProjectodeDA.app
{
    public partial class formNewPedido : Form
    {
        private Model1Container dados;
        private Restaurante restaurante;
        public formNewPedido(Model1Container crossDados, Restaurante crossRest)
        {
            InitializeComponent();
            dados = crossDados;
        }
        private void btAccept_Click(object sender, EventArgs e)
        {
            if ()
            {

            }
            this.Dispose();
        }
        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text == null)
            {
                List<Cliente> clienteList = new List<Cliente>();
                foreach (Cliente c in dados.Pessoas.ToList<Pessoa>())
                {
                    clienteList.Add(c);
                }
                bsClientes.DataSource = clienteList;
            }
            else
            {
                List<Cliente> clienteList = new List<Cliente>();
                foreach (Cliente c in dados.Pessoas.ToList<Pessoa>())
                {
                    if(c.Nome.Contains(textBox1.Text) || c.NumContribuinte.Contains(textBox1.Text))
                    {
                        clienteList.Add(c);
                    }
                }
                bsClientes.DataSource = clienteList;
            }
        }
        private void formNewPedido_Load(object sender, EventArgs e)
        {
            List<Cliente> clienteList = new List<Cliente>();
            foreach(Cliente c in dados.Pessoas.ToList<Pessoa>())
            {
                clienteList.Add(c);
            }
            bsClientes.DataSource = clienteList;
        }
    }
}
