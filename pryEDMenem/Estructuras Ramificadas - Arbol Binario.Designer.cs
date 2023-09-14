namespace pryEDMenem
{
    partial class Estructuras_Ramificadas___Arbol_Binario
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
            this.mrcListar = new System.Windows.Forms.GroupBox();
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
            this.btnEquilibrar = new System.Windows.Forms.Button();
            this.rbIn = new System.Windows.Forms.RadioButton();
            this.rbPre = new System.Windows.Forms.RadioButton();
            this.rbPost = new System.Windows.Forms.RadioButton();
            this.tvArbol = new System.Windows.Forms.TreeView();
            this.mrcListar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaD)).BeginInit();
            this.mrcEliminado.SuspendLayout();
            this.mrcElemento.SuspendLayout();
            this.SuspendLayout();
            // 
            // mrcListar
            // 
            this.mrcListar.Controls.Add(this.rbPost);
            this.mrcListar.Controls.Add(this.rbPre);
            this.mrcListar.Controls.Add(this.rbIn);
            this.mrcListar.Controls.Add(this.dgvListaD);
            this.mrcListar.Location = new System.Drawing.Point(11, 266);
            this.mrcListar.Name = "mrcListar";
            this.mrcListar.Size = new System.Drawing.Size(628, 226);
            this.mrcListar.TabIndex = 20;
            this.mrcListar.TabStop = false;
            this.mrcListar.Text = "Listado del Árbol";
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
            this.dgvListaD.Size = new System.Drawing.Size(395, 183);
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
            this.mrcEliminado.Location = new System.Drawing.Point(439, 12);
            this.mrcEliminado.Name = "mrcEliminado";
            this.mrcEliminado.Size = new System.Drawing.Size(200, 157);
            this.mrcEliminado.TabIndex = 18;
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
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Location = new System.Drawing.Point(9, 94);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(185, 39);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
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
            this.mrcElemento.Location = new System.Drawing.Point(223, 12);
            this.mrcElemento.Name = "mrcElemento";
            this.mrcElemento.Size = new System.Drawing.Size(210, 239);
            this.mrcElemento.TabIndex = 17;
            this.mrcElemento.TabStop = false;
            this.mrcElemento.Text = "Nuevo Elemento";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(86, 94);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(108, 20);
            this.txtNombre.TabIndex = 6;
            // 
            // txtTramite
            // 
            this.txtTramite.Location = new System.Drawing.Point(86, 137);
            this.txtTramite.Name = "txtTramite";
            this.txtTramite.Size = new System.Drawing.Size(108, 20);
            this.txtTramite.TabIndex = 5;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(118, 52);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(76, 20);
            this.txtCodigo.TabIndex = 4;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Enabled = false;
            this.btnAgregar.Location = new System.Drawing.Point(20, 188);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(174, 39);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
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
            // btnEquilibrar
            // 
            this.btnEquilibrar.Enabled = false;
            this.btnEquilibrar.Location = new System.Drawing.Point(448, 200);
            this.btnEquilibrar.Name = "btnEquilibrar";
            this.btnEquilibrar.Size = new System.Drawing.Size(188, 39);
            this.btnEquilibrar.TabIndex = 9;
            this.btnEquilibrar.Text = "Equilibrar";
            this.btnEquilibrar.UseVisualStyleBackColor = true;
            // 
            // rbIn
            // 
            this.rbIn.AutoSize = true;
            this.rbIn.Location = new System.Drawing.Point(22, 34);
            this.rbIn.Name = "rbIn";
            this.rbIn.Size = new System.Drawing.Size(63, 17);
            this.rbIn.TabIndex = 1;
            this.rbIn.TabStop = true;
            this.rbIn.Text = "In-Order";
            this.rbIn.UseVisualStyleBackColor = true;
            // 
            // rbPre
            // 
            this.rbPre.AutoSize = true;
            this.rbPre.Location = new System.Drawing.Point(22, 91);
            this.rbPre.Name = "rbPre";
            this.rbPre.Size = new System.Drawing.Size(70, 17);
            this.rbPre.TabIndex = 2;
            this.rbPre.TabStop = true;
            this.rbPre.Text = "Pre-Order";
            this.rbPre.UseVisualStyleBackColor = true;
            // 
            // rbPost
            // 
            this.rbPost.AutoSize = true;
            this.rbPost.Location = new System.Drawing.Point(22, 152);
            this.rbPost.Name = "rbPost";
            this.rbPost.Size = new System.Drawing.Size(75, 17);
            this.rbPost.TabIndex = 3;
            this.rbPost.TabStop = true;
            this.rbPost.Text = "Post-Order";
            this.rbPost.UseVisualStyleBackColor = true;
            // 
            // tvArbol
            // 
            this.tvArbol.Location = new System.Drawing.Point(13, 12);
            this.tvArbol.Name = "tvArbol";
            this.tvArbol.Size = new System.Drawing.Size(204, 239);
            this.tvArbol.TabIndex = 21;
            // 
            // Estructuras_Ramificadas___Arbol_Binario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 500);
            this.Controls.Add(this.tvArbol);
            this.Controls.Add(this.btnEquilibrar);
            this.Controls.Add(this.mrcListar);
            this.Controls.Add(this.mrcEliminado);
            this.Controls.Add(this.mrcElemento);
            this.Name = "Estructuras_Ramificadas___Arbol_Binario";
            this.Text = "Estructuras_Ramificadas___Arbol_Binario";
            this.mrcListar.ResumeLayout(false);
            this.mrcListar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaD)).EndInit();
            this.mrcEliminado.ResumeLayout(false);
            this.mrcEliminado.PerformLayout();
            this.mrcElemento.ResumeLayout(false);
            this.mrcElemento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mrcListar;
        private System.Windows.Forms.RadioButton rbPost;
        private System.Windows.Forms.RadioButton rbPre;
        private System.Windows.Forms.RadioButton rbIn;
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
        private System.Windows.Forms.Button btnEquilibrar;
        private System.Windows.Forms.TreeView tvArbol;
    }
}