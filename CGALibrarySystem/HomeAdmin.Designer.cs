namespace CGALibrarySystem
{
    partial class AdminHome
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
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.studentListBtn = new System.Windows.Forms.Button();
            this.bookListBtn = new System.Windows.Forms.Button();
            this.borrowingListBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.logOutBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(329, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(653, 91);
            this.label2.TabIndex = 27;
            this.label2.Text = "Welcome Admin!";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(460, 202);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(348, 32);
            this.label9.TabIndex = 33;
            this.label9.Text = "What do you want to do?";
            // 
            // studentListBtn
            // 
            this.studentListBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentListBtn.Location = new System.Drawing.Point(71, 44);
            this.studentListBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.studentListBtn.Name = "studentListBtn";
            this.studentListBtn.Size = new System.Drawing.Size(177, 45);
            this.studentListBtn.TabIndex = 34;
            this.studentListBtn.Text = "Student List";
            this.studentListBtn.UseVisualStyleBackColor = true;
            this.studentListBtn.Click += new System.EventHandler(this.btnSetInactiveSlist_Click);
            // 
            // bookListBtn
            // 
            this.bookListBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookListBtn.Location = new System.Drawing.Point(71, 109);
            this.bookListBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bookListBtn.Name = "bookListBtn";
            this.bookListBtn.Size = new System.Drawing.Size(177, 45);
            this.bookListBtn.TabIndex = 35;
            this.bookListBtn.Text = "Book List";
            this.bookListBtn.UseVisualStyleBackColor = true;
            this.bookListBtn.Click += new System.EventHandler(this.bookListBtn_Click);
            // 
            // borrowingListBtn
            // 
            this.borrowingListBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowingListBtn.Location = new System.Drawing.Point(71, 175);
            this.borrowingListBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.borrowingListBtn.Name = "borrowingListBtn";
            this.borrowingListBtn.Size = new System.Drawing.Size(177, 45);
            this.borrowingListBtn.TabIndex = 36;
            this.borrowingListBtn.Text = "Borrowing List";
            this.borrowingListBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.borrowingListBtn);
            this.groupBox1.Controls.Add(this.bookListBtn);
            this.groupBox1.Controls.Add(this.studentListBtn);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(296, 274);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 261);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Admin Account";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // logOutBtn
            // 
            this.logOutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutBtn.Location = new System.Drawing.Point(1146, 655);
            this.logOutBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(160, 45);
            this.logOutBtn.TabIndex = 37;
            this.logOutBtn.Text = "Log Out";
            this.logOutBtn.UseVisualStyleBackColor = true;
            this.logOutBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(673, 274);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(324, 261);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Super Account";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(67, 166);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 45);
            this.button1.TabIndex = 36;
            this.button1.Text = "Create Account";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(67, 58);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 75);
            this.button2.TabIndex = 35;
            this.button2.Text = "Modify Admin Account";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AdminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 721);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.logOutBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AdminHome";
            this.Text = "Library System - Admin Home";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button studentListBtn;
        private System.Windows.Forms.Button bookListBtn;
        private System.Windows.Forms.Button borrowingListBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button logOutBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}