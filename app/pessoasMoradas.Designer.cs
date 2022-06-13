namespace ProjectodeDA.app
{
    partial class pessoasMoradas
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
            this.btNew = new System.Windows.Forms.Button();
            this.bsDB = new System.Windows.Forms.BindingSource(this.components);
            this.lbMoradas = new System.Windows.Forms.ListBox();
            this.tbRua = new System.Windows.Forms.TextBox();
            this.lblRua = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.tbCidade = new System.Windows.Forms.TextBox();
            this.lblCP = new System.Windows.Forms.Label();
            this.tbCPCol1 = new System.Windows.Forms.TextBox();
            this.tbCPCol2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPais = new System.Windows.Forms.Label();
            this.tbPais = new System.Windows.Forms.TextBox();
            this.btExit = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bsDB)).BeginInit();
            this.SuspendLayout();
            // 
            // btNew
            // 
            this.btNew.Location = new System.Drawing.Point(368, 138);
            this.btNew.Name = "btNew";
            this.btNew.Size = new System.Drawing.Size(83, 21);
            this.btNew.TabIndex = 0;
            this.btNew.Text = "New";
            this.btNew.UseVisualStyleBackColor = true;
            this.btNew.Click += new System.EventHandler(this.btConfirm_Click);
            // 
            // lbMoradas
            // 
            this.lbMoradas.DataSource = this.bsDB;
            this.lbMoradas.FormattingEnabled = true;
            this.lbMoradas.Location = new System.Drawing.Point(279, 1);
            this.lbMoradas.Name = "lbMoradas";
            this.lbMoradas.Size = new System.Drawing.Size(172, 134);
            this.lbMoradas.TabIndex = 1;
            this.lbMoradas.SelectedIndexChanged += new System.EventHandler(this.lbMoradas_SelectedIndexChanged);
            // 
            // tbRua
            // 
            this.tbRua.Location = new System.Drawing.Point(4, 17);
            this.tbRua.Name = "tbRua";
            this.tbRua.Size = new System.Drawing.Size(269, 20);
            this.tbRua.TabIndex = 2;
            // 
            // lblRua
            // 
            this.lblRua.AutoSize = true;
            this.lblRua.ForeColor = System.Drawing.SystemColors.Window;
            this.lblRua.Location = new System.Drawing.Point(1, 1);
            this.lblRua.Name = "lblRua";
            this.lblRua.Size = new System.Drawing.Size(27, 13);
            this.lblRua.TabIndex = 3;
            this.lblRua.Text = "Rua";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.ForeColor = System.Drawing.SystemColors.Window;
            this.lblCidade.Location = new System.Drawing.Point(1, 41);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(40, 13);
            this.lblCidade.TabIndex = 5;
            this.lblCidade.Text = "Cidade";
            // 
            // tbCidade
            // 
            this.tbCidade.Location = new System.Drawing.Point(4, 57);
            this.tbCidade.Name = "tbCidade";
            this.tbCidade.Size = new System.Drawing.Size(269, 20);
            this.tbCidade.TabIndex = 4;
            // 
            // lblCP
            // 
            this.lblCP.AutoSize = true;
            this.lblCP.ForeColor = System.Drawing.SystemColors.Window;
            this.lblCP.Location = new System.Drawing.Point(1, 80);
            this.lblCP.Name = "lblCP";
            this.lblCP.Size = new System.Drawing.Size(72, 13);
            this.lblCP.TabIndex = 7;
            this.lblCP.Text = "Codigo Postal";
            // 
            // tbCPCol1
            // 
            this.tbCPCol1.Location = new System.Drawing.Point(4, 96);
            this.tbCPCol1.Name = "tbCPCol1";
            this.tbCPCol1.Size = new System.Drawing.Size(121, 20);
            this.tbCPCol1.TabIndex = 6;
            this.tbCPCol1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbCPCol2
            // 
            this.tbCPCol2.Location = new System.Drawing.Point(158, 96);
            this.tbCPCol2.Name = "tbCPCol2";
            this.tbCPCol2.Size = new System.Drawing.Size(115, 20);
            this.tbCPCol2.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(135, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "-";
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.ForeColor = System.Drawing.SystemColors.Window;
            this.lblPais.Location = new System.Drawing.Point(2, 118);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(29, 13);
            this.lblPais.TabIndex = 10;
            this.lblPais.Text = "País";
            // 
            // tbPais
            // 
            this.tbPais.Location = new System.Drawing.Point(5, 134);
            this.tbPais.Name = "tbPais";
            this.tbPais.Size = new System.Drawing.Size(269, 20);
            this.tbPais.TabIndex = 11;
            // 
            // btExit
            // 
            this.btExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btExit.Location = new System.Drawing.Point(453, 0);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(20, 20);
            this.btExit.TabIndex = 12;
            this.btExit.Text = "X";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(279, 138);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(83, 21);
            this.btEdit.TabIndex = 13;
            this.btEdit.Text = "Edit / Select";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // pessoasMoradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.CancelButton = this.btExit;
            this.ClientSize = new System.Drawing.Size(474, 164);
            this.ControlBox = false;
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.tbPais);
            this.Controls.Add(this.lblPais);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbCPCol2);
            this.Controls.Add(this.lblCP);
            this.Controls.Add(this.tbCPCol1);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.tbCidade);
            this.Controls.Add(this.lblRua);
            this.Controls.Add(this.tbRua);
            this.Controls.Add(this.lbMoradas);
            this.Controls.Add(this.btNew);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "pessoasMoradas";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.pessoasMoradas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsDB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btNew;
        private System.Windows.Forms.BindingSource bsDB;
        private System.Windows.Forms.ListBox lbMoradas;
        private System.Windows.Forms.TextBox tbRua;
        private System.Windows.Forms.Label lblRua;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox tbCidade;
        private System.Windows.Forms.Label lblCP;
        private System.Windows.Forms.TextBox tbCPCol1;
        private System.Windows.Forms.TextBox tbCPCol2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.TextBox tbPais;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btEdit;
    }
}