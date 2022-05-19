﻿using System;
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
    public partial class Fmon : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=DESKTOP-8LPBRKU\SQLEXPRESS;Initial Catalog=CaPhe;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from MON";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            DGM.DataSource = table;
        }
        public Fmon()
        {
            InitializeComponent();
        }

        private void Fmon_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
        }

        private void DGM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = DGM.CurrentRow.Index;
            tbmm.Text = DGM.Rows[i].Cells[0].Value.ToString();
            tbml.Text = DGM.Rows[i].Cells[1].Value.ToString();
            tbtm.Text = DGM.Rows[i].Cells[2].Value.ToString();
            tbdg.Text = DGM.Rows[i].Cells[3].Value.ToString();
        }

        private void bts_Click(object sender, EventArgs e)
        {
            try
            {
                command = connection.CreateCommand();
                command.CommandText = "Update MON set MaLoai = @MaLoai, TenMon = @TenMon, DonGiaMon= @DonGiaMon where MaMon = @MaMon";
                command.Parameters.AddWithValue("MaMon", tbmm.Text);
                command.Parameters.AddWithValue("MaLoai", tbml.Text);
                command.Parameters.AddWithValue("TenMon", tbtm.Text);
                command.Parameters.AddWithValue("DonGiaMon", tbdg.Text);
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
            SqlConnection connection = new SqlConnection(str);
            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                SqlCommand cmd = new SqlCommand("Select * from MON where TenMon like '%" + bttim.Text + "%' ", connection);
                cmd.ExecuteNonQuery();
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                DGM.DataSource = dt;
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
            catch (Exception e1)
            {
                MessageBox.Show("Không Tìm Thấy!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loaddata();
            tbmm.ResetText();
            tbml.ResetText();
            tbtm.ResetText();
            tbdg.ResetText();
        }

        private void btth_Click(object sender, EventArgs e)
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
            string sMamon = tbmm.Text;
            string smaloai = tbml.Text;
            string stenmon = tbtm.Text;
            string sdongiamon = tbdg.Text;
           
            string sQuery = "insert into MON values (@MaMon, @MaLoai, @TenMon, @DonGiaMon)";
            SqlCommand cmd = new SqlCommand(sQuery, con);
            cmd.Parameters.AddWithValue("@MaMon", sMamon);
            cmd.Parameters.AddWithValue("@MaLoai", smaloai);
            cmd.Parameters.AddWithValue("@TenMon", stenmon);
            cmd.Parameters.AddWithValue("@DonGiaMon", sdongiamon);
          
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình thêm mới! ");
            }
            string sQuerye = "select * from MON";
            SqlCommand cmde = new SqlCommand(sQuerye, con); DataTable KT = new DataTable();
            SqlDataReader dr = cmde.ExecuteReader(); KT.Load(dr);
            DGM.DataSource = KT; DGM.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            con.Close();

        }

        private void btx_Click(object sender, EventArgs e)
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
                string smon = tbmm.Text;
                string sQuery = "delete MON  where MaMon =@MaMon";
                SqlCommand cmd = new SqlCommand(sQuery, con);
                cmd.Parameters.AddWithValue("@MaMon", smon);
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa thành công! ");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xảy ra lỗi khi xóa!");
                }
                string sQuerye = "select * from MON";
                SqlCommand cmde = new SqlCommand(sQuerye, con); DataTable KT = new DataTable();
                SqlDataReader dr = cmde.ExecuteReader(); KT.Load(dr);
                DGM.DataSource = KT; DGM.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                con.Close();
            }
        }
    }
}
