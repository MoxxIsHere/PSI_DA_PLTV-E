namespace ProjectodeDA.app
{
    partial class formNewWorker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formNewWorker));
            this.lblError = new System.Windows.Forms.Label();
            this.btConfirm = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblMorada = new System.Windows.Forms.Label();
            this.tbMorada = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.tbTelefone = new System.Windows.Forms.TextBox();
            this.lblSalario = new System.Windows.Forms.Label();
            this.nbSalario = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPosicao = new System.Windows.Forms.Label();
            this.tbPosicao = new System.Windows.Forms.TextBox();
            this.lbRestaurantes = new System.Windows.Forms.ListBox();
            this.lblRestaurante = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nbSalario)).BeginInit();
            this.SuspendLayout();
            // 
            // lblError
            // 
            this.lblError.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.IndianRed;
            this.lblError.Location = new System.Drawing.Point(175, 301);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(232, 13);
            this.lblError.TabIndex = 13;
            this.lblError.Text = "Todos os campos precisam de ser preenchidos.";
            this.lblError.Visible = false;
            // 
            // btConfirm
            // 
            this.btConfirm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btConfirm.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConfirm.Location = new System.Drawing.Point(413, 284);
            this.btConfirm.Name = "btConfirm";
            this.btConfirm.Size = new System.Drawing.Size(120, 30);
            this.btConfirm.TabIndex = 12;
            this.btConfirm.Text = "Confirm";
            this.btConfirm.UseVisualStyleBackColor = true;
            this.btConfirm.Click += new System.EventHandler(this.btConfirm_Click);
            // 
            // btCancel
            // 
            this.btCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Font = new System.Drawing.Font("Microsoft Tai Le", 10F);
            this.btCancel.Location = new System.Drawing.Point(12, 284);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(120, 30);
            this.btCancel.TabIndex = 11;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(12, 25);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(521, 20);
            this.tbNome.TabIndex = 14;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.SystemColors.Control;
            this.lblName.Location = new System.Drawing.Point(9, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 15;
            this.lblName.Text = "Nome";
            // 
            // lblMorada
            // 
            this.lblMorada.AutoSize = true;
            this.lblMorada.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMorada.Location = new System.Drawing.Point(9, 51);
            this.lblMorada.Name = "lblMorada";
            this.lblMorada.Size = new System.Drawing.Size(43, 13);
            this.lblMorada.TabIndex = 17;
            this.lblMorada.Text = "Morada";
            // 
            // tbMorada
            // 
            this.tbMorada.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbMorada.Location = new System.Drawing.Point(12, 67);
            this.tbMorada.Name = "tbMorada";
            this.tbMorada.ReadOnly = true;
            this.tbMorada.Size = new System.Drawing.Size(490, 20);
            this.tbMorada.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.button1.Location = new System.Drawing.Point(508, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 25);
            this.button1.TabIndex = 18;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTelefone.Location = new System.Drawing.Point(9, 95);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(67, 13);
            this.lblTelefone.TabIndex = 20;
            this.lblTelefone.Text = "N.º Telefone";
            // 
            // tbTelefone
            // 
            this.tbTelefone.Location = new System.Drawing.Point(12, 111);
            this.tbTelefone.Name = "tbTelefone";
            this.tbTelefone.Size = new System.Drawing.Size(170, 20);
            this.tbTelefone.TabIndex = 19;
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSalario.Location = new System.Drawing.Point(185, 95);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(39, 13);
            this.lblSalario.TabIndex = 21;
            this.lblSalario.Text = "Salário";
            // 
            // nbSalario
            // 
            this.nbSalario.DecimalPlaces = 2;
            this.nbSalario.Font = new System.Drawing.Font("Microsoft Tai Le", 10F);
            this.nbSalario.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nbSalario.Location = new System.Drawing.Point(188, 111);
            this.nbSalario.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nbSalario.Name = "nbSalario";
            this.nbSalario.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nbSalario.Size = new System.Drawing.Size(104, 24);
            this.nbSalario.TabIndex = 22;
            this.nbSalario.ThousandsSeparator = true;
            this.nbSalario.Value = new decimal(new int[] {
            74083,
            0,
            0,
            131072});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 10F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(292, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 18);
            this.label1.TabIndex = 23;
            this.label1.Text = "€";
            // 
            // lblPosicao
            // 
            this.lblPosicao.AutoSize = true;
            this.lblPosicao.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPosicao.Location = new System.Drawing.Point(9, 139);
            this.lblPosicao.Name = "lblPosicao";
            this.lblPosicao.Size = new System.Drawing.Size(45, 13);
            this.lblPosicao.TabIndex = 25;
            this.lblPosicao.Text = "Posição";
            // 
            // tbPosicao
            // 
            this.tbPosicao.Location = new System.Drawing.Point(12, 155);
            this.tbPosicao.Name = "tbPosicao";
            this.tbPosicao.Size = new System.Drawing.Size(280, 20);
            this.tbPosicao.TabIndex = 24;
            // 
            // lbRestaurantes
            // 
            this.lbRestaurantes.FormattingEnabled = true;
            this.lbRestaurantes.Location = new System.Drawing.Point(314, 111);
            this.lbRestaurantes.Name = "lbRestaurantes";
            this.lbRestaurantes.Size = new System.Drawing.Size(219, 160);
            this.lbRestaurantes.TabIndex = 26;
            // 
            // lblRestaurante
            // 
            this.lblRestaurante.AutoSize = true;
            this.lblRestaurante.ForeColor = System.Drawing.SystemColors.Control;
            this.lblRestaurante.Location = new System.Drawing.Point(311, 95);
            this.lblRestaurante.Name = "lblRestaurante";
            this.lblRestaurante.Size = new System.Drawing.Size(65, 13);
            this.lblRestaurante.TabIndex = 27;
            this.lblRestaurante.Text = "Restaurante";
            // 
            // formNewWorker
            // 
            this.AcceptButton = this.btConfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.CancelButton = this.btCancel;
            this.ClientSize = new System.Drawing.Size(545, 318);
            this.Controls.Add(this.lblRestaurante);
            this.Controls.Add(this.lbRestaurantes);
            this.Controls.Add(this.lblPosicao);
            this.Controls.Add(this.tbPosicao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nbSalario);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.tbTelefone);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblMorada);
            this.Controls.Add(this.tbMorada);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btConfirm);
            this.Controls.Add(this.btCancel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formNewWorker";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo Empregado";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.formNewWorker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nbSalario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btConfirm;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblMorada;
        private System.Windows.Forms.TextBox tbMorada;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox tbTelefone;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.NumericUpDown nbSalario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPosicao;
        private System.Windows.Forms.TextBox tbPosicao;
        private System.Windows.Forms.ListBox lbRestaurantes;
        private System.Windows.Forms.Label lblRestaurante;
    }
}