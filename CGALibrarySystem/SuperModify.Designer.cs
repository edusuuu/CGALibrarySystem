namespace CGALibrarySystem
{
    partial class SuperModify
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.setSuperBtn = new System.Windows.Forms.Button();
            this.setAdminBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFullname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtAdminID = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clearBtn = new System.Windows.Forms.Button();
            this.setActiveBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.setInactiveBtn = new System.Windows.Forms.Button();
            this.btnBackSlist = new System.Windows.Forms.Button();
            this.dgAdminInfo = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAdminInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtFullname);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.txtPassword);
            this.groupBox2.Controls.Add(this.txtUsername);
            this.groupBox2.Controls.Add(this.txtAdminID);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(41, 251);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1246, 377);
            this.groupBox2.TabIndex = 48;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Edit Information";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.setSuperBtn);
            this.groupBox3.Controls.Add(this.setAdminBtn);
            this.groupBox3.Location = new System.Drawing.Point(238, 192);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(380, 143);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Account Type";
            // 
            // setSuperBtn
            // 
            this.setSuperBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setSuperBtn.Location = new System.Drawing.Point(64, 24);
            this.setSuperBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.setSuperBtn.Name = "setSuperBtn";
            this.setSuperBtn.Size = new System.Drawing.Size(247, 45);
            this.setSuperBtn.TabIndex = 0;
            this.setSuperBtn.Text = "Set as Super Account";
            this.setSuperBtn.UseVisualStyleBackColor = true;
            this.setSuperBtn.Click += new System.EventHandler(this.setSuperBtn_Click);
            // 
            // setAdminBtn
            // 
            this.setAdminBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setAdminBtn.Location = new System.Drawing.Point(64, 86);
            this.setAdminBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.setAdminBtn.Name = "setAdminBtn";
            this.setAdminBtn.Size = new System.Drawing.Size(247, 45);
            this.setAdminBtn.TabIndex = 1;
            this.setAdminBtn.Text = "Set as Admin Account";
            this.setAdminBtn.UseVisualStyleBackColor = true;
            this.setAdminBtn.Click += new System.EventHandler(this.setAdminBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 25);
            this.label8.TabIndex = 40;
            this.label8.Text = "Full Name:";
            // 
            // txtFullname
            // 
            this.txtFullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullname.Location = new System.Drawing.Point(20, 143);
            this.txtFullname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.Size = new System.Drawing.Size(380, 30);
            this.txtFullname.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(435, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 25);
            this.label4.TabIndex = 35;
            this.label4.Text = "E-mail:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(840, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 25);
            this.label3.TabIndex = 34;
            this.label3.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(840, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 25);
            this.label1.TabIndex = 33;
            this.label1.Text = "Username:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 25);
            this.label9.TabIndex = 32;
            this.label9.Text = "Admin ID:";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(440, 91);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(380, 30);
            this.txtEmail.TabIndex = 31;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(845, 143);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(380, 30);
            this.txtPassword.TabIndex = 30;
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(845, 59);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(380, 30);
            this.txtUsername.TabIndex = 29;
            // 
            // txtAdminID
            // 
            this.txtAdminID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdminID.Location = new System.Drawing.Point(20, 59);
            this.txtAdminID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAdminID.Name = "txtAdminID";
            this.txtAdminID.Size = new System.Drawing.Size(380, 30);
            this.txtAdminID.TabIndex = 28;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clearBtn);
            this.groupBox1.Controls.Add(this.setActiveBtn);
            this.groupBox1.Controls.Add(this.updateBtn);
            this.groupBox1.Controls.Add(this.setInactiveBtn);
            this.groupBox1.Location = new System.Drawing.Point(639, 192);
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
            this.clearBtn.Location = new System.Drawing.Point(243, 86);
            this.clearBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(120, 45);
            this.clearBtn.TabIndex = 2;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // setActiveBtn
            // 
            this.setActiveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setActiveBtn.Location = new System.Drawing.Point(21, 86);
            this.setActiveBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.setActiveBtn.Name = "setActiveBtn";
            this.setActiveBtn.Size = new System.Drawing.Size(198, 45);
            this.setActiveBtn.TabIndex = 1;
            this.setActiveBtn.Text = "Set as Active";
            this.setActiveBtn.UseVisualStyleBackColor = true;
            this.setActiveBtn.Click += new System.EventHandler(this.setActiveBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.Location = new System.Drawing.Point(243, 24);
            this.updateBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(120, 45);
            this.updateBtn.TabIndex = 1;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // setInactiveBtn
            // 
            this.setInactiveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setInactiveBtn.Location = new System.Drawing.Point(21, 24);
            this.setInactiveBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.setInactiveBtn.Name = "setInactiveBtn";
            this.setInactiveBtn.Size = new System.Drawing.Size(198, 45);
            this.setInactiveBtn.TabIndex = 0;
            this.setInactiveBtn.Text = "Set as Inactive";
            this.setInactiveBtn.UseVisualStyleBackColor = true;
            this.setInactiveBtn.Click += new System.EventHandler(this.setInactiveBtn_Click);
            // 
            // btnBackSlist
            // 
            this.btnBackSlist.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackSlist.Location = new System.Drawing.Point(1154, 654);
            this.btnBackSlist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBackSlist.Name = "btnBackSlist";
            this.btnBackSlist.Size = new System.Drawing.Size(133, 43);
            this.btnBackSlist.TabIndex = 47;
            this.btnBackSlist.Text = "Back";
            this.btnBackSlist.UseVisualStyleBackColor = true;
            this.btnBackSlist.Click += new System.EventHandler(this.btnBackSlist_Click);
            // 
            // dgAdminInfo
            // 
            this.dgAdminInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgAdminInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAdminInfo.Location = new System.Drawing.Point(41, 67);
            this.dgAdminInfo.Name = "dgAdminInfo";
            this.dgAdminInfo.RowHeadersWidth = 51;
            this.dgAdminInfo.RowTemplate.Height = 24;
            this.dgAdminInfo.Size = new System.Drawing.Size(1246, 164);
            this.dgAdminInfo.TabIndex = 46;
            this.dgAdminInfo.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgAdminInfo_CellMouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(402, 51);
            this.label2.TabIndex = 45;
            this.label2.Text = "Admin Information:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // refreshBtn
            // 
            this.refreshBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshBtn.Location = new System.Drawing.Point(1089, 15);
            this.refreshBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(198, 45);
            this.refreshBtn.TabIndex = 49;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // SuperModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 721);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnBackSlist);
            this.Controls.Add(this.dgAdminInfo);
            this.Controls.Add(this.label2);
            this.Name = "SuperModify";
            this.Text = "Library System - Super Modify";
            this.Load += new System.EventHandler(this.SuperModify_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgAdminInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFullname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtAdminID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button setInactiveBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button btnBackSlist;
        private System.Windows.Forms.DataGridView dgAdminInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button setSuperBtn;
        private System.Windows.Forms.Button setAdminBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.Button setActiveBtn;
    }
}