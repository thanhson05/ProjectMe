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
    public partial class FNCC : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=DESKTOP-8LPBRKU\SQLEXPRESS;Initial Catalog=CaPhe;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from NHACUNGCAP";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dtgrvncc.DataSource = table;

        }
        public FNCC()
        {
            InitializeComponent();
        }

        private void FNCC_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
        }

        private void dtgrvncc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dtgrvncc.CurrentRow.Index;
            txbPassNCC.Text = dtgrvncc.Rows[i].Cells[0].Value.ToString();
            txtTenNCC.Text = dtgrvncc.Rows[i].Cells[1].Value.ToString();
            txtdiachiNCC.Text = dtgrvncc.Rows[i].Cells[2].Value.ToString();
            txtsdtNCC.Text = dtgrvncc.Rows[i].Cells[3].Value.ToString();

        }

        private void btsss_Click(object sender, EventArgs e)
        {
            try
            {
                command = connection.CreateCommand();
                command.CommandText = "Update NHACUNGCAP set TenNCC = @TenNCC, DiaChi = @DiaChi, SDT_NCC= @SDT_NCC where MaNCC = @MaNCC";
                command.Parameters.AddWithValue("MaNCC", txbPassNCC.Text);
                command.Parameters.AddWithValue("TenNCC", txtTenNCC.Text);
                command.Parameters.AddWithValue("DiaChi", txtdiachiNCC.Text);
                command.Parameters.AddWithValue("SDT_NCC", txtsdtNCC.Text);
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

        private void btsr_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(str);
            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                SqlCommand cmd = new SqlCommand("Select * from NhaCungCap where TenNCC like '%" + tbtim.Text + "%' ", connection);
                cmd.ExecuteNonQuery();
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dtgrvncc.DataSource = dt;
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
            catch (Exception e1)
            {
                MessageBox.Show("Không Tìm Thấy!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loaddata();
            txbPassNCC.ResetText();
            txtTenNCC.ResetText();
            txtdiachiNCC.ResetText();
            txtsdtNCC.ResetText();
        }

        private void btxxxx_Click(object sender, EventArgs e)
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
                string smncc = txbPassNCC.Text;
                string sQuery = "delete NhaCungCap  where MaNCC =@MaNCC";
                SqlCommand cmd = new SqlCommand(sQuery, con);
                cmd.Parameters.AddWithValue("@MaNCC", smncc);
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa thành công! ");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xảy ra lỗi khi xóa!");
                }
                string sQuerye = "select * from NhaCungCap";
                SqlCommand cmde = new SqlCommand(sQuerye, con); DataTable KT = new DataTable();
                SqlDataReader dr = cmde.ExecuteReader(); KT.Load(dr);
                dtgrvncc.DataSource = KT; dtgrvncc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                con.Close();
            }

        }

        private void btttt_Click(object sender, EventArgs e)
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
            string sMaNcc = txbPassNCC.Text;
            string sTenNcc = txtTenNCC.Text;
            string sDiachi = txtdiachiNCC.Text;
            string sSoDienThoai = txtsdtNCC.Text;
            string sQuery = "insert into NhaCungCap values (@MaNCC, @TenNCC, @DiaChi, @SoDienThoai)";
            SqlCommand cmd = new SqlCommand(sQuery, con);
            cmd.Parameters.AddWithValue("@MaNCC", sMaNcc);
            cmd.Parameters.AddWithValue("@TenNCC", sTenNcc);
            cmd.Parameters.AddWithValue("@DiaChi", sDiachi);
            cmd.Parameters.AddWithValue("@SoDienThoai", sSoDienThoai);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình thêm mới! ");
            }
            string sQuerye = "select * from NhaCungCap";
            SqlCommand cmde = new SqlCommand(sQuerye, con); DataTable KT = new DataTable();
            SqlDataReader dr = cmde.ExecuteReader(); KT.Load(dr);
            dtgrvncc.DataSource = KT; dtgrvncc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            con.Close();

        }
    }
}
