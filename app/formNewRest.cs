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
    public partial class formNewRest : Form
    {
        private bool EditStatus;
        private Restaurante RestaurEdit;
        private Model1Container dados;
        public formNewRest(bool edit, Restaurante restaurante)
        {
            InitializeComponent();
            EditStatus = edit;
            RestaurEdit = restaurante;
        }
        private void formNewRest_Load(object sender, EventArgs e)
        {
            if (EditStatus)
            {
                dados = new Model1Container();

                Text = "Editar Restaurante";
                tbRua.Text = RestaurEdit.Moradas.Rua;
                tbCidade.Text = RestaurEdit.Moradas.Cidade;
                tbPais.Text = RestaurEdit.Moradas.Pais;
                tbCodigoPostalCol1.Text = RestaurEdit.Moradas.CodPostal.Remove(4);
                tbCodigoPostalCol2.Text = RestaurEdit.Moradas.CodPostal.Substring(5);
                tbNome.Text = RestaurEdit.Nome;
            }
            else
            {
                dados = new Model1Container();
            }
        }
        private void btConfirm_Click(object sender, EventArgs e)
        {
            if (CheckFilled() && EditStatus)
            {

                Restaurante editValuesRest = dados.Restaurantes.Find(RestaurEdit.Id);
                Morada editValuesMor = dados.Moradas.Find(RestaurEdit.Moradas.Id);

                editValuesMor.Rua = tbRua.Text;
                editValuesMor.Cidade = tbCidade.Text;
                editValuesMor.Pais = tbPais.Text;
                editValuesMor.CodPostal = (tbCodigoPostalCol1 + "-" + tbCodigoPostalCol2.Text);
                editValuesRest.Nome = tbNome.Text;

                dados.SaveChanges();

                this.Dispose();
            }
            else if((CheckFilled() && EditStatus) == false)
            {
                //introduzir dados na DB
                var novaMorada = new Morada() { Rua = tbRua.Text, Cidade = tbCidade.Text, Pais = tbPais.Text, CodPostal=tbCodigoPostalCol1.Text+"-"+tbCodigoPostalCol2.Text };
                dados.Moradas.Add(novaMorada);
                var novoRestaur = new Restaurante() { Nome=tbNome.Text, Moradas=novaMorada };
                novaMorada.Restaurante = novoRestaur;
                dados.Restaurantes.Add(novoRestaur);

                dados.SaveChanges();

                this.Dispose();
            }
            else
            {
                lblError.Visible = true;
            }
        }
        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private bool CheckFilled()
        {
            if ((tbCidade.Text.Length>0)&&(tbCodigoPostalCol1.Text.Length>0)&&(tbCodigoPostalCol2.Text.Length>0)&&(tbNome.Text.Length>0)&&(tbRua.Text.Length>0))
                return true;
            else
                return false;
        }
    }
}
