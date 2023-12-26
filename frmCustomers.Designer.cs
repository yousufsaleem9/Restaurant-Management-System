namespace Restaurant_Management_System
{
    partial class frmCustomers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomers));
            this.btnDelete = new System.Windows.Forms.Button();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGetData = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.Label23 = new System.Windows.Forms.Label();
            this.Label21 = new System.Windows.Forms.Label();
            this.Label20 = new System.Windows.Forms.Label();
            this.Label19 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.txtContactNo1 = new System.Windows.Forms.TextBox();
            this.GroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(282, 20);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(87, 29);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // GroupBox2
            // 
            this.GroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.GroupBox2.Controls.Add(this.btnGetData);
            this.GroupBox2.Controls.Add(this.btnDelete);
            this.GroupBox2.Controls.Add(this.btnUpdate);
            this.GroupBox2.Controls.Add(this.btnSave);
            this.GroupBox2.Controls.Add(this.btnNew);
            this.GroupBox2.Location = new System.Drawing.Point(3, 364);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(467, 59);
            this.GroupBox2.TabIndex = 8;
            this.GroupBox2.TabStop = false;
            // 
            // btnGetData
            // 
            this.btnGetData.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetData.Location = new System.Drawing.Point(373, 20);
            this.btnGetData.Name = "btnGetData";
            this.btnGetData.Size = new System.Drawing.Size(87, 29);
            this.btnGetData.TabIndex = 4;
            this.btnGetData.Text = "&Get Data";
            this.btnGetData.UseVisualStyleBackColor = true;
            this.btnGetData.Click += new System.EventHandler(this.btnGetData_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(190, 20);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(87, 29);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "&Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(99, 20);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 29);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(6, 19);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(87, 29);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "&New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // txtContactNo
            // 
            this.txtContactNo.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactNo.Location = new System.Drawing.Point(100, 187);
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new System.Drawing.Size(106, 22);
            this.txtContactNo.TabIndex = 3;
            this.txtContactNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContactNo_KeyPress);
            // 
            // txtNotes
            // 
            this.txtNotes.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotes.Location = new System.Drawing.Point(100, 239);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtNotes.Size = new System.Drawing.Size(313, 94);
            this.txtNotes.TabIndex = 6;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(100, 213);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(313, 22);
            this.txtEmail.TabIndex = 5;
            // 
            // Label23
            // 
            this.Label23.AutoSize = true;
            this.Label23.BackColor = System.Drawing.Color.Transparent;
            this.Label23.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label23.Location = new System.Drawing.Point(14, 240);
            this.Label23.Name = "Label23";
            this.Label23.Size = new System.Drawing.Size(44, 15);
            this.Label23.TabIndex = 77;
            this.Label23.Text = "Notes:";
            // 
            // Label21
            // 
            this.Label21.AutoSize = true;
            this.Label21.BackColor = System.Drawing.Color.Transparent;
            this.Label21.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label21.Location = new System.Drawing.Point(209, 189);
            this.Label21.Name = "Label21";
            this.Label21.Size = new System.Drawing.Size(97, 15);
            this.Label21.TabIndex = 75;
            this.Label21.Text = "Alt. Contact No.:";
            // 
            // Label20
            // 
            this.Label20.AutoSize = true;
            this.Label20.BackColor = System.Drawing.Color.Transparent;
            this.Label20.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label20.Location = new System.Drawing.Point(14, 214);
            this.Label20.Name = "Label20";
            this.Label20.Size = new System.Drawing.Size(40, 15);
            this.Label20.TabIndex = 74;
            this.Label20.Text = "Email:";
            // 
            // Label19
            // 
            this.Label19.AutoSize = true;
            this.Label19.BackColor = System.Drawing.Color.Transparent;
            this.Label19.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label19.Location = new System.Drawing.Point(13, 189);
            this.Label19.Name = "Label19";
            this.Label19.Size = new System.Drawing.Size(75, 15);
            this.Label19.TabIndex = 73;
            this.Label19.Text = "Contact No.:";
            // 
            // txtCity
            // 
            this.txtCity.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.Location = new System.Drawing.Point(100, 161);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(106, 22);
            this.txtCity.TabIndex = 2;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(100, 134);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(313, 22);
            this.txtAddress.TabIndex = 1;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.BackColor = System.Drawing.Color.Transparent;
            this.Label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(13, 164);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(32, 15);
            this.Label6.TabIndex = 69;
            this.Label6.Text = "City:";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.BackColor = System.Drawing.Color.Transparent;
            this.Label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(13, 137);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(55, 15);
            this.Label5.TabIndex = 68;
            this.Label5.Text = "Address:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(13, 108);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(44, 15);
            this.Label2.TabIndex = 67;
            this.Label2.Text = "Name:";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.Location = new System.Drawing.Point(100, 107);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(313, 22);
            this.txtCustomerName.TabIndex = 0;
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerID.Location = new System.Drawing.Point(101, 80);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.ReadOnly = true;
            this.txtCustomerID.Size = new System.Drawing.Size(106, 22);
            this.txtCustomerID.TabIndex = 7;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.BackColor = System.Drawing.Color.Transparent;
            this.Label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(13, 80);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(79, 15);
            this.Label4.TabIndex = 66;
            this.Label4.Text = "Customer ID:";
            // 
            // txtContactNo1
            // 
            this.txtContactNo1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactNo1.Location = new System.Drawing.Point(307, 189);
            this.txtContactNo1.Name = "txtContactNo1";
            this.txtContactNo1.Size = new System.Drawing.Size(106, 22);
            this.txtContactNo1.TabIndex = 4;
            this.txtContactNo1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContactNo1_KeyPress);
            // 
            // frmCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 447);
            this.Controls.Add(this.txtContactNo1);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.txtContactNo);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.Label23);
            this.Controls.Add(this.Label21);
            this.Controls.Add(this.Label20);
            this.Controls.Add(this.Label19);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.Label4);
            this.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(475, 447);
            this.MinimumSize = new System.Drawing.Size(475, 447);
            this.Name = "frmCustomers";
            this.Style = MetroFramework.MetroColorStyle.Brown;
            this.Text = "Customers";
            this.Load += new System.EventHandler(this.frmCustomers_Load);
            this.GroupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnDelete;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Button btnUpdate;
        internal System.Windows.Forms.Button btnSave;
        internal System.Windows.Forms.Button btnNew;
        internal System.Windows.Forms.TextBox txtContactNo;
        internal System.Windows.Forms.TextBox txtNotes;
        internal System.Windows.Forms.TextBox txtEmail;
        internal System.Windows.Forms.Label Label23;
        internal System.Windows.Forms.Label Label21;
        internal System.Windows.Forms.Label Label20;
        internal System.Windows.Forms.Label Label19;
        internal System.Windows.Forms.TextBox txtCity;
        internal System.Windows.Forms.TextBox txtAddress;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtCustomerName;
        internal System.Windows.Forms.TextBox txtCustomerID;
        internal System.Windows.Forms.Label Label4;
        public System.Windows.Forms.TextBox txtContactNo1;
        internal System.Windows.Forms.Button btnGetData;
    }
}