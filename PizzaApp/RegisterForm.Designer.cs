namespace PizzaApp
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtusr = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtmail = new System.Windows.Forms.TextBox();
            this.txtcalle = new System.Windows.Forms.TextBox();
            this.txtcol = new System.Windows.Forms.TextBox();
            this.cmbBoxAlc = new System.Windows.Forms.ComboBox();
            this.btnregister = new System.Windows.Forms.Button();
            this.txtcp = new System.Windows.Forms.TextBox();
            this.lblerr = new System.Windows.Forms.Label();
            this.txtInt = new System.Windows.Forms.TextBox();
            this.txtExt = new System.Windows.Forms.TextBox();
            this.btnmin = new System.Windows.Forms.PictureBox();
            this.btncerrar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PizzaApp.Properties.Resources.InitLogo;
            this.pictureBox1.Location = new System.Drawing.Point(117, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtusr
            // 
            this.txtusr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.txtusr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtusr.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusr.ForeColor = System.Drawing.Color.DimGray;
            this.txtusr.Location = new System.Drawing.Point(87, 125);
            this.txtusr.Name = "txtusr";
            this.txtusr.Size = new System.Drawing.Size(160, 16);
            this.txtusr.TabIndex = 1;
            this.txtusr.Text = "Usuario";
            this.txtusr.Enter += new System.EventHandler(this.txtusr_Enter);
            this.txtusr.Leave += new System.EventHandler(this.txtusr_Leave);
            // 
            // txtpass
            // 
            this.txtpass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.txtpass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpass.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.ForeColor = System.Drawing.Color.DimGray;
            this.txtpass.Location = new System.Drawing.Point(87, 159);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(160, 16);
            this.txtpass.TabIndex = 2;
            this.txtpass.Text = "Contraseña";
            this.txtpass.Enter += new System.EventHandler(this.txtpass_Enter);
            this.txtpass.Leave += new System.EventHandler(this.txtpass_Leave);
            // 
            // txtmail
            // 
            this.txtmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.txtmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtmail.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmail.ForeColor = System.Drawing.Color.DimGray;
            this.txtmail.Location = new System.Drawing.Point(87, 191);
            this.txtmail.Name = "txtmail";
            this.txtmail.Size = new System.Drawing.Size(160, 16);
            this.txtmail.TabIndex = 3;
            this.txtmail.Text = "Telefono";
            this.txtmail.Enter += new System.EventHandler(this.txtmail_Enter);
            this.txtmail.Leave += new System.EventHandler(this.txtmail_Leave);
            // 
            // txtcalle
            // 
            this.txtcalle.AcceptsTab = true;
            this.txtcalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.txtcalle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcalle.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcalle.ForeColor = System.Drawing.Color.DimGray;
            this.txtcalle.Location = new System.Drawing.Point(29, 226);
            this.txtcalle.Name = "txtcalle";
            this.txtcalle.Size = new System.Drawing.Size(146, 16);
            this.txtcalle.TabIndex = 4;
            this.txtcalle.Text = "Calle";
            this.txtcalle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtcalle.Enter += new System.EventHandler(this.txtcalle_Enter);
            this.txtcalle.Leave += new System.EventHandler(this.txtcalle_Leave);
            // 
            // txtcol
            // 
            this.txtcol.AcceptsTab = true;
            this.txtcol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.txtcol.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcol.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcol.ForeColor = System.Drawing.Color.DimGray;
            this.txtcol.Location = new System.Drawing.Point(87, 259);
            this.txtcol.Name = "txtcol";
            this.txtcol.Size = new System.Drawing.Size(131, 16);
            this.txtcol.TabIndex = 5;
            this.txtcol.Text = "Colonia";
            this.txtcol.Enter += new System.EventHandler(this.txtcol_Enter);
            this.txtcol.Leave += new System.EventHandler(this.txtcol_Leave);
            // 
            // cmbBoxAlc
            // 
            this.cmbBoxAlc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.cmbBoxAlc.Font = new System.Drawing.Font("MS PGothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBoxAlc.ForeColor = System.Drawing.Color.DimGray;
            this.cmbBoxAlc.FormattingEnabled = true;
            this.cmbBoxAlc.Items.AddRange(new object[] {
            "Tlalpan",
            "Venustiano Carranza",
            "Azcapotzalco",
            "Iztapalapa",
            "Iztacalco",
            "Miguel Hidalgo",
            "La Magdalena Contreras",
            "Coyoacán",
            "Milpa Alta",
            "Tláhuac",
            "Benito Juárez",
            "Cuajimalpa de Morelos",
            "Gustavo A. Madero",
            "Cuauhtémoc",
            "Álvaro Obregón",
            "Xochimilco"});
            this.cmbBoxAlc.Location = new System.Drawing.Point(87, 327);
            this.cmbBoxAlc.Name = "cmbBoxAlc";
            this.cmbBoxAlc.Size = new System.Drawing.Size(121, 21);
            this.cmbBoxAlc.TabIndex = 6;
            this.cmbBoxAlc.Text = "Iztapalapa";
            // 
            // btnregister
            // 
            this.btnregister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.btnregister.FlatAppearance.BorderSize = 0;
            this.btnregister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnregister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnregister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnregister.ForeColor = System.Drawing.Color.LightGray;
            this.btnregister.Location = new System.Drawing.Point(44, 431);
            this.btnregister.Name = "btnregister";
            this.btnregister.Size = new System.Drawing.Size(217, 40);
            this.btnregister.TabIndex = 7;
            this.btnregister.Text = "Registrarme";
            this.btnregister.UseVisualStyleBackColor = false;
            this.btnregister.Click += new System.EventHandler(this.btnregister_Click);
            // 
            // txtcp
            // 
            this.txtcp.AcceptsTab = true;
            this.txtcp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.txtcp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcp.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcp.ForeColor = System.Drawing.Color.DimGray;
            this.txtcp.Location = new System.Drawing.Point(87, 294);
            this.txtcp.Name = "txtcp";
            this.txtcp.Size = new System.Drawing.Size(131, 16);
            this.txtcp.TabIndex = 8;
            this.txtcp.Text = "CP";
            this.txtcp.Enter += new System.EventHandler(this.txtcp_Enter);
            this.txtcp.Leave += new System.EventHandler(this.txtcp_Leave);
            // 
            // lblerr
            // 
            this.lblerr.AutoSize = true;
            this.lblerr.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblerr.ForeColor = System.Drawing.Color.Maroon;
            this.lblerr.Location = new System.Drawing.Point(84, 401);
            this.lblerr.Name = "lblerr";
            this.lblerr.Size = new System.Drawing.Size(88, 13);
            this.lblerr.TabIndex = 9;
            this.lblerr.Text = "Error Message";
            this.lblerr.Visible = false;
            // 
            // txtInt
            // 
            this.txtInt.AcceptsTab = true;
            this.txtInt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.txtInt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInt.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInt.ForeColor = System.Drawing.Color.DimGray;
            this.txtInt.Location = new System.Drawing.Point(198, 226);
            this.txtInt.Name = "txtInt";
            this.txtInt.Size = new System.Drawing.Size(20, 16);
            this.txtInt.TabIndex = 10;
            this.txtInt.Text = "Int";
            this.txtInt.Enter += new System.EventHandler(this.txtInt_Enter);
            this.txtInt.Leave += new System.EventHandler(this.txtInt_Leave);
            // 
            // txtExt
            // 
            this.txtExt.AcceptsTab = true;
            this.txtExt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.txtExt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtExt.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExt.ForeColor = System.Drawing.Color.DimGray;
            this.txtExt.Location = new System.Drawing.Point(235, 226);
            this.txtExt.Name = "txtExt";
            this.txtExt.Size = new System.Drawing.Size(26, 16);
            this.txtExt.TabIndex = 11;
            this.txtExt.Text = "Ext";
            this.txtExt.Enter += new System.EventHandler(this.txtExt_Enter);
            this.txtExt.Leave += new System.EventHandler(this.txtExt_Leave);
            // 
            // btnmin
            // 
            this.btnmin.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnmin.Image = global::PizzaApp.Properties.Resources.btnMin;
            this.btnmin.InitialImage = null;
            this.btnmin.Location = new System.Drawing.Point(292, 0);
            this.btnmin.Name = "btnmin";
            this.btnmin.Size = new System.Drawing.Size(15, 18);
            this.btnmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnmin.TabIndex = 13;
            this.btnmin.TabStop = false;
            this.btnmin.Click += new System.EventHandler(this.btnmin_Click);
            // 
            // btncerrar
            // 
            this.btncerrar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btncerrar.Image = global::PizzaApp.Properties.Resources.btnClose;
            this.btncerrar.InitialImage = null;
            this.btncerrar.Location = new System.Drawing.Point(304, 0);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(15, 18);
            this.btncerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btncerrar.TabIndex = 12;
            this.btncerrar.TabStop = false;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(319, 483);
            this.Controls.Add(this.btnmin);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.txtExt);
            this.Controls.Add(this.txtInt);
            this.Controls.Add(this.lblerr);
            this.Controls.Add(this.txtcp);
            this.Controls.Add(this.btnregister);
            this.Controls.Add(this.cmbBoxAlc);
            this.Controls.Add(this.txtcol);
            this.Controls.Add(this.txtcalle);
            this.Controls.Add(this.txtmail);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtusr);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtusr;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.TextBox txtmail;
        private System.Windows.Forms.TextBox txtcalle;
        private System.Windows.Forms.TextBox txtcol;
        private System.Windows.Forms.ComboBox cmbBoxAlc;
        private System.Windows.Forms.Button btnregister;
        private System.Windows.Forms.TextBox txtcp;
        private System.Windows.Forms.Label lblerr;
        private System.Windows.Forms.TextBox txtInt;
        private System.Windows.Forms.TextBox txtExt;
        private System.Windows.Forms.PictureBox btnmin;
        private System.Windows.Forms.PictureBox btncerrar;
    }
}