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
namespace WinFormsApp1
{
    public partial class LapPhieuDatPhong : Form
    {
        SqlConnection _conn = null;
        SqlCommand _command = null;
        string _connectionString = "";

        public LapPhieuDatPhong()
        {
            InitializeComponent();

            _connectionString = @"Data Source=VanillaChocola\SQLEXPRESS;Initial Catalog=HT_QuanLyKhachSan;Integrated Security=True";
        }


        private void button1_Click(object sender, EventArgs e)
        {
            _conn = new SqlConnection(_connectionString);
            _conn.Open();

            string sql = "INSERT INTO KhachDatPhong VALUES ('" + textBox13.Text + "', '" + textBox12.Text + "', " + textBox14.Text + ", " + textBox17.Text + ", " + textBox16.Text + ", N'" + textBox15.Text + "')";
            _command = new SqlCommand(sql);
            _command.Connection = _conn;

            int n = _command.ExecuteNonQuery();
            if (n > 0)
                MessageBox.Show("Thêm thành công !!!");
            else
                MessageBox.Show("Thêm thất bại !!!");

            _conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _conn = new SqlConnection(_connectionString);
            _conn.Open();

            string sql = "INSERT INTO KhachDatPhong VALUES ('" + textBox2.Text + "', '" + textBox10.Text + "', " + textBox9.Text + ", " + textBox8.Text + ", N'" + textBox7.Text + "')";
            _command = new SqlCommand(sql);
            _command.Connection = _conn;

            int n = _command.ExecuteNonQuery();
            if (n > 0)
                MessageBox.Show("Lập thành công !!!");
            else
                MessageBox.Show("Lập thất bại !!!");

            _conn.Close();
        }
    }
}