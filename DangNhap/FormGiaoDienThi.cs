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
namespace DangNhap
{
    public partial class FormGiaoDienThi : Form
    {
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-KJNF2QE\SQLEXPRESS;Initial Catalog=Exam;Integrated Security=True");
        public string msv;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label lbMin;
        private Label lbSec;
        private Label label12;
        private RichTextBox richTextBox1;
        private Label lbA;
        private Label lbB;
        private Label lbC;
        private Label lbD;
        private Label lbAnsA;
        private Label lbAnsB;
        private Label lbAnsC;
        private Label lbAnsD;
        private Timer timer1;
        private IContainer components;
        private TextBox textBox1;
        private Label label1;

        public FormGiaoDienThi()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbMin = new System.Windows.Forms.Label();
            this.lbSec = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lbA = new System.Windows.Forms.Label();
            this.lbB = new System.Windows.Forms.Label();
            this.lbC = new System.Windows.Forms.Label();
            this.lbD = new System.Windows.Forms.Label();
            this.lbAnsA = new System.Windows.Forms.Label();
            this.lbAnsB = new System.Windows.Forms.Label();
            this.lbAnsC = new System.Windows.Forms.Label();
            this.lbAnsD = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sinh viên: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 46);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ và tên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(145, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 46);
            this.label3.TabIndex = 2;
            this.label3.Text = "ht";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(184, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 46);
            this.label4.TabIndex = 3;
            this.label4.Text = "msv";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(650, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(208, 46);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngày sinh:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(650, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 46);
            this.label6.TabIndex = 5;
            this.label6.Text = "Môn thi:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(796, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 46);
            this.label7.TabIndex = 6;
            this.label7.Text = "ns";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1082, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(183, 40);
            this.label8.TabIndex = 7;
            this.label8.Text = "Thời Gian:";
            // 
            // lbMin
            // 
            this.lbMin.AutoSize = true;
            this.lbMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMin.Location = new System.Drawing.Point(1105, 69);
            this.lbMin.Name = "lbMin";
            this.lbMin.Size = new System.Drawing.Size(75, 40);
            this.lbMin.TabIndex = 9;
            this.lbMin.Text = "min";
            // 
            // lbSec
            // 
            this.lbSec.AutoSize = true;
            this.lbSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSec.Location = new System.Drawing.Point(1145, 69);
            this.lbSec.Name = "lbSec";
            this.lbSec.Size = new System.Drawing.Size(73, 40);
            this.lbSec.TabIndex = 10;
            this.lbSec.Text = "sec";
            this.lbSec.Click += new System.EventHandler(this.lbSec_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1130, 69);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 40);
            this.label12.TabIndex = 11;
            this.label12.Text = ":";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 128);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1011, 143);
            this.richTextBox1.TabIndex = 12;
            this.richTextBox1.Text = "";
            // 
            // lbA
            // 
            this.lbA.AutoSize = true;
            this.lbA.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbA.Location = new System.Drawing.Point(43, 288);
            this.lbA.Name = "lbA";
            this.lbA.Size = new System.Drawing.Size(48, 37);
            this.lbA.TabIndex = 13;
            this.lbA.Text = "A,";
            // 
            // lbB
            // 
            this.lbB.AutoSize = true;
            this.lbB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbB.Location = new System.Drawing.Point(43, 392);
            this.lbB.Name = "lbB";
            this.lbB.Size = new System.Drawing.Size(47, 37);
            this.lbB.TabIndex = 14;
            this.lbB.Text = "B,";
            // 
            // lbC
            // 
            this.lbC.AutoSize = true;
            this.lbC.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbC.Location = new System.Drawing.Point(43, 496);
            this.lbC.Name = "lbC";
            this.lbC.Size = new System.Drawing.Size(49, 37);
            this.lbC.TabIndex = 15;
            this.lbC.Text = "C,";
            // 
            // lbD
            // 
            this.lbD.AutoSize = true;
            this.lbD.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbD.Location = new System.Drawing.Point(43, 600);
            this.lbD.Name = "lbD";
            this.lbD.Size = new System.Drawing.Size(49, 37);
            this.lbD.TabIndex = 16;
            this.lbD.Text = "D,";
            // 
            // lbAnsA
            // 
            this.lbAnsA.AutoSize = true;
            this.lbAnsA.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAnsA.Location = new System.Drawing.Point(128, 287);
            this.lbAnsA.Name = "lbAnsA";
            this.lbAnsA.Size = new System.Drawing.Size(142, 37);
            this.lbAnsA.TabIndex = 17;
            this.lbAnsA.Text = "answerA";
            // 
            // lbAnsB
            // 
            this.lbAnsB.AutoSize = true;
            this.lbAnsB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAnsB.Location = new System.Drawing.Point(128, 392);
            this.lbAnsB.Name = "lbAnsB";
            this.lbAnsB.Size = new System.Drawing.Size(141, 37);
            this.lbAnsB.TabIndex = 18;
            this.lbAnsB.Text = "answerB";
            // 
            // lbAnsC
            // 
            this.lbAnsC.AutoSize = true;
            this.lbAnsC.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAnsC.Location = new System.Drawing.Point(128, 496);
            this.lbAnsC.Name = "lbAnsC";
            this.lbAnsC.Size = new System.Drawing.Size(143, 37);
            this.lbAnsC.TabIndex = 19;
            this.lbAnsC.Text = "answerC";
            // 
            // lbAnsD
            // 
            this.lbAnsD.AutoSize = true;
            this.lbAnsD.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAnsD.Location = new System.Drawing.Point(128, 600);
            this.lbAnsD.Name = "lbAnsD";
            this.lbAnsD.Size = new System.Drawing.Size(143, 37);
            this.lbAnsD.TabIndex = 20;
            this.lbAnsD.Text = "answerD";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox1.Location = new System.Drawing.Point(6, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1017, 120);
            this.textBox1.TabIndex = 21;
            // 
            // FormGiaoDienThi
            // 
            this.ClientSize = new System.Drawing.Size(1285, 787);
            this.Controls.Add(this.lbAnsD);
            this.Controls.Add(this.lbAnsC);
            this.Controls.Add(this.lbAnsB);
            this.Controls.Add(this.lbAnsA);
            this.Controls.Add(this.lbD);
            this.Controls.Add(this.lbC);
            this.Controls.Add(this.lbB);
            this.Controls.Add(this.lbA);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.lbSec);
            this.Controls.Add(this.lbMin);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox1);
            this.Name = "FormGiaoDienThi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormGiaoDienThi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public FormGiaoDienThi(string Message):this()
        {
            conn.Open();

            msv = Message;
            string sql = "select Ten,MaND,NgaySinh from NguoiDung where  MaND ='"+msv+"';";

            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dta = cmd.ExecuteReader();
            if (dta.Read()==true)
            {
                label3.Text=dta["Ten"].ToString();
                label4.Text=dta["MaND"].ToString();
                label7.Text=dta["NgaySinh"].ToString();
                timer1.Start();
            }
            conn.Close();
        }
        private void FormGiaoDienThi_Load(object sender, EventArgs e)
        {

        }
        int sec1 = 60;
        int min1 = 4;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sec1--;
            if (sec1 == 0)
            {
                min1--;
                sec1=60;
                sec1--;
            }

            if (min1 < 0)
            {
                timer1.Stop();
                MessageBox.Show("Hết giờ làm bài thi");
            }
            lbSec.Text= sec1.ToString();
            lbMin.Text= min1.ToString();
        }

        private void lbSec_Click(object sender, EventArgs e)
        {

        }
    }
}
