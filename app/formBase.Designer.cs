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
            this.label1 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.tbRestSelec = new System.Windows.Forms.TextBox();
            this.btNewRest = new System.Windows.Forms.Button();
            this.gvRestaurantes = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Morada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btEditRest = new System.Windows.Forms.Button();
            this.btDeleteRest = new System.Windows.Forms.Button();
            this.btRestaurantes = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bsBD = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gvRestaurantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBD)).BeginInit();
            this.SuspendLayout();
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
            this.label1.TabIndex = 2;
            this.label1.Text = "Restaurante Selecionado";
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.splitter1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(138, 450);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
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
            this.tbRestSelec.TabIndex = 3;
            this.tbRestSelec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btNewRest
            // 
            this.btNewRest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNewRest.Location = new System.Drawing.Point(144, 12);
            this.btNewRest.Name = "btNewRest";
            this.btNewRest.Size = new System.Drawing.Size(135, 31);
            this.btNewRest.TabIndex = 1;
            this.btNewRest.Text = "Novo Restaurante";
            this.btNewRest.UseVisualStyleBackColor = true;
            this.btNewRest.Click += new System.EventHandler(this.btNewRest_Click);
            // 
            // gvRestaurantes
            // 
            this.gvRestaurantes.AllowUserToAddRows = false;
            this.gvRestaurantes.AllowUserToDeleteRows = false;
            this.gvRestaurantes.AllowUserToResizeColumns = false;
            this.gvRestaurantes.AllowUserToResizeRows = false;
            this.gvRestaurantes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvRestaurantes.AutoGenerateColumns = false;
            this.gvRestaurantes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(134)))), ((int)(((byte)(131)))));
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
            this.gvRestaurantes.DataSource = this.bsBD;
            this.gvRestaurantes.Location = new System.Drawing.Point(285, 0);
            this.gvRestaurantes.MultiSelect = false;
            this.gvRestaurantes.Name = "gvRestaurantes";
            this.gvRestaurantes.ReadOnly = true;
            this.gvRestaurantes.RowHeadersVisible = false;
            this.gvRestaurantes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gvRestaurantes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvRestaurantes.ShowEditingIcon = false;
            this.gvRestaurantes.Size = new System.Drawing.Size(515, 450);
            this.gvRestaurantes.TabIndex = 4;
            this.gvRestaurantes.SelectionChanged += new System.EventHandler(this.gvRestaurantes_SelectionChanged);
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
            // btEditRest
            // 
            this.btEditRest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditRest.Location = new System.Drawing.Point(144, 68);
            this.btEditRest.Name = "btEditRest";
            this.btEditRest.Size = new System.Drawing.Size(135, 31);
            this.btEditRest.TabIndex = 5;
            this.btEditRest.Text = "Editar Restaurante";
            this.btEditRest.UseVisualStyleBackColor = true;
            this.btEditRest.Click += new System.EventHandler(this.btEditRest_Click);
            // 
            // btDeleteRest
            // 
            this.btDeleteRest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDeleteRest.Location = new System.Drawing.Point(144, 121);
            this.btDeleteRest.Name = "btDeleteRest";
            this.btDeleteRest.Size = new System.Drawing.Size(135, 31);
            this.btDeleteRest.TabIndex = 6;
            this.btDeleteRest.Text = "Apagar Restaurante";
            this.btDeleteRest.UseVisualStyleBackColor = true;
            this.btDeleteRest.Click += new System.EventHandler(this.btDeleteRest_Click);
            // 
            // btRestaurantes
            // 
            this.btRestaurantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRestaurantes.Location = new System.Drawing.Point(8, 12);
            this.btRestaurantes.Name = "btRestaurantes";
            this.btRestaurantes.Size = new System.Drawing.Size(124, 31);
            this.btRestaurantes.TabIndex = 7;
            this.btRestaurantes.Text = "Restaurantes";
            this.btRestaurantes.UseVisualStyleBackColor = true;
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
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // formBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btRestaurantes);
            this.Controls.Add(this.btDeleteRest);
            this.Controls.Add(this.btEditRest);
            this.Controls.Add(this.gvRestaurantes);
            this.Controls.Add(this.btNewRest);
            this.Controls.Add(this.tbRestSelec);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.splitter1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formBase";
            this.Text = "Restaurantes";
            this.Activated += new System.EventHandler(this.formBase_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvRestaurantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TextBox tbRestSelec;
        private System.Windows.Forms.Button btNewRest;
        private System.Windows.Forms.DataGridView gvRestaurantes;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMoradaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moradasIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bsBD;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Morada;
        private System.Windows.Forms.Button btEditRest;
        private System.Windows.Forms.Button btDeleteRest;
        private System.Windows.Forms.Button btRestaurantes;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

