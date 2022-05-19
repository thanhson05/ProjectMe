using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF
{
    public partial class Ftablemanager : Form
    {
        public Ftablemanager()
        {
            InitializeComponent();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ftaikhoan f = new Ftaikhoan();
            f.ShowDialog();
        }

        private void bànToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fban f = new Fban();
            f.ShowDialog(); 
        }

        private void mónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fmon f = new Fmon();
            f.ShowDialog();
        }

        private void loạiMónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Floaimon f = new Floaimon();
            f.ShowDialog();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FNV f = new FNV();
            f.ShowDialog();
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FNCC f = new FNCC();
            f.ShowDialog();
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FHD f = new FHD();
            f.ShowDialog();
        }

       

        private void nhậpKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FNK f = new FNK();
            f.ShowDialog();
        }
    }
}
