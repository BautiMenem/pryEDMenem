﻿namespace pryEDMenem
{
    partial class frmListaSimple
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaSimple));
            this.mrcListar = new System.Windows.Forms.GroupBox();
            this.lstLista = new System.Windows.Forms.ListBox();
            this.dgvLista = new System.Windows.Forms.DataGridView();
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mrcListar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.mrcEliminado.SuspendLayout();
            this.mrcElemento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mrcListar
            // 
            this.mrcListar.Controls.Add(this.lstLista);
            this.mrcListar.Controls.Add(this.dgvLista);
            this.mrcListar.Location = new System.Drawing.Point(17, 270);
            this.mrcListar.Name = "mrcListar";
            this.mrcListar.Size = new System.Drawing.Size(628, 250);
            this.mrcListar.TabIndex = 11;
            this.mrcListar.TabStop = false;
            this.mrcListar.Text = "Listado en una Lista y una Grilla";
            // 
            // lstLista
            // 
            this.lstLista.FormattingEnabled = true;
            this.lstLista.Location = new System.Drawing.Point(6, 19);
            this.lstLista.Name = "lstLista";
            this.lstLista.Size = new System.Drawing.Size(186, 212);
            this.lstLista.TabIndex = 1;
            // 
            // dgvLista
            // 
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvLista.Location = new System.Drawing.Point(212, 20);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.Size = new System.Drawing.Size(395, 209);
            this.dgvLista.TabIndex = 0;
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
            this.mrcEliminado.Location = new System.Drawing.Point(445, 12);
            this.mrcEliminado.Name = "mrcEliminado";
            this.mrcEliminado.Size = new System.Drawing.Size(200, 242);
            this.mrcEliminado.TabIndex = 10;
            this.mrcEliminado.TabStop = false;
            this.mrcEliminado.Text = "Elemento Eliminado";
            // 
            // cboCodigo
            // 
            this.cboCodigo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCodigo.FormattingEnabled = true;
            this.cboCodigo.Location = new System.Drawing.Point(78, 46);
            this.cboCodigo.Name = "cboCodigo";
            this.cboCodigo.Size = new System.Drawing.Size(101, 21);
            this.cboCodigo.TabIndex = 8;
            this.cboCodigo.SelectedIndexChanged += new System.EventHandler(this.cboCodigo_SelectedIndexChanged);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Location = new System.Drawing.Point(20, 165);
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
            this.lblCod.Location = new System.Drawing.Point(17, 50);
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
            this.mrcElemento.Location = new System.Drawing.Point(229, 12);
            this.mrcElemento.Name = "mrcElemento";
            this.mrcElemento.Size = new System.Drawing.Size(200, 242);
            this.mrcElemento.TabIndex = 9;
            this.mrcElemento.TabStop = false;
            this.mrcElemento.Text = "Nuevo Elemento";
            this.mrcElemento.Enter += new System.EventHandler(this.mrcElemento_Enter);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(86, 81);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(108, 20);
            this.txtNombre.TabIndex = 6;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // txtTramite
            // 
            this.txtTramite.Location = new System.Drawing.Point(86, 111);
            this.txtTramite.Name = "txtTramite";
            this.txtTramite.Size = new System.Drawing.Size(108, 20);
            this.txtTramite.TabIndex = 5;
            this.txtTramite.TextChanged += new System.EventHandler(this.txtTramite_TextChanged);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(118, 47);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(76, 20);
            this.txtCodigo.TabIndex = 4;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Enabled = false;
            this.btnAgregar.Location = new System.Drawing.Point(21, 165);
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
            this.lblTramite.Location = new System.Drawing.Point(15, 118);
            this.lblTramite.Name = "lblTramite";
            this.lblTramite.Size = new System.Drawing.Size(42, 13);
            this.lblTramite.TabIndex = 2;
            this.lblTramite.Text = "Trámite";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(15, 78);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(15, 46);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(192, 242);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // frmListaSimple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(660, 529);
            this.Controls.Add(this.mrcListar);
            this.Controls.Add(this.mrcEliminado);
            this.Controls.Add(this.mrcElemento);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmListaSimple";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmListaSimple";
            this.Load += new System.EventHandler(this.frmListaSimple_Load);
            this.mrcListar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.mrcEliminado.ResumeLayout(false);
            this.mrcEliminado.PerformLayout();
            this.mrcElemento.ResumeLayout(false);
            this.mrcElemento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mrcListar;
        private System.Windows.Forms.ListBox lstLista;
        private System.Windows.Forms.DataGridView dgvLista;
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
    }
}