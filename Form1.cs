using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace VduKetNoiCSDL
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            con = new SqlConnection();
            con.ConnectionString = "Data Source = DESKTOP-JKBLUG3\\SQLEXPRESS;" +
                                   "Initial Catalog = QuanLyBanHang;" +
                                   "Integrated Security = True";
            try
            {
                con.Open();
                MessageBox.Show("Kết nối cơ sở dữ liệu thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kết nối cơ sở dữ liệu thất bại" + ex.ToString());
            }
        }

        private void insertMultirow_Click(object sender, EventArgs e)
        {
            int i = 1;
            try
            {
                for (i = 1; i <= 1000; i++)
                {
                    string sql = "insert into chatlieu values ('" + i.ToString() + "', N'bong gon loai')";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("insert du lieu thanh cong");
            }
            catch (Exception ex)
            {
                MessageBox.Show("loi" + ex.ToString());
            }

        }
        

    }
}
