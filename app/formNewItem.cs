using System;
using System.IO;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
namespace ProjectodeDA.app
{
    public partial class formNewItem : Form
    {
        private byte[] readBytes;
        private Image originalImage;
        private Image chosenImage;
        private ItemMenu editItem;
        private Model1Container dados;
        private bool EditStatus;
        public formNewItem(Model1Container crossDados, bool boolEdit, ItemMenu crossItem)
        {
            InitializeComponent();
            dados = crossDados;
            EditStatus = boolEdit;
            editItem = crossItem;
            openFileDialog1.Filter = "Image Files|*.png;*.jpg;*.jpeg;*.bmp|All Files|*.*";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog1.FileName;
                if (openFileDialog1.CheckFileExists)
                {
                    readBytes = File.ReadAllBytes(filePath);
                    MemoryStream ims = new MemoryStream(readBytes);
                    chosenImage = Image.FromStream(ims);
                    pictureBox1.Image = chosenImage;
                }
                else
                {
                    MessageBox.Show("Ficheiro Inválido", "ERRO", MessageBoxButtons.OK);
                }
            }
        }
        private void btAccept_Click(object sender, EventArgs e)
        {
            if (EditStatus)
            {
                if (CheckFilled() && readBytes != null)
                {
                    editItem.Nome = tbNome.Text;
                    editItem.Ingredientes = tbIngred.Text;
                    editItem.Preco = tbPreco.Value;
                    editItem.Ativo = cbAtivo.Checked;
                    if (originalImage != chosenImage)
                    {
                        string fotoBytes = Convert.ToBase64String(readBytes);
                        editItem.Fotografia = fotoBytes;
                    }
                    editItem.Categoria = dataGridView1.SelectedRows[0].DataBoundItem as Categoria;
                    dados.SaveChanges();
                    this.Dispose();
                }
            }
            else
            {
                if (CheckFilled() && readBytes != null)
                {
                    ItemMenu item = new ItemMenu();
                    item.Nome = tbNome.Text;
                    string fotoBytes = Convert.ToBase64String(readBytes);
                    item.Fotografia = fotoBytes;
                    item.Ingredientes = tbIngred.Text;
                    item.Preco = tbPreco.Value;
                    item.Ativo = cbAtivo.Checked;
                    item.Categoria = dataGridView1.SelectedRows[0].DataBoundItem as Categoria;
                    dados.ItemMenus.Add(item);
                    dados.SaveChanges();
                    this.Dispose();
                }
            }
        }
        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void formNewItem_Load(object sender, EventArgs e)
        {
            bsCategorias.DataSource = dados.Categorias.ToList<Categoria>();
            if(EditStatus)
            {
                MemoryStream ims = new MemoryStream(Convert.FromBase64String(editItem.Fotografia));
                readBytes = ims.ToArray();
                originalImage = Image.FromStream(ims);
                chosenImage = originalImage;
                pictureBox1.Image = originalImage;
                tbNome.Text = editItem.Nome;
                tbIngred.Text = editItem.Ingredientes;
                tbPreco.Value = editItem.Preco;
                cbAtivo.Checked = editItem.Ativo;
            }
        }
        private bool CheckFilled()
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                if (tbNome.Text.Length > 0 && tbIngred.Text.Length > 0 && (dataGridView1.SelectedRows[0].DataBoundItem as Categoria) != null && chosenImage != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
