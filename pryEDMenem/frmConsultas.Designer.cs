﻿namespace pryEDMenem
{
    partial class frmConsultas
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
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.lstConsulta = new System.Windows.Forms.ListBox();
            this.lblConsulta = new System.Windows.Forms.Label();
            this.btnListar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(13, 273);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.Size = new System.Drawing.Size(775, 221);
            this.dgvDatos.TabIndex = 0;
            // 
            // lstConsulta
            // 
            this.lstConsulta.FormattingEnabled = true;
            this.lstConsulta.Location = new System.Drawing.Point(13, 38);
            this.lstConsulta.Name = "lstConsulta";
            this.lstConsulta.Size = new System.Drawing.Size(775, 199);
            this.lstConsulta.TabIndex = 1;
            this.lstConsulta.Tag = "";
            // 
            // lblConsulta
            // 
            this.lblConsulta.AutoSize = true;
            this.lblConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsulta.Location = new System.Drawing.Point(13, 13);
            this.lblConsulta.Name = "lblConsulta";
            this.lblConsulta.Size = new System.Drawing.Size(150, 20);
            this.lblConsulta.TabIndex = 2;
            this.lblConsulta.Text = "Consulta en SQL:";
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(13, 244);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 23);
            this.btnListar.TabIndex = 3;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // frmConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 496);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.lblConsulta);
            this.Controls.Add(this.lstConsulta);
            this.Controls.Add(this.dgvDatos);
            this.Name = "frmConsultas";
            this.Text = "Consultasen la Base de Datos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.ListBox lstConsulta;
        private System.Windows.Forms.Label lblConsulta;
        private System.Windows.Forms.Button btnListar;
    }
}