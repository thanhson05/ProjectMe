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
    public partial class Login : Form
    {
       
        public Login()
        {
            InitializeComponent();
        }
        private string getID(string username, string pass)
        {
            SqlConnection con = new SqlConnection( @"Data Source=DESKTOP-FSA2QQE;Initial Catalog=QuanLyBanHangMyPham;Integrated Security=True");
            string id = "";
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Taikhoan WHERE Usename ='" +tbusername.Text+ "' and pass='" +tbpass.Text+ "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        id = dr["Usename"].ToString();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi xảy ra khi truy vấn dữ liệu hoặc kết nối với server thất bại !");
            }
            finally
            {
                con.Close();
            }
            return id;
        }
        public static string ID_USER = "";

        private void btnlogin_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection( @"Data Source=DESKTOP-FSA2QQE;Initial Catalog=QuanLyBanHangMyPham;Integrated Security=True");
            ID_USER = getID(tbusername.Text, tbpass.Text);
            if (ID_USER != "")
            {
               formTableManager f = new formTableManager();
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng !");
            }
        }
       

        
        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
        private void Login_Load(object sender, EventArgs e)
        {
            tbusername.Select();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

      

       
      
        }
    }

