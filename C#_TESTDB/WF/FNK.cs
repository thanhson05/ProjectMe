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
    public partial class FNK : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=DESKTOP-8LPBRKU\SQLEXPRESS;Initial Catalog=CaPhe;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from PHIEU_NH";
            DataSet ds = new DataSet();
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(ds, "PHIEU_NH");
            dtgvNH.DataSource = ds.Tables["PHIEU_NH"];

        }
        void loaddataCT()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from PHIEUNH_CT";
            DataSet ds = new DataSet();
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(ds, "PHIEUNH_CT");
            dtgvNH_CT.DataSource = ds.Tables["PHIEUNH_CT"];
        }
        public FNK()
        {
            InitializeComponent();
        }

        private void FNK_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
            loaddataCT();
            connection.Close();
        }

        private void dtgvNH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dtgvNH.CurrentRow.Index;
            txbPassPhieu.Text = dtgvNH.Rows[i].Cells[0].Value.ToString();
            txtMaNV.Text = dtgvNH.Rows[i].Cells[1].Value.ToString();
            txtMaNCC.Text = dtgvNH.Rows[i].Cells[2].Value.ToString();
            dateP.Text = dtgvNH.Rows[i].Cells[3].Value.ToString();
            txtGia.Text = dtgvNH.Rows[i].Cells[4].Value.ToString();
            txtTongTienPhieu.Text = dtgvNH.Rows[i].Cells[5].Value.ToString();
            txtCK.Text = dtgvNH.Rows[i].Cells[6].Value.ToString();
        }

        private void dtgvNH_CT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dtgvNH_CT.CurrentRow.Index;
            txbPassPhieu.Text = dtgvNH_CT.Rows[i].Cells[0].Value.ToString();
            txtTenHang.Text = dtgvNH_CT.Rows[i].Cells[1].Value.ToString();
            txtDonVi.Text = dtgvNH_CT.Rows[i].Cells[2].Value.ToString();
            txtSL.Text = dtgvNH_CT.Rows[i].Cells[3].Value.ToString();
            txtThanhTien.Text = dtgvNH_CT.Rows[i].Cells[4].Value.ToString();
        }

        private void buttonthem_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = "Insert into PHIEU_NH values(@MaPhieu,@MaNV,@MaNCC,@NgayNhap,@DonGiaNhap,@TongTien,@CK)";
                command.Parameters.AddWithValue("MaPhieu", txbPassPhieu.Text);
                command.Parameters.AddWithValue("MaNV", txtMaNV.Text);
                command.Parameters.AddWithValue("MaNCC", txtMaNCC.Text);
                command.Parameters.AddWithValue("NgayNhap", dateP.Text);
                command.Parameters.AddWithValue("DonGiaNhap", txtGia.Text);
                command.Parameters.AddWithValue("TongTien", txtTongTienPhieu.Text);
                command.Parameters.AddWithValue("CK", txtCK.Text);
                command.ExecuteNonQuery();
                MessageBox.Show("Thêm thành công!", "Thông Báo");
                loaddata();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm dữ liệu: " + ex.Message, "Thông Báo", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = "Insert into PHIEUNH_CT values(@MaPhieu,@TenHang,@DonViTinh,@SoLuongNhap,@ThanhTien)";

                command.Parameters.AddWithValue("MaPhieu", txbPassPhieu.Text);
                command.Parameters.AddWithValue("TenHang", txtTenHang.Text);
                command.Parameters.AddWithValue("DonViTinh", txtDonVi.Text);
                command.Parameters.AddWithValue("SoLuongNhap", txtSL.Text);
                command.Parameters.AddWithValue("ThanhTien", txtThanhTien.Text);

                command.ExecuteNonQuery();
                MessageBox.Show("Thêm thành công!", "Thông Báo");
                loaddataCT();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm dữ liệu: " + ex.Message, "Thông Báo", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = "Update PHIEU_NH set MaNV=@MaNV,MaNCC=@MaNCC,NgayNhap=@NgayNhap,DonGiaNhap=@DonGiaNhap,TongTien=@TongTien,CK=@CK where MaPhieu = @MaPhieu";
                command.Parameters.AddWithValue("MaPhieu", txbPassPhieu.Text);
                command.Parameters.AddWithValue("MaNV", txtMaNV.Text);
                command.Parameters.AddWithValue("MaNCC", txtMaNCC.Text);
                command.Parameters.AddWithValue("NgayNhap", dateP.Text);
                command.Parameters.AddWithValue("DonGiaNhap", txtGia.Text);
                command.Parameters.AddWithValue("CK", txtCK.Text);
                command.Parameters.AddWithValue("TongTien", txtTongTienPhieu.Text);
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

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn chắc chắn xóa dữ liệu ???", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (ret == DialogResult.OK)
            {
                try
                {
                    connection.Open();
                    command = connection.CreateCommand();
                    command.CommandText = "Delete PHIEU_NH  where MaPhieu=@MaPhieu";

                    command.Parameters.AddWithValue("MaPhieu", txbPassPhieu.Text);
                    command.Parameters.AddWithValue("MaNV", txtMaNV.Text);
                    command.Parameters.AddWithValue("MaNCC", txtMaNCC.Text);
                    command.Parameters.AddWithValue("NgayNhap", dateP.Text);
                    command.Parameters.AddWithValue("DonGiaNhap", txtGia.Text);
                    command.Parameters.AddWithValue("TongTien", txtTongTienPhieu.Text);
                    command.Parameters.AddWithValue("CK", txtCK.Text);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Xóa thành công!", "Thông Báo");
                    loaddata();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi sửa dữ liệu: " + ex.Message, "Thông Báo", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = "Update PHIEUNH_CT set TenHang=@TenHang,DonViTinh=@DonViTinh,SoLuongNhap=@SoLuongNhap,ThanhTien=@ThanhTien where MaPhieu = @MaPhieu";

                command.Parameters.AddWithValue("MaPhieu", txbPassPhieu.Text);
                command.Parameters.AddWithValue("TenHang", txtTenHang.Text);
                command.Parameters.AddWithValue("DonViTinh", txtDonVi.Text);
                command.Parameters.AddWithValue("SoLuongNhap", txtSL.Text);
                command.Parameters.AddWithValue("ThanhTien", txtThanhTien.Text);
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

        private void button5_Click(object sender, EventArgs e)
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
                string sMaphieu = txbPassPhieu.Text;
                string stenhang = txtTenHang.Text;
                string sdonvitinh = txtDonVi.Text;
                string ssoluongnhap = txtSL.Text;
                string sthanhtien = txtThanhTien.Text;
                string sQuery = "delete PHIEUNH_CT where MaPhieu=@MaPhieu";
                SqlCommand cmd = new SqlCommand(sQuery, connection);
                cmd.Parameters.AddWithValue("@MaPhieu", sMaphieu);
                cmd.Parameters.AddWithValue("@TenHang", stenhang);
                cmd.Parameters.AddWithValue("@DonViTinh", sdonvitinh);
                cmd.Parameters.AddWithValue("@SoLuongNhap", ssoluongnhap);
                cmd.Parameters.AddWithValue("@ThanhTien", sthanhtien);
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

        private void button2_Click(object sender, EventArgs e)
        {
            int dongia = int.Parse(txtGia.Text);
            int soluong = int.Parse(txtSL.Text);
            int ck = int.Parse(txtCK.Text);
            int tongtien;
            int thanhtien;
            tongtien = dongia - (dongia * ck / 100);
            thanhtien = soluong * tongtien;
            txtTongTienPhieu.Text = tongtien.ToString();
            txtThanhTien.Text = thanhtien.ToString();
        }

        private void buttontk_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(str);
            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                SqlCommand cmd = new SqlCommand("Select * from PHIEU_NH where MaNCC like  '%" + textBox4.Text + "%' ", connection);
                cmd.ExecuteNonQuery();
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dtgvNH.DataSource = dt;
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
            loaddataCT();
            txbPassPhieu.ResetText();
            txtMaNV.ResetText();
            txtMaNCC.ResetText();
            dateP.ResetText();
            txtGia.ResetText();
            txtCK.ResetText();
            txtTongTienPhieu.ResetText();
            txtTenHang.ResetText();
            txtDonVi.ResetText();
            txtSL.ResetText();
            txtThanhTien.ResetText();
        }
    }
}
