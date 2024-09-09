using System.Drawing;
using System.Windows.Forms;
namespace WinFormsApp1
{
    partial class LapPhieuDatPhong
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            groupBox2 = new GroupBox();
            textBox13 = new TextBox();
            label7 = new Label();
            textBox14 = new TextBox();
            label16 = new Label();
            textBox15 = new TextBox();
            textBox16 = new TextBox();
            textBox17 = new TextBox();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            groupBox1 = new GroupBox();
            textBox12 = new TextBox();
            label6 = new Label();
            button1 = new Button();
            tabPage2 = new TabPage();
            button2 = new Button();
            groupBox3 = new GroupBox();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            groupBox4 = new GroupBox();
            textBox10 = new TextBox();
            label12 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(739, 427);
            tabControl1.TabIndex = 16;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Controls.Add(button1);
            tabPage1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(731, 399);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Khách hàng";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox13);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(textBox14);
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(textBox15);
            groupBox2.Controls.Add(textBox16);
            groupBox2.Controls.Add(textBox17);
            groupBox2.Controls.Add(label17);
            groupBox2.Controls.Add(label18);
            groupBox2.Controls.Add(label19);
            groupBox2.Location = new Point(388, 21);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(308, 240);
            groupBox2.TabIndex = 31;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin phòng";
            // 
            // textBox13
            // 
            textBox13.Location = new Point(112, 22);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(149, 23);
            textBox13.TabIndex = 29;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(17, 25);
            label7.Name = "label7";
            label7.Size = new Size(82, 15);
            label7.TabIndex = 28;
            label7.Text = "Mã đặt phòng";
            // 
            // textBox14
            // 
            textBox14.Location = new Point(112, 51);
            textBox14.Name = "textBox14";
            textBox14.Size = new Size(149, 23);
            textBox14.TabIndex = 21;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(17, 54);
            label16.Name = "label16";
            label16.Size = new Size(67, 15);
            label16.TabIndex = 16;
            label16.Text = "Loại phòng";
            // 
            // textBox15
            // 
            textBox15.Location = new Point(112, 147);
            textBox15.Multiline = true;
            textBox15.Name = "textBox15";
            textBox15.Size = new Size(149, 78);
            textBox15.TabIndex = 25;
            // 
            // textBox16
            // 
            textBox16.Location = new Point(112, 115);
            textBox16.Name = "textBox16";
            textBox16.Size = new Size(149, 23);
            textBox16.TabIndex = 24;
            // 
            // textBox17
            // 
            textBox17.Location = new Point(112, 80);
            textBox17.Name = "textBox17";
            textBox17.Size = new Size(149, 23);
            textBox17.TabIndex = 23;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(17, 150);
            label17.Name = "label17";
            label17.Size = new Size(78, 15);
            label17.TabIndex = 20;
            label17.Text = "Yêu cầu riêng";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(17, 83);
            label18.Name = "label18";
            label18.Size = new Size(85, 15);
            label18.TabIndex = 18;
            label18.Text = "Số đêm lưu trú";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(17, 118);
            label19.Name = "label19";
            label19.Size = new Size(47, 15);
            label19.TabIndex = 19;
            label19.Text = "Đặt cọc";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox12);
            groupBox1.Controls.Add(label6);
            groupBox1.Location = new Point(18, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(309, 69);
            groupBox1.TabIndex = 30;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin khách hàng";
            // 
            // textBox12
            // 
            textBox12.Location = new Point(112, 22);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(149, 23);
            textBox12.TabIndex = 29;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 25);
            label6.Name = "label6";
            label6.Size = new Size(89, 15);
            label6.TabIndex = 28;
            label6.Text = "Mã khách hàng";
            // 
            // button1
            // 
            button1.Location = new Point(622, 339);
            button1.Name = "button1";
            button1.Size = new Size(89, 39);
            button1.TabIndex = 27;
            button1.Text = "Lập";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(groupBox3);
            tabPage2.Controls.Add(groupBox4);
            tabPage2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(731, 399);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Đoàn khách";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(622, 339);
            button2.Name = "button2";
            button2.Size = new Size(89, 39);
            button2.TabIndex = 34;
            button2.Text = "Lập";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBox2);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(textBox7);
            groupBox3.Controls.Add(textBox8);
            groupBox3.Controls.Add(textBox9);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label11);
            groupBox3.Location = new Point(389, 22);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(308, 240);
            groupBox3.TabIndex = 33;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thông tin phòng";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(112, 22);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(149, 23);
            textBox2.TabIndex = 29;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 25);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 28;
            label2.Text = "Mã đặt phòng";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(112, 124);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(149, 78);
            textBox7.TabIndex = 25;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(112, 92);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(149, 23);
            textBox8.TabIndex = 24;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(112, 57);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(149, 23);
            textBox9.TabIndex = 23;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(17, 127);
            label9.Name = "label9";
            label9.Size = new Size(78, 15);
            label9.TabIndex = 20;
            label9.Text = "Yêu cầu riêng";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(17, 60);
            label10.Name = "label10";
            label10.Size = new Size(85, 15);
            label10.TabIndex = 18;
            label10.Text = "Số đêm lưu trú";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(17, 95);
            label11.Name = "label11";
            label11.Size = new Size(47, 15);
            label11.TabIndex = 19;
            label11.Text = "Đặt cọc";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(textBox10);
            groupBox4.Controls.Add(label12);
            groupBox4.Location = new Point(20, 22);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(309, 60);
            groupBox4.TabIndex = 32;
            groupBox4.TabStop = false;
            groupBox4.Text = "Thông tin đoàn khách";
            // 
            // textBox10
            // 
            textBox10.Location = new Point(112, 22);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(149, 23);
            textBox10.TabIndex = 29;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(17, 25);
            label12.Name = "label12";
            label12.Size = new Size(89, 15);
            label12.TabIndex = 28;
            label12.Text = "Mã đoàn khách";
            // 
            // Form1
            // 
            CausesValidation = false;
            ClientSize = new Size(739, 427);
            Controls.Add(tabControl1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "Form1";
            Text = "Phiếu đặt phòng";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button button1;
        private TabPage tabPage2;
        private TextBox textBox12;
        private Label label6;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox textBox13;
        private Label label7;
        private TextBox textBox14;
        private Label label16;
        private TextBox textBox15;
        private TextBox textBox16;
        private TextBox textBox17;
        private Label label17;
        private Label label18;
        private Label label19;
        private GroupBox groupBox3;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox9;
        private Label label9;
        private Label label10;
        private Label label11;
        private GroupBox groupBox4;
        private TextBox textBox10;
        private Label label12;
        private Button button2;
    }
}