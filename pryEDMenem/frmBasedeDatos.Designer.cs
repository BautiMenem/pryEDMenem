namespace pryEDMenem
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
            this.mecWhere = new System.Windows.Forms.GroupBox();
            this.btnConv = new System.Windows.Forms.Button();
            this.btnSMulti = new System.Windows.Forms.Button();
            this.btnSSimple = new System.Windows.Forms.Button();
            this.mecAlg = new System.Windows.Forms.GroupBox();
            this.brnInter = new System.Windows.Forms.Button();
            this.btnDiferencia = new System.Windows.Forms.Button();
            this.btnUnion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBD)).BeginInit();
            this.mrcSelect.SuspendLayout();
            this.mecWhere.SuspendLayout();
            this.mecAlg.SuspendLayout();
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
            // 
            // btnMulti
            // 
            this.btnMulti.Location = new System.Drawing.Point(16, 82);
            this.btnMulti.Name = "btnMulti";
            this.btnMulti.Size = new System.Drawing.Size(232, 34);
            this.btnMulti.TabIndex = 1;
            this.btnMulti.Text = "Proyeccion multiatributo";
            this.btnMulti.UseVisualStyleBackColor = true;
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
            // mecWhere
            // 
            this.mecWhere.Controls.Add(this.btnConv);
            this.mecWhere.Controls.Add(this.btnSMulti);
            this.mecWhere.Controls.Add(this.btnSSimple);
            this.mecWhere.Location = new System.Drawing.Point(273, 317);
            this.mecWhere.Name = "mecWhere";
            this.mecWhere.Size = new System.Drawing.Size(254, 178);
            this.mecWhere.TabIndex = 2;
            this.mecWhere.TabStop = false;
            this.mecWhere.Text = "Operaciones de Selección - WHERE";
            // 
            // btnConv
            // 
            this.btnConv.Location = new System.Drawing.Point(6, 134);
            this.btnConv.Name = "btnConv";
            this.btnConv.Size = new System.Drawing.Size(232, 34);
            this.btnConv.TabIndex = 6;
            this.btnConv.Text = "Seleccion por convolucion";
            this.btnConv.UseVisualStyleBackColor = true;
            // 
            // btnSMulti
            // 
            this.btnSMulti.Location = new System.Drawing.Point(6, 82);
            this.btnSMulti.Name = "btnSMulti";
            this.btnSMulti.Size = new System.Drawing.Size(232, 34);
            this.btnSMulti.TabIndex = 4;
            this.btnSMulti.Text = "Seleccion multiatributo";
            this.btnSMulti.UseVisualStyleBackColor = true;
            // 
            // btnSSimple
            // 
            this.btnSSimple.Location = new System.Drawing.Point(6, 32);
            this.btnSSimple.Name = "btnSSimple";
            this.btnSSimple.Size = new System.Drawing.Size(232, 34);
            this.btnSSimple.TabIndex = 5;
            this.btnSSimple.Text = "Seleccion Simple";
            this.btnSSimple.UseVisualStyleBackColor = true;
            // 
            // mecAlg
            // 
            this.mecAlg.Controls.Add(this.brnInter);
            this.mecAlg.Controls.Add(this.btnDiferencia);
            this.mecAlg.Controls.Add(this.btnUnion);
            this.mecAlg.Location = new System.Drawing.Point(534, 317);
            this.mecAlg.Name = "mecAlg";
            this.mecAlg.Size = new System.Drawing.Size(254, 178);
            this.mecAlg.TabIndex = 3;
            this.mecAlg.TabStop = false;
            this.mecAlg.Text = "Operaciones Algebraicas";
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
            // 
            // btnUnion
            // 
            this.btnUnion.Location = new System.Drawing.Point(6, 32);
            this.btnUnion.Name = "btnUnion";
            this.btnUnion.Size = new System.Drawing.Size(232, 34);
            this.btnUnion.TabIndex = 8;
            this.btnUnion.Text = "Union";
            this.btnUnion.UseVisualStyleBackColor = true;
            // 
            // frmBasedeDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 501);
            this.Controls.Add(this.mecAlg);
            this.Controls.Add(this.mecWhere);
            this.Controls.Add(this.mrcSelect);
            this.Controls.Add(this.dgvBD);
            this.Name = "frmBasedeDatos";
            this.Text = "Base de Datos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBD)).EndInit();
            this.mrcSelect.ResumeLayout(false);
            this.mecWhere.ResumeLayout(false);
            this.mecAlg.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBD;
        private System.Windows.Forms.GroupBox mrcSelect;
        private System.Windows.Forms.GroupBox mecWhere;
        private System.Windows.Forms.GroupBox mecAlg;
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