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
            this.lblTelefone = new System.Windows.Forms.Label();
            this.tbTelefone = new System.Windows.Forms.TextBox();
            this.lblSalario = new System.Windows.Forms.Label();
            this.nbSalario = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPosicao = new System.Windows.Forms.Label();
            this.tbPosicao = new System.Windows.Forms.TextBox();
            this.lbRestaurantes = new System.Windows.Forms.ListBox();
            this.lblRestaurante = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbRua = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPais = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCidade = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbCodigoPostalCol2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbCodigoPostalCol1 = new System.Windows.Forms.TextBox();
            this.gbMorada = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.nbSalario)).BeginInit();
            this.gbMorada.SuspendLayout();
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
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTelefone.Location = new System.Drawing.Point(9, 53);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(67, 13);
            this.lblTelefone.TabIndex = 20;
            this.lblTelefone.Text = "N.º Telefone";
            // 
            // tbTelefone
            // 
            this.tbTelefone.Location = new System.Drawing.Point(12, 69);
            this.tbTelefone.Name = "tbTelefone";
            this.tbTelefone.Size = new System.Drawing.Size(170, 20);
            this.tbTelefone.TabIndex = 19;
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSalario.Location = new System.Drawing.Point(185, 53);
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
            this.nbSalario.Location = new System.Drawing.Point(188, 69);
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
            this.label1.Location = new System.Drawing.Point(292, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 18);
            this.label1.TabIndex = 23;
            this.label1.Text = "€";
            // 
            // lblPosicao
            // 
            this.lblPosicao.AutoSize = true;
            this.lblPosicao.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPosicao.Location = new System.Drawing.Point(311, 53);
            this.lblPosicao.Name = "lblPosicao";
            this.lblPosicao.Size = new System.Drawing.Size(45, 13);
            this.lblPosicao.TabIndex = 25;
            this.lblPosicao.Text = "Posição";
            // 
            // tbPosicao
            // 
            this.tbPosicao.Location = new System.Drawing.Point(314, 69);
            this.tbPosicao.Name = "tbPosicao";
            this.tbPosicao.Size = new System.Drawing.Size(219, 20);
            this.tbPosicao.TabIndex = 24;
            // 
            // lbRestaurantes
            // 
            this.lbRestaurantes.FormattingEnabled = true;
            this.lbRestaurantes.Location = new System.Drawing.Point(314, 121);
            this.lbRestaurantes.Name = "lbRestaurantes";
            this.lbRestaurantes.Size = new System.Drawing.Size(219, 147);
            this.lbRestaurantes.TabIndex = 26;
            // 
            // lblRestaurante
            // 
            this.lblRestaurante.AutoSize = true;
            this.lblRestaurante.ForeColor = System.Drawing.SystemColors.Control;
            this.lblRestaurante.Location = new System.Drawing.Point(311, 103);
            this.lblRestaurante.Name = "lblRestaurante";
            this.lblRestaurante.Size = new System.Drawing.Size(65, 13);
            this.lblRestaurante.TabIndex = 27;
            this.lblRestaurante.Text = "Restaurante";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(9, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Rua";
            // 
            // tbRua
            // 
            this.tbRua.Location = new System.Drawing.Point(10, 36);
            this.tbRua.Name = "tbRua";
            this.tbRua.Size = new System.Drawing.Size(280, 20);
            this.tbRua.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(7, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "País";
            // 
            // tbPais
            // 
            this.tbPais.Location = new System.Drawing.Point(10, 78);
            this.tbPais.Name = "tbPais";
            this.tbPais.Size = new System.Drawing.Size(120, 20);
            this.tbPais.TabIndex = 30;
            this.tbPais.Text = "Portugal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(134, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Cidade";
            // 
            // tbCidade
            // 
            this.tbCidade.Location = new System.Drawing.Point(137, 78);
            this.tbCidade.Name = "tbCidade";
            this.tbCidade.Size = new System.Drawing.Size(153, 20);
            this.tbCidade.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(7, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Cód. Postal";
            // 
            // tbCodigoPostalCol2
            // 
            this.tbCodigoPostalCol2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCodigoPostalCol2.Location = new System.Drawing.Point(114, 117);
            this.tbCodigoPostalCol2.Name = "tbCodigoPostalCol2";
            this.tbCodigoPostalCol2.Size = new System.Drawing.Size(69, 20);
            this.tbCodigoPostalCol2.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(98, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "-";
            // 
            // tbCodigoPostalCol1
            // 
            this.tbCodigoPostalCol1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCodigoPostalCol1.Location = new System.Drawing.Point(10, 117);
            this.tbCodigoPostalCol1.Name = "tbCodigoPostalCol1";
            this.tbCodigoPostalCol1.Size = new System.Drawing.Size(82, 20);
            this.tbCodigoPostalCol1.TabIndex = 35;
            // 
            // gbMorada
            // 
            this.gbMorada.Controls.Add(this.tbRua);
            this.gbMorada.Controls.Add(this.label6);
            this.gbMorada.Controls.Add(this.tbCodigoPostalCol2);
            this.gbMorada.Controls.Add(this.label2);
            this.gbMorada.Controls.Add(this.label5);
            this.gbMorada.Controls.Add(this.tbCidade);
            this.gbMorada.Controls.Add(this.tbCodigoPostalCol1);
            this.gbMorada.Controls.Add(this.tbPais);
            this.gbMorada.Controls.Add(this.label3);
            this.gbMorada.Controls.Add(this.label4);
            this.gbMorada.ForeColor = System.Drawing.SystemColors.Control;
            this.gbMorada.Location = new System.Drawing.Point(12, 103);
            this.gbMorada.Name = "gbMorada";
            this.gbMorada.Size = new System.Drawing.Size(296, 165);
            this.gbMorada.TabIndex = 38;
            this.gbMorada.TabStop = false;
            this.gbMorada.Text = "Morada";
            // 
            // formNewWorker
            // 
            this.AcceptButton = this.btConfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.CancelButton = this.btCancel;
            this.ClientSize = new System.Drawing.Size(545, 318);
            this.Controls.Add(this.gbMorada);
            this.Controls.Add(this.lblRestaurante);
            this.Controls.Add(this.lbRestaurantes);
            this.Controls.Add(this.lblPosicao);
            this.Controls.Add(this.tbPosicao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nbSalario);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.tbTelefone);
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
            this.gbMorada.ResumeLayout(false);
            this.gbMorada.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btConfirm;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox tbTelefone;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.NumericUpDown nbSalario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPosicao;
        private System.Windows.Forms.TextBox tbPosicao;
        private System.Windows.Forms.ListBox lbRestaurantes;
        private System.Windows.Forms.Label lblRestaurante;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbRua;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPais;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCidade;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbCodigoPostalCol2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbCodigoPostalCol1;
        private System.Windows.Forms.GroupBox gbMorada;
    }
}