﻿namespace CGALibrarySystem
{
    partial class HomeAdmin
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
            this.btnSetInactiveSlist = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.Location = new System.Drawing.Point(232, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(323, 46);
            this.label2.TabIndex = 27;
            this.label2.Text = "Welcome Admin!";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(291, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(208, 20);
            this.label9.TabIndex = 33;
            this.label9.Text = "What do you want to do?";
            // 
            // btnSetInactiveSlist
            // 
            this.btnSetInactiveSlist.Location = new System.Drawing.Point(329, 156);
            this.btnSetInactiveSlist.Name = "btnSetInactiveSlist";
            this.btnSetInactiveSlist.Size = new System.Drawing.Size(142, 56);
            this.btnSetInactiveSlist.TabIndex = 34;
            this.btnSetInactiveSlist.Text = "Student List";
            this.btnSetInactiveSlist.UseVisualStyleBackColor = true;
            this.btnSetInactiveSlist.Click += new System.EventHandler(this.btnSetInactiveSlist_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(329, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 56);
            this.button1.TabIndex = 35;
            this.button1.Text = "Book List";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(329, 306);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 56);
            this.button2.TabIndex = 36;
            this.button2.Text = "Borrowed Books";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSetInactiveSlist);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSetInactiveSlist;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}