namespace ProjectodeDA.app
{
    partial class formPedidos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formPedidos));
            this.btMenu = new System.Windows.Forms.Button();
            this.btPedidos = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btRestaurantes = new System.Windows.Forms.Button();
            this.tbRestSelec = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.tabBox = new System.Windows.Forms.TabControl();
            this.tabPedidos = new System.Windows.Forms.TabPage();
            this.tabClientes = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.bsDB = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabBox.SuspendLayout();
            this.tabClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsDB)).BeginInit();
            this.SuspendLayout();
            // 
            // btMenu
            // 
            this.btMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMenu.Location = new System.Drawing.Point(8, 105);
            this.btMenu.Name = "btMenu";
            this.btMenu.Size = new System.Drawing.Size(124, 31);
            this.btMenu.TabIndex = 18;
            this.btMenu.Text = "Menu";
            this.btMenu.UseVisualStyleBackColor = true;
            // 
            // btPedidos
            // 
            this.btPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPedidos.Location = new System.Drawing.Point(8, 58);
            this.btPedidos.Name = "btPedidos";
            this.btPedidos.Size = new System.Drawing.Size(124, 31);
            this.btPedidos.TabIndex = 17;
            this.btPedidos.Text = "Pedidos e Clientes";
            this.btPedidos.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::ProjectodeDA.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(19, 301);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // btRestaurantes
            // 
            this.btRestaurantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRestaurantes.Location = new System.Drawing.Point(8, 12);
            this.btRestaurantes.Name = "btRestaurantes";
            this.btRestaurantes.Size = new System.Drawing.Size(124, 31);
            this.btRestaurantes.TabIndex = 15;
            this.btRestaurantes.Text = "Restaurantes";
            this.btRestaurantes.UseVisualStyleBackColor = true;
            this.btRestaurantes.Click += new System.EventHandler(this.btRestaurantes_Click);
            // 
            // tbRestSelec
            // 
            this.tbRestSelec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbRestSelec.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbRestSelec.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbRestSelec.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRestSelec.Location = new System.Drawing.Point(0, 430);
            this.tbRestSelec.Margin = new System.Windows.Forms.Padding(0);
            this.tbRestSelec.Name = "tbRestSelec";
            this.tbRestSelec.ReadOnly = true;
            this.tbRestSelec.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbRestSelec.Size = new System.Drawing.Size(138, 20);
            this.tbRestSelec.TabIndex = 14;
            this.tbRestSelec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(5, 414);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Restaurante Selecionado";
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.splitter1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitter1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(138, 450);
            this.splitter1.TabIndex = 12;
            this.splitter1.TabStop = false;
            // 
            // tabBox
            // 
            this.tabBox.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabBox.Controls.Add(this.tabPedidos);
            this.tabBox.Controls.Add(this.tabClientes);
            this.tabBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabBox.ItemSize = new System.Drawing.Size(20, 20);
            this.tabBox.Location = new System.Drawing.Point(138, 0);
            this.tabBox.Margin = new System.Windows.Forms.Padding(0);
            this.tabBox.Multiline = true;
            this.tabBox.Name = "tabBox";
            this.tabBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabBox.SelectedIndex = 0;
            this.tabBox.Size = new System.Drawing.Size(662, 450);
            this.tabBox.TabIndex = 19;
            // 
            // tabPedidos
            // 
            this.tabPedidos.Location = new System.Drawing.Point(24, 4);
            this.tabPedidos.Name = "tabPedidos";
            this.tabPedidos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPedidos.Size = new System.Drawing.Size(634, 442);
            this.tabPedidos.TabIndex = 0;
            this.tabPedidos.Text = "Pedidos";
            this.tabPedidos.UseVisualStyleBackColor = true;
            // 
            // tabClientes
            // 
            this.tabClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.tabClientes.Controls.Add(this.btSearch);
            this.tabClientes.Controls.Add(this.textBox1);
            this.tabClientes.Controls.Add(this.listBox1);
            this.tabClientes.Location = new System.Drawing.Point(24, 4);
            this.tabClientes.Name = "tabClientes";
            this.tabClientes.Padding = new System.Windows.Forms.Padding(3);
            this.tabClientes.Size = new System.Drawing.Size(634, 442);
            this.tabClientes.TabIndex = 1;
            this.tabClientes.Text = "Clientes";
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.DataSource = this.bsDB;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(299, 35);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(332, 404);
            this.listBox1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(299, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(303, 23);
            this.textBox1.TabIndex = 1;
            // 
            // btSearch
            // 
            this.btSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btSearch.BackColor = System.Drawing.SystemColors.Window;
            this.btSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btSearch.Location = new System.Drawing.Point(608, 6);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(23, 23);
            this.btSearch.TabIndex = 2;
            this.btSearch.UseVisualStyleBackColor = false;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // formPedidos
            // 
            this.AcceptButton = this.btSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabBox);
            this.Controls.Add(this.btMenu);
            this.Controls.Add(this.btPedidos);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btRestaurantes);
            this.Controls.Add(this.tbRestSelec);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.splitter1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "formPedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Pedidos e Clientes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formPedidos_FormClosing);
            this.Load += new System.EventHandler(this.formPedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabBox.ResumeLayout(false);
            this.tabClientes.ResumeLayout(false);
            this.tabClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsDB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btMenu;
        private System.Windows.Forms.Button btPedidos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btRestaurantes;
        private System.Windows.Forms.TextBox tbRestSelec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TabControl tabBox;
        private System.Windows.Forms.TabPage tabPedidos;
        private System.Windows.Forms.TabPage tabClientes;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.BindingSource bsDB;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btSearch;
    }
}