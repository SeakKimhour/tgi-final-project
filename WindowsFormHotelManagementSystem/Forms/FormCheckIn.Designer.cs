namespace WindowsFormHotelManagementSystem.Forms
{
    partial class FormCheckIn
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCheckIn));
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.comboRoomNum = new System.Windows.Forms.ComboBox();
            this.comboRoomType = new System.Windows.Forms.ComboBox();
            this.dtpcheckoutdate = new System.Windows.Forms.DateTimePicker();
            this.dtpcheckindate = new System.Windows.Forms.DateTimePicker();
            this.txtadvance = new System.Windows.Forms.TextBox();
            this.txtsubtotal = new System.Windows.Forms.TextBox();
            this.txtdiscount = new System.Windows.Forms.TextBox();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lblDiscountType = new System.Windows.Forms.Label();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.txtnationalid = new System.Windows.Forms.TextBox();
            this.lblNationalID = new System.Windows.Forms.Label();
            this.lblGuestName = new System.Windows.Forms.Label();
            this.txtguestname = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblCheckInDate = new System.Windows.Forms.Label();
            this.lblCheckOutDate = new System.Windows.Forms.Label();
            this.lblNoOfDay = new System.Windows.Forms.Label();
            this.lblNoOfAdults = new System.Windows.Forms.Label();
            this.txtnumofdays = new System.Windows.Forms.TextBox();
            this.txtnumofadults = new System.Windows.Forms.TextBox();
            this.lblNoOfChildren = new System.Windows.Forms.Label();
            this.txtnumofchildren = new System.Windows.Forms.TextBox();
            this.lblAdvancePayment = new System.Windows.Forms.Label();
            this.lblRoomNumber = new System.Windows.Forms.Label();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.errprovider = new System.Windows.Forms.ErrorProvider(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errprovider)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCheckIn.Location = new System.Drawing.Point(1017, 454);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(100, 39);
            this.btnCheckIn.TabIndex = 1;
            this.btnCheckIn.Text = "Check In";
            this.btnCheckIn.UseVisualStyleBackColor = true;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(1135, 454);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 39);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.80925F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.83732F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.41453F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.85632F));
            this.tableLayoutPanel1.Controls.Add(this.comboRoomNum, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.comboRoomType, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.dtpcheckoutdate, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.dtpcheckindate, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtadvance, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtsubtotal, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtdiscount, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblSubTotal, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblDiscountType, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtphone, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtnationalid, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblNationalID, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblGuestName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtguestname, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblPhoneNumber, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblCheckInDate, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblCheckOutDate, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblNoOfDay, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblNoOfAdults, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.txtnumofdays, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.txtnumofadults, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.lblNoOfChildren, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.txtnumofchildren, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.lblAdvancePayment, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblRoomNumber, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblRoomType, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 3);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1221, 434);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // comboRoomNum
            // 
            this.comboRoomNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboRoomNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboRoomNum.FormattingEnabled = true;
            this.comboRoomNum.Location = new System.Drawing.Point(257, 181);
            this.comboRoomNum.Name = "comboRoomNum";
            this.comboRoomNum.Size = new System.Drawing.Size(321, 29);
            this.comboRoomNum.TabIndex = 5;
            // 
            // comboRoomType
            // 
            this.comboRoomType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboRoomType.FormattingEnabled = true;
            this.comboRoomType.Location = new System.Drawing.Point(257, 138);
            this.comboRoomType.Name = "comboRoomType";
            this.comboRoomType.Size = new System.Drawing.Size(321, 29);
            this.comboRoomType.TabIndex = 5;
            this.comboRoomType.SelectedIndexChanged += new System.EventHandler(this.comboRoomType_SelectedIndexChanged_1);
            // 
            // dtpcheckoutdate
            // 
            this.dtpcheckoutdate.CustomFormat = "yyyy/MM/dd";
            this.dtpcheckoutdate.Location = new System.Drawing.Point(257, 261);
            this.dtpcheckoutdate.Name = "dtpcheckoutdate";
            this.dtpcheckoutdate.Size = new System.Drawing.Size(321, 29);
            this.dtpcheckoutdate.TabIndex = 6;
            this.dtpcheckoutdate.ValueChanged += new System.EventHandler(this.dtpcheckoutdate_ValueChanged);
            // 
            // dtpcheckindate
            // 
            this.dtpcheckindate.CustomFormat = "yyyy/MM/dd";
            this.dtpcheckindate.Location = new System.Drawing.Point(257, 218);
            this.dtpcheckindate.Name = "dtpcheckindate";
            this.dtpcheckindate.Size = new System.Drawing.Size(321, 29);
            this.dtpcheckindate.TabIndex = 5;
            // 
            // txtadvance
            // 
            this.txtadvance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtadvance.Location = new System.Drawing.Point(809, 93);
            this.txtadvance.Name = "txtadvance";
            this.txtadvance.Size = new System.Drawing.Size(409, 29);
            this.txtadvance.TabIndex = 12;
            this.txtadvance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtadvance_KeyPress);
            // 
            // txtsubtotal
            // 
            this.txtsubtotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtsubtotal.Location = new System.Drawing.Point(809, 50);
            this.txtsubtotal.Name = "txtsubtotal";
            this.txtsubtotal.Size = new System.Drawing.Size(409, 29);
            this.txtsubtotal.TabIndex = 11;
            // 
            // txtdiscount
            // 
            this.txtdiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtdiscount.Location = new System.Drawing.Point(809, 7);
            this.txtdiscount.Name = "txtdiscount";
            this.txtdiscount.Size = new System.Drawing.Size(409, 29);
            this.txtdiscount.TabIndex = 10;
            this.txtdiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdiscount_KeyPress);
            this.txtdiscount.Leave += new System.EventHandler(this.txtdiscounttype_Leave);
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Location = new System.Drawing.Point(709, 53);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(94, 23);
            this.lblSubTotal.TabIndex = 39;
            this.lblSubTotal.Text = "Sub Total : ";
            // 
            // lblDiscountType
            // 
            this.lblDiscountType.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDiscountType.AutoSize = true;
            this.lblDiscountType.Location = new System.Drawing.Point(712, 10);
            this.lblDiscountType.Name = "lblDiscountType";
            this.lblDiscountType.Size = new System.Drawing.Size(91, 23);
            this.lblDiscountType.TabIndex = 37;
            this.lblDiscountType.Text = "Discount : ";
            this.lblDiscountType.Click += new System.EventHandler(this.lblDiscountType_Click);
            // 
            // txtphone
            // 
            this.txtphone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtphone.Location = new System.Drawing.Point(257, 93);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(321, 29);
            this.txtphone.TabIndex = 2;
            this.txtphone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtphone_KeyPress);
            // 
            // txtnationalid
            // 
            this.txtnationalid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtnationalid.Location = new System.Drawing.Point(257, 50);
            this.txtnationalid.Name = "txtnationalid";
            this.txtnationalid.Size = new System.Drawing.Size(321, 29);
            this.txtnationalid.TabIndex = 1;
            // 
            // lblNationalID
            // 
            this.lblNationalID.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNationalID.AutoSize = true;
            this.lblNationalID.Location = new System.Drawing.Point(145, 53);
            this.lblNationalID.Name = "lblNationalID";
            this.lblNationalID.Size = new System.Drawing.Size(106, 23);
            this.lblNationalID.TabIndex = 2;
            this.lblNationalID.Text = "National ID :";
            // 
            // lblGuestName
            // 
            this.lblGuestName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblGuestName.AutoSize = true;
            this.lblGuestName.Location = new System.Drawing.Point(135, 10);
            this.lblGuestName.Name = "lblGuestName";
            this.lblGuestName.Size = new System.Drawing.Size(116, 23);
            this.lblGuestName.TabIndex = 0;
            this.lblGuestName.Text = "Guest name : ";
            // 
            // txtguestname
            // 
            this.txtguestname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtguestname.Location = new System.Drawing.Point(257, 7);
            this.txtguestname.Name = "txtguestname";
            this.txtguestname.Size = new System.Drawing.Size(321, 29);
            this.txtguestname.TabIndex = 0;
            this.txtguestname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtguestname_KeyPress);
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(117, 96);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(134, 23);
            this.lblPhoneNumber.TabIndex = 3;
            this.lblPhoneNumber.Text = "Phone number: ";
            // 
            // lblCheckInDate
            // 
            this.lblCheckInDate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCheckInDate.AutoSize = true;
            this.lblCheckInDate.Location = new System.Drawing.Point(119, 225);
            this.lblCheckInDate.Name = "lblCheckInDate";
            this.lblCheckInDate.Size = new System.Drawing.Size(132, 23);
            this.lblCheckInDate.TabIndex = 6;
            this.lblCheckInDate.Text = "Check In Date : ";
            // 
            // lblCheckOutDate
            // 
            this.lblCheckOutDate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCheckOutDate.AutoSize = true;
            this.lblCheckOutDate.Location = new System.Drawing.Point(105, 268);
            this.lblCheckOutDate.Name = "lblCheckOutDate";
            this.lblCheckOutDate.Size = new System.Drawing.Size(146, 23);
            this.lblCheckOutDate.TabIndex = 7;
            this.lblCheckOutDate.Text = "Check Out Date : ";
            // 
            // lblNoOfDay
            // 
            this.lblNoOfDay.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNoOfDay.AutoSize = true;
            this.lblNoOfDay.Location = new System.Drawing.Point(148, 311);
            this.lblNoOfDay.Name = "lblNoOfDay";
            this.lblNoOfDay.Size = new System.Drawing.Size(103, 23);
            this.lblNoOfDay.TabIndex = 8;
            this.lblNoOfDay.Text = "No. Of Days";
            // 
            // lblNoOfAdults
            // 
            this.lblNoOfAdults.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNoOfAdults.AutoSize = true;
            this.lblNoOfAdults.Location = new System.Drawing.Point(137, 354);
            this.lblNoOfAdults.Name = "lblNoOfAdults";
            this.lblNoOfAdults.Size = new System.Drawing.Size(114, 23);
            this.lblNoOfAdults.TabIndex = 9;
            this.lblNoOfAdults.Text = "No. Of Adults";
            // 
            // txtnumofdays
            // 
            this.txtnumofdays.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtnumofdays.Location = new System.Drawing.Point(257, 308);
            this.txtnumofdays.Name = "txtnumofdays";
            this.txtnumofdays.Size = new System.Drawing.Size(321, 29);
            this.txtnumofdays.TabIndex = 7;
            // 
            // txtnumofadults
            // 
            this.txtnumofadults.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtnumofadults.Location = new System.Drawing.Point(257, 351);
            this.txtnumofadults.Name = "txtnumofadults";
            this.txtnumofadults.Size = new System.Drawing.Size(321, 29);
            this.txtnumofadults.TabIndex = 8;
            this.txtnumofadults.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnumofadults_KeyPress);
            // 
            // lblNoOfChildren
            // 
            this.lblNoOfChildren.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNoOfChildren.AutoSize = true;
            this.lblNoOfChildren.Location = new System.Drawing.Point(121, 399);
            this.lblNoOfChildren.Name = "lblNoOfChildren";
            this.lblNoOfChildren.Size = new System.Drawing.Size(130, 23);
            this.lblNoOfChildren.TabIndex = 30;
            this.lblNoOfChildren.Text = "No. Of Children";
            // 
            // txtnumofchildren
            // 
            this.txtnumofchildren.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtnumofchildren.Location = new System.Drawing.Point(257, 396);
            this.txtnumofchildren.Name = "txtnumofchildren";
            this.txtnumofchildren.Size = new System.Drawing.Size(321, 29);
            this.txtnumofchildren.TabIndex = 9;
            this.txtnumofchildren.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnumofchildren_KeyPress);
            // 
            // lblAdvancePayment
            // 
            this.lblAdvancePayment.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblAdvancePayment.AutoSize = true;
            this.lblAdvancePayment.Location = new System.Drawing.Point(640, 96);
            this.lblAdvancePayment.Name = "lblAdvancePayment";
            this.lblAdvancePayment.Size = new System.Drawing.Size(163, 23);
            this.lblAdvancePayment.TabIndex = 38;
            this.lblAdvancePayment.Text = "Advance Payment : ";
            // 
            // lblRoomNumber
            // 
            this.lblRoomNumber.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblRoomNumber.AutoSize = true;
            this.lblRoomNumber.Location = new System.Drawing.Point(113, 182);
            this.lblRoomNumber.Name = "lblRoomNumber";
            this.lblRoomNumber.Size = new System.Drawing.Size(138, 23);
            this.lblRoomNumber.TabIndex = 4;
            this.lblRoomNumber.Text = "Room Number : ";
            // 
            // lblRoomType
            // 
            this.lblRoomType.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblRoomType.AutoSize = true;
            this.lblRoomType.Location = new System.Drawing.Point(140, 139);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(111, 23);
            this.lblRoomType.TabIndex = 5;
            this.lblRoomType.Text = "Room Type : ";
            // 
            // errprovider
            // 
            this.errprovider.ContainerControl = this;
            this.errprovider.Icon = ((System.Drawing.Icon)(resources.GetObject("errprovider.Icon")));
            // 
            // FormCheckIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1295, 496);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCheckIn);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormCheckIn";
            this.Text = "CHECK IN";
            this.Load += new System.EventHandler(this.FormCheckIn_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errprovider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DateTimePicker dtpcheckoutdate;
        private System.Windows.Forms.DateTimePicker dtpcheckindate;
        private System.Windows.Forms.TextBox txtadvance;
        private System.Windows.Forms.TextBox txtsubtotal;
        private System.Windows.Forms.TextBox txtdiscount;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label lblDiscountType;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.TextBox txtnationalid;
        private System.Windows.Forms.Label lblNationalID;
        private System.Windows.Forms.Label lblGuestName;
        private System.Windows.Forms.TextBox txtguestname;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblRoomNumber;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.Label lblCheckInDate;
        private System.Windows.Forms.Label lblCheckOutDate;
        private System.Windows.Forms.Label lblNoOfDay;
        private System.Windows.Forms.Label lblNoOfAdults;
        private System.Windows.Forms.TextBox txtnumofdays;
        private System.Windows.Forms.TextBox txtnumofadults;
        private System.Windows.Forms.Label lblNoOfChildren;
        private System.Windows.Forms.TextBox txtnumofchildren;
        private System.Windows.Forms.Label lblAdvancePayment;
        private System.Windows.Forms.ErrorProvider errprovider;
        private System.Windows.Forms.ComboBox comboRoomNum;
        private System.Windows.Forms.ComboBox comboRoomType;
    }
}