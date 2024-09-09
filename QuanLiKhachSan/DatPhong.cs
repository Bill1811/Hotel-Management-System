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

    public partial class DatPhong : Form

    {

        public DatPhong()

        {

            InitializeComponent();

        }

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-6DQI5MG\SQLEXPRESS;Initial Catalog=HT_QuanLyKhachSan;Integrated Security=True");
            string strsql;
            SqlCommand cmd;
        
       
        private void Form1_Load(object sender, EventArgs e)
        {

            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-6DQI5MG\SQLEXPRESS;Initial Catalog=HT_QuanLyKhachSan;Integrated Security=True")) ;
            {
                SqlCommand cmd = new SqlCommand("Select MaDatPhong,GiaTien,TinhTrangPhong from Room", conn);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable table1 = new DataTable();
                da.Fill(table1);
                comboBox1.DataSource = table1;
                DataRow itemrow = table1.NewRow();
                itemrow[0] = "Chon Loai Phong";
                table1.Rows.InsertAt(itemrow, 0);
                comboBox1.DisplayMember = "MaDatPhong";
                comboBox1.ValueMember = "GiaTien";

            
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

         

            cmd = conn.CreateCommand();
            cmd.CommandText = "update Room set NgayCheckIn ='" + dateTimePicker1.Value.ToString() + "', NgayCheckOut ='" + dateTimePicker2.Value.ToString() + "',TinhTrangPhong='Đã đặt' where MaDatPhong= '" + comboBox1.Text + "'";
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        
            MessageBox.Show("Đặt phòng thành công");


        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            conn.Open();
            strsql = "Select * from Room where MaDatPhong= '" + comboBox1.Text + "'" +
                "And ((@start1 >= NgayCheckIn And @end1 <= NgayCheckOut)" +

                "Or (@start1 <= NgayCheckIn And @end1 >= NgayCheckOut)" +

                "or (@start1 > NgayCheckIn And @end1 > NgayCheckOut And @start1<NgayCheckOut)" +

                "or (@start1 < NgayCheckIn And @end1 < NgayCheckOut And @end1>NgayCheckIn))";

            cmd = new SqlCommand(strsql, conn);
            cmd.Parameters.AddWithValue("room1", comboBox1.Text);

            cmd.Parameters.AddWithValue("start1", dateTimePicker1.Value.ToString());

            cmd.Parameters.AddWithValue("end1", dateTimePicker2.Value.ToString());

            SqlDataReader myreader = cmd.ExecuteReader();

            if (myreader.Read())

            {

                MessageBox.Show("Phòng đã có người đặt trước: " + myreader.GetValue(1).ToString() + " tới: " + myreader.GetValue(2).ToString());

            }

            else

            {

                MessageBox.Show("Phòng chưa có ai đặt");

            }

            conn.Close();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = comboBox1.SelectedValue.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

  

        private void DatPhong_Load(object sender, EventArgs e)
        {

        }

  

        private void DatPhong_Load_1(object sender, EventArgs e)
        {
            
        }
    }

}