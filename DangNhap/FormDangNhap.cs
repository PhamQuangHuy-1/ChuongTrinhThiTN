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
    public partial class FormDangNhap : Form
    {
        //link database của Huy
        //SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-9GAKJV7\SQLEXPRESS01;Initial Catalog=Exam;Integrated Security=True");

         
        //link database của Hoàng
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-KJNF2QE\SQLEXPRESS;Initial Catalog=Exam;Integrated Security=True");

        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void llblQuenmk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            

        }

        private void llblDangky_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btDangnhap_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string tk = txtTentk.Text;
                string mk = txtMatkhau.Text;
                Frmmain f = new Frmmain();
                FrmKTraThongTinSV d = new FrmKTraThongTinSV(txtTentk.Text, txtMatkhau.Text);
                string sql = "Select MaQND, MaND, Password from NguoiDung where MaND= '"+tk+"'and Password= '"+mk+"';";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dta= cmd.ExecuteReader();
                if (dta.Read()==true) 
                {
                    string l = dta["MaQND"].ToString();
                    if (l == "1")
                    {
                        d.Show();
                    }
                    else  
                    {
                        f.Show ();
                    }
                }
                else 
                {
                    MessageBox.Show("Đăng nhập thất bại!");
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Lỗi kết nối");
            }
            this.Hide();
        }

        private void txtTentk_TextChanged(object sender, EventArgs e)
        {

        }
    }   
}
