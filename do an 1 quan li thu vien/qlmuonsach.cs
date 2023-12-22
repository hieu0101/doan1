using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace do_an_1_quan_li_thu_vien
{
    public partial class qlmuonsach : Form
    {
        SqlConnection con;
        public void Hienthi()
        {
            string sqlSELECT = "SELECT * FROM MUONSACH";
            SqlCommand cmd = new SqlCommand(sqlSELECT, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            db4.DataSource = dt;
        }
        public qlmuonsach()
        {
            InitializeComponent();
        }

        private void qlmuonsach_Load(object sender, EventArgs e)
        {
            string conString = ConfigurationManager.ConnectionStrings["QUANLYTHUVIEN"].ConnectionString.ToString();
            con = new SqlConnection(conString);
            con.Open();
            Hienthi();
        }

        private void butthem_Click(object sender, EventArgs e)
        {
            string sqlINSERT = "INSERT INTO MUONSACH VALUES (@MASACH , @MATHE , @MANV , @SOLUONGMUON , @NGAYMUON , @NGAYHENTRA , @TINHTRANG )";
            SqlCommand cmd = new SqlCommand(sqlINSERT, con);
            cmd.Parameters.AddWithValue("MASACH", masach.Text);
            cmd.Parameters.AddWithValue("MATHE", mathe.Text);
            cmd.Parameters.AddWithValue("MANV", manhanvien.Text);
            cmd.Parameters.AddWithValue("SOLUONGMUON", soluongmuon.Text);
            cmd.Parameters.AddWithValue("NGAYMUON", ngaymuon.Text);
            cmd.Parameters.AddWithValue("NGAYHENTRA", ngayhentra.Text);
            cmd.Parameters.AddWithValue("TINHTRANG", tinhtrang.Text);
            cmd.ExecuteNonQuery();
            Hienthi();
        }

        private void butsua_Click(object sender, EventArgs e)
        {
            string sqledit = "UPDATE MUONSACH SET   SOLUONGMUON = @SOLUONGMUON , NGAYMUON = @NGAYMUON , NGAYHENTRA = @NGAYHENTRA , TINHTRANG = @TINHTRANG WHERE MASACH = @MASACH AND MATHE = @MATHE AND MANV = @MANV  ";
            SqlCommand cmd = new SqlCommand(sqledit, con);
            cmd.Parameters.AddWithValue("MASACH", masach.Text);
            cmd.Parameters.AddWithValue("MATHE", mathe.Text);
            cmd.Parameters.AddWithValue("MANV", manhanvien.Text);
            cmd.Parameters.AddWithValue("SOLUONGMUON", soluongmuon.Text);
            cmd.Parameters.AddWithValue("NGAYMUON", ngaymuon.Text);
            cmd.Parameters.AddWithValue("NGAYHENTRA", ngayhentra.Text);
            cmd.Parameters.AddWithValue("TINHTRANG", tinhtrang.Text);
            cmd.ExecuteNonQuery();
            Hienthi();
        }

        private void butxoa_Click(object sender, EventArgs e)
        {
            string sqldelete = "DELETE FROM MUONSACH WHERE MASACH = @MASACH AND MATHE = @MATHE AND MANV = @MANV  ";
            SqlCommand cmd = new SqlCommand(sqldelete, con);
            cmd.Parameters.AddWithValue("MASACH", masach.Text);
            cmd.Parameters.AddWithValue("MATHE", mathe.Text);
            cmd.Parameters.AddWithValue("MANV", manhanvien.Text);
            cmd.Parameters.AddWithValue("SOLUONGMUON", soluongmuon.Text);
            cmd.Parameters.AddWithValue("NGAYMUON", ngaymuon.Text);
            cmd.Parameters.AddWithValue("NGAYHENTRA", ngayhentra.Text);
            cmd.Parameters.AddWithValue("TINHTRANG", tinhtrang.Text);
            cmd.ExecuteNonQuery();
            Hienthi();
        }

        private void db4_Click(object sender, EventArgs e)
        {
            int curow = db4.CurrentRow.Index;
            masach.Text = db4.Rows[curow].Cells[0].Value.ToString();
            mathe.Text = db4.Rows[curow].Cells[1].Value.ToString();
            manhanvien.Text = db4.Rows[curow].Cells[2].Value.ToString();
            soluongmuon.Text = db4.Rows[curow].Cells[3].Value.ToString();
            ngaymuon.Text = db4.Rows[curow].Cells[4].Value.ToString();
            ngayhentra.Text = db4.Rows[curow].Cells[5].Value.ToString();
            tinhtrang.Text = db4.Rows[curow].Cells[6].Value.ToString();
           
        }

        private void butthoat_Click(object sender, EventArgs e)
        {
            DialogResult cc = MessageBox.Show(
              "Bạn chắc chắn muốn thoát?",
              "Confirm",
              MessageBoxButtons.YesNo,
              MessageBoxIcon.Warning);
            if (cc == DialogResult.Yes)
                Close();
            else if (cc == DialogResult.No)
                MessageBox.Show("Mời tiếp tục đăng nhập!");
        }

        
    }
}
