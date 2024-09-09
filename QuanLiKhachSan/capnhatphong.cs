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

namespace Capnhatphong
{
    public partial class CapNhatPhong : Form
    {

        string sqlQueryData = "Select MaDatPhong,TinhTrangPhong from Room";
        public CapNhatPhong()
        {
            InitializeComponent();
            connect = new SqlConnection(str);
            connect.Open();
            loadData(sqlQueryData);
            LoadDataToComboBox();
        }

        SqlConnection connect;
        SqlCommand command;
        string str = @"Data Source=DESKTOP-6DQI5MG\SQLEXPRESS;Initial Catalog=HT_QuanLyKhachSan;Integrated Security=True";
        SqlDataAdapter adap = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loadData(string sqlQueryData)
        {
            command = connect.CreateCommand();
            command.CommandText = sqlQueryData;
            adap.SelectCommand = command;
            table.Clear();
            adap.Fill(table);
            dataGrid.DataSource = table;

            string[] headerTexts = new string[] { "Mã phòng", "Tình trạng phòng" };
            for (int i = 0; i < dataGrid.Columns.Count; i++)
            {
                dataGrid.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                if (i < headerTexts.Length)
                {
                    dataGrid.Columns[i].HeaderText = headerTexts[i];
                }
            }
            dataGrid.Columns["MaDatPhong"].ReadOnly = true;
            dataGrid.Columns["TinhTrangPhong"].ReadOnly = true;

        }


        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPhong.ReadOnly = true;
            int i;
            i = dataGrid.CurrentRow.Index;
            txtPhong.Text = dataGrid.Rows[i].Cells[0].Value.ToString();
            ttPhong.Text = dataGrid.Rows[i].Cells[1].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPhong.Text))
            {
                command = connect.CreateCommand();
                command.CommandText = "UPDATE Room SET TinhTrangPhong = @tinhTrangPhong WHERE MaDatPhong = @maDatPhong";
                command.Parameters.AddWithValue("@tinhTrangPhong", ttPhong.Text);
                command.Parameters.AddWithValue("@maDatPhong", txtPhong.Text);
                command.ExecuteNonQuery();
            }

            MessageBox.Show("Cập nhật dữ liệu thành công!");
            loadData(sqlQueryData);

            txtPhong.Text = "";
            ttPhong.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            ttPhong.Items.Add("Đã đặt");
            ttPhong.Items.Add("Trống");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            command = connect.CreateCommand();
            command.CommandText = "Select MaDatPhong,TinhTrangPhong from Room where (MaDatPhong like '%" + cbPhong.Text + "%')";
            adap.SelectCommand = command;
            table.Clear();
            adap.Fill(table);
            dataGrid.DataSource = table;
            foreach (DataGridViewColumn column in dataGrid.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            loadData(sqlQueryData);
        }

        private void LoadDataToComboBox()
        {
            string query = "SELECT MaDatPhong FROM Room";
            SqlCommand command = new SqlCommand(query, connect);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                cbPhong.Items.Add(reader["MaDatPhong"].ToString());
            }
            reader.Close();
        }

        private void cbPhong_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
