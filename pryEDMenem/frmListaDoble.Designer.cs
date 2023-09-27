namespace pryEDMenem
{
    partial class frmListaDoble
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaDoble));
            this.mrcListar = new System.Windows.Forms.GroupBox();
            this.lstListaD = new System.Windows.Forms.ListBox();
            this.dgvListaD = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mrcEliminado = new System.Windows.Forms.GroupBox();
            this.cboCodigo = new System.Windows.Forms.ComboBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblCod = new System.Windows.Forms.Label();
            this.mrcElemento = new System.Windows.Forms.GroupBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtTramite = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblTramite = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.mrcListarD = new System.Windows.Forms.GroupBox();
            this.rbDescendente = new System.Windows.Forms.RadioButton();
            this.rbAscendente = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mrcListar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaD)).BeginInit();
            this.mrcEliminado.SuspendLayout();
            this.mrcElemento.SuspendLayout();
            this.mrcListarD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mrcListar
            // 
            this.mrcListar.Controls.Add(this.lstListaD);
            this.mrcListar.Controls.Add(this.dgvListaD);
            this.mrcListar.Location = new System.Drawing.Point(8, 270);
            this.mrcListar.Name = "mrcListar";
            this.mrcListar.Size = new System.Drawing.Size(628, 250);
            this.mrcListar.TabIndex = 15;
            this.mrcListar.TabStop = false;
            this.mrcListar.Text = "Listado en una Lista y una Grilla";
            // 
            // lstListaD
            // 
            this.lstListaD.FormattingEnabled = true;
            this.lstListaD.Location = new System.Drawing.Point(6, 19);
            this.lstListaD.Name = "lstListaD";
            this.lstListaD.Size = new System.Drawing.Size(186, 212);
            this.lstListaD.TabIndex = 1;
            // 
            // dgvListaD
            // 
            this.dgvListaD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvListaD.Location = new System.Drawing.Point(212, 20);
            this.dgvListaD.Name = "dgvListaD";
            this.dgvListaD.Size = new System.Drawing.Size(395, 209);
            this.dgvListaD.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Código";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Trámite";
            this.Column3.Name = "Column3";
            // 
            // mrcEliminado
            // 
            this.mrcEliminado.Controls.Add(this.cboCodigo);
            this.mrcEliminado.Controls.Add(this.btnEliminar);
            this.mrcEliminado.Controls.Add(this.lblCod);
            this.mrcEliminado.Location = new System.Drawing.Point(436, 12);
            this.mrcEliminado.Name = "mrcEliminado";
            this.mrcEliminado.Size = new System.Drawing.Size(200, 131);
            this.mrcEliminado.TabIndex = 14;
            this.mrcEliminado.TabStop = false;
            this.mrcEliminado.Text = "Elemento Eliminado";
            // 
            // cboCodigo
            // 
            this.cboCodigo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCodigo.FormattingEnabled = true;
            this.cboCodigo.Location = new System.Drawing.Point(78, 38);
            this.cboCodigo.Name = "cboCodigo";
            this.cboCodigo.Size = new System.Drawing.Size(101, 21);
            this.cboCodigo.TabIndex = 8;
            this.cboCodigo.SelectedIndexChanged += new System.EventHandler(this.cboCodigo_SelectedIndexChanged);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Location = new System.Drawing.Point(20, 71);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(159, 39);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Location = new System.Drawing.Point(17, 38);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(40, 13);
            this.lblCod.TabIndex = 7;
            this.lblCod.Text = "Código";
            // 
            // mrcElemento
            // 
            this.mrcElemento.Controls.Add(this.txtNombre);
            this.mrcElemento.Controls.Add(this.txtTramite);
            this.mrcElemento.Controls.Add(this.txtCodigo);
            this.mrcElemento.Controls.Add(this.btnAgregar);
            this.mrcElemento.Controls.Add(this.lblTramite);
            this.mrcElemento.Controls.Add(this.lblNombre);
            this.mrcElemento.Controls.Add(this.lblCodigo);
            this.mrcElemento.Location = new System.Drawing.Point(220, 12);
            this.mrcElemento.Name = "mrcElemento";
            this.mrcElemento.Size = new System.Drawing.Size(210, 252);
            this.mrcElemento.TabIndex = 13;
            this.mrcElemento.TabStop = false;
            this.mrcElemento.Text = "Nuevo Elemento";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(86, 94);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(108, 20);
            this.txtNombre.TabIndex = 6;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // txtTramite
            // 
            this.txtTramite.Location = new System.Drawing.Point(86, 137);
            this.txtTramite.Name = "txtTramite";
            this.txtTramite.Size = new System.Drawing.Size(108, 20);
            this.txtTramite.TabIndex = 5;
            this.txtTramite.TextChanged += new System.EventHandler(this.txtTramite_TextChanged);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(118, 52);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(76, 20);
            this.txtCodigo.TabIndex = 4;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Enabled = false;
            this.btnAgregar.Location = new System.Drawing.Point(35, 188);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(159, 39);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblTramite
            // 
            this.lblTramite.AutoSize = true;
            this.lblTramite.Location = new System.Drawing.Point(17, 140);
            this.lblTramite.Name = "lblTramite";
            this.lblTramite.Size = new System.Drawing.Size(42, 13);
            this.lblTramite.TabIndex = 2;
            this.lblTramite.Text = "Trámite";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(15, 97);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(17, 55);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código";
            // 
            // mrcListarD
            // 
            this.mrcListarD.Controls.Add(this.rbDescendente);
            this.mrcListarD.Controls.Add(this.rbAscendente);
            this.mrcListarD.Enabled = false;
            this.mrcListarD.Location = new System.Drawing.Point(436, 149);
            this.mrcListarD.Name = "mrcListarD";
            this.mrcListarD.Size = new System.Drawing.Size(200, 115);
            this.mrcListarD.TabIndex = 15;
            this.mrcListarD.TabStop = false;
            this.mrcListarD.Text = "Listar Datos";
            // 
            // rbDescendente
            // 
            this.rbDescendente.AutoSize = true;
            this.rbDescendente.Location = new System.Drawing.Point(20, 51);
            this.rbDescendente.Name = "rbDescendente";
            this.rbDescendente.Size = new System.Drawing.Size(89, 17);
            this.rbDescendente.TabIndex = 1;
            this.rbDescendente.TabStop = true;
            this.rbDescendente.Text = "Descendente";
            this.rbDescendente.UseVisualStyleBackColor = true;
            this.rbDescendente.CheckedChanged += new System.EventHandler(this.rbDescendente_CheckedChanged);
            // 
            // rbAscendente
            // 
            this.rbAscendente.AutoSize = true;
            this.rbAscendente.Location = new System.Drawing.Point(20, 28);
            this.rbAscendente.Name = "rbAscendente";
            this.rbAscendente.Size = new System.Drawing.Size(82, 17);
            this.rbAscendente.TabIndex = 0;
            this.rbAscendente.TabStop = true;
            this.rbAscendente.Text = "Ascendente";
            this.rbAscendente.UseVisualStyleBackColor = true;
            this.rbAscendente.CheckedChanged += new System.EventHandler(this.rbAscendente_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(206, 252);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // frmListaDoble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(649, 526);
            this.Controls.Add(this.mrcListarD);
            this.Controls.Add(this.mrcListar);
            this.Controls.Add(this.mrcEliminado);
            this.Controls.Add(this.mrcElemento);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmListaDoble";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmListaDoble";
            this.Load += new System.EventHandler(this.frmListaDoble_Load);
            this.mrcListar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaD)).EndInit();
            this.mrcEliminado.ResumeLayout(false);
            this.mrcEliminado.PerformLayout();
            this.mrcElemento.ResumeLayout(false);
            this.mrcElemento.PerformLayout();
            this.mrcListarD.ResumeLayout(false);
            this.mrcListarD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mrcListar;
        private System.Windows.Forms.ListBox lstListaD;
        private System.Windows.Forms.DataGridView dgvListaD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.GroupBox mrcEliminado;
        private System.Windows.Forms.ComboBox cboCodigo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.GroupBox mrcElemento;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtTramite;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblTramite;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox mrcListarD;
        private System.Windows.Forms.RadioButton rbDescendente;
        private System.Windows.Forms.RadioButton rbAscendente;
    }
}