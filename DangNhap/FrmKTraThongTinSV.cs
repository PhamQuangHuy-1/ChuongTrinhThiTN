﻿using System;
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
    public partial class FrmKTraThongTinSV : Form
    {   //link database của Huy
        //SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-9GAKJV7\SQLEXPRESS01;Initial Catalog=Exam;Integrated Security=True");


        //link database của Hoàng
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-KJNF2QE\SQLEXPRESS;Initial Catalog=Exam;Integrated Security=True");

        public string tk;
        public string mk;
        public FrmKTraThongTinSV()
        {
            InitializeComponent();
        }

        public FrmKTraThongTinSV(string Message1, string Message2) : this()
        {
            conn.Open();
            tk = Message1;
            mk = Message2;
            string sql = "select Ten,MaND,NgaySinh from NguoiDung where  MaND ='"+tk+"' and Password= '"+mk+"';";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dta = cmd.ExecuteReader();
            if (dta.Read()==true)
            {
                label4.Text=dta["Ten"].ToString();
                label5.Text=dta["MaND"].ToString();
                label6.Text=dta["NgaySinh"].ToString();
            }
        }
      

        private void button1_Click_1(object sender, EventArgs e)
        {
            conn.Close();
            conn.Open();
            string msv = label5.Text;
            FormGiaoDienThi Child1 = new FormGiaoDienThi(label5.Text);
            string sql = "select Ten from NguoiDung where MaND ='"+tk+"' and Password= '"+mk+"';";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dta = cmd.ExecuteReader();

            while (dta.Read())
            {
                Child1.ShowDialog();

            }
            conn.Close();
        }
    }
}
