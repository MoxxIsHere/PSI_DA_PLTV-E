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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPedidos = new System.Windows.Forms.TabPage();
            this.toolStripPedidos = new System.Windows.Forms.ToolStrip();
            this.gvPedidos = new System.Windows.Forms.DataGridView();
            this.tabClientes = new System.Windows.Forms.TabPage();
            this.tabMenu = new System.Windows.Forms.TabPage();
            this.btNovoPedido = new System.Windows.Forms.ToolStripButton();
            this.btApagarPedido = new System.Windows.Forms.ToolStripButton();
            this.btCancelado = new System.Windows.Forms.ToolStripButton();
            this.btFeito = new System.Windows.Forms.ToolStripButton();
            this.bsPedidosActivos = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPedidos.SuspendLayout();
            this.toolStripPedidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPedidosActivos)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(1146, 24);
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
            // 
            // itemsDeVendaToolStripMenuItem
            // 
            this.itemsDeVendaToolStripMenuItem.Name = "itemsDeVendaToolStripMenuItem";
            this.itemsDeVendaToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.itemsDeVendaToolStripMenuItem.Text = "Items de Venda";
            // 
            // métodosDePagamentoToolStripMenuItem
            // 
            this.métodosDePagamentoToolStripMenuItem.Name = "métodosDePagamentoToolStripMenuItem";
            this.métodosDePagamentoToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.métodosDePagamentoToolStripMenuItem.Text = "Métodos de Pagamento";
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
            // tabPedidos
            // 
            this.tabPedidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.tabPedidos.Controls.Add(this.toolStripPedidos);
            this.tabPedidos.Controls.Add(this.gvPedidos);
            this.tabPedidos.Location = new System.Drawing.Point(4, 4);
            this.tabPedidos.Name = "tabPedidos";
            this.tabPedidos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPedidos.Size = new System.Drawing.Size(1138, 535);
            this.tabPedidos.TabIndex = 0;
            this.tabPedidos.Text = "Pedidos";
            // 
            // toolStripPedidos
            // 
            this.toolStripPedidos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btNovoPedido,
            this.btApagarPedido,
            this.btCancelado,
            this.btFeito});
            this.toolStripPedidos.Location = new System.Drawing.Point(3, 3);
            this.toolStripPedidos.Name = "toolStripPedidos";
            this.toolStripPedidos.Size = new System.Drawing.Size(1132, 28);
            this.toolStripPedidos.TabIndex = 1;
            this.toolStripPedidos.Text = "toolStrip1";
            // 
            // gvPedidos
            // 
            this.gvPedidos.AutoGenerateColumns = false;
            this.gvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvPedidos.DataSource = this.bsPedidosActivos;
            this.gvPedidos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gvPedidos.Location = new System.Drawing.Point(3, 31);
            this.gvPedidos.Name = "gvPedidos";
            this.gvPedidos.Size = new System.Drawing.Size(1132, 501);
            this.gvPedidos.TabIndex = 0;
            // 
            // tabClientes
            // 
            this.tabClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.tabClientes.Location = new System.Drawing.Point(4, 4);
            this.tabClientes.Name = "tabClientes";
            this.tabClientes.Padding = new System.Windows.Forms.Padding(3);
            this.tabClientes.Size = new System.Drawing.Size(1138, 535);
            this.tabClientes.TabIndex = 1;
            this.tabClientes.Text = "Clientes";
            // 
            // tabMenu
            // 
            this.tabMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.tabMenu.Location = new System.Drawing.Point(4, 4);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.Padding = new System.Windows.Forms.Padding(3);
            this.tabMenu.Size = new System.Drawing.Size(1138, 535);
            this.tabMenu.TabIndex = 2;
            this.tabMenu.Text = "Menu";
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
            // btApagarPedido
            // 
            this.btApagarPedido.AutoSize = false;
            this.btApagarPedido.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btApagarPedido.Image = global::ProjectodeDA.Properties.Resources.delete;
            this.btApagarPedido.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btApagarPedido.Name = "btApagarPedido";
            this.btApagarPedido.Size = new System.Drawing.Size(25, 25);
            this.btApagarPedido.Text = "Apagar";
            this.btApagarPedido.Click += new System.EventHandler(this.btApagarPedido_Click);
            // 
            // btCancelado
            // 
            this.btCancelado.AutoSize = false;
            this.btCancelado.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btCancelado.Image = global::ProjectodeDA.Properties.Resources.cross;
            this.btCancelado.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btCancelado.Name = "btCancelado";
            this.btCancelado.Size = new System.Drawing.Size(25, 25);
            this.btCancelado.Text = "toolStripButton1";
            // 
            // btFeito
            // 
            this.btFeito.AutoSize = false;
            this.btFeito.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btFeito.Image = global::ProjectodeDA.Properties.Resources.check;
            this.btFeito.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btFeito.Name = "btFeito";
            this.btFeito.Size = new System.Drawing.Size(25, 25);
            this.btFeito.Text = "Feito";
            this.btFeito.Click += new System.EventHandler(this.btActivo_Click);
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formIndividuais_FormClosing);
            this.Load += new System.EventHandler(this.formIndividuais_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPedidos.ResumeLayout(false);
            this.tabPedidos.PerformLayout();
            this.toolStripPedidos.ResumeLayout(false);
            this.toolStripPedidos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPedidosActivos)).EndInit();
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
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPedidos;
        private System.Windows.Forms.TabPage tabClientes;
        private System.Windows.Forms.TabPage tabMenu;
        private System.Windows.Forms.DataGridView gvPedidos;
        private System.Windows.Forms.BindingSource bsPedidosActivos;
        private System.Windows.Forms.ToolStrip toolStripPedidos;
        private System.Windows.Forms.ToolStripButton btNovoPedido;
        private System.Windows.Forms.ToolStripButton btApagarPedido;
        private System.Windows.Forms.ToolStripButton btFeito;
        private System.Windows.Forms.ToolStripButton btCancelado;
    }
}