namespace CGALibrarySystem
{
    partial class AdminBorrowingList
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
<<<<<<< HEAD
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.setAdminAccRbtn = new System.Windows.Forms.RadioButton();
            this.setSuperAccRbtn = new System.Windows.Forms.RadioButton();
            this.viewFine = new System.Windows.Forms.Label();
=======
>>>>>>> fd599d6ed8a98db4de992d2442b6fbc43359eeef
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.returnedBtn = new System.Windows.Forms.Button();
            this.notReturnedBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.txtReturnDate = new System.Windows.Forms.TextBox();
            this.txtBorrowDate = new System.Windows.Forms.TextBox();
            this.txtBorrowingID = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clearBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.dgBorrowingList = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBackSlist = new System.Windows.Forms.Button();
<<<<<<< HEAD
            this.viewBorrowingID = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBorrowingList)).BeginInit();
=======
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.setAdminAccRbtn = new System.Windows.Forms.RadioButton();
            this.setSuperAccRbtn = new System.Windows.Forms.RadioButton();
            this.viewFine = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBorrowingList)).BeginInit();
            this.groupBox4.SuspendLayout();
>>>>>>> fd599d6ed8a98db4de992d2442b6fbc43359eeef
            this.SuspendLayout();
            // 
            // groupBox2
            // 
<<<<<<< HEAD
            this.groupBox2.Controls.Add(this.viewBorrowingID);
=======
>>>>>>> fd599d6ed8a98db4de992d2442b6fbc43359eeef
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtStudentID);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtBookID);
            this.groupBox2.Controls.Add(this.txtReturnDate);
            this.groupBox2.Controls.Add(this.txtBorrowDate);
            this.groupBox2.Controls.Add(this.txtBorrowingID);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(51, 299);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1246, 361);
            this.groupBox2.TabIndex = 47;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Edit Information";
<<<<<<< HEAD
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.setAdminAccRbtn);
            this.groupBox4.Controls.Add(this.setSuperAccRbtn);
            this.groupBox4.Controls.Add(this.viewFine);
            this.groupBox4.Location = new System.Drawing.Point(435, 112);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(380, 87);
            this.groupBox4.TabIndex = 43;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Fine";
            // 
            // setAdminAccRbtn
            // 
            this.setAdminAccRbtn.AutoSize = true;
            this.setAdminAccRbtn.Location = new System.Drawing.Point(222, 54);
            this.setAdminAccRbtn.Name = "setAdminAccRbtn";
            this.setAdminAccRbtn.Size = new System.Drawing.Size(73, 24);
            this.setAdminAccRbtn.TabIndex = 43;
            this.setAdminAccRbtn.TabStop = true;
            this.setAdminAccRbtn.Text = "None";
            this.setAdminAccRbtn.UseVisualStyleBackColor = true;
            this.setAdminAccRbtn.CheckedChanged += new System.EventHandler(this.setAdminAccRbtn_CheckedChanged);
            // 
            // setSuperAccRbtn
            // 
            this.setSuperAccRbtn.AutoSize = true;
            this.setSuperAccRbtn.Location = new System.Drawing.Point(78, 54);
            this.setSuperAccRbtn.Name = "setSuperAccRbtn";
            this.setSuperAccRbtn.Size = new System.Drawing.Size(72, 24);
            this.setSuperAccRbtn.TabIndex = 42;
            this.setSuperAccRbtn.TabStop = true;
            this.setSuperAccRbtn.Text = "P100";
            this.setSuperAccRbtn.UseVisualStyleBackColor = true;
            this.setSuperAccRbtn.CheckedChanged += new System.EventHandler(this.setSuperAccRbtn_CheckedChanged);
            // 
            // viewFine
            // 
            this.viewFine.AutoSize = true;
            this.viewFine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewFine.Location = new System.Drawing.Point(150, 24);
            this.viewFine.Name = "viewFine";
            this.viewFine.Size = new System.Drawing.Size(0, 22);
            this.viewFine.TabIndex = 41;
=======
>>>>>>> fd599d6ed8a98db4de992d2442b6fbc43359eeef
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.returnedBtn);
            this.groupBox3.Controls.Add(this.notReturnedBtn);
            this.groupBox3.Location = new System.Drawing.Point(179, 203);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(380, 143);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Status";
            // 
            // returnedBtn
            // 
            this.returnedBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnedBtn.Location = new System.Drawing.Point(93, 22);
            this.returnedBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.returnedBtn.Name = "returnedBtn";
            this.returnedBtn.Size = new System.Drawing.Size(198, 45);
            this.returnedBtn.TabIndex = 0;
            this.returnedBtn.Text = "Returned";
            this.returnedBtn.UseVisualStyleBackColor = true;
            this.returnedBtn.Click += new System.EventHandler(this.returnedBtn_Click);
            // 
            // notReturnedBtn
            // 
            this.notReturnedBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notReturnedBtn.Location = new System.Drawing.Point(93, 86);
            this.notReturnedBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.notReturnedBtn.Name = "notReturnedBtn";
            this.notReturnedBtn.Size = new System.Drawing.Size(198, 45);
            this.notReturnedBtn.TabIndex = 1;
            this.notReturnedBtn.Text = "Not Returned";
            this.notReturnedBtn.UseVisualStyleBackColor = true;
            this.notReturnedBtn.Click += new System.EventHandler(this.notReturnedBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 25);
            this.label8.TabIndex = 40;
            this.label8.Text = "Student ID:";
            // 
            // txtStudentID
            // 
            this.txtStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentID.Location = new System.Drawing.Point(22, 148);
            this.txtStudentID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(380, 30);
            this.txtStudentID.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(430, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 25);
            this.label4.TabIndex = 35;
            this.label4.Text = "Book ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(842, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 25);
            this.label3.TabIndex = 34;
            this.label3.Text = "Return Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(842, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 25);
            this.label1.TabIndex = 33;
            this.label1.Text = "Borrow Date:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(17, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 25);
            this.label9.TabIndex = 32;
            this.label9.Text = "Borrowing ID:";
            // 
            // txtBookID
            // 
            this.txtBookID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookID.Location = new System.Drawing.Point(435, 64);
            this.txtBookID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.Size = new System.Drawing.Size(380, 30);
            this.txtBookID.TabIndex = 31;
            // 
            // txtReturnDate
            // 
            this.txtReturnDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReturnDate.Location = new System.Drawing.Point(847, 148);
            this.txtReturnDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtReturnDate.Name = "txtReturnDate";
            this.txtReturnDate.Size = new System.Drawing.Size(380, 30);
            this.txtReturnDate.TabIndex = 30;
            // 
            // txtBorrowDate
            // 
            this.txtBorrowDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBorrowDate.Location = new System.Drawing.Point(847, 64);
            this.txtBorrowDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBorrowDate.Name = "txtBorrowDate";
            this.txtBorrowDate.Size = new System.Drawing.Size(380, 30);
            this.txtBorrowDate.TabIndex = 29;
            // 
            // txtBorrowingID
            // 
            this.txtBorrowingID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBorrowingID.Location = new System.Drawing.Point(22, 64);
            this.txtBorrowingID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBorrowingID.Name = "txtBorrowingID";
            this.txtBorrowingID.Size = new System.Drawing.Size(380, 30);
            this.txtBorrowingID.TabIndex = 28;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clearBtn);
            this.groupBox1.Controls.Add(this.updateBtn);
            this.groupBox1.Location = new System.Drawing.Point(691, 203);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(380, 143);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modify";
            // 
            // clearBtn
            // 
            this.clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.Location = new System.Drawing.Point(90, 22);
            this.clearBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(198, 45);
            this.clearBtn.TabIndex = 2;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.Location = new System.Drawing.Point(90, 86);
            this.updateBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(198, 45);
            this.updateBtn.TabIndex = 1;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // dgBorrowingList
            // 
            this.dgBorrowingList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgBorrowingList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBorrowingList.Location = new System.Drawing.Point(51, 67);
            this.dgBorrowingList.Name = "dgBorrowingList";
            this.dgBorrowingList.RowHeadersWidth = 51;
            this.dgBorrowingList.RowTemplate.Height = 24;
            this.dgBorrowingList.Size = new System.Drawing.Size(1246, 215);
            this.dgBorrowingList.TabIndex = 46;
            this.dgBorrowingList.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgBorrowingList_CellMouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(322, 51);
            this.label2.TabIndex = 45;
            this.label2.Text = "Borrowing List:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnBackSlist
            // 
            this.btnBackSlist.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackSlist.Location = new System.Drawing.Point(1164, 670);
            this.btnBackSlist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBackSlist.Name = "btnBackSlist";
            this.btnBackSlist.Size = new System.Drawing.Size(133, 40);
            this.btnBackSlist.TabIndex = 48;
            this.btnBackSlist.Text = "Back";
            this.btnBackSlist.UseVisualStyleBackColor = true;
            this.btnBackSlist.Click += new System.EventHandler(this.btnBackSlist_Click);
            // 
<<<<<<< HEAD
            // viewBorrowingID
            // 
            this.viewBorrowingID.AutoSize = true;
            this.viewBorrowingID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewBorrowingID.Location = new System.Drawing.Point(175, 37);
            this.viewBorrowingID.Name = "viewBorrowingID";
            this.viewBorrowingID.Size = new System.Drawing.Size(0, 22);
            this.viewBorrowingID.TabIndex = 44;
=======
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.setAdminAccRbtn);
            this.groupBox4.Controls.Add(this.setSuperAccRbtn);
            this.groupBox4.Controls.Add(this.viewFine);
            this.groupBox4.Location = new System.Drawing.Point(435, 112);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(380, 87);
            this.groupBox4.TabIndex = 43;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Fine";
            // 
            // setAdminAccRbtn
            // 
            this.setAdminAccRbtn.AutoSize = true;
            this.setAdminAccRbtn.Location = new System.Drawing.Point(222, 54);
            this.setAdminAccRbtn.Name = "setAdminAccRbtn";
            this.setAdminAccRbtn.Size = new System.Drawing.Size(73, 24);
            this.setAdminAccRbtn.TabIndex = 43;
            this.setAdminAccRbtn.TabStop = true;
            this.setAdminAccRbtn.Text = "None";
            this.setAdminAccRbtn.UseVisualStyleBackColor = true;
            this.setAdminAccRbtn.CheckedChanged += new System.EventHandler(this.setAdminAccRbtn_CheckedChanged);
            // 
            // setSuperAccRbtn
            // 
            this.setSuperAccRbtn.AutoSize = true;
            this.setSuperAccRbtn.Location = new System.Drawing.Point(78, 54);
            this.setSuperAccRbtn.Name = "setSuperAccRbtn";
            this.setSuperAccRbtn.Size = new System.Drawing.Size(72, 24);
            this.setSuperAccRbtn.TabIndex = 42;
            this.setSuperAccRbtn.TabStop = true;
            this.setSuperAccRbtn.Text = "P100";
            this.setSuperAccRbtn.UseVisualStyleBackColor = true;
            this.setSuperAccRbtn.CheckedChanged += new System.EventHandler(this.setSuperAccRbtn_CheckedChanged);
            // 
            // viewFine
            // 
            this.viewFine.AutoSize = true;
            this.viewFine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewFine.Location = new System.Drawing.Point(150, 24);
            this.viewFine.Name = "viewFine";
            this.viewFine.Size = new System.Drawing.Size(0, 22);
            this.viewFine.TabIndex = 41;
>>>>>>> fd599d6ed8a98db4de992d2442b6fbc43359eeef
            // 
            // AdminBorrowingList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 721);
            this.Controls.Add(this.btnBackSlist);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgBorrowingList);
            this.Controls.Add(this.label2);
            this.Name = "AdminBorrowingList";
            this.Text = "Library System - Admin Borrowing List";
            this.Load += new System.EventHandler(this.AdminBorrowingList_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
<<<<<<< HEAD
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgBorrowingList)).EndInit();
=======
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgBorrowingList)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
>>>>>>> fd599d6ed8a98db4de992d2442b6fbc43359eeef
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button returnedBtn;
        private System.Windows.Forms.Button notReturnedBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBookID;
        private System.Windows.Forms.TextBox txtReturnDate;
        private System.Windows.Forms.TextBox txtBorrowDate;
        private System.Windows.Forms.TextBox txtBorrowingID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.DataGridView dgBorrowingList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBackSlist;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton setAdminAccRbtn;
        private System.Windows.Forms.RadioButton setSuperAccRbtn;
        private System.Windows.Forms.Label viewFine;
<<<<<<< HEAD
        private System.Windows.Forms.Label viewBorrowingID;
=======
>>>>>>> fd599d6ed8a98db4de992d2442b6fbc43359eeef
    }
}