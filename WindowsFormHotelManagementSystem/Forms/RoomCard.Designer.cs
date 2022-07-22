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
            this.label5 = new System.Windows.Forms.Label();
            this.lblroomstatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbximage)).BeginInit();
            this.pnlstatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbximage
            // 
            this.pbximage.Image = global::WindowsFormHotelManagementSystem.Properties.Resources.photo_2022_05_19_16_25_03;
            this.pbximage.Location = new System.Drawing.Point(0, 0);
            this.pbximage.Name = "pbximage";
            this.pbximage.Size = new System.Drawing.Size(241, 180);
            this.pbximage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbximage.TabIndex = 0;
            this.pbximage.TabStop = false;
            this.pbximage.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label1.Location = new System.Drawing.Point(14, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Room Type:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label2.Location = new System.Drawing.Point(14, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Room Number:";
            // 
            // lblroomtype
            // 
            this.lblroomtype.AutoSize = true;
            this.lblroomtype.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblroomtype.Location = new System.Drawing.Point(151, 197);
            this.lblroomtype.Name = "lblroomtype";
            this.lblroomtype.Size = new System.Drawing.Size(53, 20);
            this.lblroomtype.TabIndex = 1;
            this.lblroomtype.Text = "label1";
            // 
            // lblroomnumber
            // 
            this.lblroomnumber.AutoSize = true;
            this.lblroomnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblroomnumber.Location = new System.Drawing.Point(151, 250);
            this.lblroomnumber.Name = "lblroomnumber";
            this.lblroomnumber.Size = new System.Drawing.Size(53, 20);
            this.lblroomnumber.TabIndex = 1;
            this.lblroomnumber.Text = "label1";
            // 
            // pnlstatus
            // 
            this.pnlstatus.BackColor = System.Drawing.Color.LimeGreen;
            this.pnlstatus.Controls.Add(this.lblroomstatus);
            this.pnlstatus.Controls.Add(this.label5);
            this.pnlstatus.Location = new System.Drawing.Point(0, 286);
            this.pnlstatus.Name = "pnlstatus";
            this.pnlstatus.Size = new System.Drawing.Size(241, 70);
            this.pnlstatus.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.label5.Location = new System.Drawing.Point(13, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 29);
            this.label5.TabIndex = 0;
            this.label5.Text = "Status:";
            // 
            // lblroomstatus
            // 
            this.lblroomstatus.AutoSize = true;
            this.lblroomstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblroomstatus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblroomstatus.Location = new System.Drawing.Point(104, 17);
            this.lblroomstatus.Name = "lblroomstatus";
            this.lblroomstatus.Size = new System.Drawing.Size(101, 25);
            this.lblroomstatus.TabIndex = 1;
            this.lblroomstatus.Text = "Available";
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
            this.Name = "RoomCard";
            this.Size = new System.Drawing.Size(242, 355);
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
