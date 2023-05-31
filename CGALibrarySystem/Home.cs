using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CGALibrarySystem
{
    public partial class Home : Form
    {
       
        public Home()
        {
            InitializeComponent();
        }

        private void borrowBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Borrow borrow = new Borrow();
            borrow.Show();
        }

        private void returnBtn_Click(object sender, EventArgs e)
        {            
            Return retrn = new Return();
            retrn.Show();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Edit edit = new Edit();
            edit.Show();
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to log out?", "Warning!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Hide();
                Form1 f1 = new Form1();
                f1.Show();
            }
            else if (dialogResult == DialogResult.No)
            {

            }

        }
    }
}
