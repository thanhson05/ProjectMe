using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPham
{
    public partial class formTableManager : Form
    {
        bool isThoat = true;
        public formTableManager()
        {
            InitializeComponent();
        }

        private void thôngTinCáToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAccountprofile f = new fAccountprofile();
            f.ShowDialog();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAdmin f = new FormAdmin();
            f.ShowDialog();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isThoat = false;
            this.Close();
            Login f = new Login();
            f.Show();
        }

        private void formTableManager_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isThoat)
                Application.Exit();
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BILL b = new BILL();
            b.ShowDialog();
        }

        private void doanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Baocaodoanhthu f = new Baocaodoanhthu();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void doanhThuToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Baocaodoanhthu f = new Baocaodoanhthu();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

       

        
       
        
    }
}
