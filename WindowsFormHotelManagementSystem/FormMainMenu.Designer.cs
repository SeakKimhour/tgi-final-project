namespace WindowsFormHotelManagementSystem
{
    partial class FormMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainMenu));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnLoginOut = new FontAwesome.Sharp.IconButton();
            this.btncustomerinfo = new FontAwesome.Sharp.IconButton();
            this.btnavailableroom = new FontAwesome.Sharp.IconButton();
            this.btncheckout = new FontAwesome.Sharp.IconButton();
            this.btncheckin = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnMinimize = new FontAwesome.Sharp.IconPictureBox();
            this.btnMaximize = new FontAwesome.Sharp.IconPictureBox();
            this.btnExit = new FontAwesome.Sharp.IconPictureBox();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(22)))), ((int)(((byte)(39)))));
            this.panelMenu.Controls.Add(this.btnLoginOut);
            this.panelMenu.Controls.Add(this.btncustomerinfo);
            this.panelMenu.Controls.Add(this.btnavailableroom);
            this.panelMenu.Controls.Add(this.btncheckout);
            this.panelMenu.Controls.Add(this.btncheckin);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(293, 619);
            this.panelMenu.TabIndex = 0;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
            // 
            // btnLoginOut
            // 
            this.btnLoginOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(22)))), ((int)(((byte)(39)))));
            this.btnLoginOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLoginOut.FlatAppearance.BorderSize = 0;
            this.btnLoginOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginOut.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLoginOut.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnLoginOut.IconColor = System.Drawing.Color.Black;
            this.btnLoginOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLoginOut.Location = new System.Drawing.Point(0, 586);
            this.btnLoginOut.Name = "btnLoginOut";
            this.btnLoginOut.Size = new System.Drawing.Size(293, 33);
            this.btnLoginOut.TabIndex = 8;
            this.btnLoginOut.Text = "Logout";
            this.btnLoginOut.UseVisualStyleBackColor = false;
            this.btnLoginOut.Click += new System.EventHandler(this.btnLoginOut_Click);
            // 
            // btncustomerinfo
            // 
            this.btncustomerinfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btncustomerinfo.FlatAppearance.BorderSize = 0;
            this.btncustomerinfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncustomerinfo.ForeColor = System.Drawing.Color.Gainsboro;
            this.btncustomerinfo.IconChar = FontAwesome.Sharp.IconChar.Info;
            this.btncustomerinfo.IconColor = System.Drawing.Color.Gainsboro;
            this.btncustomerinfo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btncustomerinfo.IconSize = 32;
            this.btncustomerinfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncustomerinfo.Location = new System.Drawing.Point(0, 378);
            this.btncustomerinfo.Margin = new System.Windows.Forms.Padding(4);
            this.btncustomerinfo.Name = "btncustomerinfo";
            this.btncustomerinfo.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.btncustomerinfo.Size = new System.Drawing.Size(293, 78);
            this.btncustomerinfo.TabIndex = 4;
            this.btncustomerinfo.Text = "CUSTOMER INFO";
            this.btncustomerinfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncustomerinfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncustomerinfo.UseVisualStyleBackColor = true;
            this.btncustomerinfo.Click += new System.EventHandler(this.btncustomerinfo_Click);
            // 
            // btnavailableroom
            // 
            this.btnavailableroom.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnavailableroom.FlatAppearance.BorderSize = 0;
            this.btnavailableroom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnavailableroom.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnavailableroom.IconChar = FontAwesome.Sharp.IconChar.Hotel;
            this.btnavailableroom.IconColor = System.Drawing.Color.Gainsboro;
            this.btnavailableroom.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnavailableroom.IconSize = 32;
            this.btnavailableroom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnavailableroom.Location = new System.Drawing.Point(0, 300);
            this.btnavailableroom.Margin = new System.Windows.Forms.Padding(4);
            this.btnavailableroom.Name = "btnavailableroom";
            this.btnavailableroom.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.btnavailableroom.Size = new System.Drawing.Size(293, 78);
            this.btnavailableroom.TabIndex = 3;
            this.btnavailableroom.Text = "AVAILABLE ROOM";
            this.btnavailableroom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnavailableroom.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnavailableroom.UseVisualStyleBackColor = true;
            this.btnavailableroom.Click += new System.EventHandler(this.btnavailableroom_Click);
            // 
            // btncheckout
            // 
            this.btncheckout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btncheckout.FlatAppearance.BorderSize = 0;
            this.btncheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncheckout.ForeColor = System.Drawing.Color.Gainsboro;
            this.btncheckout.IconChar = FontAwesome.Sharp.IconChar.Outdent;
            this.btncheckout.IconColor = System.Drawing.Color.Gainsboro;
            this.btncheckout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btncheckout.IconSize = 32;
            this.btncheckout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncheckout.Location = new System.Drawing.Point(0, 222);
            this.btncheckout.Margin = new System.Windows.Forms.Padding(4);
            this.btncheckout.Name = "btncheckout";
            this.btncheckout.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.btncheckout.Size = new System.Drawing.Size(293, 78);
            this.btncheckout.TabIndex = 2;
            this.btncheckout.Text = "CHECK OUT";
            this.btncheckout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncheckout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncheckout.UseVisualStyleBackColor = true;
            this.btncheckout.Click += new System.EventHandler(this.btncheckout_Click);
            // 
            // btncheckin
            // 
            this.btncheckin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btncheckin.FlatAppearance.BorderSize = 0;
            this.btncheckin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncheckin.ForeColor = System.Drawing.Color.Gainsboro;
            this.btncheckin.IconChar = FontAwesome.Sharp.IconChar.Indent;
            this.btncheckin.IconColor = System.Drawing.Color.Gainsboro;
            this.btncheckin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btncheckin.IconSize = 32;
            this.btncheckin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncheckin.Location = new System.Drawing.Point(0, 144);
            this.btncheckin.Margin = new System.Windows.Forms.Padding(4);
            this.btncheckin.Name = "btncheckin";
            this.btncheckin.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.btncheckin.Size = new System.Drawing.Size(293, 78);
            this.btncheckin.TabIndex = 1;
            this.btncheckin.Text = "CHECK IN";
            this.btncheckin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncheckin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncheckin.UseVisualStyleBackColor = true;
            this.btncheckin.Click += new System.EventHandler(this.btncheckin_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(22)))), ((int)(((byte)(39)))));
            this.panelLogo.Controls.Add(this.btnHome);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(4);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.panelLogo.Size = new System.Drawing.Size(293, 144);
            this.panelLogo.TabIndex = 0;
            this.panelLogo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLogo_Paint);
            // 
            // btnHome
            // 
            this.btnHome.Image = global::WindowsFormHotelManagementSystem.Properties.Resources.TGI_logo_final_EN_03_03;
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(289, 136);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(22)))), ((int)(((byte)(39)))));
            this.panelTitleBar.Controls.Add(this.btnMinimize);
            this.panelTitleBar.Controls.Add(this.btnMaximize);
            this.panelTitleBar.Controls.Add(this.btnExit);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Controls.Add(this.lblTitleChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(293, 0);
            this.panelTitleBar.Margin = new System.Windows.Forms.Padding(4);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(878, 66);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTitleBar_Paint);
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(22)))), ((int)(((byte)(39)))));
            this.btnMinimize.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimize.IconColor = System.Drawing.Color.Gainsboro;
            this.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimize.IconSize = 30;
            this.btnMinimize.Location = new System.Drawing.Point(719, 16);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(4);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(33, 30);
            this.btnMinimize.TabIndex = 5;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(22)))), ((int)(((byte)(39)))));
            this.btnMaximize.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btnMaximize.IconColor = System.Drawing.Color.Gainsboro;
            this.btnMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximize.IconSize = 30;
            this.btnMaximize.Location = new System.Drawing.Point(769, 16);
            this.btnMaximize.Margin = new System.Windows.Forms.Padding(4);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(33, 30);
            this.btnMaximize.TabIndex = 4;
            this.btnMaximize.TabStop = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(22)))), ((int)(((byte)(39)))));
            this.btnExit.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btnExit.IconColor = System.Drawing.Color.Gainsboro;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 30;
            this.btnExit.Location = new System.Drawing.Point(819, 16);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(33, 30);
            this.btnExit.TabIndex = 3;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(22)))), ((int)(((byte)(39)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.IconSize = 30;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(32, 16);
            this.iconCurrentChildForm.Margin = new System.Windows.Forms.Padding(4);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(33, 30);
            this.iconCurrentChildForm.TabIndex = 2;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitleChildForm.Location = new System.Drawing.Point(73, 16);
            this.lblTitleChildForm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(47, 17);
            this.lblTitleChildForm.TabIndex = 1;
            this.lblTitleChildForm.Text = "HOME";
            this.lblTitleChildForm.Click += new System.EventHandler(this.lblTitleChildForm_Click);
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(22)))), ((int)(((byte)(39)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(293, 66);
            this.panelShadow.Margin = new System.Windows.Forms.Padding(4);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(878, 10);
            this.panelShadow.TabIndex = 2;
            this.panelShadow.Paint += new System.Windows.Forms.PaintEventHandler(this.panelShadow_Paint);
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.White;
            this.panelDesktop.Controls.Add(this.pictureBox1);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(293, 76);
            this.panelDesktop.Margin = new System.Windows.Forms.Padding(4);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(878, 543);
            this.panelDesktop.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::WindowsFormHotelManagementSystem.Properties.Resources.photo_2022_05_19_16_25_03;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(878, 543);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 619);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Menu";
            this.Load += new System.EventHandler(this.FormMainMenu_Load);
            this.Resize += new System.EventHandler(this.FormMainMenu_Resize);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btncustomerinfo;
        private FontAwesome.Sharp.IconButton btnavailableroom;
        private FontAwesome.Sharp.IconButton btncheckout;
        private FontAwesome.Sharp.IconButton btncheckin;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lblTitleChildForm;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconPictureBox btnMinimize;
        private FontAwesome.Sharp.IconPictureBox btnMaximize;
        private FontAwesome.Sharp.IconPictureBox btnExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnLoginOut;
    }
}

