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
    public partial class AdminHome : Form
    {
        public AdminHome()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSetInactiveSlist_Click(object sender, EventArgs e)
        {
            AdminStudentList studentList = new AdminStudentList();
            studentList.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void bookListBtn_Click(object sender, EventArgs e)
        {
            AdminBookList bookList = new AdminBookList();
            bookList.Show();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            SuperAccountLogIn superLogIn = new SuperAccountLogIn();
            superLogIn.modifyAcc = "edit";
            superLogIn.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SuperAccountLogIn superLogIn = new SuperAccountLogIn();
            superLogIn.modifyAcc = "create";
            superLogIn.Show();
<<<<<<< HEAD
        }

        private void borrowingListBtn_Click(object sender, EventArgs e)
        {
            AdminBorrowingList borrowingList = new AdminBorrowingList();
            borrowingList.Show();
=======
>>>>>>> fd599d6ed8a98db4de992d2442b6fbc43359eeef
        }
    }
}
