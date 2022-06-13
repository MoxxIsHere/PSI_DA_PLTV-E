using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
namespace ProjectodeDA.app
{
    public partial class formPedidos : Form
    {
        private bool editReal;
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
            List<Cliente> clientes = new List<Cliente>();
            foreach(Cliente cliente in dados.Pessoas)
            {
                clientes.Add(cliente);
            }
            bsDB.DataSource = clientes;
            this.Location = formBase.Location;
            tbRestSelec.Text = restSel.Nome;
        }
        private void formPedidos_FormClosing(object sender, FormClosingEventArgs e)
        {
            formBase.Dispose();
        }
        private void btSearch_Click(object sender, EventArgs e)
        {
            LookUpCliente(tbSearch.Text);
        }
        private void LookUpCliente(string query)
        {
            if (query != null)
            {
                lbClientes.DataSource = dados.Pessoas.ToList<Pessoa>();
                List<Pessoa> searchPessoas = new List<Pessoa>();
                foreach (Pessoa pessoa in lbClientes.Items)
                {
                    if (pessoa.Nome.ToLower().Contains(query.ToLower()))
                    {
                        searchPessoas.Add(pessoa);
                    }
                }
                lbClientes.DataSource = searchPessoas;
            }
            else
            {
                lbClientes.DataSource = dados.Pessoas.ToList<Pessoa>();
            }
        }
        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            LookUpCliente(tbSearch.Text);
        }

        private void btNewClient_Click(object sender, EventArgs e)
        {
            gpDisplayPessoa.Text = "Novo Cliente";
            tbNome.ReadOnly = false;
            tbNome.Text = null;
            tbTelemovel.ReadOnly = false;
            tbTelemovel.Text = null;
            tbMorada.Text = null;
            tbTGasto.Text = null;
            tbTGasto.Enabled = false;
            tbNif.Text = null;
        }
        private void btEditClient_Click(object sender, EventArgs e)
        {

        }
        private void btDeleteRest_Click(object sender, EventArgs e)
        {

        }
        private void lbClientes_SelectedValueChanged(object sender, EventArgs e)
        {
            if(lbClientes.SelectedValue != null)
            {
                Cliente cliente = lbClientes.SelectedItem as Cliente;
                gpDisplayPessoa.Text = "Cliente";
                try
                {
                    tbNome.Text = cliente.Nome;
                    tbNome.ReadOnly = true;
                    tbTelemovel.Text = cliente.Telemovel;
                    tbTelemovel.ReadOnly = true;
                    tbMorada.Text = cliente.Moradas.ToString();
                    tbTGasto.Enabled = true;
                    tbTGasto.Text = Convert.ToString(cliente.TotalGasto);
                    tbNif.Text = cliente.NumContribuinte;
                    tbNif.ReadOnly = true;
                }
                catch (Exception ex)
                {
                    tbNome.Text = null;
                    tbNome.ReadOnly = true;
                    tbTelemovel.Text = null;
                    tbTelemovel.ReadOnly = true;
                    tbMorada.Text = null;
                    tbNif.ReadOnly = true;
                    tbTGasto.Enabled = true;
                    tbTGasto.Text = null;
                    tbNif.Text = null;
                    tbNif.ReadOnly = true;
                }
            }
        }
        private void btConfirmar_Click(object sender, EventArgs e)
        {
            if (editReal)
            {

            }
            else
            {
                Cliente novoCliente = new Cliente();
                novoCliente.Nome = tbNome.Text;
                novoCliente.Telemovel = tbTelemovel.Text;
                //novoCliente.Moradas = ;
                novoCliente.NumContribuinte = tbNif.Text;
            }
        }
        private void btMoradas_Click(object sender, EventArgs e)
        {
            var selMorada = new pessoasMoradas(tbMorada, dados);
            selMorada.ShowDialog();
        }
    }
}
