﻿namespace pryEDMenem
{
    partial class frmBasedeDatos
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
            this.dgvBD = new System.Windows.Forms.DataGridView();
            this.mrcSelect = new System.Windows.Forms.GroupBox();
            this.btnJuntar = new System.Windows.Forms.Button();
            this.btnMulti = new System.Windows.Forms.Button();
            this.btnSimple = new System.Windows.Forms.Button();
            this.mrcWhere = new System.Windows.Forms.GroupBox();
            this.btnConv = new System.Windows.Forms.Button();
            this.btnSMulti = new System.Windows.Forms.Button();
            this.btnSSimple = new System.Windows.Forms.Button();
            this.mrcAlg = new System.Windows.Forms.GroupBox();
            this.brnInter = new System.Windows.Forms.Button();
            this.btnDiferencia = new System.Windows.Forms.Button();
            this.btnUnion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBD)).BeginInit();
            this.mrcSelect.SuspendLayout();
            this.mrcWhere.SuspendLayout();
            this.mrcAlg.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBD
            // 
            this.dgvBD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBD.Location = new System.Drawing.Point(13, 13);
            this.dgvBD.Name = "dgvBD";
            this.dgvBD.Size = new System.Drawing.Size(775, 297);
            this.dgvBD.TabIndex = 0;
            // 
            // mrcSelect
            // 
            this.mrcSelect.Controls.Add(this.btnJuntar);
            this.mrcSelect.Controls.Add(this.btnMulti);
            this.mrcSelect.Controls.Add(this.btnSimple);
            this.mrcSelect.Location = new System.Drawing.Point(13, 317);
            this.mrcSelect.Name = "mrcSelect";
            this.mrcSelect.Size = new System.Drawing.Size(254, 178);
            this.mrcSelect.TabIndex = 1;
            this.mrcSelect.TabStop = false;
            this.mrcSelect.Text = "Operaciones de Proyectos - SELECT";
            // 
            // btnJuntar
            // 
            this.btnJuntar.Location = new System.Drawing.Point(16, 134);
            this.btnJuntar.Name = "btnJuntar";
            this.btnJuntar.Size = new System.Drawing.Size(232, 34);
            this.btnJuntar.TabIndex = 2;
            this.btnJuntar.Text = "Juntar";
            this.btnJuntar.UseVisualStyleBackColor = true;
            this.btnJuntar.Click += new System.EventHandler(this.btnJuntar_Click);
            // 
            // btnMulti
            // 
            this.btnMulti.Location = new System.Drawing.Point(16, 82);
            this.btnMulti.Name = "btnMulti";
            this.btnMulti.Size = new System.Drawing.Size(232, 34);
            this.btnMulti.TabIndex = 1;
            this.btnMulti.Text = "Proyeccion multiatributo";
            this.btnMulti.UseVisualStyleBackColor = true;
            this.btnMulti.Click += new System.EventHandler(this.btnMulti_Click);
            // 
            // btnSimple
            // 
            this.btnSimple.Location = new System.Drawing.Point(16, 32);
            this.btnSimple.Name = "btnSimple";
            this.btnSimple.Size = new System.Drawing.Size(232, 34);
            this.btnSimple.TabIndex = 0;
            this.btnSimple.Text = "Proyeccion Simple";
            this.btnSimple.UseVisualStyleBackColor = true;
            this.btnSimple.Click += new System.EventHandler(this.btnSimple_Click);
            // 
            // mrcWhere
            // 
            this.mrcWhere.Controls.Add(this.btnConv);
            this.mrcWhere.Controls.Add(this.btnSMulti);
            this.mrcWhere.Controls.Add(this.btnSSimple);
            this.mrcWhere.Location = new System.Drawing.Point(273, 317);
            this.mrcWhere.Name = "mrcWhere";
            this.mrcWhere.Size = new System.Drawing.Size(254, 178);
            this.mrcWhere.TabIndex = 2;
            this.mrcWhere.TabStop = false;
            this.mrcWhere.Text = "Operaciones de Selección - WHERE";
            // 
            // btnConv
            // 
            this.btnConv.Location = new System.Drawing.Point(6, 134);
            this.btnConv.Name = "btnConv";
            this.btnConv.Size = new System.Drawing.Size(232, 34);
            this.btnConv.TabIndex = 6;
            this.btnConv.Text = "Seleccion por convolucion";
            this.btnConv.UseVisualStyleBackColor = true;
            this.btnConv.Click += new System.EventHandler(this.btnConv_Click);
            // 
            // btnSMulti
            // 
            this.btnSMulti.Location = new System.Drawing.Point(6, 82);
            this.btnSMulti.Name = "btnSMulti";
            this.btnSMulti.Size = new System.Drawing.Size(232, 34);
            this.btnSMulti.TabIndex = 4;
            this.btnSMulti.Text = "Seleccion multiatributo";
            this.btnSMulti.UseVisualStyleBackColor = true;
            this.btnSMulti.Click += new System.EventHandler(this.btnSMulti_Click);
            // 
            // btnSSimple
            // 
            this.btnSSimple.Location = new System.Drawing.Point(6, 32);
            this.btnSSimple.Name = "btnSSimple";
            this.btnSSimple.Size = new System.Drawing.Size(232, 34);
            this.btnSSimple.TabIndex = 5;
            this.btnSSimple.Text = "Seleccion Simple";
            this.btnSSimple.UseVisualStyleBackColor = true;
            this.btnSSimple.Click += new System.EventHandler(this.btnSSimple_Click);
            // 
            // mrcAlg
            // 
            this.mrcAlg.Controls.Add(this.brnInter);
            this.mrcAlg.Controls.Add(this.btnDiferencia);
            this.mrcAlg.Controls.Add(this.btnUnion);
            this.mrcAlg.Location = new System.Drawing.Point(534, 317);
            this.mrcAlg.Name = "mrcAlg";
            this.mrcAlg.Size = new System.Drawing.Size(254, 178);
            this.mrcAlg.TabIndex = 3;
            this.mrcAlg.TabStop = false;
            this.mrcAlg.Text = "Operaciones Algebraicas";
            // 
            // brnInter
            // 
            this.brnInter.Location = new System.Drawing.Point(6, 82);
            this.brnInter.Name = "brnInter";
            this.brnInter.Size = new System.Drawing.Size(232, 34);
            this.brnInter.TabIndex = 7;
            this.brnInter.Text = "Intersección";
            this.brnInter.UseVisualStyleBackColor = true;
            this.brnInter.Click += new System.EventHandler(this.brnInter_Click);
            // 
            // btnDiferencia
            // 
            this.btnDiferencia.Location = new System.Drawing.Point(6, 134);
            this.btnDiferencia.Name = "btnDiferencia";
            this.btnDiferencia.Size = new System.Drawing.Size(232, 34);
            this.btnDiferencia.TabIndex = 3;
            this.btnDiferencia.Text = "Diferencia";
            this.btnDiferencia.UseVisualStyleBackColor = true;
            this.btnDiferencia.Click += new System.EventHandler(this.btnDiferencia_Click);
            // 
            // btnUnion
            // 
            this.btnUnion.Location = new System.Drawing.Point(6, 32);
            this.btnUnion.Name = "btnUnion";
            this.btnUnion.Size = new System.Drawing.Size(232, 34);
            this.btnUnion.TabIndex = 8;
            this.btnUnion.Text = "Union";
            this.btnUnion.UseVisualStyleBackColor = true;
            this.btnUnion.Click += new System.EventHandler(this.btnUnion_Click);
            // 
            // frmBasedeDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 501);
            this.Controls.Add(this.mrcAlg);
            this.Controls.Add(this.mrcWhere);
            this.Controls.Add(this.mrcSelect);
            this.Controls.Add(this.dgvBD);
            this.Name = "frmBasedeDatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Operaciones SQL";
            this.Load += new System.EventHandler(this.frmBasedeDatos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBD)).EndInit();
            this.mrcSelect.ResumeLayout(false);
            this.mrcWhere.ResumeLayout(false);
            this.mrcAlg.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBD;
        private System.Windows.Forms.GroupBox mrcSelect;
        private System.Windows.Forms.GroupBox mrcWhere;
        private System.Windows.Forms.GroupBox mrcAlg;
        private System.Windows.Forms.Button btnJuntar;
        private System.Windows.Forms.Button btnMulti;
        private System.Windows.Forms.Button btnSimple;
        private System.Windows.Forms.Button btnConv;
        private System.Windows.Forms.Button btnSMulti;
        private System.Windows.Forms.Button btnSSimple;
        private System.Windows.Forms.Button brnInter;
        private System.Windows.Forms.Button btnDiferencia;
        private System.Windows.Forms.Button btnUnion;
    }
}