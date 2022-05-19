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
    public partial class FormAdmin : Form

    {
        SqlConnection connection;
        SqlCommand command;
        string scon = "Data Source=DESKTOP-FSA2QQE;Initial Catalog=QuanLyBanHangMyPham;Integrated Security=True";
        
        
        public FormAdmin()
        {
            InitializeComponent();
            LoadSanPham();
            LoadNhanVien();
            LoadTaiKhoan();
            LoadNhaCungCap();
            LoadHoaDon();
            LoadLoaiSP();
        }
        private void FormAdmin_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(scon);
            connection.Open();
            
        }
        void LoadSanPham()
        {
            string scon  = "Data Source=DESKTOP-FSA2QQE;Initial Catalog=QuanLyBanHangMyPham;Integrated Security=True";
            SqlConnection connection = new SqlConnection(scon);

            string query = "SELECT * FROM SanPham";
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            connection.Close();
            datagvSp.DataSource = data;
        }
        void LoadNhanVien()
        {
            string scon = "Data Source=DESKTOP-FSA2QQE;Initial Catalog=QuanLyBanHangMyPham;Integrated Security=True";
            SqlConnection connection = new SqlConnection(scon);
            string query = "SELECT * FROM NhanVien";
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            connection.Close();
            dtgvDSNV.DataSource = data;
        }
        void LoadTaiKhoan()
        {
            string scon = "Data Source=DESKTOP-FSA2QQE;Initial Catalog=QuanLyBanHangMyPham;Integrated Security=True";
            SqlConnection connection = new SqlConnection(scon);

            string query = "SELECT * FROM TaiKhoan";
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            connection.Close();
            dtgvtk.DataSource = data;
        }
        void LoadNhaCungCap()
        {
            string scon = "Data Source=DESKTOP-FSA2QQE;Initial Catalog=QuanLyBanHangMyPham;Integrated Security=True";
            SqlConnection connection = new SqlConnection(scon);

            string query = "Select * from NhaCungCap";
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            connection.Close();
            dtgvNCC.DataSource = data;
        }
        void LoadHoaDon()
        {
            string scon = "Data Source=DESKTOP-FSA2QQE;Initial Catalog=QuanLyBanHangMyPham;Integrated Security=True";
            SqlConnection connection = new SqlConnection(scon);

            string query = "Select * from HoaDonBanHang";
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            connection.Close();
            dgvhd.DataSource = data;
        }
        void LoadLoaiSP()
        {
            string scon = "Data Source=DESKTOP-FSA2QQE;Initial Catalog=QuanLyBanHangMyPham;Integrated Security=True";
            SqlConnection connection = new SqlConnection(scon);

            string query = "Select * from LoaiSanPham";
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            connection.Close();
            dataGridView1.DataSource = data;
        }

        private void datagvSp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i; int igioitinh = 0; 
            i = datagvSp.CurrentRow.Index;
            tbmsp.Text = datagvSp.Rows[i].Cells[0].Value.ToString();
            txtsp.Text = datagvSp.Rows[i].Cells[1].Value.ToString();
            tbgia.Text = datagvSp.Rows[i].Cells[2].Value.ToString();
            tbdvt.Text = datagvSp.Rows[i].Cells[3].Value.ToString();
            tbmancc.Text = datagvSp.Rows[i].Cells[4].Value.ToString();
            tbmlsp.Text = datagvSp.Rows[i].Cells[5].Value.ToString();
            igioitinh = Convert.ToInt16(datagvSp.Rows[i].Cells[6].Value);
            if (igioitinh == 1)
            {
                cbn.Checked = true; cbnu.Checked = false;
            }
            else
            {
                cbnu.Checked = true; cbn.Checked = false;
            }

        }


        private void txtsp_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtgvDSNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i; int igioitinh = 0;
            i = dtgvDSNV.CurrentRow.Index;
            tbmnv.Text = dtgvDSNV.Rows[i].Cells[0].Value.ToString();
            tbname.Text = dtgvDSNV.Rows[i].Cells[1].Value.ToString();
            dtpngaysinh.Text = dtgvDSNV.Rows[i].Cells[2].Value.ToString();
            igioitinh = Convert.ToInt16(dtgvDSNV.Rows[i].Cells[3].Value);
            if (igioitinh == 1)
            {
                cbnamNV.Checked = true; cbnuNV.Checked = false;
            }
            else
            {
                cbnuNV.Checked = true; cbnamNV.Checked = false;
            }
            tbsodienthoai.Text = dtgvDSNV.Rows[i].Cells[4].Value.ToString();
            tbdiachi.Text = dtgvDSNV.Rows[i].Cells[5].Value.ToString();
        }

        private void dtgvNCC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dtgvNCC.CurrentRow.Index;
            tbmncc.Text = dtgvNCC.Rows[i].Cells[0].Value.ToString();
            tbtncc.Text = dtgvNCC.Rows[i].Cells[1].Value.ToString();
            tbdc.Text = dtgvNCC.Rows[i].Cells[2].Value.ToString();
            tbnb.Text = dtgvNCC.Rows[i].Cells[3].Value.ToString();
            tbw.Text = dtgvNCC.Rows[i].Cells[4].Value.ToString();
            
        }

        private void dtgvtk_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dtgvtk.CurrentRow.Index;
            tbttk.Text = dtgvtk.Rows[i].Cells[0].Value.ToString();
            tbmk.Text = dtgvtk.Rows[i].Cells[1].Value.ToString();
            tbbmnv.Text = dtgvtk.Rows[i].Cells[2].Value.ToString();
        }

        private void dgvhd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvhd.CurrentRow.Index;
            tbmhd.Text = dgvhd.Rows[i].Cells[0].Value.ToString();
            tbtkh.Text = dgvhd.Rows[i].Cells[1].Value.ToString();
            dtplap.Text = dgvhd.Rows[i].Cells[2].Value.ToString();
            txsdt.Text = dgvhd.Rows[i].Cells[3].Value.ToString();
            txtmnv.Text = dgvhd.Rows[i].Cells[4].Value.ToString();
            tbtt.Text = dgvhd.Rows[i].Cells[5].Value.ToString();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            tblsp.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
           
        }
        private void bts_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(scon);
            try
            {
                con.Open();

            }
            catch (Exception ex )
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DB");
            }
            string sMaNcc = tbmncc.Text;
            string sTenNcc = tbtncc.Text;
            string sDiachi = tbdc.Text;
            string sSoDienThoai = tbnb.Text;
            string sWeb = tbw.Text;
            string sQuery = "insert into NhaCungCap values (@MaNCC, @TenNCC, @DiaChi, @SoDienThoai, @Website)";
            SqlCommand cmd = new SqlCommand(sQuery, con);
            cmd.Parameters.AddWithValue("@MaNCC", sMaNcc);
            cmd.Parameters.AddWithValue("@TenNCC", sTenNcc);
            cmd.Parameters.AddWithValue("@DiaChi", sDiachi);
            cmd.Parameters.AddWithValue("@SoDienThoai", sSoDienThoai);
            cmd.Parameters.AddWithValue("@Website", sWeb);
            
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm thành công!");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình thêm mới! ");
            }
            string sQuerye = "select * from NhaCungCap";
            SqlCommand cmde = new SqlCommand(sQuerye, con); DataTable KT = new DataTable();
            SqlDataReader dr = cmde.ExecuteReader(); KT.Load(dr);
            dtgvNCC.DataSource = KT; dtgvNCC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            con.Close();
        }

        private void btluu_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(scon);
            try
            {
                con.Open();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DB");
            }
            string sMaNV = tbmnv.Text;
            string sTenNV = tbname.Text;
            string sNgaySinh = dtpngaysinh.Value.ToString("yyyy-MM-dd");
            int igioitinh=0;
                if(cbnamNV.Checked == true )
                {
                    igioitinh = 1;
                }
            string sSoDienThoai= tbsodienthoai.Text;
            string sDiachi = tbdiachi.Text;
            string sQuery = "insert into NhanVien values (@MaNV, @HoVaTen, @NgaySinh, @GioiTinh, @SoDienThoai, @DiaChi)";
            SqlCommand cmd = new SqlCommand(sQuery, con);
            cmd.Parameters.AddWithValue("@MaNV", sMaNV);
            cmd.Parameters.AddWithValue("@HoVaTen", sTenNV);
            cmd.Parameters.AddWithValue("@NgaySinh", sNgaySinh);
            cmd.Parameters.AddWithValue("@GioiTinh", igioitinh);
            cmd.Parameters.AddWithValue("@SoDienThoai", sSoDienThoai);
            cmd.Parameters.AddWithValue("@DiaChi", sDiachi);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình thêm mới! ");
            }
            string sQuerye = "select * from NhanVien";
            SqlCommand cmde = new SqlCommand(sQuerye, con); DataTable KT = new DataTable();
            SqlDataReader dr = cmde.ExecuteReader(); KT.Load(dr);
            dtgvDSNV.DataSource = KT; dtgvDSNV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            con.Close();

        }

        private void btthem_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(scon);
            try
            {
                con.Open();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DB");
            }
            string smasp = tbmsp.Text;
            string stensp = txtsp.Text;
            string sgia = tbgia.Text;
            string sdvt = tbdvt.Text;
            string smncc = tbmancc.Text;
            string smlsp = tbmlsp.Text;
            int igioitinh = 0;
            if (cbnamNV.Checked == true)
            {
                igioitinh = 1;
            }
            string sQuery = " insert into SanPham values (@MaSP, @TenSP, @GiaBan, @DonViTinh,@MaNCC,@MaLoaiSp,@GioiTinhSuDung)";
            SqlCommand cmd = new SqlCommand(sQuery, con);
            cmd.Parameters.AddWithValue("@MaSP", smasp);
            cmd.Parameters.AddWithValue("@TenSP", stensp);
            cmd.Parameters.AddWithValue("@GiaBan", sgia);
            cmd.Parameters.AddWithValue("@DonViTinh", sdvt);
            cmd.Parameters.AddWithValue("@MaNCC", smncc);
            cmd.Parameters.AddWithValue("@MaLoaiSP", smlsp);
            cmd.Parameters.AddWithValue("@GioiTinhSuDung", igioitinh);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình thêm mới!");
            }
            string sQuerye = "select * from SanPham";
            SqlCommand cmde = new SqlCommand(sQuerye, con); DataTable KT = new DataTable();
            SqlDataReader dr = cmde.ExecuteReader(); KT.Load(dr);
            datagvSp.DataSource = KT; datagvSp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            con.Close();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(scon);
            try
            {
                con.Open();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DB");
            }
            string sU = tbttk.Text;
            string sP = tbmk.Text;
            string sMnv = tbbmnv.Text;
            
            string sQuery = "insert into Taikhoan  values (@Usename, @pass, @MaNV)";
            SqlCommand cmd = new SqlCommand(sQuery, con);
            cmd.Parameters.AddWithValue("@Usename", sU);
            cmd.Parameters.AddWithValue("@pass", sP);
            cmd.Parameters.AddWithValue("@MaNV", sMnv);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình thêm mới! ");
            }
            string sQuerye = "select * from Taikhoan";
            SqlCommand cmde = new SqlCommand(sQuerye, con); DataTable KT = new DataTable();
            SqlDataReader dr = cmde.ExecuteReader(); KT.Load(dr);
            dtgvtk.DataSource = KT; dtgvtk.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            con.Close();
        }
        private void btttluu_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(scon);
            try
            {
                con.Open();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DB");
            }
            string sMahd = tbmhd.Text;
            string sTenkh = tbtkh.Text;
            string sNgaylap = dtplap.Value.ToString("yyyy-MM-dd");
            string sSoDienThoai = txsdt.Text;
            string smanv = txtmnv.Text;
            string sthanhtien = tbtt.Text;
            string sQuery = "insert into HoaDonBanHang values (@MaHD,@TenKH,@NgayLap,@SoDienThoai,@MaNV,@ThanhTien)";
            SqlCommand cmd = new SqlCommand(sQuery, con);
            cmd.Parameters.AddWithValue("@MaHD", sMahd);
            cmd.Parameters.AddWithValue("@TenKH", sTenkh);
            cmd.Parameters.AddWithValue("@NgayLap", sNgaylap);
            cmd.Parameters.AddWithValue("@SoDienThoai", sSoDienThoai);
            cmd.Parameters.AddWithValue("@MaNV", smanv);
            cmd.Parameters.AddWithValue("@ThanhTien", sthanhtien);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình thêm mới! ");
            }
            string sQuerye = "select * from HoaDonBanHang";

            SqlCommand cmde = new SqlCommand(sQuerye, con); DataTable KT = new DataTable();
            SqlDataReader dr = cmde.ExecuteReader(); KT.Load(dr);
            dgvhd.DataSource = KT; dgvhd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            con.Close();
        }
        private void btthemne_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(scon);
            try
            {
                con.Open();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DB");
            }
            string sMalsp = tblsp.Text;
            string sTenlsp = textBox2.Text;

            string sQuery = "insert into LoaiSanPham values (@MaLoaiSP,@TenLoaiSP)";
            SqlCommand cmd = new SqlCommand(sQuery, con);
            cmd.Parameters.AddWithValue("@MaLoaiSP", sMalsp);
            cmd.Parameters.AddWithValue("@TenLoaiSP", sTenlsp);
            
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình thêm mới! ");
            }
            string sQuerye = "select * from LoaiSanPham";

            SqlCommand cmde = new SqlCommand(sQuerye, con); DataTable KT = new DataTable();
            SqlDataReader dr = cmde.ExecuteReader(); KT.Load(dr);
            dataGridView1.DataSource = KT; dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            con.Close();
        }


        private void btnsua_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(scon);
            try
            {
                con.Open();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DB");
            }
            string sMaNV = tbmnv.Text;
            string sTenNV = tbname.Text;
            string sNgaySinh = dtpngaysinh.Value.ToString("yyyy-MM-dd");
            int igioitinh = 0;
            if (cbnamNV.Checked == true)
            {
                igioitinh = 1;
            }
            string sSoDienThoai = tbsodienthoai.Text;
            string sDiachi = tbdiachi.Text;

            string sQuery = "update NhanVien set HoVaTen= @HoVaTen, NgaySinh=@NgaySinh,  GioiTinh = @GioiTinh,  SoDienThoai = @SoDienThoai, DiaChi = @DiaChi" + " Where MaNV = @MaNV";

            SqlCommand cmd = new SqlCommand(sQuery, con);
            cmd.Parameters.AddWithValue("@MaNV", sMaNV);
            cmd.Parameters.AddWithValue("@HoVaTen", sTenNV);
            cmd.Parameters.AddWithValue("@NgaySinh", sNgaySinh);
            cmd.Parameters.AddWithValue("@GioiTinh", igioitinh);
            cmd.Parameters.AddWithValue("@SoDienThoai", sSoDienThoai);
            cmd.Parameters.AddWithValue("@DiaChi", sDiachi);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình cập nhật!");
            }
            string sQuerye = "select * from NhanVien";
            SqlCommand cmde = new SqlCommand(sQuerye, con); DataTable KT = new DataTable();
            SqlDataReader dr = cmde.ExecuteReader(); KT.Load(dr);
            dtgvDSNV.DataSource = KT; dtgvDSNV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            con.Close();
        }

        private void btedit_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(scon);
            try
            {
                con.Open();

            }
            catch (Exception ex )
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DB");
            }
            string sMaNcc = tbmncc.Text;
            string sTenNcc = tbtncc.Text;
            string sDiachi = tbdc.Text;
            string sSoDienThoai = tbnb.Text;
            string sWeb = tbw.Text;
            string sQuery = " update NhaCungCap set TenNCC=@TenNCC, DiaChi=@DiaChi, SoDienThoai=@SoDienThoai, Website=@Website "+" Where MaNCC=@MaNCC";
            SqlCommand cmd = new SqlCommand(sQuery, con);
            cmd.Parameters.AddWithValue("@MaNCC", sMaNcc);
            cmd.Parameters.AddWithValue("@TenNCC", sTenNcc);
            cmd.Parameters.AddWithValue("@DiaChi", sDiachi);
            cmd.Parameters.AddWithValue("@SoDienThoai", sSoDienThoai);
            cmd.Parameters.AddWithValue("@Website", sWeb);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật thành công!");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình cập nhật! ");
            }
            string sQuerye = "select * from NhaCungCap";
            SqlCommand cmde = new SqlCommand(sQuerye, con); DataTable KT = new DataTable();
            SqlDataReader dr = cmde.ExecuteReader(); KT.Load(dr);
            dtgvNCC.DataSource = KT; dtgvNCC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            con.Close();
        
        }

        private void bttts_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(scon);
            try
            {
                con.Open();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DB");
            }
            string sU = tbttk.Text;
            string sP = tbmk.Text;
            string sMnv = tbbmnv.Text;
            string sQuery = " update Taikhoan set pass=@pass,MaNV=@MaNV " + " Where Usename = @Usename";
            SqlCommand cmd = new SqlCommand(sQuery, con);
            cmd.Parameters.AddWithValue("@Usename", sU);
            cmd.Parameters.AddWithValue("@pass", sP);
            cmd.Parameters.AddWithValue("@MaNV", sMnv);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình cập nhật! ");
            }
            string sQuerye = "select * from Taikhoan";
            SqlCommand cmde = new SqlCommand(sQuerye, con); DataTable KT = new DataTable();
            SqlDataReader dr = cmde.ExecuteReader(); KT.Load(dr);
            dtgvtk.DataSource = KT; dtgvtk.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            con.Close();
        }

        private void bttsua_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(scon);
            try
            {
                con.Open();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DB");
            }
            string sMasp = tbmsp.Text;
            string sTensp = txtsp.Text;
            string sGia = tbgia.Text;
            string sDVT = tbdvt.Text;
            string sMNCC = tbmancc.Text;
            string sMlsp = tbmlsp.Text;
            int igioitinh = 0;
            if (cbnamNV.Checked == true)
            {
                igioitinh = 1;
            }

            string sQuery = " update  SanPham set TenSP=@TenSP, GiaBan=@GiaBan, DonViTinh=@DonViTinh, MaNCC=@MaNCC, MaLoaiSP=@MaLoaiSP, GioiTinhSuDung=@GioiTinhSuDung "+" Where MaSP=@MaSP";
            SqlCommand cmd = new SqlCommand(sQuery, con);
            cmd.Parameters.AddWithValue("@MaSP", sMasp);
            cmd.Parameters.AddWithValue("@TenSP", sTensp);
            cmd.Parameters.AddWithValue("@GiaBan", sGia);
            cmd.Parameters.AddWithValue("@DonViTinh", sDVT);
            cmd.Parameters.AddWithValue("@MaNCC", sMNCC);
            cmd.Parameters.AddWithValue("@MaLoaiSP", sMlsp);
            cmd.Parameters.AddWithValue("@GioiTinhSuDung", igioitinh);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình cập nhật! ");
            }
            string sQuerye = "select * from SanPham";
            SqlCommand cmde = new SqlCommand(sQuerye, con); DataTable KT = new DataTable();
            SqlDataReader dr = cmde.ExecuteReader(); KT.Load(dr);
            datagvSp.DataSource = KT; datagvSp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            con.Close();

        }

        private void btxua_Click(object sender, EventArgs e)
        {
      SqlConnection con = new SqlConnection(scon);
            try
            {
                con.Open();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DB");
            }
            string sMahd = tbmhd.Text;
            string sTenkh = tbtkh.Text;
            string sNgaylap = dtplap.Value.ToString("yyyy-MM-dd");
            string sSoDienThoai = txsdt.Text;
            string smanv = txtmnv.Text;
            string sthanhtien = tbtt.Text;

            string sQuery = "update  HoaDonBanHang set TenKH=@TenKH, NgayLap=@NgayLap, SoDienThoai=@SoDienThoai,MaNV=@MaNV,ThanhTien=@ThanhTien" + " Where MaHD = @MaHD";
            SqlCommand cmd = new SqlCommand(sQuery, con);
            cmd.Parameters.AddWithValue("@MaHD", sMahd);
            cmd.Parameters.AddWithValue("@TenKH", sTenkh);
            cmd.Parameters.AddWithValue("@NgayLap", sNgaylap);
            cmd.Parameters.AddWithValue("@SoDienThoai", sSoDienThoai);
            cmd.Parameters.AddWithValue("@MaNV", smanv);
            cmd.Parameters.AddWithValue("@ThanhTien", sthanhtien);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình cập nhật! ");
            }
            string sQuerye = "select * from HoaDonBanHang";
            SqlCommand cmde = new SqlCommand(sQuerye, con); DataTable KT = new DataTable();
            SqlDataReader dr = cmde.ExecuteReader(); KT.Load(dr);
            dgvhd.DataSource = KT; dgvhd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            con.Close();
        }
        private void btcapnhatne_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(scon);
            try
            {
                con.Open();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DB");
            }
            string sMalsp = tblsp.Text;
            string sTenlsp = textBox2.Text;
            string sQuery = "update  LoaiSanPham set TenLoaiSP=@TenLoaiSP" + " Where MaLoaiSP = @MaLoaiSP";
            SqlCommand cmd = new SqlCommand(sQuery, con);
            cmd.Parameters.AddWithValue("@MaLoaiSP", sMalsp);
            cmd.Parameters.AddWithValue("@TenLoaiSP", sTenlsp);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình cập nhật! ");
            }
            string sQuerye = "select * from LoaiSanPham";

            SqlCommand cmde = new SqlCommand(sQuerye, con); DataTable KT = new DataTable();
            SqlDataReader dr = cmde.ExecuteReader(); KT.Load(dr);
            dataGridView1.DataSource = KT; dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            con.Close();
        }


        private void bttim_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(scon);
            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                SqlCommand cmd = new SqlCommand("Select * from SanPham where TenSP like '%" + tbs.Text + "%' or MaSP like '%" + tbs.Text + "%' or GiaBan like '%" + tbs.Text + "%' or MaNCC like '%" + tbs.Text + "%' or MaLoaiSP like '%" + tbs.Text + "%'", connection);
                cmd.ExecuteNonQuery();
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                datagvSp.DataSource = dt;
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
            catch (Exception e1)
            {
                MessageBox.Show("Không Tìm Thấy!", "Thông Báo", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            
        }

        private void btk_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(scon);
            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                SqlCommand cmd = new SqlCommand("Select * from NhanVien where HoVaTen like '%" + tbsh.Text + "%' or MaNV like '%" + tbsh.Text + "%' or SoDienThoai like '%" + tbsh.Text + "%' or DiaChi like '%" + tbsh.Text + "%' ", connection);
                cmd.ExecuteNonQuery();
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dtgvDSNV.DataSource = dt;
                if (connection.State == ConnectionState.Open)
                    connection.Close();

            }
            catch (Exception e1)
            {
                MessageBox.Show("Không Tìm Thấy!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btkt_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(scon);
            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                SqlCommand cmd = new SqlCommand("Select * from NhaCungCap where TenNCC like '%" + TBKT.Text + "%' or MaNCC like '%" + TBKT.Text + "%' or DiaChi like '%" + TBKT.Text + "%' or SoDienThoai like '%" + TBKT.Text + "%' or Website like '%" + TBKT.Text + "%'", connection);
                cmd.ExecuteNonQuery();
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dtgvNCC.DataSource = dt;
                if (connection.State == ConnectionState.Open)
                    connection.Close();

            }
            catch (Exception e1)
            {
                MessageBox.Show("Không Tìm Thấy!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TKTK_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(scon);
            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                SqlCommand cmd = new SqlCommand("Select * from Taikhoan where Usename like '%" + TBTKTK.Text + "%' or MaNV like '%" + TBTKTK.Text + "%' ", connection);
                cmd.ExecuteNonQuery();
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dtgvtk.DataSource = dt;
                if (connection.State == ConnectionState.Open)
                    connection.Close();

            }
            catch (Exception e1)
            {
                MessageBox.Show("Không Tìm Thấy!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TKHD_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(scon);
            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                SqlCommand cmd = new SqlCommand("Select * from HoaDonBanHang where TenKH like '%" + TBHD.Text + "%' or MaHD like '%" + TBHD.Text + "%' or SoDienThoai like '%" + TBHD.Text + "%' or MaNV like '%" + TBHD.Text + "%' or ThanhTien like '%" + TBHD.Text + "%' ", connection);
                cmd.ExecuteNonQuery();
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dgvhd.DataSource = dt;
                if (connection.State == ConnectionState.Open)
                    connection.Close();

            }
            catch (Exception e1)
            {
                MessageBox.Show("Không Tìm Thấy!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
       

        private void bttxoa_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn có chắc chắn là muốn xóa không ?", "Thông báo ", MessageBoxButtons.OKCancel);
            if (ret == DialogResult.OK)
            {
                SqlConnection con = new SqlConnection(scon);
                try
                {
                    con.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xảy ra lỗi trong quá trình kết nối dữ liệu");
                }
                string smsp = tbmsp.Text;
                string sQuery = "delete SanPham where MaSP=@MaSP";
                SqlCommand cmd = new SqlCommand(sQuery, con);
                cmd.Parameters.AddWithValue("@MaSP", smsp);
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa thành công! ");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xảy ra lỗi khi xóa!");
                }
                string sQuerye = "select * from SanPham";
                SqlCommand cmde = new SqlCommand(sQuerye, con); DataTable KT = new DataTable();
                SqlDataReader dr = cmde.ExecuteReader(); KT.Load(dr);
                datagvSp.DataSource = KT; datagvSp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                con.Close();
            }
        }

        private void tnxoa_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn có chắc chắn là muốn xóa không ?", "Thông báo ", MessageBoxButtons.OKCancel);
            if (ret == DialogResult.OK)
            {
                SqlConnection con = new SqlConnection(scon);
                try
                {
                    con.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xảy ra lỗi trong quá trình kết nối dữ liệu");
                }
                string smnv = tbmnv.Text;
                string sQuery = "delete NhanVien where MaNV =@MaNV";
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
                string sQuerye = "select * from NhanVien";
                SqlCommand cmde = new SqlCommand(sQuerye, con); DataTable KT = new DataTable();
                SqlDataReader dr = cmde.ExecuteReader(); KT.Load(dr);
                dtgvDSNV.DataSource = KT; dtgvDSNV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                con.Close();
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn có chắc chắn là muốn xóa không ?", "Thông báo ", MessageBoxButtons.OKCancel);
            if (ret == DialogResult.OK)
            {
                SqlConnection con = new SqlConnection(scon);
                try
                {
                    con.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xảy ra lỗi trong quá trình kết nối dữ liệu");
                }
                string smncc = tbmncc.Text;
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
                dtgvNCC.DataSource = KT; dtgvNCC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                con.Close();
            }
        }

        private void btde_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn có chắc chắn là muốn xóa không ?", "Thông báo ", MessageBoxButtons.OKCancel);
            if (ret == DialogResult.OK)
            {
                SqlConnection con = new SqlConnection(scon);
                try
                {
                    con.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xảy ra lỗi trong quá trình kết nối dữ liệu");
                }
                string stk = tbttk.Text;
                string sQuery = "delete Taikhoan  where Usename =@Usename";
                SqlCommand cmd = new SqlCommand(sQuery, con);
                cmd.Parameters.AddWithValue("@Usename", stk);
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa thành công! ");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xảy ra lỗi khi xóa!");
                }
                string sQuerye = "select * from Taikhoan";
                SqlCommand cmde = new SqlCommand(sQuerye, con); DataTable KT = new DataTable();
                SqlDataReader dr = cmde.ExecuteReader(); KT.Load(dr);
                dtgvtk.DataSource = KT; dtgvtk.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                con.Close();
            }
        }

        private void XOAXOA_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn có chắc chắn là muốn xóa không ?", "Thông báo ", MessageBoxButtons.OKCancel);
            if (ret == DialogResult.OK)
            {
                SqlConnection con = new SqlConnection(scon);
                try
                {
                    con.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xảy ra lỗi trong quá trình kết nối dữ liệu");
                }
                string sHD = tbmhd.Text;
                string sQuery = "delete HoaDonBanHang where MaHD =@MaHD";
                SqlCommand cmd = new SqlCommand(sQuery, con);
                cmd.Parameters.AddWithValue("@MaHD", sHD);
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa thành công! ");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xảy ra lỗi khi xóa!");
                }
                string sQuerye = "select * from HoaDonBanHang";
                SqlCommand cmde = new SqlCommand(sQuerye, con); DataTable KT = new DataTable();
                SqlDataReader dr = cmde.ExecuteReader(); KT.Load(dr);
                dgvhd.DataSource = KT; dgvhd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadSanPham();
            tbmsp.ResetText();
            txtsp.ResetText();
            tbgia.ResetText();
            tbdvt.ResetText();
            tbs.ResetText();
            tbmancc.ResetText();
            tbmlsp.ResetText();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadNhanVien();
            tbmnv.ResetText();
            tbname.ResetText();
            dtpngaysinh.ResetText();
            tbsodienthoai.ResetText();
            tbsh.ResetText();
            tbdiachi.ResetText();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadNhaCungCap();
            tbmncc.ResetText();
            tbtncc.ResetText();
            tbdc.ResetText();
            tbnb.ResetText();
            tbw.ResetText();
            TBKT.ResetText();
           

        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoadTaiKhoan();
            tbttk.ResetText();
            tbmk.ResetText();
            tbbmnv.ResetText();
            TBTKTK.ResetText();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LoadHoaDon();
            tbmhd.ResetText();
            tbtkh.ResetText();
            dtplap.ResetText();
            txsdt.ResetText();
            txtmnv.ResetText();
            tbtt.ResetText();
            TBHD.ResetText();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(scon);
            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                SqlCommand cmd = new SqlCommand("Select * from LoaiSanPham Where MaLoaiSP like '%" + tbtimkiem.Text + "%' or TenLoaiSP  like '%" + tbtimkiem.Text + "%'", connection);
                cmd.ExecuteNonQuery();
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dataGridView1.DataSource = dt;
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
            catch (Exception e1)
            {
                MessageBox.Show("Không Tìm Thấy!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btxoane_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn có chắc chắn là muốn xóa không ?", "Thông báo ", MessageBoxButtons.OKCancel);
            if (ret == DialogResult.OK)
            {
                SqlConnection con = new SqlConnection(scon);
                try
                {
                    con.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xảy ra lỗi trong quá trình kết nối dữ liệu");
                }
                string smnlc = tblsp.Text;
                string sQuery = "delete LoaiSanPham  where MaLoaiSP=@MaLoaiSP";
                SqlCommand cmd = new SqlCommand(sQuery, con);
                cmd.Parameters.AddWithValue("@MaLoaiSP", smnlc);
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa thành công! ");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xảy ra lỗi khi xóa!");
                }
                string sQuerye = "select * from LoaiSanPham";
                SqlCommand cmde = new SqlCommand(sQuerye, con); DataTable KT = new DataTable();
                SqlDataReader dr = cmde.ExecuteReader(); KT.Load(dr);
                dataGridView1.DataSource = KT; dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                con.Close();
            }
        }

        private void bttailai_Click(object sender, EventArgs e)
        {
            LoadLoaiSP();
            tblsp.ResetText();
            textBox2.ResetText();
            tbtimkiem.ResetText();
        }


    }
    }

