namespace ProjectodeDA.app
{
    partial class formIndividuais
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formIndividuais));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.tabMenu = new System.Windows.Forms.TabPage();
            this.btRemover = new System.Windows.Forms.Button();
            this.gvMenuIndividual = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsMenuGlobal = new System.Windows.Forms.BindingSource(this.components);
            this.tbPesquisar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btAdicionar = new System.Windows.Forms.Button();
            this.gvMenuGlobal = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabClientes = new System.Windows.Forms.TabPage();
            this.tabPedidos = new System.Windows.Forms.TabPage();
            this.tbPedidoInfo = new System.Windows.Forms.RichTextBox();
            this.toolStripPedidos = new System.Windows.Forms.ToolStrip();
            this.btNovoPedido = new System.Windows.Forms.ToolStripButton();
            this.btPagar = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.cbEstado = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.cbFiltro = new System.Windows.Forms.ToolStripComboBox();
            this.btConfigurar = new System.Windows.Forms.ToolStripButton();
            this.gvPedidos = new System.Windows.Forms.DataGridView();
            this.bsPedidosActivos = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl = new System.Windows.Forms.TabControl();
            this.bsMenuIndividual = new System.Windows.Forms.BindingSource(this.components);
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trabalhadors = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripClientes = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.lblProcurarCliente = new System.Windows.Forms.ToolStripLabel();
            this.tbProcurarCliente = new System.Windows.Forms.ToolStripTextBox();
            this.gvClientes = new System.Windows.Forms.DataGridView();
            this.bsClientes = new System.Windows.Forms.BindingSource(this.components);
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.novoPedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verPedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restaurantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.tabMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvMenuIndividual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMenuGlobal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMenuGlobal)).BeginInit();
            this.tabClientes.SuspendLayout();
            this.tabPedidos.SuspendLayout();
            this.toolStripPedidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPedidosActivos)).BeginInit();
            this.tabControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsMenuIndividual)).BeginInit();
            this.toolStripClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowMerge = false;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restaurantesToolStripMenuItem,
            this.pedidosToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.menuMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1146, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoClienteToolStripMenuItem,
            this.editarClienteToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // novoClienteToolStripMenuItem
            // 
            this.novoClienteToolStripMenuItem.Name = "novoClienteToolStripMenuItem";
            this.novoClienteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.novoClienteToolStripMenuItem.Text = "Novo Cliente";
            this.novoClienteToolStripMenuItem.Click += new System.EventHandler(this.novoClienteToolStripMenuItem_Click);
            // 
            // editarClienteToolStripMenuItem
            // 
            this.editarClienteToolStripMenuItem.Name = "editarClienteToolStripMenuItem";
            this.editarClienteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editarClienteToolStripMenuItem.Text = "Editar Cliente";
            this.editarClienteToolStripMenuItem.Click += new System.EventHandler(this.editarClienteToolStripMenuItem_Click);
            // 
            // menuMenu
            // 
            this.menuMenu.Name = "menuMenu";
            this.menuMenu.Size = new System.Drawing.Size(50, 20);
            this.menuMenu.Text = "Menu";
            this.menuMenu.Click += new System.EventHandler(this.menuMenu_Click);
            // 
            // tabMenu
            // 
            this.tabMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.tabMenu.Controls.Add(this.btRemover);
            this.tabMenu.Controls.Add(this.gvMenuIndividual);
            this.tabMenu.Controls.Add(this.tbPesquisar);
            this.tabMenu.Controls.Add(this.label1);
            this.tabMenu.Controls.Add(this.btAdicionar);
            this.tabMenu.Controls.Add(this.gvMenuGlobal);
            this.tabMenu.Location = new System.Drawing.Point(4, 4);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.Padding = new System.Windows.Forms.Padding(3);
            this.tabMenu.Size = new System.Drawing.Size(1138, 535);
            this.tabMenu.TabIndex = 2;
            this.tabMenu.Text = "Menu";
            // 
            // btRemover
            // 
            this.btRemover.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btRemover.Location = new System.Drawing.Point(490, 362);
            this.btRemover.Name = "btRemover";
            this.btRemover.Size = new System.Drawing.Size(156, 75);
            this.btRemover.TabIndex = 8;
            this.btRemover.Text = "Remover";
            this.btRemover.UseVisualStyleBackColor = true;
            this.btRemover.Click += new System.EventHandler(this.btRemover_Click);
            // 
            // gvMenuIndividual
            // 
            this.gvMenuIndividual.AllowUserToAddRows = false;
            this.gvMenuIndividual.AllowUserToDeleteRows = false;
            this.gvMenuIndividual.AllowUserToResizeColumns = false;
            this.gvMenuIndividual.AllowUserToResizeRows = false;
            this.gvMenuIndividual.AutoGenerateColumns = false;
            this.gvMenuIndividual.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.gvMenuIndividual.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvMenuIndividual.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.gvMenuIndividual.DataSource = this.bsMenuIndividual;
            this.gvMenuIndividual.Dock = System.Windows.Forms.DockStyle.Right;
            this.gvMenuIndividual.Location = new System.Drawing.Point(675, 3);
            this.gvMenuIndividual.Name = "gvMenuIndividual";
            this.gvMenuIndividual.ReadOnly = true;
            this.gvMenuIndividual.RowHeadersVisible = false;
            this.gvMenuIndividual.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvMenuIndividual.Size = new System.Drawing.Size(460, 529);
            this.gvMenuIndividual.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.FillWeight = 2F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn2.FillWeight = 13F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Categoria";
            this.dataGridViewTextBoxColumn3.FillWeight = 10F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Categoria";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Preco";
            this.dataGridViewTextBoxColumn4.FillWeight = 10F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Preço (€)";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Ativo";
            this.dataGridViewTextBoxColumn5.FillWeight = 5F;
            this.dataGridViewTextBoxColumn5.HeaderText = "Activo";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // tbPesquisar
            // 
            this.tbPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPesquisar.Location = new System.Drawing.Point(467, 237);
            this.tbPesquisar.Name = "tbPesquisar";
            this.tbPesquisar.Size = new System.Drawing.Size(202, 20);
            this.tbPesquisar.TabIndex = 6;
            this.tbPesquisar.TextChanged += new System.EventHandler(this.tbPesquisar_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(464, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pesquisar Item";
            // 
            // btAdicionar
            // 
            this.btAdicionar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btAdicionar.Location = new System.Drawing.Point(490, 281);
            this.btAdicionar.Name = "btAdicionar";
            this.btAdicionar.Size = new System.Drawing.Size(156, 75);
            this.btAdicionar.TabIndex = 2;
            this.btAdicionar.Text = "Adicionar";
            this.btAdicionar.UseVisualStyleBackColor = true;
            this.btAdicionar.Click += new System.EventHandler(this.btAdicionar_Click_1);
            // 
            // gvMenuGlobal
            // 
            this.gvMenuGlobal.AllowUserToAddRows = false;
            this.gvMenuGlobal.AllowUserToDeleteRows = false;
            this.gvMenuGlobal.AllowUserToResizeColumns = false;
            this.gvMenuGlobal.AllowUserToResizeRows = false;
            this.gvMenuGlobal.AutoGenerateColumns = false;
            this.gvMenuGlobal.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.gvMenuGlobal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvMenuGlobal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.gvMenuGlobal.DataSource = this.bsMenuGlobal;
            this.gvMenuGlobal.Dock = System.Windows.Forms.DockStyle.Left;
            this.gvMenuGlobal.Location = new System.Drawing.Point(3, 3);
            this.gvMenuGlobal.Name = "gvMenuGlobal";
            this.gvMenuGlobal.ReadOnly = true;
            this.gvMenuGlobal.RowHeadersVisible = false;
            this.gvMenuGlobal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvMenuGlobal.Size = new System.Drawing.Size(455, 529);
            this.gvMenuGlobal.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "Id";
            this.Column1.FillWeight = 2F;
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "Nome";
            this.Column2.FillWeight = 13F;
            this.Column2.HeaderText = "Nome";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "Categoria";
            this.Column3.FillWeight = 10F;
            this.Column3.HeaderText = "Categoria";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "Preco";
            this.Column4.FillWeight = 10F;
            this.Column4.HeaderText = "Preço (€)";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.DataPropertyName = "Ativo";
            this.Column5.FillWeight = 5F;
            this.Column5.HeaderText = "Activo";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // tabClientes
            // 
            this.tabClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.tabClientes.Controls.Add(this.gvClientes);
            this.tabClientes.Controls.Add(this.toolStripClientes);
            this.tabClientes.Location = new System.Drawing.Point(4, 4);
            this.tabClientes.Name = "tabClientes";
            this.tabClientes.Padding = new System.Windows.Forms.Padding(3);
            this.tabClientes.Size = new System.Drawing.Size(1138, 535);
            this.tabClientes.TabIndex = 1;
            this.tabClientes.Text = "Clientes";
            // 
            // tabPedidos
            // 
            this.tabPedidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.tabPedidos.Controls.Add(this.tbPedidoInfo);
            this.tabPedidos.Controls.Add(this.toolStripPedidos);
            this.tabPedidos.Controls.Add(this.gvPedidos);
            this.tabPedidos.Location = new System.Drawing.Point(4, 4);
            this.tabPedidos.Name = "tabPedidos";
            this.tabPedidos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPedidos.Size = new System.Drawing.Size(1138, 535);
            this.tabPedidos.TabIndex = 0;
            this.tabPedidos.Text = "Pedidos";
            // 
            // tbPedidoInfo
            // 
            this.tbPedidoInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPedidoInfo.BackColor = System.Drawing.SystemColors.Control;
            this.tbPedidoInfo.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbPedidoInfo.Location = new System.Drawing.Point(820, 34);
            this.tbPedidoInfo.Name = "tbPedidoInfo";
            this.tbPedidoInfo.ReadOnly = true;
            this.tbPedidoInfo.Size = new System.Drawing.Size(315, 498);
            this.tbPedidoInfo.TabIndex = 2;
            this.tbPedidoInfo.Text = "";
            // 
            // toolStripPedidos
            // 
            this.toolStripPedidos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btNovoPedido,
            this.btPagar,
            this.toolStripLabel2,
            this.cbEstado,
            this.toolStripLabel1,
            this.cbFiltro,
            this.btConfigurar});
            this.toolStripPedidos.Location = new System.Drawing.Point(3, 3);
            this.toolStripPedidos.Name = "toolStripPedidos";
            this.toolStripPedidos.Size = new System.Drawing.Size(1132, 28);
            this.toolStripPedidos.TabIndex = 1;
            this.toolStripPedidos.Text = "toolStrip1";
            // 
            // btNovoPedido
            // 
            this.btNovoPedido.AutoSize = false;
            this.btNovoPedido.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btNovoPedido.Image = global::ProjectodeDA.Properties.Resources._new;
            this.btNovoPedido.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btNovoPedido.Name = "btNovoPedido";
            this.btNovoPedido.Size = new System.Drawing.Size(25, 25);
            this.btNovoPedido.Text = "Novo";
            this.btNovoPedido.Click += new System.EventHandler(this.btNovoPedido_Click);
            // 
            // btPagar
            // 
            this.btPagar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btPagar.Image = global::ProjectodeDA.Properties.Resources.pay;
            this.btPagar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btPagar.Name = "btPagar";
            this.btPagar.Size = new System.Drawing.Size(23, 25);
            this.btPagar.Text = "Pagar";
            this.btPagar.Click += new System.EventHandler(this.btPagar_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(42, 25);
            this.toolStripLabel2.Text = "Estado";
            // 
            // cbEstado
            // 
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(121, 28);
            this.cbEstado.TextChanged += new System.EventHandler(this.cbEstado_TextChanged);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(34, 25);
            this.toolStripLabel1.Text = "Filtro";
            // 
            // cbFiltro
            // 
            this.cbFiltro.Items.AddRange(new object[] {
            "Todos"});
            this.cbFiltro.Name = "cbFiltro";
            this.cbFiltro.Size = new System.Drawing.Size(121, 28);
            this.cbFiltro.Text = "Todos";
            this.cbFiltro.ToolTipText = "Filtro";
            this.cbFiltro.TextChanged += new System.EventHandler(this.cbFiltro_TextChanged);
            // 
            // btConfigurar
            // 
            this.btConfigurar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btConfigurar.Image = global::ProjectodeDA.Properties.Resources.configure;
            this.btConfigurar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btConfigurar.Name = "btConfigurar";
            this.btConfigurar.Size = new System.Drawing.Size(23, 25);
            this.btConfigurar.Text = "toolStripButton1";
            this.btConfigurar.Click += new System.EventHandler(this.btConfigurar_Click);
            // 
            // gvPedidos
            // 
            this.gvPedidos.AllowUserToAddRows = false;
            this.gvPedidos.AllowUserToDeleteRows = false;
            this.gvPedidos.AllowUserToResizeColumns = false;
            this.gvPedidos.AllowUserToResizeRows = false;
            this.gvPedidos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvPedidos.AutoGenerateColumns = false;
            this.gvPedidos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.gvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Estado,
            this.Cliente,
            this.Trabalhadors,
            this.ValorTotal});
            this.gvPedidos.DataSource = this.bsPedidosActivos;
            this.gvPedidos.Location = new System.Drawing.Point(-4, 34);
            this.gvPedidos.Name = "gvPedidos";
            this.gvPedidos.ReadOnly = true;
            this.gvPedidos.RowHeadersVisible = false;
            this.gvPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvPedidos.Size = new System.Drawing.Size(823, 501);
            this.gvPedidos.TabIndex = 0;
            this.gvPedidos.SelectionChanged += new System.EventHandler(this.gvPedidos_SelectionChanged);
            // 
            // tabControl
            // 
            this.tabControl.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl.Controls.Add(this.tabPedidos);
            this.tabControl.Controls.Add(this.tabClientes);
            this.tabControl.Controls.Add(this.tabMenu);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tabControl.Location = new System.Drawing.Point(0, 24);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1146, 561);
            this.tabControl.TabIndex = 14;
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Id.DataPropertyName = "Id";
            this.Id.FillWeight = 5F;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Estado.DataPropertyName = "Estado";
            this.Estado.FillWeight = 10F;
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // Cliente
            // 
            this.Cliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cliente.DataPropertyName = "Clientes";
            this.Cliente.FillWeight = 10F;
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            // 
            // Trabalhadors
            // 
            this.Trabalhadors.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Trabalhadors.DataPropertyName = "Trabalhadors";
            this.Trabalhadors.FillWeight = 10F;
            this.Trabalhadors.HeaderText = "Trabalhador";
            this.Trabalhadors.Name = "Trabalhadors";
            this.Trabalhadors.ReadOnly = true;
            // 
            // ValorTotal
            // 
            this.ValorTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ValorTotal.DataPropertyName = "ValorTotal";
            this.ValorTotal.FillWeight = 5F;
            this.ValorTotal.HeaderText = "Valor (€)";
            this.ValorTotal.Name = "ValorTotal";
            this.ValorTotal.ReadOnly = true;
            // 
            // toolStripClientes
            // 
            this.toolStripClientes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.lblProcurarCliente,
            this.tbProcurarCliente});
            this.toolStripClientes.Location = new System.Drawing.Point(3, 3);
            this.toolStripClientes.Name = "toolStripClientes";
            this.toolStripClientes.Size = new System.Drawing.Size(1132, 28);
            this.toolStripClientes.TabIndex = 2;
            this.toolStripClientes.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.AutoSize = false;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::ProjectodeDA.Properties.Resources._new;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(25, 25);
            this.toolStripButton1.Text = "Novo";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::ProjectodeDA.Properties.Resources.edit;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 25);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // lblProcurarCliente
            // 
            this.lblProcurarCliente.Name = "lblProcurarCliente";
            this.lblProcurarCliente.Size = new System.Drawing.Size(92, 25);
            this.lblProcurarCliente.Text = "Procurar Cliente";
            // 
            // tbProcurarCliente
            // 
            this.tbProcurarCliente.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbProcurarCliente.Name = "tbProcurarCliente";
            this.tbProcurarCliente.Size = new System.Drawing.Size(150, 28);
            this.tbProcurarCliente.TextChanged += new System.EventHandler(this.tbProcurarCliente_TextChanged);
            // 
            // gvClientes
            // 
            this.gvClientes.AllowUserToAddRows = false;
            this.gvClientes.AllowUserToDeleteRows = false;
            this.gvClientes.AllowUserToResizeColumns = false;
            this.gvClientes.AllowUserToResizeRows = false;
            this.gvClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvClientes.AutoGenerateColumns = false;
            this.gvClientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.gvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.gvClientes.DataSource = this.bsClientes;
            this.gvClientes.Location = new System.Drawing.Point(3, 32);
            this.gvClientes.MultiSelect = false;
            this.gvClientes.Name = "gvClientes";
            this.gvClientes.ReadOnly = true;
            this.gvClientes.RowHeadersVisible = false;
            this.gvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvClientes.Size = new System.Drawing.Size(1132, 500);
            this.gvClientes.TabIndex = 3;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.DataPropertyName = "Id";
            this.Column6.FillWeight = 5F;
            this.Column6.HeaderText = "Id";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.DataPropertyName = "Nome";
            this.Column7.FillWeight = 20F;
            this.Column7.HeaderText = "Nome";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column8.DataPropertyName = "Telemovel";
            this.Column8.FillWeight = 10F;
            this.Column8.HeaderText = "Telefone";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column9.DataPropertyName = "NumContribuinte";
            this.Column9.FillWeight = 10F;
            this.Column9.HeaderText = "NIF";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column10.DataPropertyName = "TotalGasto";
            this.Column10.FillWeight = 10F;
            this.Column10.HeaderText = "Total Gasto (€)";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // novoPedidoToolStripMenuItem
            // 
            this.novoPedidoToolStripMenuItem.Name = "novoPedidoToolStripMenuItem";
            this.novoPedidoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.novoPedidoToolStripMenuItem.Text = "Novo Pedido";
            this.novoPedidoToolStripMenuItem.Click += new System.EventHandler(this.novoPedidoToolStripMenuItem_Click);
            // 
            // verPedidosToolStripMenuItem
            // 
            this.verPedidosToolStripMenuItem.Name = "verPedidosToolStripMenuItem";
            this.verPedidosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.verPedidosToolStripMenuItem.Text = "Ver Pedidos";
            this.verPedidosToolStripMenuItem.Click += new System.EventHandler(this.verPedidosToolStripMenuItem_Click);
            // 
            // pedidosToolStripMenuItem
            // 
            this.pedidosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoPedidoToolStripMenuItem,
            this.verPedidosToolStripMenuItem});
            this.pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            this.pedidosToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.pedidosToolStripMenuItem.Text = "Pedidos";
            // 
            // restaurantesToolStripMenuItem
            // 
            this.restaurantesToolStripMenuItem.Name = "restaurantesToolStripMenuItem";
            this.restaurantesToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.restaurantesToolStripMenuItem.Text = "Restaurantes";
            this.restaurantesToolStripMenuItem.Click += new System.EventHandler(this.restaurantesToolStripMenuItem_Click);
            // 
            // formIndividuais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 585);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formIndividuais";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Restaurante";
            this.Activated += new System.EventHandler(this.formIndividuais_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formIndividuais_FormClosing);
            this.Load += new System.EventHandler(this.formIndividuais_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabMenu.ResumeLayout(false);
            this.tabMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvMenuIndividual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMenuGlobal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMenuGlobal)).EndInit();
            this.tabClientes.ResumeLayout(false);
            this.tabClientes.PerformLayout();
            this.tabPedidos.ResumeLayout(false);
            this.tabPedidos.PerformLayout();
            this.toolStripPedidos.ResumeLayout(false);
            this.toolStripPedidos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPedidosActivos)).EndInit();
            this.tabControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsMenuIndividual)).EndInit();
            this.toolStripClientes.ResumeLayout(false);
            this.toolStripClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarClienteToolStripMenuItem;
        private System.Windows.Forms.BindingSource bsPedidosActivos;
        private System.Windows.Forms.TabPage tabMenu;
        private System.Windows.Forms.TabPage tabClientes;
        private System.Windows.Forms.TabPage tabPedidos;
        private System.Windows.Forms.RichTextBox tbPedidoInfo;
        private System.Windows.Forms.ToolStrip toolStripPedidos;
        private System.Windows.Forms.ToolStripButton btNovoPedido;
        private System.Windows.Forms.ToolStripComboBox cbFiltro;
        private System.Windows.Forms.ToolStripButton btConfigurar;
        private System.Windows.Forms.DataGridView gvPedidos;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripComboBox cbEstado;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripMenuItem menuMenu;
        private System.Windows.Forms.ToolStripButton btPagar;
        private System.Windows.Forms.DataGridView gvMenuGlobal;
        private System.Windows.Forms.BindingSource bsMenuGlobal;
        private System.Windows.Forms.BindingSource bsMenuIndividual;
        private System.Windows.Forms.TextBox tbPesquisar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btAdicionar;
        private System.Windows.Forms.DataGridView gvMenuIndividual;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button btRemover;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trabalhadors;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorTotal;
        private System.Windows.Forms.ToolStrip toolStripClientes;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripLabel lblProcurarCliente;
        private System.Windows.Forms.ToolStripTextBox tbProcurarCliente;
        private System.Windows.Forms.DataGridView gvClientes;
        private System.Windows.Forms.BindingSource bsClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.ToolStripMenuItem restaurantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoPedidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verPedidosToolStripMenuItem;
    }
}