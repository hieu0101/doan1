using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace do_an_1_quan_li_thu_vien
{
    public partial class theodoimuontra : Form
    {
        SqlConnection con;
        public theodoimuontra()
        {
            InitializeComponent();
        }

        public void Hienthi()
        {
            string sqlSELECT = "SELECT * FROM THEODOIMUONTRA";
            SqlCommand cmd = new SqlCommand(sqlSELECT, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            db3.DataSource = dt;
        }

        private void theodoimuontra_Load(object sender, EventArgs e)
        {
            string conString = ConfigurationManager.ConnectionStrings["QUANLYTHUVIEN"].ConnectionString.ToString();
            con = new SqlConnection(conString);
            con.Open();
            Hienthi();
        }

        private void db3_Click(object sender, EventArgs e)
        {
            int curow = db3.CurrentRow.Index;
            mathe.Text = db3.Rows[curow].Cells[0].Value.ToString();
            masach.Text = db3.Rows[curow].Cells[1].Value.ToString();
            ngaymuon.Text = db3.Rows[curow].Cells[2].Value.ToString();
            ngaytra.Text = db3.Rows[curow].Cells[3].Value.ToString();
            tinhtrang.Text = db3.Rows[curow].Cells[4].Value.ToString();
            soluongmuon.Text = db3.Rows[curow].Cells[5].Value.ToString();
            soluongtra.Text = db3.Rows[curow].Cells[6].Value.ToString();
            conlai.Text = db3.Rows[curow].Cells[7].Value.ToString();
            
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            string sqlINSERT = "INSERT INTO THEODOIMUONTRA VALUES (@MATHE , @MASACH , @NGAYMUON , @NGAYTRA , @TINHTRANGSAUTRA , @SOLUONGMUON , @SOLUONGTRA, @CONLAI )";
            SqlCommand cmd = new SqlCommand(sqlINSERT, con);
            cmd.Parameters.AddWithValue("MATHE", mathe.Text);
            cmd.Parameters.AddWithValue("MASACH", masach.Text);
            cmd.Parameters.AddWithValue("NGAYMUON", ngaymuon.Text);
            cmd.Parameters.AddWithValue("NGAYTRA", ngaytra.Text);
            cmd.Parameters.AddWithValue("TINHTRANGSAUTRA", tinhtrang.Text);
            cmd.Parameters.AddWithValue("SOLUONGMUON", soluongmuon.Text);
            cmd.Parameters.AddWithValue("SOLUONGTRA", soluongtra.Text);
            cmd.Parameters.AddWithValue("CONLAI", conlai.Text);
            
            cmd.ExecuteNonQuery();
            Hienthi();
        }

        private void sua_Click(object sender, EventArgs e)
        {
            string sqledit = "UPDATE THEODOIMUONTRA SET  MASACH = @MASACH , NGAYMUON = @NGAYMUON , NGAYTRA = @NGAYTRA , TINHTRANGSAUTRA = @TINHTRANGSAUTRA , SOLUONGMUON = @SOLUONGMUON , SOLUONGTRA = @SOLUONGTRA, CONLAI = @CONLAI WHERE MATHE = @MATHE";
            SqlCommand cmd = new SqlCommand(sqledit, con);
            cmd.Parameters.AddWithValue("MATHE", mathe.Text);
            cmd.Parameters.AddWithValue("MASACH", masach.Text);
            cmd.Parameters.AddWithValue("NGAYMUON", ngaymuon.Text);
            cmd.Parameters.AddWithValue("NGAYTRA", ngaytra.Text);
            cmd.Parameters.AddWithValue("TINHTRANGSAUTRA", tinhtrang.Text);
            cmd.Parameters.AddWithValue("SOLUONGMUON", soluongmuon.Text);
            cmd.Parameters.AddWithValue("SOLUONGTRA", soluongtra.Text);
            cmd.Parameters.AddWithValue("CONLAI", conlai.Text);

            cmd.ExecuteNonQuery();
            Hienthi();
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            string sqlDELETE = "DELETE FROM THEODOIMUONTRA WHERE MATHE = @MATHE";
            SqlCommand cmd = new SqlCommand(sqlDELETE, con);
            cmd.Parameters.AddWithValue("MATHE", mathe.Text);
            cmd.Parameters.AddWithValue("MASACH", masach.Text);
            cmd.Parameters.AddWithValue("NGAYMUON", ngaymuon.Text);
            cmd.Parameters.AddWithValue("NGAYTRA", ngaytra.Text);
            cmd.Parameters.AddWithValue("TINHTRANGSAUTRA", tinhtrang.Text);
            cmd.Parameters.AddWithValue("SOLUONGMUON", soluongmuon.Text);
            cmd.Parameters.AddWithValue("SOLUONGTRA", soluongtra.Text);
            cmd.Parameters.AddWithValue("CONLAI", conlai.Text);
            cmd.ExecuteNonQuery();
            Hienthi();
        }

        private void bttimkiem_Click(object sender, EventArgs e)
        {
            string sqltimkiem = "SELECT * FROM THEODOIMUONTRA WHERE MATHE = @MATHE";
            SqlCommand cmd = new SqlCommand(sqltimkiem, con);
            cmd.Parameters.AddWithValue("MATHE", tk.Text);
            cmd.Parameters.AddWithValue("MASACH", masach.Text);
            cmd.Parameters.AddWithValue("NGAYMUON", ngaymuon.Text);
            cmd.Parameters.AddWithValue("NGAYTRA", ngaytra.Text);
            cmd.Parameters.AddWithValue("TINHTRANGSAUTRA", tinhtrang.Text);
            cmd.Parameters.AddWithValue("SOLUONGMUON", soluongmuon.Text);
            cmd.Parameters.AddWithValue("SOLUONGTRA", soluongtra.Text);
            cmd.Parameters.AddWithValue("CONLAI", conlai.Text);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            db3.DataSource = dt;
        }

        private void thoat_Click(object sender, EventArgs e)
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
        public void Xoa()
        {
            soluongmuon.Text = "";
            soluongtra.Text = "";
        }
        private void conlai_Click(object sender, EventArgs e)
        {
            try
            {
                soluongmuon.Text = (Convert.ToDouble(soluongmuon.Text)).ToString();
                soluongtra.Text = (Convert.ToDouble(soluongtra.Text)).ToString();
                conlai.Text = (Convert.ToDouble(soluongmuon) + Convert.ToDouble(soluongtra.Text)).ToString();
                Xoa();
            }
            catch
            {
                MessageBox.Show("Bạn đã nhập liệu sai", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void conlai_EnabledChanged(object sender, EventArgs e)
        {

        }
    }
}
