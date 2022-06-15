using System;
using System.Linq;
using System.Windows.Forms;
namespace ProjectodeDA.app
{
    public partial class pessoasMoradas : Form
    {
        private TextBox content;
        private Model1Container dados;
        private Morada morada;
        private Morada returnMorada;
        public pessoasMoradas(TextBox textBox, Model1Container crossDB)
        {
            InitializeComponent();
            content = textBox;
            dados = crossDB;
            returnMorada = morada;
        }
        private void pessoasMoradas_Load(object sender, EventArgs e)
        {
            bsDB.DataSource = dados.Moradas.ToList<Morada>();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void btConfirm_Click(object sender, EventArgs e)
        {
            if (CheckFilled())
            {
                try
                {
                    Morada novMorada = new Morada();
                    novMorada.Rua = tbRua.Text;
                    novMorada.Cidade = tbCidade.Text;
                    novMorada.Pais = tbPais.Text;
                    novMorada.CodPostal = tbCPCol1.Text + "-" + tbCPCol2.Text;
                    dados.Moradas.Add(novMorada);
                    dados.SaveChanges();
                    content.Text = novMorada.ToString();
                    returnMorada = morada;
                    this.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Código Postal Existente \n{ex}", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                FieldWarning();
            }
        }
        private void lbMoradas_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Não há forma de apagar moradas, não é pedido de qualquer forma
            morada = lbMoradas.SelectedItem as Morada;
            if (morada != null)
            {
                tbCidade.Text = morada.Cidade;
                tbPais.Text = morada.Pais;
                tbRua.Text = morada.Rua;
                tbCPCol1.Text = morada.CodPostal.Remove(4);
                tbCPCol2.Text = morada.CodPostal.Substring(5);
            }
        }
        private void btEdit_Click(object sender, EventArgs e)
        {
            if (CheckFilled())
            {
                Morada novMorada = new Morada();
                novMorada.Rua = tbRua.Text;
                novMorada.Cidade = tbCidade.Text;
                novMorada.Pais = tbPais.Text;
                novMorada.CodPostal = tbCPCol1.Text + "-" + tbCPCol2.Text;
                if (novMorada != morada)
                {
                    try
                    {
                        morada.Rua = tbRua.Text;
                        morada.Cidade = tbCidade.Text;
                        morada.Pais = tbPais.Text;
                        morada.CodPostal = tbCPCol1.Text + "-" + tbCPCol2.Text;
                        dados.SaveChanges();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show($"Código Postal Existente \n{ex}", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                content.Text = morada.ToString();
                returnMorada = morada;
                this.Dispose();
            }
            else
            {
                FieldWarning();
            }
        }
        private bool CheckFilled()
        {
            if ((tbCidade.Text.Length > 0) && (tbCPCol1.Text.Length > 0) && (tbCPCol2.Text.Length > 0) && (tbRua.Text.Length > 0))
                return true;
            else
                return false;
        }
        private void FieldWarning()
        {
            if(tbCidade.Text.Length < 0)
            {
                lblCidade.ForeColor = System.Drawing.Color.IndianRed;
                lblCidade.Refresh();
            }
            else if(tbCPCol1.Text.Length < 0 || tbCPCol2.Text.Length < 0)
            {
                lblCP.ForeColor = System.Drawing.Color.IndianRed;
                lblCP.Refresh();
            }
            else if(tbPais.Text.Length < 0)
            {
                lblPais.ForeColor = System.Drawing.Color.IndianRed;
                lblPais.Refresh();
            }
            else if(tbRua.Text.Length < 0)
            {
                lblRua.ForeColor = System.Drawing.Color.IndianRed;
                lblRua.Refresh();
            }
        }
    }
}
