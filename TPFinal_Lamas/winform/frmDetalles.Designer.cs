namespace winform
{
    partial class frmDetalles
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
            this.pbxDetalles = new System.Windows.Forms.PictureBox();
            this.lblDetPrecio = new System.Windows.Forms.Label();
            this.tbxDetPrecio = new System.Windows.Forms.TextBox();
            this.tbxDetImag = new System.Windows.Forms.TextBox();
            this.tbxDetDesc = new System.Windows.Forms.TextBox();
            this.tbxDetNom = new System.Windows.Forms.TextBox();
            this.tbxDetCod = new System.Windows.Forms.TextBox();
            this.lblDetImag = new System.Windows.Forms.Label();
            this.lblDetDisp = new System.Windows.Forms.Label();
            this.lblDetMarca = new System.Windows.Forms.Label();
            this.lblDetDesc = new System.Windows.Forms.Label();
            this.lblDetNom = new System.Windows.Forms.Label();
            this.lblDetCod = new System.Windows.Forms.Label();
            this.cbxDetMarca = new System.Windows.Forms.ComboBox();
            this.cbxDetDisp = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDetalles)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxDetalles
            // 
            this.pbxDetalles.Location = new System.Drawing.Point(282, 39);
            this.pbxDetalles.Name = "pbxDetalles";
            this.pbxDetalles.Size = new System.Drawing.Size(191, 175);
            this.pbxDetalles.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxDetalles.TabIndex = 33;
            this.pbxDetalles.TabStop = false;
            // 
            // lblDetPrecio
            // 
            this.lblDetPrecio.AutoSize = true;
            this.lblDetPrecio.Location = new System.Drawing.Point(72, 197);
            this.lblDetPrecio.Name = "lblDetPrecio";
            this.lblDetPrecio.Size = new System.Drawing.Size(40, 13);
            this.lblDetPrecio.TabIndex = 32;
            this.lblDetPrecio.Text = "Precio:";
            // 
            // tbxDetPrecio
            // 
            this.tbxDetPrecio.Location = new System.Drawing.Point(118, 194);
            this.tbxDetPrecio.Name = "tbxDetPrecio";
            this.tbxDetPrecio.ReadOnly = true;
            this.tbxDetPrecio.Size = new System.Drawing.Size(121, 20);
            this.tbxDetPrecio.TabIndex = 6;
            // 
            // tbxDetImag
            // 
            this.tbxDetImag.Location = new System.Drawing.Point(118, 168);
            this.tbxDetImag.Name = "tbxDetImag";
            this.tbxDetImag.ReadOnly = true;
            this.tbxDetImag.Size = new System.Drawing.Size(121, 20);
            this.tbxDetImag.TabIndex = 5;
            // 
            // tbxDetDesc
            // 
            this.tbxDetDesc.Location = new System.Drawing.Point(118, 88);
            this.tbxDetDesc.Name = "tbxDetDesc";
            this.tbxDetDesc.ReadOnly = true;
            this.tbxDetDesc.Size = new System.Drawing.Size(121, 20);
            this.tbxDetDesc.TabIndex = 2;
            // 
            // tbxDetNom
            // 
            this.tbxDetNom.Location = new System.Drawing.Point(118, 62);
            this.tbxDetNom.Name = "tbxDetNom";
            this.tbxDetNom.ReadOnly = true;
            this.tbxDetNom.Size = new System.Drawing.Size(121, 20);
            this.tbxDetNom.TabIndex = 1;
            // 
            // tbxDetCod
            // 
            this.tbxDetCod.Location = new System.Drawing.Point(118, 36);
            this.tbxDetCod.Name = "tbxDetCod";
            this.tbxDetCod.ReadOnly = true;
            this.tbxDetCod.Size = new System.Drawing.Size(121, 20);
            this.tbxDetCod.TabIndex = 0;
            // 
            // lblDetImag
            // 
            this.lblDetImag.AutoSize = true;
            this.lblDetImag.Location = new System.Drawing.Point(19, 171);
            this.lblDetImag.Name = "lblDetImag";
            this.lblDetImag.Size = new System.Drawing.Size(93, 13);
            this.lblDetImag.TabIndex = 30;
            this.lblDetImag.Text = "Dirección Imagen:";
            // 
            // lblDetDisp
            // 
            this.lblDetDisp.AutoSize = true;
            this.lblDetDisp.Location = new System.Drawing.Point(51, 144);
            this.lblDetDisp.Name = "lblDetDisp";
            this.lblDetDisp.Size = new System.Drawing.Size(61, 13);
            this.lblDetDisp.TabIndex = 28;
            this.lblDetDisp.Text = "Dispositivo:";
            // 
            // lblDetMarca
            // 
            this.lblDetMarca.AutoSize = true;
            this.lblDetMarca.Location = new System.Drawing.Point(72, 117);
            this.lblDetMarca.Name = "lblDetMarca";
            this.lblDetMarca.Size = new System.Drawing.Size(40, 13);
            this.lblDetMarca.TabIndex = 26;
            this.lblDetMarca.Text = "Marca:";
            // 
            // lblDetDesc
            // 
            this.lblDetDesc.AutoSize = true;
            this.lblDetDesc.Location = new System.Drawing.Point(46, 91);
            this.lblDetDesc.Name = "lblDetDesc";
            this.lblDetDesc.Size = new System.Drawing.Size(66, 13);
            this.lblDetDesc.TabIndex = 24;
            this.lblDetDesc.Text = "Descripción:";
            // 
            // lblDetNom
            // 
            this.lblDetNom.AutoSize = true;
            this.lblDetNom.Location = new System.Drawing.Point(65, 65);
            this.lblDetNom.Name = "lblDetNom";
            this.lblDetNom.Size = new System.Drawing.Size(47, 13);
            this.lblDetNom.TabIndex = 22;
            this.lblDetNom.Text = "Nombre:";
            // 
            // lblDetCod
            // 
            this.lblDetCod.AutoSize = true;
            this.lblDetCod.Location = new System.Drawing.Point(69, 39);
            this.lblDetCod.Name = "lblDetCod";
            this.lblDetCod.Size = new System.Drawing.Size(43, 13);
            this.lblDetCod.TabIndex = 20;
            this.lblDetCod.Text = "Código:";
            // 
            // cbxDetMarca
            // 
            this.cbxDetMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDetMarca.Enabled = false;
            this.cbxDetMarca.FormattingEnabled = true;
            this.cbxDetMarca.Location = new System.Drawing.Point(118, 114);
            this.cbxDetMarca.Name = "cbxDetMarca";
            this.cbxDetMarca.Size = new System.Drawing.Size(121, 21);
            this.cbxDetMarca.TabIndex = 3;
            // 
            // cbxDetDisp
            // 
            this.cbxDetDisp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDetDisp.Enabled = false;
            this.cbxDetDisp.FormattingEnabled = true;
            this.cbxDetDisp.Location = new System.Drawing.Point(118, 141);
            this.cbxDetDisp.Name = "cbxDetDisp";
            this.cbxDetDisp.Size = new System.Drawing.Size(121, 21);
            this.cbxDetDisp.TabIndex = 4;
            // 
            // frmDetalles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(508, 235);
            this.Controls.Add(this.cbxDetDisp);
            this.Controls.Add(this.cbxDetMarca);
            this.Controls.Add(this.pbxDetalles);
            this.Controls.Add(this.lblDetPrecio);
            this.Controls.Add(this.tbxDetPrecio);
            this.Controls.Add(this.tbxDetImag);
            this.Controls.Add(this.tbxDetDesc);
            this.Controls.Add(this.tbxDetNom);
            this.Controls.Add(this.tbxDetCod);
            this.Controls.Add(this.lblDetImag);
            this.Controls.Add(this.lblDetDisp);
            this.Controls.Add(this.lblDetMarca);
            this.Controls.Add(this.lblDetDesc);
            this.Controls.Add(this.lblDetNom);
            this.Controls.Add(this.lblDetCod);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(524, 274);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(524, 274);
            this.Name = "frmDetalles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalles del artículo";
            this.Load += new System.EventHandler(this.frmDetalles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxDetalles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxDetalles;
        private System.Windows.Forms.Label lblDetPrecio;
        private System.Windows.Forms.TextBox tbxDetPrecio;
        private System.Windows.Forms.TextBox tbxDetImag;
        private System.Windows.Forms.TextBox tbxDetDesc;
        private System.Windows.Forms.TextBox tbxDetNom;
        private System.Windows.Forms.TextBox tbxDetCod;
        private System.Windows.Forms.Label lblDetImag;
        private System.Windows.Forms.Label lblDetDisp;
        private System.Windows.Forms.Label lblDetMarca;
        private System.Windows.Forms.Label lblDetDesc;
        private System.Windows.Forms.Label lblDetNom;
        private System.Windows.Forms.Label lblDetCod;
        private System.Windows.Forms.ComboBox cbxDetMarca;
        private System.Windows.Forms.ComboBox cbxDetDisp;
    }
}