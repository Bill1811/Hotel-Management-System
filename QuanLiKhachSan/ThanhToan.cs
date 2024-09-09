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

namespace QuanLiKhachSan
{
    public partial class ThanhToan : Form
    {
        string strCon = @"Data Source=DESKTOP-CAL94V2\SQLEXPRESS;Initial Catalog=HT_QuanLyKhachSan;Integrated Security=True";
        //Đối tượng kết nối
        SqlConnection sqlCon = null;
        public ThanhToan()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "SELECT MaKH FROM dbo.KhachDatPhong WHERE MaDatPhong = @MaDatPhong_2 ";
                SqlConnection Con = new SqlConnection(strCon);
                Con.Open();
                string ma = "";
                SqlCommand cmd = new SqlCommand(sql, Con);
                cmd.Parameters.AddWithValue("@MaDatPhong_2", textBox1.Text);
                //cmd.ExecuteNonQuery();
                SqlDataReader reader;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                    ma = reader.GetValue(0).ToString();
                reader.Close();
                textBox3.Text = ma;
                sql = "SELECT TongTien FROM dbo.CheckIn WHERE MaDatPhong = @MaDatPhong_2 ";
                ma = "";
                cmd = new SqlCommand(sql, Con);
                cmd.Parameters.AddWithValue("@MaDatPhong_2", textBox1.Text);
                //cmd.ExecuteNonQuery();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                    ma = reader.GetValue(0).ToString();
                reader.Close();
                textBox5.Text = ma;
                sql = "SELECT TinhTrangThanhToan FROM dbo.CheckIn WHERE MaDatPhong = @MaDatPhong_2 ";
                ma = "";
                cmd = new SqlCommand(sql, Con);
                cmd.Parameters.AddWithValue("@MaDatPhong_2", textBox1.Text);
                //cmd.ExecuteNonQuery();          
                reader = cmd.ExecuteReader();
                while (reader.Read())
                    ma = reader.GetValue(0).ToString();
                reader.Close();
                textBox2.Text = ma;
                sql = "SELECT * FROM dbo.KhachDatPhong WHERE MaDatPhong = @MaDatPhong_2 ";
                cmd = new SqlCommand(sql, Con);
                cmd.Parameters.AddWithValue("@MaDatPhong_2", textBox1.Text);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                textBox4.Text = textBox1.Text;
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox2.Text == "Ðã thanh toán")
                {
                    MessageBox.Show("Phòng đã được thanh toán trước đó");
                }
                else
                {
                    SqlConnection Con = new SqlConnection(strCon);
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT (KH.SoDu - CI.TongTien) FROM dbo.KhachHang KH,dbo.CheckIn CI WHERE KH.MaKH=@MaKH AND CI.MaDatPhong = @MaDatPhong_4 ", Con);
                    cmd.Parameters.AddWithValue("@MaDatPhong_4", textBox4.Text);
                    cmd.Parameters.AddWithValue("@MaKH", textBox3.Text);
                    string ma = "";
                    SqlDataReader reader; ///DH000022
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                        ma = reader.GetValue(0).ToString();
                    reader.Close();
                    if (int.Parse(ma) > 0)
                    {
                        MessageBox.Show("Số dư hợp lệ");
                        textBox6.Text = ma;
                        cmd = new SqlCommand("UPDATE dbo.KhachHang SET SoDu=@SoDu WHERE MaKH = @MaKH", Con);
                        cmd.Parameters.AddWithValue("@SoDu", textBox6.Text);
                        cmd.Parameters.AddWithValue("@MaDonHang_4", textBox4.Text);
                        cmd.Parameters.AddWithValue("@MaKH", textBox3.Text);
                        cmd.ExecuteNonQuery();
                        cmd = new SqlCommand("SELECT SoDu FROM dbo.KhachHang WHERE MaKH=@MaKH", Con);
                        cmd.Parameters.AddWithValue("@MaKH", textBox3.Text);
                        cmd.ExecuteNonQuery();
                        cmd = new SqlCommand("UPDATE CheckIn SET TinhTrangThanhToan = 'Đã thanh toán' WHERE MaDatPhong = @MaDatPhong_4", Con);
                        cmd.Parameters.AddWithValue("@MaDatPhong_4", textBox4.Text);
                        cmd.ExecuteNonQuery();
                        cmd = new SqlCommand("select MaDatPhong, TinhTrangThanhToan From CheckIn WHERE MaDatPhong = @MaDatPhong_4", Con);
                        cmd.Parameters.AddWithValue("@MaDatPhong_4", textBox4.Text);
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataGridView2.DataSource = dt;
                    }
                    else
                        MessageBox.Show("Số dư không đủ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
