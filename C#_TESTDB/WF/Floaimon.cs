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
    public partial class Floaimon : Form
    {

        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=DESKTOP-8LPBRKU\SQLEXPRESS;Initial Catalog=CaPhe;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from LOAIMON";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            DGloaimon.DataSource = table;
        }
        public Floaimon()
        {
            InitializeComponent();
        }

        private void Floaimon_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
        }

        private void DGloaimon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int i;
            i = DGloaimon.CurrentRow.Index;
            tbmaloai.Text = DGloaimon.Rows[i].Cells[0].Value.ToString();
            tbtenloai.Text = DGloaimon.Rows[i].Cells[1].Value.ToString();
           
        }

        private void btsu_Click(object sender, EventArgs e)
        {
            try
            {
                command = connection.CreateCommand();
                command.CommandText = "Update LOAIMON set TenLoai = @TenLoai where MaLoai = @MaLoai";
                command.Parameters.AddWithValue("MaLoai", tbmaloai.Text);
                command.Parameters.AddWithValue("TenLoai", tbtenloai.Text);
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

        private void btt_Click(object sender, EventArgs e)
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
            string smaloai= tbmaloai.Text;
            string stenloai = tbtenloai.Text;
           

            string sQuery = "insert into LOAIMON values (@MaLoai, @TenLoai)";
            SqlCommand cmd = new SqlCommand(sQuery, con);
            cmd.Parameters.AddWithValue("@MaLoai", smaloai);
            cmd.Parameters.AddWithValue("@TenLoai", stenloai);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình thêm mới! ");
            }
            string sQuerye = "select * from LOAIMON";
            SqlCommand cmde = new SqlCommand(sQuerye, con); DataTable KT = new DataTable();
            SqlDataReader dr = cmde.ExecuteReader(); KT.Load(dr);
            DGloaimon.DataSource = KT; DGloaimon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            con.Close();

        }

        private void btxo_Click(object sender, EventArgs e)
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
                string smaloai = tbmaloai.Text;
                string sQuery = "delete LOAIMON  where MaLoai =@MaLoai";
                SqlCommand cmd = new SqlCommand(sQuery, con);
                cmd.Parameters.AddWithValue("@MaLoai", smaloai);
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa thành công! ");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xảy ra lỗi khi xóa!");
                }
                string sQuerye = "select * from LOAIMON";
                SqlCommand cmde = new SqlCommand(sQuerye, con); DataTable KT = new DataTable();
                SqlDataReader dr = cmde.ExecuteReader(); KT.Load(dr);
                DGloaimon.DataSource = KT; DGloaimon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                con.Close();
            }
        }

        private void buttonreset_Click(object sender, EventArgs e)
        {
            loaddata();
            tbmaloai.ResetText();
            tbtenloai.ResetText();
        }
    }
}
