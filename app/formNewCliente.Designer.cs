namespace ProjectodeDA.app
{
    partial class formNewCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formNewCliente));
            this.btAccept = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.gbMorada = new System.Windows.Forms.GroupBox();
            this.tbRua = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbCodigoPostalCol2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbCidade = new System.Windows.Forms.TextBox();
            this.tbCodigoPostalCol1 = new System.Windows.Forms.TextBox();
            this.tbPais = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbTelefone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNC = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.gbMorada.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btAccept
            // 
            this.btAccept.Location = new System.Drawing.Point(229, 354);
            this.btAccept.Name = "btAccept";
            this.btAccept.Size = new System.Drawing.Size(75, 23);
            this.btAccept.TabIndex = 0;
            this.btAccept.Text = "Accept";
            this.btAccept.UseVisualStyleBackColor = true;
            this.btAccept.Click += new System.EventHandler(this.btAccept_Click);
            // 
            // btCancel
            // 
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(12, 354);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 1;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
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
            this.gbMorada.Location = new System.Drawing.Point(12, 183);
            this.gbMorada.Name = "gbMorada";
            this.gbMorada.Size = new System.Drawing.Size(296, 165);
            this.gbMorada.TabIndex = 39;
            this.gbMorada.TabStop = false;
            this.gbMorada.Text = "Morada";
            // 
            // tbRua
            // 
            this.tbRua.Location = new System.Drawing.Point(10, 36);
            this.tbRua.Name = "tbRua";
            this.tbRua.Size = new System.Drawing.Size(280, 20);
            this.tbRua.TabIndex = 28;
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
            // tbCidade
            // 
            this.tbCidade.Location = new System.Drawing.Point(137, 78);
            this.tbCidade.Name = "tbCidade";
            this.tbCidade.Size = new System.Drawing.Size(153, 20);
            this.tbCidade.TabIndex = 32;
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
            // tbPais
            // 
            this.tbPais.Location = new System.Drawing.Point(10, 78);
            this.tbPais.Name = "tbPais";
            this.tbPais.Size = new System.Drawing.Size(120, 20);
            this.tbPais.TabIndex = 30;
            this.tbPais.Text = "Portugal";
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbNC);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tbTelefone);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbNome);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 165);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente";
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(10, 36);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(280, 20);
            this.tbNome.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(9, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Nome";
            // 
            // tbTelefone
            // 
            this.tbTelefone.Location = new System.Drawing.Point(10, 78);
            this.tbTelefone.Name = "tbTelefone";
            this.tbTelefone.Size = new System.Drawing.Size(280, 20);
            this.tbTelefone.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(9, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Telemovel";
            // 
            // tbNC
            // 
            this.tbNC.Location = new System.Drawing.Point(10, 123);
            this.tbNC.Name = "tbNC";
            this.tbNC.Size = new System.Drawing.Size(280, 20);
            this.tbNC.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(9, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "NIF";
            // 
            // formNewCliente
            // 
            this.AcceptButton = this.btAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.CancelButton = this.btCancel;
            this.ClientSize = new System.Drawing.Size(320, 386);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbMorada);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btAccept);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formNewCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo Cliente";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.formNewCliente_Load);
            this.gbMorada.ResumeLayout(false);
            this.gbMorada.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btAccept;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.GroupBox gbMorada;
        private System.Windows.Forms.TextBox tbRua;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbCodigoPostalCol2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbCidade;
        private System.Windows.Forms.TextBox tbCodigoPostalCol1;
        private System.Windows.Forms.TextBox tbPais;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbNC;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbTelefone;
        private System.Windows.Forms.Label label1;
    }
}