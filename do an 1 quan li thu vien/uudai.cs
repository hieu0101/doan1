using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace do_an_1_quan_li_thu_vien
{
    public partial class uudai : Form
    {
        SqlConnection con;
        public void Hienthi()
        {
            string sqlSELECT = "SELECT * FROM UUDAIDOCGIA";
            SqlCommand cmd = new SqlCommand(sqlSELECT, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            db6.DataSource = dt;
        }
        public uudai()
        {
            InitializeComponent();
        }

        private void uudai_Load(object sender, EventArgs e)
        {
            string conString = ConfigurationManager.ConnectionStrings["QUANLYTHUVIEN"].ConnectionString.ToString();
            con = new SqlConnection(conString);
            con.Open();
            Hienthi();
        }

        private void tonthem_Click(object sender, EventArgs e)
        {
            string sqlINSERT = "INSERT INTO UUDAIDOCGIA VALUES (@MAUUDAI , @MATHE , @MANV , @GOIUUDAI)";
            SqlCommand cmd = new SqlCommand(sqlINSERT, con);
            cmd.Parameters.AddWithValue("MAUUDAI", mauudai.Text);
            cmd.Parameters.AddWithValue("MATHE", mathe.Text);
            cmd.Parameters.AddWithValue("MANV", manhanvien.Text);
            cmd.Parameters.AddWithValue("GOIUUDAI", goiuudai.Text);
            cmd.ExecuteNonQuery();
            Hienthi();
        }

        private void db6_Click(object sender, EventArgs e)
        {
            int curow = db6.CurrentRow.Index;
            mauudai.Text = db6.Rows[curow].Cells[0].Value.ToString();
            mathe.Text = db6.Rows[curow].Cells[1].Value.ToString();
            manhanvien.Text = db6.Rows[curow].Cells[2].Value.ToString();
            goiuudai.Text = db6.Rows[curow].Cells[3].Value.ToString();
        }

        private void tonsua_Click(object sender, EventArgs e)
        {
            string sqledit = "UPDATE UUDAIDOCGIA SET  MATHE = @MATHE , MANV = @MANV , GOIUUDAI = @GOIUUDAI WHERE MAUUDAI = @MAUUDAI";
            SqlCommand cmd = new SqlCommand(sqledit, con);
            cmd.Parameters.AddWithValue("MAUUDAI", mauudai.Text);
            cmd.Parameters.AddWithValue("MATHE", mathe.Text);
            cmd.Parameters.AddWithValue("MANV", manhanvien.Text);
            cmd.Parameters.AddWithValue("GOIUUDAI", goiuudai.Text);
            cmd.ExecuteNonQuery();
            Hienthi();
        }


        private void tonxoa_Click(object sender, EventArgs e)
        {
            string sqlxoa = "DELETE FROM UUDAIDOCGIA WHERE MAUUDAI = @MAUUDAI";
            SqlCommand cmd = new SqlCommand(sqlxoa, con);
            cmd.Parameters.AddWithValue("MAUUDAI", mauudai.Text);
            cmd.Parameters.AddWithValue("MATHE", mathe.Text);
            cmd.Parameters.AddWithValue("MANV", manhanvien.Text);
            cmd.Parameters.AddWithValue("GOIUUDAI", goiuudai.Text);
            cmd.ExecuteNonQuery();
            Hienthi();
        }

        private void tonthoat_Click(object sender, EventArgs e)
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
