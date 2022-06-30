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
    public partial class FrmKQuaThi : Form
    {   //link database của Huy
        //SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-9GAKJV7\SQLEXPRESS01;Initial Catalog=Exam;Integrated Security=True");


        //link database của Hoàng
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-KJNF2QE\SQLEXPRESS;Initial Catalog=Exam;Integrated Security=True");
        SqlDataAdapter da3 = new SqlDataAdapter();
        SqlDataAdapter da4 = new SqlDataAdapter();
        DataTable dt3 = new DataTable();
        DataTable dt4 = new DataTable();

        int i;
        public FrmKQuaThi()
        {
            InitializeComponent();
        }

        private void FrmKQuaThi_Load(object sender, EventArgs e)
        {
            conn.Open();
            string h = "select * from KetQua ";
            da3 = new SqlDataAdapter(h, conn);
            dt3 = new DataTable();
            dt3.Clear();
            da3.Fill(dt3);
            grdData5.DataSource= dt3;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            i=grdData5.CurrentRow.Index;
            conn.Close();
            conn.Open();
            string h = "select MaBL, MaND, ExamID, BaiLam.MaCH, TraLoi, DapAn from BaiLam,CauHoi where BaiLam.MaCH=CauHoi.MaCH and MaND= '"+ grdData5.Rows[i].Cells["MaND"].Value.ToString() +"' and TraLoi is not null ";
            da4 = new SqlDataAdapter(h, conn);
            dt4 = new DataTable();
            dt4.Clear();
            da4.Fill(dt4);
            grdData6.DataSource= dt4;
            button4.Visible=true;
            button2.Visible=false;
            button3.Visible=false;
            grdData5.Hide();
            

        }

        private void button4_Click(object sender, EventArgs e)
        {

            grdData5.Show();
            button4.Visible=false;
            button2.Visible=true;
            button3.Visible=true;
        }

       
    }
}
