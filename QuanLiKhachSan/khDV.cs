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
using Khtracuu;
namespace tracuukh
{
    public partial class khDV : Form
    {
        public khDV(string maKH, bool isKH)
        {
            InitializeComponent();
            if (isKH)
            {
                txtmaKH.Text = maKH;
                string connectionString = @"Data Source=DESKTOP-6DQI5MG\SQLEXPRESS;Initial Catalog=HT_QuanLyKhachSan;Integrated Security=True";
                string query = "SELECT MaDichVu, soLan, NgaySuDung FROM KhachSuDungDichVu WHERE MaKH = '" + maKH + "'";
                SqlDataAdapter adap = new SqlDataAdapter(query, connectionString);
                DataTable table = new DataTable();
                adap.Fill(table);
                txtmaDV.Text = table.Rows[0]["MaDichVu"].ToString();
                txtsolan.Text = table.Rows[0]["soLan"].ToString();
                txtdate.Text = table.Rows[0]["NgaySuDung"].ToString();
                txtmaKH.ReadOnly = true;
                txtmaDV.ReadOnly = true;
                txtsolan.ReadOnly = true;
                txtdate.ReadOnly = true;
            }
            else
            {
               label1.Text = "MaDoan";
               txtmaKH.Text = maKH;
               label3.Dispose();
               txtsolan.Dispose();
               string connectionString = @"Data Source=DESKTOP-6DQI5MG\SQLEXPRESS;Initial Catalog=HT_QuanLyKhachSan;Integrated Security=True";
               string query = "SELECT MaDichVu, MaDoan, NgaySuDung FROM DoanSuDungDichVu WHERE MaDoan = '" + maKH + "'";
               SqlDataAdapter adap = new SqlDataAdapter(query, connectionString);
               DataTable table = new DataTable();
               adap.Fill(table);
               txtmaDV.Text = table.Rows[0]["MaDichVu"].ToString();
               txtdate.Text = table.Rows[0]["NgaySuDung"].ToString();
               txtmaKH.ReadOnly = true;
               txtmaDV.ReadOnly = true;
               txtdate.ReadOnly = true;
            }

        }

        private void khDV_Load(object sender, EventArgs e)
        {

        }
    }
}