namespace CGALibrarySystem
{
    partial class adminStudentList
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSetInactiveSlist = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SlistAdm = new System.Windows.Forms.DataGridView();
            this.btnUpdSlist = new System.Windows.Forms.Button();
            this.tbSID = new System.Windows.Forms.TextBox();
            this.tbUsern = new System.Windows.Forms.TextBox();
            this.tbEmailSlist = new System.Windows.Forms.TextBox();
            this.tbPassSlist = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbSectionSlist = new System.Windows.Forms.TextBox();
            this.tbCourseSlist = new System.Windows.Forms.TextBox();
            this.tbFnameSlist = new System.Windows.Forms.TextBox();
            this.btnBackSlist = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SlistAdm)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSetInactiveSlist);
            this.groupBox1.Controls.Add(this.btnUpdSlist);
            this.groupBox1.Location = new System.Drawing.Point(735, 350);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(154, 168);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnSetInactiveSlist
            // 
            this.btnSetInactiveSlist.Location = new System.Drawing.Point(6, 27);
            this.btnSetInactiveSlist.Name = "btnSetInactiveSlist";
            this.btnSetInactiveSlist.Size = new System.Drawing.Size(142, 56);
            this.btnSetInactiveSlist.TabIndex = 0;
            this.btnSetInactiveSlist.Text = "Set as Inactive";
            this.btnSetInactiveSlist.UseVisualStyleBackColor = true;
            this.btnSetInactiveSlist.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.Location = new System.Drawing.Point(4, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 46);
            this.label2.TabIndex = 26;
            this.label2.Text = "Student List";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SlistAdm
            // 
            this.SlistAdm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SlistAdm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SlistAdm.Location = new System.Drawing.Point(165, 86);
            this.SlistAdm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SlistAdm.Name = "SlistAdm";
            this.SlistAdm.RowHeadersWidth = 51;
            this.SlistAdm.RowTemplate.Height = 24;
            this.SlistAdm.Size = new System.Drawing.Size(734, 231);
            this.SlistAdm.TabIndex = 27;
            this.SlistAdm.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgBookInfo_CellContentClick);
            // 
            // btnUpdSlist
            // 
            this.btnUpdSlist.Location = new System.Drawing.Point(7, 106);
            this.btnUpdSlist.Name = "btnUpdSlist";
            this.btnUpdSlist.Size = new System.Drawing.Size(141, 48);
            this.btnUpdSlist.TabIndex = 1;
            this.btnUpdSlist.Text = "Update";
            this.btnUpdSlist.UseVisualStyleBackColor = true;
            this.btnUpdSlist.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbSID
            // 
            this.tbSID.Location = new System.Drawing.Point(121, 340);
            this.tbSID.Name = "tbSID";
            this.tbSID.Size = new System.Drawing.Size(243, 26);
            this.tbSID.TabIndex = 28;
            // 
            // tbUsern
            // 
            this.tbUsern.Location = new System.Drawing.Point(121, 385);
            this.tbUsern.Name = "tbUsern";
            this.tbUsern.Size = new System.Drawing.Size(243, 26);
            this.tbUsern.TabIndex = 29;
            // 
            // tbEmailSlist
            // 
            this.tbEmailSlist.Location = new System.Drawing.Point(475, 428);
            this.tbEmailSlist.Name = "tbEmailSlist";
            this.tbEmailSlist.Size = new System.Drawing.Size(243, 26);
            this.tbEmailSlist.TabIndex = 31;
            // 
            // tbPassSlist
            // 
            this.tbPassSlist.Location = new System.Drawing.Point(475, 383);
            this.tbPassSlist.Name = "tbPassSlist";
            this.tbPassSlist.Size = new System.Drawing.Size(243, 26);
            this.tbPassSlist.TabIndex = 30;
            this.tbPassSlist.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(22, 343);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 20);
            this.label9.TabIndex = 32;
            this.label9.Text = "Student ID";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 387);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "Username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(378, 387);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 34;
            this.label3.Text = "Password";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(405, 431);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 35;
            this.label4.Text = "E-mail";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(399, 479);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 20);
            this.label6.TabIndex = 42;
            this.label6.Text = "Section";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(43, 480);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 20);
            this.label7.TabIndex = 41;
            this.label7.Text = "Course";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(22, 434);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 20);
            this.label8.TabIndex = 40;
            this.label8.Text = "Full name";
            // 
            // tbSectionSlist
            // 
            this.tbSectionSlist.Location = new System.Drawing.Point(475, 474);
            this.tbSectionSlist.Name = "tbSectionSlist";
            this.tbSectionSlist.Size = new System.Drawing.Size(243, 26);
            this.tbSectionSlist.TabIndex = 38;
            // 
            // tbCourseSlist
            // 
            this.tbCourseSlist.Location = new System.Drawing.Point(121, 476);
            this.tbCourseSlist.Name = "tbCourseSlist";
            this.tbCourseSlist.Size = new System.Drawing.Size(243, 26);
            this.tbCourseSlist.TabIndex = 37;
            this.tbCourseSlist.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // tbFnameSlist
            // 
            this.tbFnameSlist.Location = new System.Drawing.Point(121, 431);
            this.tbFnameSlist.Name = "tbFnameSlist";
            this.tbFnameSlist.Size = new System.Drawing.Size(243, 26);
            this.tbFnameSlist.TabIndex = 36;
            // 
            // btnBackSlist
            // 
            this.btnBackSlist.Location = new System.Drawing.Point(26, 86);
            this.btnBackSlist.Name = "btnBackSlist";
            this.btnBackSlist.Size = new System.Drawing.Size(121, 37);
            this.btnBackSlist.TabIndex = 43;
            this.btnBackSlist.Text = "Back";
            this.btnBackSlist.UseVisualStyleBackColor = true;
            this.btnBackSlist.Click += new System.EventHandler(this.btnBackSlist_Click);
            // 
            // adminStudentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 530);
            this.Controls.Add(this.btnBackSlist);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbSectionSlist);
            this.Controls.Add(this.tbCourseSlist);
            this.Controls.Add(this.tbFnameSlist);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbEmailSlist);
            this.Controls.Add(this.tbPassSlist);
            this.Controls.Add(this.tbUsern);
            this.Controls.Add(this.tbSID);
            this.Controls.Add(this.SlistAdm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Name = "adminStudentList";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SlistAdm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView SlistAdm;
        private System.Windows.Forms.Button btnSetInactiveSlist;
        private System.Windows.Forms.Button btnUpdSlist;
        private System.Windows.Forms.TextBox tbSID;
        private System.Windows.Forms.TextBox tbUsern;
        private System.Windows.Forms.TextBox tbEmailSlist;
        private System.Windows.Forms.TextBox tbPassSlist;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbSectionSlist;
        private System.Windows.Forms.TextBox tbCourseSlist;
        private System.Windows.Forms.TextBox tbFnameSlist;
        private System.Windows.Forms.Button btnBackSlist;
    }
}