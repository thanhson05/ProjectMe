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
    public partial class FNV : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=DESKTOP-8LPBRKU\SQLEXPRESS;Initial Catalog=CaPhe;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from NHANVIEN";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            GVNV.DataSource = table;
        }
        public FNV()
        {
            InitializeComponent();
        }

        private void FNV_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
        }

        private void GVNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = GVNV.CurrentRow.Index;
            tbmnv.Text = GVNV.Rows[i].Cells[0].Value.ToString();
            tbtnv.Text = GVNV.Rows[i].Cells[1].Value.ToString();
            tbdc.Text = GVNV.Rows[i].Cells[2].Value.ToString();
            tbsdt.Text = GVNV.Rows[i].Cells[3].Value.ToString();
        }

        private void btss_Click(object sender, EventArgs e)
        {
            try
            {
                command = connection.CreateCommand();
                command.CommandText = "Update NHANVIEN set TenNV = @TenNV, DiaChiNV = @DiaChiNV, SDT_NV= @SDT_NV where MaNV = @MaNV";
                command.Parameters.AddWithValue("MaNV", tbmnv.Text);
                command.Parameters.AddWithValue("TenNV", tbtnv.Text);
                command.Parameters.AddWithValue("DiaChiNV", tbdc.Text);
                command.Parameters.AddWithValue("SDT_NV", tbsdt.Text);
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
            loaddata();
            tbmnv.ResetText();
            tbtnv.ResetText();
            tbdc.ResetText();
            tbsdt.ResetText();
        }

        private void bttt_Click(object sender, EventArgs e)
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
            string sMaNv = tbmnv.Text;
            string sTenNv = tbtnv.Text;
            string sDiachi = tbdc.Text;
            string sSoDienThoai = tbsdt.Text;
            string sQuery = "insert into NHANVIEN values (@MaNV, @TenNV, @DiaChiNV, @SĐT_NV)";
            SqlCommand cmd = new SqlCommand(sQuery, con);
            cmd.Parameters.AddWithValue("@MaNV", sMaNv);
            cmd.Parameters.AddWithValue("@TenNV", sTenNv);
            cmd.Parameters.AddWithValue("@DiaChiNV", sDiachi);
            cmd.Parameters.AddWithValue("@SĐT_NV", sSoDienThoai);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình thêm mới! ");
            }
            string sQuerye = "select * from NHANVIEN";
            SqlCommand cmde = new SqlCommand(sQuerye, con); DataTable KT = new DataTable();
            SqlDataReader dr = cmde.ExecuteReader(); KT.Load(dr);
            GVNV.DataSource = KT; GVNV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            con.Close();
        }

        private void btxx_Click(object sender, EventArgs e)
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
                string smnv = tbmnv.Text;
                string sQuery = "delete NHANVIEN  where MaNV =@MaNV";
                SqlCommand cmd = new SqlCommand(sQuery, con);
                cmd.Parameters.AddWithValue("@MaNV", smnv);
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
                GVNV.DataSource = KT; GVNV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                con.Close();
            }
        }
    }
}
