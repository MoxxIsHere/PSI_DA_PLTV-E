namespace ProjectodeDA.app
{
    partial class formGestaoGeral
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formGestaoGeral));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.restaurantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restaurantesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.empregadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemsDeVendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.métodosDePagamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoPedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verPedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerirMenusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabsControl = new System.Windows.Forms.TabControl();
            this.tabEmpregados = new System.Windows.Forms.TabPage();
            this.gvEmpregados = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Morada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Posicao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Restaurante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsEmpregados = new System.Windows.Forms.BindingSource(this.components);
            this.toolsEmpregados = new System.Windows.Forms.ToolStrip();
            this.btAddEmp = new System.Windows.Forms.ToolStripButton();
            this.btEditEmp = new System.Windows.Forms.ToolStripButton();
            this.btDeleteEmp = new System.Windows.Forms.ToolStripButton();
            this.btActEmp = new System.Windows.Forms.ToolStripButton();
            this.btProcEmp = new System.Windows.Forms.ToolStripButton();
            this.tbPesqEmp = new System.Windows.Forms.ToolStripTextBox();
            this.tabMenuItems = new System.Windows.Forms.TabPage();
            this.lbItems = new System.Windows.Forms.ListView();
            this.toolsItems = new System.Windows.Forms.ToolStrip();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripButton9 = new System.Windows.Forms.ToolStripButton();
            this.tabMetodosPag = new System.Windows.Forms.TabPage();
            this.toolsMetodos = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.tbMetodosPesquisa = new System.Windows.Forms.ToolStripTextBox();
            this.gvMetodos = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ativo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsMetodos = new System.Windows.Forms.BindingSource(this.components);
            this.bsItems = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            this.tabsControl.SuspendLayout();
            this.tabEmpregados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvEmpregados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEmpregados)).BeginInit();
            this.toolsEmpregados.SuspendLayout();
            this.tabMenuItems.SuspendLayout();
            this.toolsItems.SuspendLayout();
            this.tabMetodosPag.SuspendLayout();
            this.toolsMetodos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvMetodos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMetodos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsItems)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowMerge = false;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restaurantesToolStripMenuItem,
            this.pedidosToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // restaurantesToolStripMenuItem
            // 
            this.restaurantesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restaurantesToolStripMenuItem1,
            this.empregadosToolStripMenuItem,
            this.itemsDeVendaToolStripMenuItem,
            this.métodosDePagamentoToolStripMenuItem});
            this.restaurantesToolStripMenuItem.Name = "restaurantesToolStripMenuItem";
            this.restaurantesToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.restaurantesToolStripMenuItem.Text = "Gestão Global";
            // 
            // restaurantesToolStripMenuItem1
            // 
            this.restaurantesToolStripMenuItem1.Name = "restaurantesToolStripMenuItem1";
            this.restaurantesToolStripMenuItem1.Size = new System.Drawing.Size(201, 22);
            this.restaurantesToolStripMenuItem1.Text = "Restaurantes";
            this.restaurantesToolStripMenuItem1.Click += new System.EventHandler(this.restaurantesToolStripMenuItem1_Click);
            // 
            // empregadosToolStripMenuItem
            // 
            this.empregadosToolStripMenuItem.Name = "empregadosToolStripMenuItem";
            this.empregadosToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.empregadosToolStripMenuItem.Text = "Empregados";
            this.empregadosToolStripMenuItem.Click += new System.EventHandler(this.empregadosToolStripMenuItem_Click);
            // 
            // itemsDeVendaToolStripMenuItem
            // 
            this.itemsDeVendaToolStripMenuItem.Name = "itemsDeVendaToolStripMenuItem";
            this.itemsDeVendaToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.itemsDeVendaToolStripMenuItem.Text = "Items de Venda";
            this.itemsDeVendaToolStripMenuItem.Click += new System.EventHandler(this.itemsDeVendaToolStripMenuItem_Click);
            // 
            // métodosDePagamentoToolStripMenuItem
            // 
            this.métodosDePagamentoToolStripMenuItem.Name = "métodosDePagamentoToolStripMenuItem";
            this.métodosDePagamentoToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.métodosDePagamentoToolStripMenuItem.Text = "Métodos de Pagamento";
            this.métodosDePagamentoToolStripMenuItem.Click += new System.EventHandler(this.métodosDePagamentoToolStripMenuItem_Click);
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
            // novoPedidoToolStripMenuItem
            // 
            this.novoPedidoToolStripMenuItem.Name = "novoPedidoToolStripMenuItem";
            this.novoPedidoToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.novoPedidoToolStripMenuItem.Text = "Novo Pedido";
            // 
            // verPedidosToolStripMenuItem
            // 
            this.verPedidosToolStripMenuItem.Name = "verPedidosToolStripMenuItem";
            this.verPedidosToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.verPedidosToolStripMenuItem.Text = "Ver Pedidos";
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
            this.novoClienteToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.novoClienteToolStripMenuItem.Text = "Novo Cliente";
            // 
            // editarClienteToolStripMenuItem
            // 
            this.editarClienteToolStripMenuItem.Name = "editarClienteToolStripMenuItem";
            this.editarClienteToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.editarClienteToolStripMenuItem.Text = "Editar Cliente";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarMenuToolStripMenuItem,
            this.gerirMenusToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // adicionarMenuToolStripMenuItem
            // 
            this.adicionarMenuToolStripMenuItem.Name = "adicionarMenuToolStripMenuItem";
            this.adicionarMenuToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.adicionarMenuToolStripMenuItem.Text = "Adicionar Menu";
            // 
            // gerirMenusToolStripMenuItem
            // 
            this.gerirMenusToolStripMenuItem.Name = "gerirMenusToolStripMenuItem";
            this.gerirMenusToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.gerirMenusToolStripMenuItem.Text = "Gerir Menus";
            // 
            // tabsControl
            // 
            this.tabsControl.Controls.Add(this.tabEmpregados);
            this.tabsControl.Controls.Add(this.tabMenuItems);
            this.tabsControl.Controls.Add(this.tabMetodosPag);
            this.tabsControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabsControl.Location = new System.Drawing.Point(0, 24);
            this.tabsControl.Margin = new System.Windows.Forms.Padding(0);
            this.tabsControl.Multiline = true;
            this.tabsControl.Name = "tabsControl";
            this.tabsControl.Padding = new System.Drawing.Point(0, 0);
            this.tabsControl.SelectedIndex = 0;
            this.tabsControl.Size = new System.Drawing.Size(800, 426);
            this.tabsControl.TabIndex = 14;
            this.tabsControl.TabIndexChanged += new System.EventHandler(this.tabsControl_TabIndexChanged);
            // 
            // tabEmpregados
            // 
            this.tabEmpregados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.tabEmpregados.Controls.Add(this.gvEmpregados);
            this.tabEmpregados.Controls.Add(this.toolsEmpregados);
            this.tabEmpregados.Location = new System.Drawing.Point(4, 22);
            this.tabEmpregados.Name = "tabEmpregados";
            this.tabEmpregados.Padding = new System.Windows.Forms.Padding(3);
            this.tabEmpregados.Size = new System.Drawing.Size(792, 400);
            this.tabEmpregados.TabIndex = 0;
            this.tabEmpregados.Text = "Empregados";
            // 
            // gvEmpregados
            // 
            this.gvEmpregados.AllowUserToAddRows = false;
            this.gvEmpregados.AllowUserToDeleteRows = false;
            this.gvEmpregados.AllowUserToResizeColumns = false;
            this.gvEmpregados.AllowUserToResizeRows = false;
            this.gvEmpregados.AutoGenerateColumns = false;
            this.gvEmpregados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.gvEmpregados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(44)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(212)))), ((int)(((byte)(124)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(105)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvEmpregados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gvEmpregados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvEmpregados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Nome,
            this.Morada,
            this.Salario,
            this.Posicao,
            this.Restaurante});
            this.gvEmpregados.DataSource = this.bsEmpregados;
            this.gvEmpregados.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gvEmpregados.Location = new System.Drawing.Point(3, 37);
            this.gvEmpregados.MultiSelect = false;
            this.gvEmpregados.Name = "gvEmpregados";
            this.gvEmpregados.ReadOnly = true;
            this.gvEmpregados.RowHeadersVisible = false;
            this.gvEmpregados.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gvEmpregados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvEmpregados.ShowEditingIcon = false;
            this.gvEmpregados.Size = new System.Drawing.Size(786, 360);
            this.gvEmpregados.TabIndex = 5;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 30;
            // 
            // Nome
            // 
            this.Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nome.DataPropertyName = "Nome";
            this.Nome.FillWeight = 10F;
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Morada
            // 
            this.Morada.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Morada.DataPropertyName = "Moradas";
            this.Morada.FillWeight = 10F;
            this.Morada.HeaderText = "Morada";
            this.Morada.Name = "Morada";
            this.Morada.ReadOnly = true;
            // 
            // Salario
            // 
            this.Salario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Salario.DataPropertyName = "Salario";
            this.Salario.FillWeight = 10F;
            this.Salario.HeaderText = "Salário";
            this.Salario.Name = "Salario";
            this.Salario.ReadOnly = true;
            // 
            // Posicao
            // 
            this.Posicao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Posicao.DataPropertyName = "Posicao";
            this.Posicao.FillWeight = 10F;
            this.Posicao.HeaderText = "Posição";
            this.Posicao.Name = "Posicao";
            this.Posicao.ReadOnly = true;
            // 
            // Restaurante
            // 
            this.Restaurante.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Restaurante.DataPropertyName = "Restaurante";
            this.Restaurante.FillWeight = 10F;
            this.Restaurante.HeaderText = "Restaurante";
            this.Restaurante.Name = "Restaurante";
            this.Restaurante.ReadOnly = true;
            // 
            // toolsEmpregados
            // 
            this.toolsEmpregados.AllowMerge = false;
            this.toolsEmpregados.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolsEmpregados.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btAddEmp,
            this.btEditEmp,
            this.btDeleteEmp,
            this.btActEmp,
            this.btProcEmp,
            this.tbPesqEmp});
            this.toolsEmpregados.Location = new System.Drawing.Point(3, 3);
            this.toolsEmpregados.Name = "toolsEmpregados";
            this.toolsEmpregados.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolsEmpregados.Size = new System.Drawing.Size(786, 33);
            this.toolsEmpregados.TabIndex = 0;
            // 
            // btAddEmp
            // 
            this.btAddEmp.AutoSize = false;
            this.btAddEmp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btAddEmp.Image = global::ProjectodeDA.Properties.Resources._new;
            this.btAddEmp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btAddEmp.Name = "btAddEmp";
            this.btAddEmp.Size = new System.Drawing.Size(30, 30);
            this.btAddEmp.Text = "Novo";
            this.btAddEmp.Click += new System.EventHandler(this.btAddEmp_Click);
            // 
            // btEditEmp
            // 
            this.btEditEmp.AutoSize = false;
            this.btEditEmp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btEditEmp.Image = global::ProjectodeDA.Properties.Resources.edit;
            this.btEditEmp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btEditEmp.Name = "btEditEmp";
            this.btEditEmp.Size = new System.Drawing.Size(30, 30);
            this.btEditEmp.Text = "Editar";
            this.btEditEmp.Click += new System.EventHandler(this.btEditEmp_Click);
            // 
            // btDeleteEmp
            // 
            this.btDeleteEmp.AutoSize = false;
            this.btDeleteEmp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btDeleteEmp.Image = global::ProjectodeDA.Properties.Resources.delete;
            this.btDeleteEmp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btDeleteEmp.Name = "btDeleteEmp";
            this.btDeleteEmp.Size = new System.Drawing.Size(30, 30);
            this.btDeleteEmp.Text = "Apagar";
            this.btDeleteEmp.Click += new System.EventHandler(this.btDeleteEmp_Click);
            // 
            // btActEmp
            // 
            this.btActEmp.AutoSize = false;
            this.btActEmp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btActEmp.Image = global::ProjectodeDA.Properties.Resources.refresh;
            this.btActEmp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btActEmp.Name = "btActEmp";
            this.btActEmp.Size = new System.Drawing.Size(30, 30);
            this.btActEmp.Text = "Actualizar";
            this.btActEmp.Click += new System.EventHandler(this.btActEmp_Click);
            // 
            // btProcEmp
            // 
            this.btProcEmp.AutoSize = false;
            this.btProcEmp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btProcEmp.Image = global::ProjectodeDA.Properties.Resources.search;
            this.btProcEmp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btProcEmp.Name = "btProcEmp";
            this.btProcEmp.Size = new System.Drawing.Size(30, 30);
            this.btProcEmp.Text = "Procurar";
            this.btProcEmp.Click += new System.EventHandler(this.btProcEmp_Click);
            // 
            // tbPesqEmp
            // 
            this.tbPesqEmp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbPesqEmp.Name = "tbPesqEmp";
            this.tbPesqEmp.Size = new System.Drawing.Size(150, 33);
            this.tbPesqEmp.TextChanged += new System.EventHandler(this.tbPesqEmp_TextChanged);
            // 
            // tabMenuItems
            // 
            this.tabMenuItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.tabMenuItems.Controls.Add(this.lbItems);
            this.tabMenuItems.Controls.Add(this.toolsItems);
            this.tabMenuItems.Location = new System.Drawing.Point(4, 22);
            this.tabMenuItems.Name = "tabMenuItems";
            this.tabMenuItems.Padding = new System.Windows.Forms.Padding(3);
            this.tabMenuItems.Size = new System.Drawing.Size(792, 400);
            this.tabMenuItems.TabIndex = 1;
            this.tabMenuItems.Text = "Items";
            // 
            // lbItems
            // 
            this.lbItems.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbItems.HideSelection = false;
            this.lbItems.Location = new System.Drawing.Point(3, 38);
            this.lbItems.Name = "lbItems";
            this.lbItems.Size = new System.Drawing.Size(786, 359);
            this.lbItems.TabIndex = 9;
            this.lbItems.UseCompatibleStateImageBehavior = false;
            // 
            // toolsItems
            // 
            this.toolsItems.AllowMerge = false;
            this.toolsItems.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolsItems.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton6,
            this.toolStripButton7,
            this.toolStripButton8,
            this.toolStripLabel1,
            this.toolStripComboBox1,
            this.toolStripButton9});
            this.toolsItems.Location = new System.Drawing.Point(3, 3);
            this.toolsItems.Name = "toolsItems";
            this.toolsItems.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolsItems.Size = new System.Drawing.Size(786, 33);
            this.toolsItems.TabIndex = 8;
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.AutoSize = false;
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = global::ProjectodeDA.Properties.Resources._new;
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(30, 30);
            this.toolStripButton6.Text = "Novo";
            this.toolStripButton6.Click += new System.EventHandler(this.toolStripButton6_Click);
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.AutoSize = false;
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = global::ProjectodeDA.Properties.Resources.edit;
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(30, 30);
            this.toolStripButton7.Text = "Editar";
            this.toolStripButton7.Click += new System.EventHandler(this.toolStripButton7_Click);
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.AutoSize = false;
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton8.Image = global::ProjectodeDA.Properties.Resources.delete;
            this.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.Size = new System.Drawing.Size(30, 30);
            this.toolStripButton8.Text = "Apagar";
            this.toolStripButton8.Click += new System.EventHandler(this.toolStripButton8_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripLabel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(63, 30);
            this.toolStripLabel1.Text = "Categorias";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 33);
            this.toolStripComboBox1.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox1_SelectedIndexChanged);
            // 
            // toolStripButton9
            // 
            this.toolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton9.Image = global::ProjectodeDA.Properties.Resources.edit;
            this.toolStripButton9.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton9.Name = "toolStripButton9";
            this.toolStripButton9.Size = new System.Drawing.Size(23, 30);
            this.toolStripButton9.Text = "Gerir Categorias";
            this.toolStripButton9.Click += new System.EventHandler(this.toolStripButton9_Click);
            // 
            // tabMetodosPag
            // 
            this.tabMetodosPag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.tabMetodosPag.Controls.Add(this.toolsMetodos);
            this.tabMetodosPag.Controls.Add(this.gvMetodos);
            this.tabMetodosPag.Location = new System.Drawing.Point(4, 22);
            this.tabMetodosPag.Name = "tabMetodosPag";
            this.tabMetodosPag.Size = new System.Drawing.Size(792, 400);
            this.tabMetodosPag.TabIndex = 2;
            this.tabMetodosPag.Text = "Métodos de Pagamento";
            // 
            // toolsMetodos
            // 
            this.toolsMetodos.AllowMerge = false;
            this.toolsMetodos.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolsMetodos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripButton5,
            this.tbMetodosPesquisa});
            this.toolsMetodos.Location = new System.Drawing.Point(0, 0);
            this.toolsMetodos.Name = "toolsMetodos";
            this.toolsMetodos.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolsMetodos.Size = new System.Drawing.Size(792, 33);
            this.toolsMetodos.TabIndex = 7;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.AutoSize = false;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::ProjectodeDA.Properties.Resources._new;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(30, 30);
            this.toolStripButton1.Text = "Novo";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.AutoSize = false;
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::ProjectodeDA.Properties.Resources.edit;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(30, 30);
            this.toolStripButton2.Text = "Editar";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.AutoSize = false;
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::ProjectodeDA.Properties.Resources.delete;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(30, 30);
            this.toolStripButton3.Text = "Apagar";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.AutoSize = false;
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = global::ProjectodeDA.Properties.Resources.refresh;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(30, 30);
            this.toolStripButton4.Text = "Actualizar";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.AutoSize = false;
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = global::ProjectodeDA.Properties.Resources.search;
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(30, 30);
            this.toolStripButton5.Text = "Procurar";
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // tbMetodosPesquisa
            // 
            this.tbMetodosPesquisa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbMetodosPesquisa.Name = "tbMetodosPesquisa";
            this.tbMetodosPesquisa.Size = new System.Drawing.Size(150, 33);
            this.tbMetodosPesquisa.TextChanged += new System.EventHandler(this.tbMetodosPesquisa_TextChanged);
            // 
            // gvMetodos
            // 
            this.gvMetodos.AllowUserToAddRows = false;
            this.gvMetodos.AllowUserToDeleteRows = false;
            this.gvMetodos.AllowUserToResizeColumns = false;
            this.gvMetodos.AllowUserToResizeRows = false;
            this.gvMetodos.AutoGenerateColumns = false;
            this.gvMetodos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.gvMetodos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(44)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(212)))), ((int)(((byte)(124)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(105)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvMetodos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gvMetodos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvMetodos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Ativo,
            this.dataGridViewTextBoxColumn2});
            this.gvMetodos.DataSource = this.bsMetodos;
            this.gvMetodos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gvMetodos.Location = new System.Drawing.Point(0, 34);
            this.gvMetodos.MultiSelect = false;
            this.gvMetodos.Name = "gvMetodos";
            this.gvMetodos.ReadOnly = true;
            this.gvMetodos.RowHeadersVisible = false;
            this.gvMetodos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gvMetodos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvMetodos.ShowEditingIcon = false;
            this.gvMetodos.Size = new System.Drawing.Size(792, 366);
            this.gvMetodos.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 30;
            // 
            // Ativo
            // 
            this.Ativo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ativo.DataPropertyName = "Ativo";
            this.Ativo.FillWeight = 1F;
            this.Ativo.HeaderText = "Ativo";
            this.Ativo.Name = "Ativo";
            this.Ativo.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Metodopagamento";
            this.dataGridViewTextBoxColumn2.FillWeight = 10F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // formGestaoGeral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabsControl);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formGestaoGeral";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão Global";
            this.Activated += new System.EventHandler(this.formGestaoGeral_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formGestaoGeral_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabsControl.ResumeLayout(false);
            this.tabEmpregados.ResumeLayout(false);
            this.tabEmpregados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvEmpregados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEmpregados)).EndInit();
            this.toolsEmpregados.ResumeLayout(false);
            this.toolsEmpregados.PerformLayout();
            this.tabMenuItems.ResumeLayout(false);
            this.tabMenuItems.PerformLayout();
            this.toolsItems.ResumeLayout(false);
            this.toolsItems.PerformLayout();
            this.tabMetodosPag.ResumeLayout(false);
            this.tabMetodosPag.PerformLayout();
            this.toolsMetodos.ResumeLayout(false);
            this.toolsMetodos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvMetodos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMetodos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem restaurantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restaurantesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem empregadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemsDeVendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem métodosDePagamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoPedidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verPedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerirMenusToolStripMenuItem;
        private System.Windows.Forms.TabControl tabsControl;
        private System.Windows.Forms.TabPage tabEmpregados;
        private System.Windows.Forms.TabPage tabMenuItems;
        private System.Windows.Forms.TabPage tabMetodosPag;
        private System.Windows.Forms.DataGridView gvEmpregados;
        private System.Windows.Forms.BindingSource bsEmpregados;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Morada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Posicao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Restaurante;
        private System.Windows.Forms.ToolStrip toolsEmpregados;
        private System.Windows.Forms.ToolStripButton btAddEmp;
        private System.Windows.Forms.ToolStripButton btEditEmp;
        private System.Windows.Forms.ToolStripButton btDeleteEmp;
        private System.Windows.Forms.ToolStripButton btActEmp;
        private System.Windows.Forms.ToolStripButton btProcEmp;
        private System.Windows.Forms.ToolStripTextBox tbPesqEmp;
        private System.Windows.Forms.ToolStrip toolsMetodos;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripTextBox tbMetodosPesquisa;
        private System.Windows.Forms.DataGridView gvMetodos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ativo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.BindingSource bsMetodos;
        private System.Windows.Forms.ToolStrip toolsItems;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.ListView lbItems;
        private System.Windows.Forms.BindingSource bsItems;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripButton toolStripButton9;
    }
}