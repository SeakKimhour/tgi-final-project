namespace WindowsFormHotelManagementSystem.Forms
{
    partial class RoomCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbximage = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblroomtype = new System.Windows.Forms.Label();
            this.lblroomnumber = new System.Windows.Forms.Label();
            this.pnlstatus = new System.Windows.Forms.Panel();
            this.lblroomstatus = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbximage)).BeginInit();
            this.pnlstatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbximage
            // 
            this.pbximage.Image = global::WindowsFormHotelManagementSystem.Properties.Resources.photo_2022_05_19_16_25_03;
            this.pbximage.Location = new System.Drawing.Point(0, 0);
            this.pbximage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbximage.Name = "pbximage";
            this.pbximage.Size = new System.Drawing.Size(248, 180);
            this.pbximage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbximage.TabIndex = 0;
            this.pbximage.TabStop = false;
            this.pbximage.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pbximage.DoubleClick += new System.EventHandler(this.RoomCard_DoubleClick);
            this.pbximage.MouseEnter += new System.EventHandler(this.RoomCard_MouseEnter);
            this.pbximage.MouseLeave += new System.EventHandler(this.RoomCard_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Room Type:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.DoubleClick += new System.EventHandler(this.RoomCard_DoubleClick);
            this.label1.MouseEnter += new System.EventHandler(this.RoomCard_MouseEnter);
            this.label1.MouseLeave += new System.EventHandler(this.RoomCard_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Room Number:";
            this.label2.DoubleClick += new System.EventHandler(this.RoomCard_DoubleClick);
            this.label2.MouseEnter += new System.EventHandler(this.RoomCard_MouseEnter);
            this.label2.MouseLeave += new System.EventHandler(this.RoomCard_MouseLeave);
            // 
            // lblroomtype
            // 
            this.lblroomtype.AutoSize = true;
            this.lblroomtype.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblroomtype.Location = new System.Drawing.Point(148, 197);
            this.lblroomtype.Name = "lblroomtype";
            this.lblroomtype.Size = new System.Drawing.Size(53, 20);
            this.lblroomtype.TabIndex = 1;
            this.lblroomtype.Text = "label1";
            this.lblroomtype.DoubleClick += new System.EventHandler(this.RoomCard_DoubleClick);
            this.lblroomtype.MouseEnter += new System.EventHandler(this.RoomCard_MouseEnter);
            this.lblroomtype.MouseLeave += new System.EventHandler(this.RoomCard_MouseLeave);
            // 
            // lblroomnumber
            // 
            this.lblroomnumber.AutoSize = true;
            this.lblroomnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblroomnumber.Location = new System.Drawing.Point(148, 250);
            this.lblroomnumber.Name = "lblroomnumber";
            this.lblroomnumber.Size = new System.Drawing.Size(53, 20);
            this.lblroomnumber.TabIndex = 1;
            this.lblroomnumber.Text = "label1";
            this.lblroomnumber.DoubleClick += new System.EventHandler(this.RoomCard_DoubleClick);
            this.lblroomnumber.MouseEnter += new System.EventHandler(this.RoomCard_MouseEnter);
            this.lblroomnumber.MouseLeave += new System.EventHandler(this.RoomCard_MouseLeave);
            // 
            // pnlstatus
            // 
            this.pnlstatus.BackColor = System.Drawing.Color.LimeGreen;
            this.pnlstatus.Controls.Add(this.lblroomstatus);
            this.pnlstatus.Controls.Add(this.label5);
            this.pnlstatus.Location = new System.Drawing.Point(0, 286);
            this.pnlstatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlstatus.Name = "pnlstatus";
            this.pnlstatus.Size = new System.Drawing.Size(251, 70);
            this.pnlstatus.TabIndex = 2;
            this.pnlstatus.DoubleClick += new System.EventHandler(this.RoomCard_DoubleClick);
            this.pnlstatus.MouseEnter += new System.EventHandler(this.RoomCard_MouseEnter);
            this.pnlstatus.MouseLeave += new System.EventHandler(this.RoomCard_MouseLeave);
            // 
            // lblroomstatus
            // 
            this.lblroomstatus.AutoSize = true;
            this.lblroomstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblroomstatus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblroomstatus.Location = new System.Drawing.Point(99, 17);
            this.lblroomstatus.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.lblroomstatus.Name = "lblroomstatus";
            this.lblroomstatus.Size = new System.Drawing.Size(101, 25);
            this.lblroomstatus.TabIndex = 1;
            this.lblroomstatus.Text = "Available";
            this.lblroomstatus.DoubleClick += new System.EventHandler(this.RoomCard_DoubleClick);
            this.lblroomstatus.MouseEnter += new System.EventHandler(this.RoomCard_MouseEnter);
            this.lblroomstatus.MouseLeave += new System.EventHandler(this.RoomCard_MouseLeave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Status:";
            this.label5.DoubleClick += new System.EventHandler(this.RoomCard_DoubleClick);
            this.label5.MouseEnter += new System.EventHandler(this.RoomCard_MouseEnter);
            this.label5.MouseLeave += new System.EventHandler(this.RoomCard_MouseLeave);
            // 
            // RoomCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblroomnumber);
            this.Controls.Add(this.pnlstatus);
            this.Controls.Add(this.lblroomtype);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbximage);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(127, 62, 0, 25);
            this.Name = "RoomCard";
            this.Size = new System.Drawing.Size(251, 354);
            this.DoubleClick += new System.EventHandler(this.RoomCard_DoubleClick);
            this.MouseEnter += new System.EventHandler(this.RoomCard_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.RoomCard_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.pbximage)).EndInit();
            this.pnlstatus.ResumeLayout(false);
            this.pnlstatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbximage;
        private System.Windows.Forms.Label lblroomnumber;
        private System.Windows.Forms.Label lblroomtype;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlstatus;
        private System.Windows.Forms.Label lblroomstatus;
        private System.Windows.Forms.Label label5;
    }
}
