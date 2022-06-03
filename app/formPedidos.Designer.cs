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
            this.btSearch = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.lbClientes = new System.Windows.Forms.ListBox();
            this.bsDB = new System.Windows.Forms.BindingSource(this.components);
            this.btDeleteRest = new System.Windows.Forms.Button();
            this.btEditClient = new System.Windows.Forms.Button();
            this.btNewClient = new System.Windows.Forms.Button();
            this.gpDisplayPessoa = new System.Windows.Forms.GroupBox();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTelemovel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMorada = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbTGasto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbNif = new System.Windows.Forms.TextBox();
            this.btConfirmar = new System.Windows.Forms.Button();
            this.btMoradas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabBox.SuspendLayout();
            this.tabClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsDB)).BeginInit();
            this.gpDisplayPessoa.SuspendLayout();
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
            this.tabClientes.Controls.Add(this.btConfirmar);
            this.tabClientes.Controls.Add(this.gpDisplayPessoa);
            this.tabClientes.Controls.Add(this.btDeleteRest);
            this.tabClientes.Controls.Add(this.btSearch);
            this.tabClientes.Controls.Add(this.btEditClient);
            this.tabClientes.Controls.Add(this.tbSearch);
            this.tabClientes.Controls.Add(this.btNewClient);
            this.tabClientes.Controls.Add(this.lbClientes);
            this.tabClientes.Location = new System.Drawing.Point(24, 4);
            this.tabClientes.Name = "tabClientes";
            this.tabClientes.Padding = new System.Windows.Forms.Padding(3);
            this.tabClientes.Size = new System.Drawing.Size(634, 442);
            this.tabClientes.TabIndex = 1;
            this.tabClientes.Text = "Clientes";
            // 
            // btSearch
            // 
            this.btSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btSearch.BackColor = System.Drawing.SystemColors.Window;
            this.btSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btSearch.Image = global::ProjectodeDA.Properties.Resources.search;
            this.btSearch.Location = new System.Drawing.Point(263, 107);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(25, 25);
            this.btSearch.TabIndex = 2;
            this.btSearch.UseVisualStyleBackColor = false;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearch.Location = new System.Drawing.Point(6, 109);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(253, 23);
            this.tbSearch.TabIndex = 1;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // lbClientes
            // 
            this.lbClientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbClientes.DataSource = this.bsDB;
            this.lbClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClientes.FormattingEnabled = true;
            this.lbClientes.ItemHeight = 20;
            this.lbClientes.Location = new System.Drawing.Point(294, -2);
            this.lbClientes.Name = "lbClientes";
            this.lbClientes.Size = new System.Drawing.Size(340, 444);
            this.lbClientes.TabIndex = 0;
            this.lbClientes.SelectedValueChanged += new System.EventHandler(this.lbClientes_SelectedValueChanged);
            // 
            // btDeleteRest
            // 
            this.btDeleteRest.Enabled = false;
            this.btDeleteRest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDeleteRest.Location = new System.Drawing.Point(198, 8);
            this.btDeleteRest.Name = "btDeleteRest";
            this.btDeleteRest.Size = new System.Drawing.Size(90, 90);
            this.btDeleteRest.TabIndex = 22;
            this.btDeleteRest.Text = "Apagar Cliente";
            this.btDeleteRest.UseVisualStyleBackColor = true;
            this.btDeleteRest.Click += new System.EventHandler(this.btDeleteRest_Click);
            // 
            // btEditClient
            // 
            this.btEditClient.Enabled = false;
            this.btEditClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditClient.Location = new System.Drawing.Point(102, 8);
            this.btEditClient.Name = "btEditClient";
            this.btEditClient.Size = new System.Drawing.Size(90, 90);
            this.btEditClient.TabIndex = 21;
            this.btEditClient.Text = "Editar Cliente";
            this.btEditClient.UseVisualStyleBackColor = true;
            this.btEditClient.Click += new System.EventHandler(this.btEditClient_Click);
            // 
            // btNewClient
            // 
            this.btNewClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNewClient.Location = new System.Drawing.Point(6, 8);
            this.btNewClient.Name = "btNewClient";
            this.btNewClient.Size = new System.Drawing.Size(90, 90);
            this.btNewClient.TabIndex = 20;
            this.btNewClient.Text = "Novo Cliente";
            this.btNewClient.UseVisualStyleBackColor = true;
            this.btNewClient.Click += new System.EventHandler(this.btNewClient_Click);
            // 
            // gpDisplayPessoa
            // 
            this.gpDisplayPessoa.Controls.Add(this.btMoradas);
            this.gpDisplayPessoa.Controls.Add(this.label6);
            this.gpDisplayPessoa.Controls.Add(this.tbNif);
            this.gpDisplayPessoa.Controls.Add(this.label5);
            this.gpDisplayPessoa.Controls.Add(this.tbTGasto);
            this.gpDisplayPessoa.Controls.Add(this.label4);
            this.gpDisplayPessoa.Controls.Add(this.tbMorada);
            this.gpDisplayPessoa.Controls.Add(this.label3);
            this.gpDisplayPessoa.Controls.Add(this.tbTelemovel);
            this.gpDisplayPessoa.Controls.Add(this.label2);
            this.gpDisplayPessoa.Controls.Add(this.tbNome);
            this.gpDisplayPessoa.ForeColor = System.Drawing.SystemColors.Window;
            this.gpDisplayPessoa.Location = new System.Drawing.Point(6, 184);
            this.gpDisplayPessoa.Name = "gpDisplayPessoa";
            this.gpDisplayPessoa.Size = new System.Drawing.Size(282, 250);
            this.gpDisplayPessoa.TabIndex = 23;
            this.gpDisplayPessoa.TabStop = false;
            this.gpDisplayPessoa.Text = "Cliente";
            // 
            // tbNome
            // 
            this.tbNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNome.Location = new System.Drawing.Point(6, 33);
            this.tbNome.Name = "tbNome";
            this.tbNome.ReadOnly = true;
            this.tbNome.Size = new System.Drawing.Size(270, 23);
            this.tbNome.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(203, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 27;
            this.label3.Text = "Telemóvel";
            // 
            // tbTelemovel
            // 
            this.tbTelemovel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTelemovel.Location = new System.Drawing.Point(6, 79);
            this.tbTelemovel.Name = "tbTelemovel";
            this.tbTelemovel.ReadOnly = true;
            this.tbTelemovel.Size = new System.Drawing.Size(270, 23);
            this.tbTelemovel.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(220, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 29;
            this.label4.Text = "Morada";
            // 
            // tbMorada
            // 
            this.tbMorada.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMorada.Location = new System.Drawing.Point(6, 125);
            this.tbMorada.Name = "tbMorada";
            this.tbMorada.ReadOnly = true;
            this.tbMorada.Size = new System.Drawing.Size(247, 23);
            this.tbMorada.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(194, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 17);
            this.label5.TabIndex = 31;
            this.label5.Text = "Total Gasto";
            // 
            // tbTGasto
            // 
            this.tbTGasto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTGasto.Location = new System.Drawing.Point(6, 171);
            this.tbTGasto.Name = "tbTGasto";
            this.tbTGasto.ReadOnly = true;
            this.tbTGasto.Size = new System.Drawing.Size(270, 23);
            this.tbTGasto.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(79, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 17);
            this.label6.TabIndex = 33;
            this.label6.Text = "Número de Idenficiação Fiscal";
            // 
            // tbNif
            // 
            this.tbNif.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNif.Location = new System.Drawing.Point(6, 217);
            this.tbNif.Name = "tbNif";
            this.tbNif.ReadOnly = true;
            this.tbNif.Size = new System.Drawing.Size(270, 23);
            this.tbNif.TabIndex = 32;
            // 
            // btConfirmar
            // 
            this.btConfirmar.Enabled = false;
            this.btConfirmar.Location = new System.Drawing.Point(212, 138);
            this.btConfirmar.Name = "btConfirmar";
            this.btConfirmar.Size = new System.Drawing.Size(75, 40);
            this.btConfirmar.TabIndex = 24;
            this.btConfirmar.Text = "Confirm";
            this.btConfirmar.UseVisualStyleBackColor = true;
            this.btConfirmar.Click += new System.EventHandler(this.btConfirmar_Click);
            // 
            // btMoradas
            // 
            this.btMoradas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btMoradas.BackColor = System.Drawing.SystemColors.Window;
            this.btMoradas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMoradas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btMoradas.Location = new System.Drawing.Point(256, 125);
            this.btMoradas.Name = "btMoradas";
            this.btMoradas.Size = new System.Drawing.Size(25, 23);
            this.btMoradas.TabIndex = 25;
            this.btMoradas.Text = "...";
            this.btMoradas.UseVisualStyleBackColor = false;
            this.btMoradas.Click += new System.EventHandler(this.btMoradas_Click);
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
            this.gpDisplayPessoa.ResumeLayout(false);
            this.gpDisplayPessoa.PerformLayout();
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
        private System.Windows.Forms.ListBox lbClientes;
        private System.Windows.Forms.BindingSource bsDB;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.Button btDeleteRest;
        private System.Windows.Forms.Button btEditClient;
        private System.Windows.Forms.Button btNewClient;
        private System.Windows.Forms.GroupBox gpDisplayPessoa;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbNif;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbTGasto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbMorada;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTelemovel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btConfirmar;
        private System.Windows.Forms.Button btMoradas;
    }
}