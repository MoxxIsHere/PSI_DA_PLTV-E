namespace ProjectodeDA
{
    partial class formBase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formBase));
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
            this.tsRestaurante = new System.Windows.Forms.ToolStrip();
            this.btNovoRest = new System.Windows.Forms.ToolStripButton();
            this.btEditarRest = new System.Windows.Forms.ToolStripButton();
            this.btApagarRest = new System.Windows.Forms.ToolStripButton();
            this.btRefresh = new System.Windows.Forms.ToolStripButton();
            this.btSearch = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.Morada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvRestaurantes = new System.Windows.Forms.DataGridView();
            this.bsBD = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            this.tsRestaurante.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvRestaurantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBD)).BeginInit();
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
            this.menuStrip1.TabIndex = 12;
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
            this.pedidosToolStripMenuItem.Enabled = false;
            this.pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            this.pedidosToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.pedidosToolStripMenuItem.Text = "Pedidos";
            // 
            // novoPedidoToolStripMenuItem
            // 
            this.novoPedidoToolStripMenuItem.Name = "novoPedidoToolStripMenuItem";
            this.novoPedidoToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.novoPedidoToolStripMenuItem.Text = "Novo Pedido";
            this.novoPedidoToolStripMenuItem.Click += new System.EventHandler(this.novoPedidoToolStripMenuItem_Click);
            // 
            // verPedidosToolStripMenuItem
            // 
            this.verPedidosToolStripMenuItem.Name = "verPedidosToolStripMenuItem";
            this.verPedidosToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.verPedidosToolStripMenuItem.Text = "Ver Pedidos";
            this.verPedidosToolStripMenuItem.Click += new System.EventHandler(this.verPedidosToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoClienteToolStripMenuItem,
            this.editarClienteToolStripMenuItem});
            this.clientesToolStripMenuItem.Enabled = false;
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // novoClienteToolStripMenuItem
            // 
            this.novoClienteToolStripMenuItem.Name = "novoClienteToolStripMenuItem";
            this.novoClienteToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.novoClienteToolStripMenuItem.Text = "Novo Cliente";
            this.novoClienteToolStripMenuItem.Click += new System.EventHandler(this.novoClienteToolStripMenuItem_Click);
            // 
            // editarClienteToolStripMenuItem
            // 
            this.editarClienteToolStripMenuItem.Name = "editarClienteToolStripMenuItem";
            this.editarClienteToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.editarClienteToolStripMenuItem.Text = "Editar Cliente";
            this.editarClienteToolStripMenuItem.Click += new System.EventHandler(this.editarClienteToolStripMenuItem_Click);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarMenuToolStripMenuItem,
            this.gerirMenusToolStripMenuItem});
            this.menuToolStripMenuItem.Enabled = false;
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // adicionarMenuToolStripMenuItem
            // 
            this.adicionarMenuToolStripMenuItem.Name = "adicionarMenuToolStripMenuItem";
            this.adicionarMenuToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.adicionarMenuToolStripMenuItem.Text = "Adicionar Menu";
            this.adicionarMenuToolStripMenuItem.Click += new System.EventHandler(this.adicionarMenuToolStripMenuItem_Click);
            // 
            // gerirMenusToolStripMenuItem
            // 
            this.gerirMenusToolStripMenuItem.Name = "gerirMenusToolStripMenuItem";
            this.gerirMenusToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.gerirMenusToolStripMenuItem.Text = "Gerir Menus";
            this.gerirMenusToolStripMenuItem.Click += new System.EventHandler(this.gerirMenusToolStripMenuItem_Click);
            // 
            // tsRestaurante
            // 
            this.tsRestaurante.AllowMerge = false;
            this.tsRestaurante.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.tsRestaurante.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsRestaurante.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btNovoRest,
            this.btEditarRest,
            this.btApagarRest,
            this.btRefresh,
            this.btSearch,
            this.toolStripTextBox1});
            this.tsRestaurante.Location = new System.Drawing.Point(0, 24);
            this.tsRestaurante.Name = "tsRestaurante";
            this.tsRestaurante.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tsRestaurante.Size = new System.Drawing.Size(800, 33);
            this.tsRestaurante.TabIndex = 13;
            // 
            // btNovoRest
            // 
            this.btNovoRest.AutoSize = false;
            this.btNovoRest.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btNovoRest.Image = global::ProjectodeDA.Properties.Resources._new;
            this.btNovoRest.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btNovoRest.Name = "btNovoRest";
            this.btNovoRest.Size = new System.Drawing.Size(30, 30);
            this.btNovoRest.Text = "Novo";
            this.btNovoRest.Click += new System.EventHandler(this.btNovoRest_Click);
            // 
            // btEditarRest
            // 
            this.btEditarRest.AutoSize = false;
            this.btEditarRest.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btEditarRest.Image = global::ProjectodeDA.Properties.Resources.edit;
            this.btEditarRest.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btEditarRest.Name = "btEditarRest";
            this.btEditarRest.Size = new System.Drawing.Size(30, 30);
            this.btEditarRest.Text = "Editar";
            this.btEditarRest.Click += new System.EventHandler(this.btEditarRest_Click);
            // 
            // btApagarRest
            // 
            this.btApagarRest.AutoSize = false;
            this.btApagarRest.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btApagarRest.Image = global::ProjectodeDA.Properties.Resources.delete;
            this.btApagarRest.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btApagarRest.Name = "btApagarRest";
            this.btApagarRest.Size = new System.Drawing.Size(30, 30);
            this.btApagarRest.Text = "Apagar";
            this.btApagarRest.Click += new System.EventHandler(this.btApagarRest_Click);
            // 
            // btRefresh
            // 
            this.btRefresh.AutoSize = false;
            this.btRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btRefresh.Image = global::ProjectodeDA.Properties.Resources.refresh;
            this.btRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(30, 30);
            this.btRefresh.Text = "Actualizar";
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // btSearch
            // 
            this.btSearch.AutoSize = false;
            this.btSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btSearch.Image = global::ProjectodeDA.Properties.Resources.search;
            this.btSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(30, 30);
            this.btSearch.Text = "Procurar";
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(150, 33);
            this.toolStripTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.toolStripTextBox1_KeyPress);
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
            // Nome
            // 
            this.Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nome.DataPropertyName = "Nome";
            this.Nome.FillWeight = 10F;
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 30;
            // 
            // gvRestaurantes
            // 
            this.gvRestaurantes.AllowUserToAddRows = false;
            this.gvRestaurantes.AllowUserToDeleteRows = false;
            this.gvRestaurantes.AllowUserToResizeColumns = false;
            this.gvRestaurantes.AllowUserToResizeRows = false;
            this.gvRestaurantes.AutoGenerateColumns = false;
            this.gvRestaurantes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.gvRestaurantes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(44)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(212)))), ((int)(((byte)(124)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(105)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvRestaurantes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gvRestaurantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvRestaurantes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Nome,
            this.Morada});
            this.gvRestaurantes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gvRestaurantes.DataSource = this.bsBD;
            this.gvRestaurantes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gvRestaurantes.Location = new System.Drawing.Point(0, 56);
            this.gvRestaurantes.MultiSelect = false;
            this.gvRestaurantes.Name = "gvRestaurantes";
            this.gvRestaurantes.ReadOnly = true;
            this.gvRestaurantes.RowHeadersVisible = false;
            this.gvRestaurantes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gvRestaurantes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvRestaurantes.ShowEditingIcon = false;
            this.gvRestaurantes.Size = new System.Drawing.Size(800, 394);
            this.gvRestaurantes.TabIndex = 4;
            this.gvRestaurantes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvRestaurantes_CellDoubleClick);
            this.gvRestaurantes.SelectionChanged += new System.EventHandler(this.gvRestaurantes_SelectionChanged);
            // 
            // formBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tsRestaurante);
            this.Controls.Add(this.gvRestaurantes);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "formBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Restaurantes";
            this.Activated += new System.EventHandler(this.formBase_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tsRestaurante.ResumeLayout(false);
            this.tsRestaurante.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvRestaurantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMoradaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moradasIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bsBD;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem restaurantesToolStripMenuItem;
        private System.Windows.Forms.ToolStrip tsRestaurante;
        private System.Windows.Forms.ToolStripButton btNovoRest;
        private System.Windows.Forms.ToolStripButton btEditarRest;
        private System.Windows.Forms.ToolStripButton btApagarRest;
        private System.Windows.Forms.ToolStripButton btSearch;
        private System.Windows.Forms.ToolStripButton btRefresh;
        private System.Windows.Forms.ToolStripMenuItem restaurantesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem empregadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemsDeVendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem métodosDePagamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Morada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridView gvRestaurantes;
        private System.Windows.Forms.ToolStripMenuItem novoPedidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verPedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerirMenusToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
    }
}

