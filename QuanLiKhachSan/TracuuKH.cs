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
using tracuukh;

namespace Khtracuu
{
    public partial class FormTC : Form
    {
        string selectQueryDataKH = "Select * from KhachHang";
        string selectQueryDataDK = "Select * from DoanKhach";
        SqlConnection connect;
        SqlCommand command;
        string str = @"Data Source=DESKTOP-6DQI5MG\SQLEXPRESS;Initial Catalog=HT_QuanLyKhachSan;Integrated Security=True";
        SqlDataAdapter adap = new SqlDataAdapter();
        DataTable table = new DataTable();

        public FormTC()
        {
            InitializeComponent();
            connect = new SqlConnection(str);
            connect.Open();
            tabControl1.SelectedIndex = 0;
            loadDataKH(selectQueryDataKH);
            
        }


        void loadDataKH(string selectQueryData)
        {
            command = connect.CreateCommand();
            command.CommandText = selectQueryData;
            adap.SelectCommand = command;
            table.Clear();
            adap.Fill(table);
            khGrid.DataSource = table;
            string[] headerTexts = new string[] { "Mã khách hàng", "Họ Tên", "SĐT", "FAX", "Email" };
            for (int i = 0; i < khGrid.Columns.Count; i++)
            {
                khGrid.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                if (i < headerTexts.Length)
                {
                    khGrid.Columns[i].HeaderText = headerTexts[i];
                }
            }
            khGrid.ReadOnly = true;
        }

        void loadDataDK(string sqlQueryData)
        {
            DataTable table2 = new DataTable();
            command = connect.CreateCommand();
            command.CommandText = sqlQueryData;
            adap.SelectCommand = command;
            table.Clear();
            adap.Fill(table2);
            dkGrid.DataSource = table2;
            string[] headerText = { "Mã Đoàn", "Tên Đoàn", "Tên Đại Diện", "SĐT", "Số Lượng" };
            for (int i = 0; i < dkGrid.Columns.Count; i++)
            {
                dkGrid.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                if (i < headerText.Length)
                {
                    dkGrid.Columns[i].HeaderText = headerText[i];
                }
            }
            dkGrid.ReadOnly = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            khGrid.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFindKh_Click_1(object sender, EventArgs e)
        {
            string[] proper = { "MaKH", "HoTen", "SDT", "Fax", "Email" };
            TextBox[] textBoxes = { maKH, ten, sdt, fax, email };
            string query = "SELECT * FROM KhachHang";
            bool firstChecked = true;
            for (int i = 0; i < proper.Length; i++)
            {
                if (!string.IsNullOrEmpty(textBoxes[i].Text))
                {
                    if (firstChecked == true)
                    {
                        query += " WHERE " + proper[i] + " LIKE N'%" + textBoxes[i].Text + "%'";
                        firstChecked = false;
                    }
                    else
                    {
                        query += " AND " + proper[i] + " LIKE N'%" + textBoxes[i].Text + "%'";
                    }
                }
            }
            loadDataKH(query);
        }

        private void btnDataALL_Click(object sender, EventArgs e)
        {
            loadDataKH(selectQueryDataKH);
            TextBox[] textBoxes = { maKH, ten, sdt, fax, email };
            for (int i = 0; i < textBoxes.Length; i++)
            {
                textBoxes[i].Text = "";
            }
        }
       

        private void khGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dkGrid.ReadOnly = true;
        }

      
        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFindDK_Click_1(object sender, EventArgs e)
        {
            string[] proper = { "MaDoan", "TenDoan", "TenNguoiDaiDien", "SDT", "SoLuong" };
            TextBox[] textbox = { maDoan, tenDoan, ngDien, sdt, soLuong };
            string query = "Select * From DoanKhach";
            bool firstCheck = true;
            for (int i = 0; i < proper.Length; i++)
            {
                if (!string.IsNullOrEmpty(textbox[i].Text))
                {
                    if (firstCheck == true)
                    {
                        query += " Where " + proper[i] + " Like N'%" + textbox[i].Text + "%'";
                        firstCheck = false;
                    }
                    else
                    {
                        query += " And " + proper[i] + " Like N'%" + textbox[i].Text + "%'";
                    }
                }
            }
            loadDataDK(query);
        }

        private void btnALLData_Click(object sender, EventArgs e)
        {
            loadDataDK(selectQueryDataDK);
        }

        private void tabControl1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage1)
            {
                loadDataKH(selectQueryDataKH);
                xoadulieu(false);


            }
            else if (tabControl1.SelectedTab == tabPage2)
            {
                loadDataDK(selectQueryDataDK);
                xoadulieu(true);

            }
        }

        public void xoadulieu(bool kh)
        {
            if (kh)
            {
                maKH.Text = "";
                ten.Text = "";
                sdt.Text = "";
                fax.Text = "";
                email.Text = "";
            }
            else
            {
                maDoan.Text = "";
                tenDoan.Text = "";
                ngDien.Text = "";
                sdt.Text = "";
                soLuong.Text = "";
            }
        }
        private void btnALLData_Click_1(object sender, EventArgs e)
        {
            loadDataDK(selectQueryDataDK);
            xoadulieu(false);

        }

        private void btnDataALLKH_Click(object sender, EventArgs e)
        {
            loadDataKH(selectQueryDataKH);
            xoadulieu(true);
           
        }

        private void khGrid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string maKH = khGrid.Rows[e.RowIndex].Cells["MaKH"].Value.ToString();
            string query = "SELECT soLan FROM KhachSuDungDichVu WHERE MaKH = '" + maKH + "'";
            SqlDataAdapter adap = new SqlDataAdapter(query, connect);
            DataTable table = new DataTable();
            adap.Fill(table);

            if (table.Rows.Count > 0 && (int)table.Rows[0]["soLan"] != 0)
            {
                Form formKHDV = new khDV(maKH,true);
                formKHDV.Show();
            }
            else
            {
                MessageBox.Show("Khách hàng không sử dụng dịch vụ nào.");
            }
        }

        private void dkGrid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string maDoan = dkGrid.Rows[e.RowIndex].Cells["MaDoan"].Value.ToString();
            Form formKHDV = new khDV(maDoan, false);
            formKHDV.Show();
        }
    }
}
