namespace PizzaApp
{
    partial class Form1
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
            this.mainFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCompra = new System.Windows.Forms.Button();
            this.totalLabel = new System.Windows.Forms.Label();
            this.SideMenu = new System.Windows.Forms.Panel();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.ContactBtn = new System.Windows.Forms.Button();
            this.AboutBtn = new System.Windows.Forms.Button();
            this.OrderBtn = new System.Windows.Forms.Button();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.LogoLabel = new System.Windows.Forms.Label();
            this.LogoPB = new System.Windows.Forms.PictureBox();
            this.buyPanel = new System.Windows.Forms.Panel();
            this.OrderLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SideMenu.SuspendLayout();
            this.logoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPB)).BeginInit();
            this.buyPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainFlowLayout
            // 
            this.mainFlowLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainFlowLayout.AutoScroll = true;
            this.mainFlowLayout.Location = new System.Drawing.Point(25, 158);
            this.mainFlowLayout.Name = "mainFlowLayout";
            this.mainFlowLayout.Size = new System.Drawing.Size(712, 366);
            this.mainFlowLayout.TabIndex = 9;
            // 
            // btnCompra
            // 
            this.btnCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(181)))), ((int)(((byte)(89)))));
            this.btnCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompra.ForeColor = System.Drawing.Color.White;
            this.btnCompra.Location = new System.Drawing.Point(124, 586);
            this.btnCompra.Name = "btnCompra";
            this.btnCompra.Size = new System.Drawing.Size(113, 46);
            this.btnCompra.TabIndex = 10;
            this.btnCompra.Text = "Comprar";
            this.btnCompra.UseVisualStyleBackColor = false;
            this.btnCompra.Click += new System.EventHandler(this.btnCompra_Click);
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(515, 598);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(71, 29);
            this.totalLabel.TabIndex = 11;
            this.totalLabel.Text = "$0.00";
            // 
            // SideMenu
            // 
            this.SideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(93)))), ((int)(((byte)(92)))));
            this.SideMenu.Controls.Add(this.logoutBtn);
            this.SideMenu.Controls.Add(this.ContactBtn);
            this.SideMenu.Controls.Add(this.AboutBtn);
            this.SideMenu.Controls.Add(this.OrderBtn);
            this.SideMenu.Controls.Add(this.logoPanel);
            this.SideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideMenu.Location = new System.Drawing.Point(0, 0);
            this.SideMenu.Name = "SideMenu";
            this.SideMenu.Size = new System.Drawing.Size(239, 681);
            this.SideMenu.TabIndex = 12;
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.Color.Transparent;
            this.logoutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logoutBtn.FlatAppearance.BorderSize = 0;
            this.logoutBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(73)))), ((int)(((byte)(72)))));
            this.logoutBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.logoutBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(73)))), ((int)(((byte)(72)))));
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.logoutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutBtn.Location = new System.Drawing.Point(0, 622);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.logoutBtn.Size = new System.Drawing.Size(239, 59);
            this.logoutBtn.TabIndex = 4;
            this.logoutBtn.Text = "  Logout";
            this.logoutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // ContactBtn
            // 
            this.ContactBtn.BackColor = System.Drawing.Color.Transparent;
            this.ContactBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ContactBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.ContactBtn.FlatAppearance.BorderSize = 0;
            this.ContactBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(73)))), ((int)(((byte)(72)))));
            this.ContactBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ContactBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(73)))), ((int)(((byte)(72)))));
            this.ContactBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ContactBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.ContactBtn.Image = global::PizzaApp.Properties.Resources.contact_icon;
            this.ContactBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ContactBtn.Location = new System.Drawing.Point(0, 419);
            this.ContactBtn.Name = "ContactBtn";
            this.ContactBtn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.ContactBtn.Size = new System.Drawing.Size(239, 59);
            this.ContactBtn.TabIndex = 3;
            this.ContactBtn.Text = "  Contacto";
            this.ContactBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ContactBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ContactBtn.UseVisualStyleBackColor = false;
            this.ContactBtn.Click += new System.EventHandler(this.ContactBtn_Click);
            // 
            // AboutBtn
            // 
            this.AboutBtn.BackColor = System.Drawing.Color.Transparent;
            this.AboutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AboutBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.AboutBtn.FlatAppearance.BorderSize = 0;
            this.AboutBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(73)))), ((int)(((byte)(72)))));
            this.AboutBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.AboutBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(73)))), ((int)(((byte)(72)))));
            this.AboutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AboutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.AboutBtn.Image = global::PizzaApp.Properties.Resources.about_us_icon;
            this.AboutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AboutBtn.Location = new System.Drawing.Point(0, 360);
            this.AboutBtn.Name = "AboutBtn";
            this.AboutBtn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.AboutBtn.Size = new System.Drawing.Size(239, 59);
            this.AboutBtn.TabIndex = 2;
            this.AboutBtn.Text = "  Acerca de";
            this.AboutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AboutBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AboutBtn.UseVisualStyleBackColor = false;
            this.AboutBtn.Click += new System.EventHandler(this.AboutBtn_Click);
            // 
            // OrderBtn
            // 
            this.OrderBtn.BackColor = System.Drawing.Color.Transparent;
            this.OrderBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OrderBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.OrderBtn.FlatAppearance.BorderSize = 0;
            this.OrderBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(73)))), ((int)(((byte)(72)))));
            this.OrderBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.OrderBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(73)))), ((int)(((byte)(72)))));
            this.OrderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OrderBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.OrderBtn.Image = global::PizzaApp.Properties.Resources.pizza_icon;
            this.OrderBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OrderBtn.Location = new System.Drawing.Point(0, 301);
            this.OrderBtn.Name = "OrderBtn";
            this.OrderBtn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.OrderBtn.Size = new System.Drawing.Size(239, 59);
            this.OrderBtn.TabIndex = 1;
            this.OrderBtn.Text = "  Ordena";
            this.OrderBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.OrderBtn.UseCompatibleTextRendering = true;
            this.OrderBtn.UseVisualStyleBackColor = true;
            this.OrderBtn.Click += new System.EventHandler(this.OrderBtn_Click);
            // 
            // logoPanel
            // 
            this.logoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(93)))), ((int)(((byte)(92)))));
            this.logoPanel.Controls.Add(this.LogoLabel);
            this.logoPanel.Controls.Add(this.LogoPB);
            this.logoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoPanel.Location = new System.Drawing.Point(0, 0);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(239, 301);
            this.logoPanel.TabIndex = 0;
            // 
            // LogoLabel
            // 
            this.LogoLabel.AutoSize = true;
            this.LogoLabel.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Bold);
            this.LogoLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LogoLabel.Location = new System.Drawing.Point(21, 216);
            this.LogoLabel.Name = "LogoLabel";
            this.LogoLabel.Size = new System.Drawing.Size(200, 40);
            this.LogoLabel.TabIndex = 1;
            this.LogoLabel.Text = "Child\'s Piksas";
            // 
            // LogoPB
            // 
            this.LogoPB.BackColor = System.Drawing.Color.Transparent;
            this.LogoPB.Image = global::PizzaApp.Properties.Resources.Pizza_logo;
            this.LogoPB.Location = new System.Drawing.Point(40, 49);
            this.LogoPB.Name = "LogoPB";
            this.LogoPB.Size = new System.Drawing.Size(150, 150);
            this.LogoPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoPB.TabIndex = 0;
            this.LogoPB.TabStop = false;
            // 
            // buyPanel
            // 
            this.buyPanel.Controls.Add(this.OrderLabel);
            this.buyPanel.Controls.Add(this.pictureBox1);
            this.buyPanel.Controls.Add(this.mainFlowLayout);
            this.buyPanel.Controls.Add(this.label1);
            this.buyPanel.Controls.Add(this.totalLabel);
            this.buyPanel.Controls.Add(this.btnCompra);
            this.buyPanel.Location = new System.Drawing.Point(239, 0);
            this.buyPanel.Name = "buyPanel";
            this.buyPanel.Size = new System.Drawing.Size(765, 681);
            this.buyPanel.TabIndex = 13;
            // 
            // OrderLabel
            // 
            this.OrderLabel.AutoSize = true;
            this.OrderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderLabel.ForeColor = System.Drawing.Color.SeaGreen;
            this.OrderLabel.Location = new System.Drawing.Point(135, 58);
            this.OrderLabel.Name = "OrderLabel";
            this.OrderLabel.Size = new System.Drawing.Size(335, 51);
            this.OrderLabel.TabIndex = 13;
            this.OrderLabel.Text = "Realiza tu orden";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PizzaApp.Properties.Resources.order_icon;
            this.pictureBox1.Location = new System.Drawing.Point(45, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(435, 598);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "Total:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 681);
            this.Controls.Add(this.buyPanel);
            this.Controls.Add(this.SideMenu);
            this.MaximumSize = new System.Drawing.Size(1020, 720);
            this.MinimumSize = new System.Drawing.Size(1020, 720);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SideMenu.ResumeLayout(false);
            this.logoPanel.ResumeLayout(false);
            this.logoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPB)).EndInit();
            this.buyPanel.ResumeLayout(false);
            this.buyPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel mainFlowLayout;
        private System.Windows.Forms.Button btnCompra;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Panel SideMenu;
        private System.Windows.Forms.Button ContactBtn;
        private System.Windows.Forms.Button AboutBtn;
        private System.Windows.Forms.Button OrderBtn;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.Label LogoLabel;
        private System.Windows.Forms.PictureBox LogoPB;
        private System.Windows.Forms.Panel buyPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label OrderLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button logoutBtn;
    }
}

