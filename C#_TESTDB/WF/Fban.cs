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
    public partial class Fban : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=DESKTOP-8LPBRKU\SQLEXPRESS;Initial Catalog=CaPhe;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from BAN";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            DTGVVBAN.DataSource = table;

        }
        public Fban()
        {
            InitializeComponent();
        }

        private void Fban_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
        }

        private void DTGVVBAN_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = DTGVVBAN.CurrentRow.Index;
            tbma.Text = DTGVVBAN.Rows[i].Cells[0].Value.ToString();
            tbten.Text = DTGVVBAN.Rows[i].Cells[1].Value.ToString();
            
        }

        private void btedit_Click(object sender, EventArgs e)
        {
            try
            {
                command = connection.CreateCommand();
                command.CommandText = "Update BAN set  Tenban = @Tenban where Maban = @Maban";
                command.Parameters.AddWithValue("Maban", tbma.Text);
                command.Parameters.AddWithValue("Tenban", tbten.Text);
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

        private void btthem_Click(object sender, EventArgs e)
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
            string smaban = tbma.Text;
            string stenban = tbten.Text;


            string sQuery = "insert into BAN values (@MaBan, @TenBan)";
            SqlCommand cmd = new SqlCommand(sQuery, con);
            cmd.Parameters.AddWithValue("@MaBan", smaban);
            cmd.Parameters.AddWithValue("@TenBan", stenban);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình thêm mới! ");
            }
            string sQuerye = "select * from BAN";
            SqlCommand cmde = new SqlCommand(sQuerye, con); DataTable KT = new DataTable();
            SqlDataReader dr = cmde.ExecuteReader(); KT.Load(dr);
            DTGVVBAN.DataSource = KT; DTGVVBAN.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            con.Close();
        }

        private void btd_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn có chắc chắn là muốn xóa không ?", "Thông báo ", MessageBoxButtons.OKCancel);
            if (ret == DialogResult.OK)
            {
                SqlConnection connection = new SqlConnection(str);
                
                
                    connection.Open();
                
                
                string smaban = tbma.Text;
                string stenban = tbten.Text;
                string sQuery = "delete BAN  where Maban =@Maban";
                SqlCommand cmd = new SqlCommand(sQuery, connection);
                cmd.Parameters.AddWithValue("@Maban", smaban);
                cmd.Parameters.AddWithValue("@TenBan", stenban);
                
                
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loaddata();
                
                
                connection.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loaddata();
            tbma.ResetText();
            tbten.ResetText();
        }
    }
}
