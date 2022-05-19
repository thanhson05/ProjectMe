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

namespace WF
{
    public partial class Ftaikhoan : Form
    {
        SqlConnection  connection;
        SqlCommand command;
        string str = @"Data Source=DESKTOP-8LPBRKU\SQLEXPRESS;Initial Catalog=CaPhe;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from TAIKHOAN";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dtgrvtk.DataSource = table;

        }
        public Ftaikhoan()
        {
            InitializeComponent();
        }

        private void Ftaikhoan_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
        }

        private void dtgrvtk_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dtgrvtk.CurrentRow.Index;
            txbten.Text = dtgrvtk.Rows[i].Cells[0].Value.ToString();
            txbpass.Text = dtgrvtk.Rows[i].Cells[1].Value.ToString();
            txbloai.Text = dtgrvtk.Rows[i].Cells[2].Value.ToString();
        }

        private void buttons_Click(object sender, EventArgs e)
        {
            try
            {
                command = connection.CreateCommand();
                command.CommandText = "Update TAIKHOAN set  MatKhau = @MatKhau, LoaiTK= @LoaiTK where TenTK = @TenTK";
                command.Parameters.AddWithValue("TenTK", txbten.Text);
                command.Parameters.AddWithValue("MatKhau", txbpass.Text);
                command.Parameters.AddWithValue("LoaiTK", txbloai.Text);
                command.ExecuteNonQuery();
                MessageBox.Show("Sửa thành công!", "Thông Báo");
                loaddata();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi sửa dữ liệu: " + ex.Message, "Thông Báo", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(str);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DB");
            }
            string sten = txbten.Text;
            string smk = txbpass.Text;
            string sloaitk = txbloai.Text;


            string sQuery = "insert into TAIKHOAN values (@TenTK, @MatKhau, @LoaiTK)";
            SqlCommand cmd = new SqlCommand(sQuery, con);
            cmd.Parameters.AddWithValue("@TenTK", sten);
            cmd.Parameters.AddWithValue("@MatKhau", smk);
            cmd.Parameters.AddWithValue("@LoaiTK", sloaitk);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình thêm mới! ");
            }
            string sQuerye = "select * from TAIKHOAN";
            SqlCommand cmde = new SqlCommand(sQuerye, con); DataTable KT = new DataTable();
            SqlDataReader dr = cmde.ExecuteReader(); KT.Load(dr);
            dtgrvtk.DataSource = KT; dtgrvtk.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            con.Close();
        }

        private void buttonx_Click(object sender, EventArgs e)
        {

            DialogResult ret = MessageBox.Show("Bạn có chắc chắn là muốn xóa không ?", "Thông báo ", MessageBoxButtons.OKCancel);
            if (ret == DialogResult.OK)
            {
                SqlConnection con = new SqlConnection(str);
                try
                {
                    con.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xảy ra lỗi trong quá trình kết nối dữ liệu");
                }
                string stentk = txbten.Text;
                string sQuery = "delete TAIKHOAN  where TenTK = @TenTK";
                SqlCommand cmd = new SqlCommand(sQuery, con);
                cmd.Parameters.AddWithValue("@TenTK", stentk);
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa thành công! ");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xảy ra lỗi khi xóa!");
                }
                string sQuerye = "select * from TAIKHOAN";
                SqlCommand cmde = new SqlCommand(sQuerye, con); DataTable KT = new DataTable();
                SqlDataReader dr = cmde.ExecuteReader(); KT.Load(dr);
                dtgrvtk.DataSource = KT; dtgrvtk.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                con.Close();
            }
        }

        private void bt_Click(object sender, EventArgs e)
        {
            loaddata();
            txbten.ResetText();
            txbpass.ResetText();
            txbloai.ResetText();
        }
    }
}
