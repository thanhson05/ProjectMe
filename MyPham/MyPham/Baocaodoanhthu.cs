using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace MyPham
{
    public partial class Baocaodoanhthu : Form
    {
        public Baocaodoanhthu()
        {
            InitializeComponent();
        }
        private void Lienket()
        {
            try
            {
                SqlConnection kn = new SqlConnection(@"Data Source=DESKTOP-FSA2QQE;Initial Catalog=QuanLyBanHangMyPham;Integrated Security=True");
                kn.Open();
                string sql = @"select MaHD as 'Ma hoa don', TenKH as 'Ten khach hang', NgayLap as 'Ngay lap', ThanhTien as 'Thanh tien' FROM HoaDonBanHang
                WHERE NgayLap BETWEEN '" + txtTungay.Text + @"'AND'" + txtdenngay.Text + @"'
                GROUP by MaHD,TenKH,NgayLap,ThanhTien";
                SqlCommand commandsql = new SqlCommand(sql, kn);
                SqlDataAdapter com = new SqlDataAdapter(commandsql);
                DataTable table = new DataTable();
                com.Fill(table);
                dataGridView1.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi!!!");
            }
        }
       
        private void tinhtien()
        {
            int n = dataGridView1.Rows.Count;
            Double tien = 0;
            for (int i = 0; i < n - 1; i++)
            {
                tien += Double.Parse(dataGridView1.Rows[i].Cells["Thanh tien"].Value.ToString());
            }
            txtTongDT.Text = tien.ToString();
        }
       

        private void bththongke_Click(object sender, EventArgs e)
        {
            Lienket();
           
            tinhtien();
            
        }

        private void Baocaodoanhthu_Load(object sender, EventArgs e)
        {
            DateTime tn = DateTime.Now;
            txtTungay.Text = tn.ToString("MM/dd/yyyy");
            txtdenngay.Text = tn.ToString("MM/dd/yyyy");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
