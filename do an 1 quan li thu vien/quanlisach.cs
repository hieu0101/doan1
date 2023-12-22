using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace do_an_1_quan_li_thu_vien
{
    public partial class quanlisach : Form
    {
        public quanlisach()
        {
            InitializeComponent();
        }

        SqlConnection con;
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void quanlisach_Load(object sender, EventArgs e)
        {
            string conString = ConfigurationManager.ConnectionStrings["QUANLYTHUVIEN"].ConnectionString.ToString();
            con = new SqlConnection(conString);
            con.Open();
            Hienthi();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string sqlINSERT = "INSERT INTO SACH VALUES (@MASACH, @TENSACH, @TACGIA, @NGONNGU, @CHUYENNGANH, @SOLUONGSACH, @SOLUONGDAMUON , @SOLUONGCON, @NAMXUATBAN, @NHAXUATBAN )";
            SqlCommand cmd = new SqlCommand(sqlINSERT, con);
            cmd.Parameters.AddWithValue("MASACH", masach.Text);
            cmd.Parameters.AddWithValue("TENSACH", tensach.Text);
            cmd.Parameters.AddWithValue("TACGIA", tacgia.Text);
            cmd.Parameters.AddWithValue("NGONNGU", ngonngu.Text);
            cmd.Parameters.AddWithValue("CHUYENNGANH", cchuyennghanh.Text);
            cmd.Parameters.AddWithValue("SOLUONGSACH", soluongsach.Text);
            cmd.Parameters.AddWithValue("SOLUONGDAMUON", soluongdamuon.Text);
            cmd.Parameters.AddWithValue("SOLUONGCON", soluongcon.Text);
            cmd.Parameters.AddWithValue("NAMXUATBAN", namxuatban.Text);
            cmd.Parameters.AddWithValue("NHAXUATBAN", nhaxuatban.Text);
            cmd.ExecuteNonQuery();
            Hienthi();
        }

        private void quanlisach_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }

        public void Hienthi()
        {
            string sqlSELECT = "SELECT * FROM SACH";
            SqlCommand cmd = new SqlCommand(sqlSELECT, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string sqlEdit = "UPDATE SACH SET TENSACH = @TENSACH,TACGIA = @TACGIA,NGONNGU = @NGONNGU,CHUYENNGANH = @CHUYENNGANH,SOLUONGSACH = @SOLUONGSACH,SOLUONGDAMUON = @SOLUONGDAMUON ,SOLUONGCON = @SOLUONGCON, NAMXUATBAN = @NAMXUATBAN, NHAXUATBAN = @NHAXUATBAN WHERE MASACH = @MASACH ";
            SqlCommand cmd = new SqlCommand(sqlEdit, con);
            cmd.Parameters.AddWithValue("MASACH", masach.Text);
            cmd.Parameters.AddWithValue("TENSACH", tensach.Text);
            cmd.Parameters.AddWithValue("TACGIA", tacgia.Text);
            cmd.Parameters.AddWithValue("NGONNGU", ngonngu.Text);
            cmd.Parameters.AddWithValue("CHUYENNGANH", cchuyennghanh.Text);
            cmd.Parameters.AddWithValue("SOLUONGSACH", soluongsach.Text);
            cmd.Parameters.AddWithValue("SOLUONGDAMUON", soluongdamuon.Text);
            cmd.Parameters.AddWithValue("SOLUONGCON", soluongcon.Text);
            cmd.Parameters.AddWithValue("NAMXUATBAN", namxuatban.Text);
            cmd.Parameters.AddWithValue("NHAXUATBAN", nhaxuatban.Text);
            cmd.ExecuteNonQuery();
            Hienthi();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string sqlDELETE = "DELETE FROM SACH WHERE MASACH = @MASACH ";
            SqlCommand cmd = new SqlCommand(sqlDELETE, con);
            cmd.Parameters.AddWithValue("MASACH", masach.Text);
            cmd.Parameters.AddWithValue("TENSACH", tensach.Text);
            cmd.Parameters.AddWithValue("TACGIA", tacgia.Text);
            cmd.Parameters.AddWithValue("NGONNGU", ngonngu.Text);
            cmd.Parameters.AddWithValue("CHUYENNGANH", cchuyennghanh.Text);
            cmd.Parameters.AddWithValue("SOLUONGSACH", soluongsach.Text);
            cmd.Parameters.AddWithValue("SOLUONGDAMUON", soluongdamuon.Text);
            cmd.Parameters.AddWithValue("SOLUONGCON", soluongcon.Text);
            cmd.Parameters.AddWithValue("NAMXUATBAN", namxuatban.Text);
            cmd.Parameters.AddWithValue("NHAXUATBAN", nhaxuatban.Text);
            cmd.ExecuteNonQuery();
            Hienthi();
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string sqlTimkiem = "SELECT * FROM SACH WHERE MASACH = @MASACH ";
            SqlCommand cmd = new SqlCommand(sqlTimkiem, con);
            cmd.Parameters.AddWithValue("MASACH", timkiem.Text);
            cmd.Parameters.AddWithValue("TENSACH", tensach.Text);
            cmd.Parameters.AddWithValue("TACGIA", tacgia.Text);
            cmd.Parameters.AddWithValue("NGONNGU", ngonngu.Text);
            cmd.Parameters.AddWithValue("CHUYENNGANH", cchuyennghanh.Text);
            cmd.Parameters.AddWithValue("SOLUONGSACH", soluongsach.Text);
            cmd.Parameters.AddWithValue("SOLUONGDAMUON", soluongdamuon.Text);
            cmd.Parameters.AddWithValue("SOLUONGCON", soluongcon.Text);
            cmd.Parameters.AddWithValue("NAMXUATBAN", namxuatban.Text);
            cmd.Parameters.AddWithValue("NHAXUATBAN", nhaxuatban.Text);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            int curow = dataGridView1.CurrentRow.Index;
            masach.Text = dataGridView1.Rows[curow].Cells[0].Value.ToString();
            tensach.Text = dataGridView1.Rows[curow].Cells[1].Value.ToString();
            tacgia.Text = dataGridView1.Rows[curow].Cells[2].Value.ToString();
            ngonngu.Text = dataGridView1.Rows[curow].Cells[3].Value.ToString();
            cchuyennghanh.Text = dataGridView1.Rows[curow].Cells[4].Value.ToString();
            soluongsach.Text = dataGridView1.Rows[curow].Cells[5].Value.ToString();
            soluongdamuon.Text = dataGridView1.Rows[curow].Cells[6].Value.ToString();
            soluongcon.Text = dataGridView1.Rows[curow].Cells[7].Value.ToString();
            namxuatban.Text = dataGridView1.Rows[curow].Cells[8].Value.ToString();
            nhaxuatban.Text = dataGridView1.Rows[curow].Cells[9].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {
            groupBox1.BackColor = Color.FromArgb(60, Color.Silver);
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

