namespace WindowsFormHotelManagementSystem.Forms
{
    partial class FormCustomerInfo
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
            this.customerDataGrid = new System.Windows.Forms.DataGridView();
            this.cs_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cs_national_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cs_phone_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cs_room_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cs_checkin_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cs_checkout_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // customerDataGrid
            // 
            this.customerDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cs_name,
            this.cs_national_id,
            this.cs_phone_number,
            this.cs_room_number,
            this.cs_checkin_date,
            this.cs_checkout_date});
            this.customerDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customerDataGrid.Location = new System.Drawing.Point(0, 0);
            this.customerDataGrid.Name = "customerDataGrid";
            this.customerDataGrid.ReadOnly = true;
            this.customerDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customerDataGrid.Size = new System.Drawing.Size(923, 493);
            this.customerDataGrid.TabIndex = 1;
            // 
            // cs_name
            // 
            this.cs_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cs_name.HeaderText = "Name";
            this.cs_name.Name = "cs_name";
            this.cs_name.ReadOnly = true;
            // 
            // cs_national_id
            // 
            this.cs_national_id.HeaderText = "National ID";
            this.cs_national_id.Name = "cs_national_id";
            this.cs_national_id.ReadOnly = true;
            this.cs_national_id.Width = 150;
            // 
            // cs_phone_number
            // 
            this.cs_phone_number.HeaderText = "Phone Number";
            this.cs_phone_number.Name = "cs_phone_number";
            this.cs_phone_number.ReadOnly = true;
            this.cs_phone_number.Width = 130;
            // 
            // cs_room_number
            // 
            this.cs_room_number.HeaderText = "Room Number";
            this.cs_room_number.Name = "cs_room_number";
            this.cs_room_number.ReadOnly = true;
            this.cs_room_number.Width = 104;
            // 
            // cs_checkin_date
            // 
            this.cs_checkin_date.HeaderText = "Checkin Date";
            this.cs_checkin_date.Name = "cs_checkin_date";
            this.cs_checkin_date.ReadOnly = true;
            this.cs_checkin_date.Width = 150;
            // 
            // cs_checkout_date
            // 
            this.cs_checkout_date.HeaderText = "Checkout Date";
            this.cs_checkout_date.Name = "cs_checkout_date";
            this.cs_checkout_date.ReadOnly = true;
            this.cs_checkout_date.Width = 150;
            // 
            // FormCustomerInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(923, 493);
            this.Controls.Add(this.customerDataGrid);
            this.Name = "FormCustomerInfo";
            this.Text = "CUSTOMER INFORMATION";
            this.Load += new System.EventHandler(this.FormCustomerInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView customerDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cs_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn cs_national_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cs_phone_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn cs_room_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn cs_checkin_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn cs_checkout_date;
    }
}