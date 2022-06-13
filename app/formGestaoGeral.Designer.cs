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
            this.tabMenuItems = new System.Windows.Forms.TabPage();
            this.tabMetodosPag = new System.Windows.Forms.TabPage();
            this.menuStrip1.SuspendLayout();
            this.tabsControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
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
            this.tabsControl.Name = "tabsControl";
            this.tabsControl.SelectedIndex = 0;
            this.tabsControl.Size = new System.Drawing.Size(800, 426);
            this.tabsControl.TabIndex = 14;
            // 
            // tabEmpregados
            // 
            this.tabEmpregados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.tabEmpregados.Location = new System.Drawing.Point(4, 22);
            this.tabEmpregados.Name = "tabEmpregados";
            this.tabEmpregados.Padding = new System.Windows.Forms.Padding(3);
            this.tabEmpregados.Size = new System.Drawing.Size(792, 400);
            this.tabEmpregados.TabIndex = 0;
            this.tabEmpregados.Text = "Empregados";
            // 
            // tabMenuItems
            // 
            this.tabMenuItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.tabMenuItems.Location = new System.Drawing.Point(4, 22);
            this.tabMenuItems.Name = "tabMenuItems";
            this.tabMenuItems.Padding = new System.Windows.Forms.Padding(3);
            this.tabMenuItems.Size = new System.Drawing.Size(792, 400);
            this.tabMenuItems.TabIndex = 1;
            this.tabMenuItems.Text = "Items";
            // 
            // tabMetodosPag
            // 
            this.tabMetodosPag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.tabMetodosPag.Location = new System.Drawing.Point(4, 22);
            this.tabMetodosPag.Name = "tabMetodosPag";
            this.tabMetodosPag.Size = new System.Drawing.Size(792, 400);
            this.tabMetodosPag.TabIndex = 2;
            this.tabMetodosPag.Text = "Métodos de Pagamento";
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formGestaoGeral_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabsControl.ResumeLayout(false);
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
    }
}