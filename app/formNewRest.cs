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
        public formNewRest()
        {
            InitializeComponent();
        }
        private void btConfirm_Click(object sender, EventArgs e)
        {
            if(CheckFilled())
            {
                //introduzir dados na DB
            }
            else
            {
                lblError.Visible = true;
            }
        }
        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool CheckFilled()
        {
            if((tbCidade.Text.Length>0)&&(tbCodigoPostalCol1.Text.Length>0)&&(tbCodigoPostalCol2.Text.Length>0)&&(tbNome.Text.Length>0)&&(tbRua.Text.Length>0))
                return true;
            else
                return false;
        }
    }
}
