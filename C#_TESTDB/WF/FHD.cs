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
    public partial class FHD : Form
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataReader DocDuLieu;
        string str = @"Data Source=DESKTOP-8LPBRKU\SQLEXPRESS;Initial Catalog=CaPhe;Integrated Security=True";
        string Lenh;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
       

        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from HOADON";
            DataSet ds = new DataSet();
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(ds, "HOADON");
            dtgvHD1.DataSource = ds.Tables["HOADON"];

        }
        void loaddataCT()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from HOADON_CT";
            DataSet ds = new DataSet();
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(ds, "HOADON_CT");
            dtgvHoaDonChiTiet.DataSource = ds.Tables["HOADON_CT"];
        }
        void loadTenMon()
        {
            connection = new SqlConnection(str);
            Lenh = @"select TenMon from MON ";
            connection.Open();
            command = new SqlCommand(Lenh, connection);
            DocDuLieu = command.ExecuteReader();
            while (DocDuLieu.Read())
            {
                combTenMon.Items.Add(DocDuLieu[0].ToString());
            }
            connection.Close();
        }
      
        public FHD()
        {
            InitializeComponent();
        }

        private void FHD_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
            loadTenMon();
            loaddataCT();
            connection.Close();

        }

        private void dtgvHD1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dtgvHD1.CurrentRow.Index;
            txbPassHD.Text = dtgvHD1.Rows[i].Cells[0].Value.ToString();
            txtMaNV.Text = dtgvHD1.Rows[i].Cells[1].Value.ToString();
            txtMB.Text = dtgvHD1.Rows[i].Cells[2].Value.ToString();
            dateHD.Text = dtgvHD1.Rows[i].Cells[3].Value.ToString();
            txtTongTien.Text = dtgvHD1.Rows[i].Cells[4].Value.ToString();
        }

        private void btthemHD_Click(object sender, EventArgs e)
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
            string smahd = txbPassHD.Text;
            string smanv = txtMaNV.Text;
            string smaban = txtMB.Text;
            string sngayhd = dateHD.Text;
            string stongtien = txtTongTien.Text;
            string sQuery = "insert into HOADON values (@MaHD,@MaNV,@Maban,@NgayHD,@TongTien)";
            SqlCommand cmd = new SqlCommand(sQuery, con);
            cmd.Parameters.AddWithValue("@MaHD", smahd);
            cmd.Parameters.AddWithValue("@MaNV", smanv);
            cmd.Parameters.AddWithValue("@Maban", smaban);
            cmd.Parameters.AddWithValue("@NgayHD", sngayhd);
            cmd.Parameters.AddWithValue("@TongTien", stongtien);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm thành công");

            }
            catch (Exception ex)
                {
                MessageBox.Show("Xảy ra lỗi trong quá trình thêm mới!");
            }
            string sQuerye = "Select * from HOADON";
            SqlCommand cmde = new SqlCommand(sQuerye, con); DataTable KT = new DataTable();
            SqlDataReader dr = cmde.ExecuteReader(); KT.Load(dr);
            dtgvHD1.DataSource = KT; dtgvHD1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            con.Close();
        }

        private void btsuaHD_Click(object sender, EventArgs e)
        {
            try
            {
                command = connection.CreateCommand();
                command.CommandText = "Update HOADON set MaNV = @MaNV, Maban = @Maban, NgayHD = @NgayHD, TongTien = @TongTien where MaHD = @MaHD";
                connection.Open();
                command.Parameters.AddWithValue("MaHD", txbPassHD.Text);
                command.Parameters.AddWithValue("MaNV", txtMaNV.Text);
                command.Parameters.AddWithValue("Maban", txtMB.Text);
                command.Parameters.AddWithValue("NgayHD", dateHD.Text);
                command.Parameters.AddWithValue("TongTien", txtTongTien.Text);
                command.ExecuteNonQuery();
                MessageBox.Show("Sửa thành công!", "Thông Báo");
                loaddata();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi sửa dữ liệu: " + ex.Message, "Thông Báo", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }

        private void btxoaHD_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn chắc chắn xóa dữ liệu ???", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (ret == DialogResult.OK)
            {
                SqlConnection connection = new SqlConnection(str);
                try
                {
                    connection.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DataBase");
                }
                string sMaHD = txbPassHD.Text;
                string sMaNV = txtMaNV.Text;
                string sMaban = txtMB.Text;
                string sdateHD = dateHD.Text;
                string sTongTien = txtTongTien.Text;
                string sQuery = "delete HOADON where MaHD=@MaHD";

                SqlCommand cmd = new SqlCommand(sQuery, connection);
                cmd.Parameters.AddWithValue("@MaHD", sMaHD);
                cmd.Parameters.AddWithValue("@MaNV", sMaNV);
                cmd.Parameters.AddWithValue("@Maban", sMaban);
                cmd.Parameters.AddWithValue("@NgayHD", sdateHD);
                cmd.Parameters.AddWithValue("@TongTien", sTongTien);
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Bạn đã xóa dữ liệu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loaddata();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xảy ra lỗi trong quá trình xóa dữ liệu");
                }
                connection.Close();
            }
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            int dongia = int.Parse(txtDonGia.Text);
            int soluong = int.Parse(txtSL.Text);
            int giamgia = int.Parse(txtGiamGia.Text);
            int tinhtien;
            tinhtien = (dongia * soluong) - (dongia*soluong*giamgia)/100;
            txtTongTien.Text = tinhtien.ToString();
        }

        private void combTenMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            Lenh = @"select DonGiaMon,MaMon from MON where TenMon= N'" + combTenMon.Text + @"'";
            connection.Open();
            command = new SqlCommand(Lenh, connection);
            DocDuLieu = command.ExecuteReader();
            while (DocDuLieu.Read())
            {
                string gia = (string)DocDuLieu["DonGiaMon"].ToString();
                string mamon = (string)DocDuLieu["MaMon"].ToString();
                txtDonGia.Text = gia;
                txtMaMon.Text = mamon;
            }
            connection.Close();
        }

        

        private void btnThemHDCT_Click(object sender, EventArgs e)
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
            string sMaHD = txbPassHD.Text;
            string sMaMon = txtMaMon.Text;
            string sSoLuongMon = txtSL.Text;
            string sGiamGia = txtGiamGia.Text;
            string sQuery = "insert into HOADON_CT values (@MaHD, @MaMon, @SoLuongMon, @GiamGia)";
            SqlCommand cmd = new SqlCommand(sQuery, con);
            cmd.Parameters.AddWithValue("@MaHD", sMaHD);
            cmd.Parameters.AddWithValue("@MaMon", sMaMon);
            cmd.Parameters.AddWithValue("@SoLuongMon", sSoLuongMon);
            cmd.Parameters.AddWithValue("@GiamGia", sGiamGia);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình thêm mới! ");
            }
            string sQuerye = "select * from HOADON_CT";
            SqlCommand cmde = new SqlCommand(sQuerye, con); DataTable KT = new DataTable();
            SqlDataReader dr = cmde.ExecuteReader(); KT.Load(dr);
            dtgvHoaDonChiTiet.DataSource = KT; dtgvHoaDonChiTiet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            con.Close();
        }

        private void btnSuaHDCT_Click(object sender, EventArgs e)
        {
            try
            {
                command = connection.CreateCommand();
                command.CommandText = "Update HOADON_CT set MaMon = @MaMon, SoLuongMon = @SoLuongMon, GiamGia = @GiamGia where MaHD = @MaHD";
                connection.Open();
                command.Parameters.AddWithValue("MaHD", txbPassHD.Text);
                command.Parameters.AddWithValue("MaMon", txtMaMon.Text);
                command.Parameters.AddWithValue("SoLuongMon", txtSL.Text);
                command.Parameters.AddWithValue("GiamGia", txtGiamGia.Text);
                command.ExecuteNonQuery();
                MessageBox.Show("Sửa thành công!", "Thông Báo");
                loaddataCT();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi sửa dữ liệu: " + ex.Message, "Thông Báo", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }

        }

        private void btnXoaHDCT_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn chắc chắn xóa dữ liệu ???", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (ret == DialogResult.OK)
            {
                SqlConnection connection = new SqlConnection(str);
                try
                {
                    connection.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DataBase");
                }
                string sMaHD = txbPassHD.Text;
                string sMaMon = txtMaMon.Text;
                string sSoLuongMon = txtSL.Text;
                string sGiamGia = txtGiamGia.Text;
                string sQuery = "delete HOADON_CT where MaHD=@MaHD";

                SqlCommand cmd = new SqlCommand(sQuery, connection);
                cmd.Parameters.AddWithValue("@MaHD", sMaHD);
                cmd.Parameters.AddWithValue("@MaMon", sMaMon);
                cmd.Parameters.AddWithValue("@SoLuongMon", sSoLuongMon);
                cmd.Parameters.AddWithValue("@GiamGia", sGiamGia);
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Bạn đã xóa dữ liệu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loaddataCT();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xảy ra lỗi trong quá trình xóa dữ liệu");
                }
                connection.Close();
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            loaddata();
            loaddataCT();
            txbPassHD.ResetText();
            txtMaNV.ResetText();
            txtMB.ResetText();
            dateHD.ResetText();
            txtTongTien.ResetText();
            txtDonGia.ResetText();
            txtMaMon.ResetText();
            txtSL.ResetText();
            txtGiamGia.ResetText();
            combTenMon.ResetText();

        }

        private void dtgvHoaDonChiTiet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txbPassHD.Text = dtgvHoaDonChiTiet.Rows[e.RowIndex].Cells["MaHD"].Value.ToString();
            txtMaMon.Text = dtgvHoaDonChiTiet.Rows[e.RowIndex].Cells["MaMon"].Value.ToString();
            txtSL.Text = dtgvHoaDonChiTiet.Rows[e.RowIndex].Cells["SoLuongMon"].Value.ToString();
            txtGiamGia.Text = dtgvHoaDonChiTiet.Rows[e.RowIndex].Cells["GiamGia"].Value.ToString();
        }

        private void bttimHD_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(str);
            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                SqlCommand cmd = new SqlCommand("Select * from HOADON where NgayHD like  '%" + textBox1.Text+ "%' ", connection);
                cmd.ExecuteNonQuery();
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dtgvHD1.DataSource = dt;
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
            catch (Exception e1)
            {
                MessageBox.Show("Không Tìm Thấy!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}


