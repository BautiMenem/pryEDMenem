namespace pryEDMenem
{
    partial class frmRepaso
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
            this.lblOperacion = new System.Windows.Forms.Label();
            this.cboOperacion = new System.Windows.Forms.ComboBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.txtRepaso = new System.Windows.Forms.TextBox();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOperacion
            // 
            this.lblOperacion.AutoSize = true;
            this.lblOperacion.Location = new System.Drawing.Point(12, 21);
            this.lblOperacion.Name = "lblOperacion";
            this.lblOperacion.Size = new System.Drawing.Size(202, 13);
            this.lblOperacion.TabIndex = 0;
            this.lblOperacion.Text = "Operacion a realizar en la base de Datos:";
            // 
            // cboOperacion
            // 
            this.cboOperacion.FormattingEnabled = true;
            this.cboOperacion.Items.AddRange(new object[] {
            "Diferencia",
            "Intersección",
            "Juntar",
            "Proyeccion Simple",
            "Proyeccion Multiatributo",
            "Selección Multiatributo con Operador AND",
            "Selección Multiatributo con Operador OR",
            "Selección Multiatributo por Convolucion ",
            "Selección Simple ",
            "Unión"});
            this.cboOperacion.Location = new System.Drawing.Point(220, 19);
            this.cboOperacion.Name = "cboOperacion";
            this.cboOperacion.Size = new System.Drawing.Size(447, 21);
            this.cboOperacion.TabIndex = 1;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(687, 17);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 23);
            this.btnListar.TabIndex = 2;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // txtRepaso
            // 
            this.txtRepaso.Location = new System.Drawing.Point(12, 46);
            this.txtRepaso.Multiline = true;
            this.txtRepaso.Name = "txtRepaso";
            this.txtRepaso.Size = new System.Drawing.Size(750, 98);
            this.txtRepaso.TabIndex = 3;
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(12, 151);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.Size = new System.Drawing.Size(750, 287);
            this.dgvDatos.TabIndex = 4;
            // 
            // frmRepaso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 450);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.txtRepaso);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.cboOperacion);
            this.Controls.Add(this.lblOperacion);
            this.Name = "frmRepaso";
            this.Text = "frmRepaso";
            this.Load += new System.EventHandler(this.frmRepaso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOperacion;
        private System.Windows.Forms.ComboBox cboOperacion;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.TextBox txtRepaso;
        private System.Windows.Forms.DataGridView dgvDatos;
    }
}