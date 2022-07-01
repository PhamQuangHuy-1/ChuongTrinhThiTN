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
    public partial class FrmShowDiem : Form
    {   //link database của Huy
        //SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-9GAKJV7\SQLEXPRESS01;Initial Catalog=Exam;Integrated Security=True");

        //link database của Hoàng
        //SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-KJNF2QE\SQLEXPRESS;Initial Catalog=Exam;Integrated Security=True");

        //Link Database Cuyên
        SqlConnection conn = new SqlConnection(@"Data Source = CUYEN\CUYEN; Initial Catalog = ExamData; Integrated Security = True");

        SqlDataAdapter da1 = new SqlDataAdapter();
        DataTable dt1 = new DataTable();
        string MND;
      
        public FrmShowDiem()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public FrmShowDiem(string Message) : this()
        {
            MND= Message;                     
            conn.Open();
            string diem = "select count(TraLoi) as 'So Diem' from BaiLam, CauHoi where BaiLam.MaCH= CauHoi.MaCH and BaiLam.TraLoi=CauHoi.DapAn and 'So Diem' is not null and MaND ='"+MND+"'; ";
            da1 = new SqlDataAdapter(diem, conn);
            dt1 = new DataTable();
            dt1.Clear();
            da1.Fill(dt1);
            grdData3.DataSource= dt1;
            label2.Text= grdData3.Rows[0].Cells["So Diem"].Value.ToString();


            //string updatediem = "select SoDiem from KetQua where MaND= '"+MND+"' ";
            //cmd1 = conn.CreateCommand();
            //cmd1.CommandText= updatediem;
            //cmd1.ExecuteScalar();
            //label2.Text=cmd1.CommandText.ToString();
        }
        private void FrmShowDiem_Load(object sender, EventArgs e)
        {
           
        }
    }
}
