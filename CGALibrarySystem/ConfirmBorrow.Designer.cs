namespace CGALibrarySystem
{
    partial class ConfirmBorrow
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
            this.txtAvailable = new System.Windows.Forms.Label();
            this.viewNameBook = new System.Windows.Forms.Label();
            this.viewBorrowingID = new System.Windows.Forms.Label();
            this.viewBookID = new System.Windows.Forms.Label();
            this.viewStudentID = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.submitBtn = new System.Windows.Forms.Button();
            this.dgBorrowingInfo = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.viewReturnDate = new System.Windows.Forms.Label();
            this.viewBorrowDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgBorrowingInfo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAvailable
            // 
            this.txtAvailable.AutoSize = true;
            this.txtAvailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAvailable.ForeColor = System.Drawing.SystemColors.Control;
            this.txtAvailable.Location = new System.Drawing.Point(281, 613);
            this.txtAvailable.Name = "txtAvailable";
            this.txtAvailable.Size = new System.Drawing.Size(33, 22);
            this.txtAvailable.TabIndex = 92;
            this.txtAvailable.Text = "No";
            this.txtAvailable.Visible = false;
            // 
            // viewNameBook
            // 
            this.viewNameBook.AutoSize = true;
            this.viewNameBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewNameBook.Location = new System.Drawing.Point(22, 69);
            this.viewNameBook.MaximumSize = new System.Drawing.Size(500, 0);
            this.viewNameBook.Name = "viewNameBook";
            this.viewNameBook.Size = new System.Drawing.Size(0, 22);
            this.viewNameBook.TabIndex = 91;
            // 
            // viewBorrowingID
            // 
            this.viewBorrowingID.AutoSize = true;
            this.viewBorrowingID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewBorrowingID.Location = new System.Drawing.Point(197, 42);
            this.viewBorrowingID.Name = "viewBorrowingID";
            this.viewBorrowingID.Size = new System.Drawing.Size(19, 29);
            this.viewBorrowingID.TabIndex = 90;
            this.viewBorrowingID.Text = " ";
            // 
            // viewBookID
            // 
            this.viewBookID.AutoSize = true;
            this.viewBookID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewBookID.Location = new System.Drawing.Point(137, 122);
            this.viewBookID.Name = "viewBookID";
            this.viewBookID.Size = new System.Drawing.Size(19, 29);
            this.viewBookID.TabIndex = 89;
            this.viewBookID.Text = " ";
            this.viewBookID.Click += new System.EventHandler(this.viewBookID_Click);
            // 
            // viewStudentID
            // 
            this.viewStudentID.AutoSize = true;
            this.viewStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewStudentID.Location = new System.Drawing.Point(166, 80);
            this.viewStudentID.Name = "viewStudentID";
            this.viewStudentID.Size = new System.Drawing.Size(19, 29);
            this.viewStudentID.TabIndex = 88;
            this.viewStudentID.Text = " ";
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(1211, 662);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(94, 33);
            this.backBtn.TabIndex = 85;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // submitBtn
            // 
            this.submitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitBtn.Location = new System.Drawing.Point(325, 160);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(102, 33);
            this.submitBtn.TabIndex = 84;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // dgBorrowingInfo
            // 
            this.dgBorrowingInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgBorrowingInfo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgBorrowingInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBorrowingInfo.Location = new System.Drawing.Point(614, 40);
            this.dgBorrowingInfo.Name = "dgBorrowingInfo";
            this.dgBorrowingInfo.RowHeadersWidth = 51;
            this.dgBorrowingInfo.RowTemplate.Height = 24;
            this.dgBorrowingInfo.Size = new System.Drawing.Size(691, 322);
            this.dgBorrowingInfo.TabIndex = 83;
            this.dgBorrowingInfo.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgBorrowingInfo_CellMouseClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(228, 29);
            this.label5.TabIndex = 82;
            this.label5.Text = "Name of the Book:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(443, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 25);
            this.label7.TabIndex = 80;
            this.label7.Text = "Return Date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 25);
            this.label6.TabIndex = 79;
            this.label6.Text = "Borrow Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 29);
            this.label3.TabIndex = 78;
            this.label3.Text = "Book ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 29);
            this.label2.TabIndex = 77;
            this.label2.Text = "Borrowing ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 29);
            this.label1.TabIndex = 76;
            this.label1.Text = "Student ID:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.viewBorrowingID);
            this.groupBox1.Controls.Add(this.viewBookID);
            this.groupBox1.Controls.Add(this.viewStudentID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(26, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(559, 173);
            this.groupBox1.TabIndex = 93;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "IDs";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.viewNameBook);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(26, 225);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(559, 137);
            this.groupBox2.TabIndex = 94;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 29);
            this.label4.TabIndex = 92;
            this.label4.Text = "Select Date:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.viewReturnDate);
            this.groupBox3.Controls.Add(this.viewBorrowDate);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.submitBtn);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(309, 391);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(770, 219);
            this.groupBox3.TabIndex = 95;
            this.groupBox3.TabStop = false;
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // viewReturnDate
            // 
            this.viewReturnDate.AutoSize = true;
            this.viewReturnDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewReturnDate.Location = new System.Drawing.Point(444, 94);
            this.viewReturnDate.MaximumSize = new System.Drawing.Size(293, 0);
            this.viewReturnDate.Name = "viewReturnDate";
            this.viewReturnDate.Size = new System.Drawing.Size(0, 22);
            this.viewReturnDate.TabIndex = 93;
            // 
            // viewBorrowDate
            // 
            this.viewBorrowDate.AutoSize = true;
            this.viewBorrowDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewBorrowDate.Location = new System.Drawing.Point(26, 94);
            this.viewBorrowDate.MaximumSize = new System.Drawing.Size(293, 0);
            this.viewBorrowDate.Name = "viewBorrowDate";
            this.viewBorrowDate.Size = new System.Drawing.Size(0, 22);
            this.viewBorrowDate.TabIndex = 92;
            // 
            // ConfirmBorrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 721);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtAvailable);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.dgBorrowingInfo);
            this.Name = "ConfirmBorrow";
            this.Text = "Library System - Confirm Borrow";
            this.Load += new System.EventHandler(this.ConfirmBorrow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgBorrowingInfo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtAvailable;
        private System.Windows.Forms.Label viewNameBook;
        private System.Windows.Forms.Label viewBorrowingID;
        private System.Windows.Forms.Label viewBookID;
        private System.Windows.Forms.Label viewStudentID;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.DataGridView dgBorrowingInfo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label viewBorrowDate;
        private System.Windows.Forms.Label viewReturnDate;
    }
}