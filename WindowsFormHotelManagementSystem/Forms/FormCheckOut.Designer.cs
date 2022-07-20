namespace WindowsFormHotelManagementSystem.Forms
{
    partial class FormCheckOut
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cbb_room = new System.Windows.Forms.ComboBox();
            this.dtp_check_in_date = new System.Windows.Forms.DateTimePicker();
            this.dtp_check_out_date = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.lblGuestName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGuestName = new System.Windows.Forms.TextBox();
            this.txtTotalNight = new System.Windows.Forms.TextBox();
            this.txtAddtionPrice = new System.Windows.Forms.TextBox();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68F));
            this.tableLayoutPanel1.Controls.Add(this.cbb_room, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.dtp_check_in_date, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.dtp_check_out_date, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblGuestName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtGuestName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtTotalNight, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtAddtionPrice, 1, 6);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(16, 16);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28592F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28592F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28592F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28592F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28592F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28592F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28449F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(451, 417);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // cbb_room
            // 
            this.cbb_room.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbb_room.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_room.FormattingEnabled = true;
            this.cbb_room.Location = new System.Drawing.Point(147, 76);
            this.cbb_room.Name = "cbb_room";
            this.cbb_room.Size = new System.Drawing.Size(376, 29);
            this.cbb_room.TabIndex = 1;
            this.cbb_room.SelectedIndexChanged += new System.EventHandler(this.cbb_room_SelectedIndexChanged);
            this.cbb_room.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbb_room_KeyDown);
            // 
            // dtp_check_in_date
            // 
            this.dtp_check_in_date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_check_in_date.Location = new System.Drawing.Point(148, 192);
            this.dtp_check_in_date.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_check_in_date.Name = "dtp_check_in_date";
            this.dtp_check_in_date.Size = new System.Drawing.Size(299, 29);
            this.dtp_check_in_date.TabIndex = 3;
            // 
            // dtp_check_out_date
            // 
            this.dtp_check_out_date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_check_out_date.Location = new System.Drawing.Point(148, 133);
            this.dtp_check_out_date.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_check_out_date.Name = "dtp_check_out_date";
            this.dtp_check_out_date.Size = new System.Drawing.Size(299, 29);
            this.dtp_check_out_date.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 362);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 46);
            this.label6.TabIndex = 7;
            this.label6.Text = "Additional price :";
            // 
            // lblGuestName
            // 
            this.lblGuestName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblGuestName.AutoSize = true;
            this.lblGuestName.Location = new System.Drawing.Point(24, 18);
            this.lblGuestName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGuestName.Name = "lblGuestName";
            this.lblGuestName.Size = new System.Drawing.Size(116, 23);
            this.lblGuestName.TabIndex = 1;
            this.lblGuestName.Text = "Guest name : ";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 254);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Total Night : ";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 183);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "Check Out Date : ";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 136);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Check In Date : ";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 77);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "Room Number : ";
            // 
            // txtGuestName
            // 
            this.txtGuestName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGuestName.Location = new System.Drawing.Point(148, 15);
            this.txtGuestName.Margin = new System.Windows.Forms.Padding(4);
            this.txtGuestName.Name = "txtGuestName";
            this.txtGuestName.Size = new System.Drawing.Size(299, 29);
            this.txtGuestName.TabIndex = 0;
            this.txtGuestName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGuestName_KeyPress);
            // 
            // txtTotalNight
            // 
            this.txtTotalNight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalNight.Location = new System.Drawing.Point(148, 251);
            this.txtTotalNight.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalNight.Name = "txtTotalNight";
            this.txtTotalNight.Size = new System.Drawing.Size(299, 29);
            this.txtTotalNight.TabIndex = 4;
            this.txtTotalNight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotalNight_KeyPress);
            // 
            // txtAddtionPrice
            // 
            this.txtAddtionPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddtionPrice.Location = new System.Drawing.Point(148, 371);
            this.txtAddtionPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddtionPrice.Name = "txtAddtionPrice";
            this.txtAddtionPrice.Size = new System.Drawing.Size(299, 29);
            this.txtAddtionPrice.TabIndex = 5;
            this.txtAddtionPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAddtionPrice_KeyPress);
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCheckIn.Location = new System.Drawing.Point(657, 454);
            this.btnCheckIn.Margin = new System.Windows.Forms.Padding(4);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(100, 39);
            this.btnCheckIn.TabIndex = 0;
            this.btnCheckIn.Text = "Check OUT";
            this.btnCheckIn.UseVisualStyleBackColor = true;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(775, 454);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 39);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // FormCheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(935, 496);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCheckIn);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormCheckOut";
            this.Text = "CHECK OUT";
            this.Load += new System.EventHandler(this.FormCheckOut_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblGuestName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGuestName;
        private System.Windows.Forms.TextBox txtTotalNight;
        private System.Windows.Forms.TextBox txtAddtionPrice;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DateTimePicker dtp_check_in_date;
        private System.Windows.Forms.DateTimePicker dtp_check_out_date;
        private System.Windows.Forms.ComboBox cbb_room;
    }
}