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
    public partial class quanlinhanvien : Form
    {
        public quanlinhanvien()
        {
            InitializeComponent();
        }
        SqlConnection con;
        public void Hienthi()
        {
            string sqlSELECT = "SELECT * FROM NHANVIEN";
            SqlCommand cmd = new SqlCommand(sqlSELECT, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            db1.DataSource = dt;

        }
        private void sua_Click(object sender, EventArgs e)
        {
            string sqlEdit = "UPDATE NHANVIEN SET HOTEN = @HOTEN,NGAYSINH = @NGAYSINH,BOPHAN = @BOPHAN,CHUCVU = @CHUCVU,GIOITINH = @GIOITINH WHERE MANV = @MANV";
            SqlCommand cmd = new SqlCommand(sqlEdit, con);
            cmd.Parameters.AddWithValue("MANV", manv.Text);
            cmd.Parameters.AddWithValue("HOTEN", ht.Text);
            cmd.Parameters.AddWithValue("NGAYSINH", ns.Text);
            cmd.Parameters.AddWithValue("BOPHAN", bp.Text);
            cmd.Parameters.AddWithValue("CHUCVU", cv.Text);
            cmd.Parameters.AddWithValue("GIOITINH", gt.Text);
            cmd.ExecuteNonQuery();
            Hienthi();
        }
        private void quanlinhanvien_Load(object sender, EventArgs e)
        {
            string connString = ConfigurationManager.ConnectionStrings["QUANLYTHUVIEN"].ConnectionString.ToString();
            con = new SqlConnection(connString);
            con.Open();
            Hienthi();
        }
        private void quanlinhanvien_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }

        private void them_Click(object sender, EventArgs e)
        {
            string sqlINSERT = "INSERT INTO NHANVIEN VALUES (@MANV , @HOTEN , @NGAYSINH , @BOPHAN , @CHUCVU , @GIOITINH )";
            SqlCommand cmd = new SqlCommand(sqlINSERT, con);
            cmd.Parameters.AddWithValue("MANV", manv.Text);
            cmd.Parameters.AddWithValue("HOTEN", ht.Text);
            cmd.Parameters.AddWithValue("NGAYSINH", ns.Text);
            cmd.Parameters.AddWithValue("BOPHAN", bp.Text);
            cmd.Parameters.AddWithValue("CHUCVU", cv.Text);
            cmd.Parameters.AddWithValue("GIOITINH", gt.Text);
            cmd.ExecuteNonQuery();
            Hienthi();
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            string sqlDELETE = "DELETE FROM NHANVIEN WHERE MANV = @MANV";
            SqlCommand cmd = new SqlCommand(sqlDELETE, con);
            cmd.Parameters.AddWithValue("MANV", manv.Text);
            cmd.Parameters.AddWithValue("HOTEN", ht.Text);
            cmd.Parameters.AddWithValue("NGAYSINH", ns.Text);
            cmd.Parameters.AddWithValue("BOPHAN", bp.Text);
            cmd.Parameters.AddWithValue("CHUCVU", cv.Text);
            cmd.Parameters.AddWithValue("GIOITINH", gt.Text);
            cmd.ExecuteNonQuery();
            Hienthi();
        }

        private void timkiem_Click(object sender, EventArgs e)
        {
            string sqltimkiem = "SELECT * FROM NHANVIEN WHERE MANV = @MANV";
            SqlCommand cmd = new SqlCommand(sqltimkiem, con);
            cmd.Parameters.AddWithValue("MANV", macantim.Text);
            cmd.Parameters.AddWithValue("HOTEN", ht.Text);
            cmd.Parameters.AddWithValue("NGAYSINH", ns.Text);
            cmd.Parameters.AddWithValue("BOPHAN", bp.Text);
            cmd.Parameters.AddWithValue("CHUCVU", cv.Text);
            cmd.Parameters.AddWithValue("GIOITINH", gt.Text);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            db1.DataSource = dt;
        }

        private void db1_Click(object sender, EventArgs e)
        {
            int curow = db1.CurrentRow.Index;
            manv.Text = db1.Rows[curow].Cells[0].Value.ToString();
            ht.Text = db1.Rows[curow].Cells[1].Value.ToString();
            ns.Text = db1.Rows[curow].Cells[2].Value.ToString();
            bp.Text = db1.Rows[curow].Cells[3].Value.ToString();
            cv.Text = db1.Rows[curow].Cells[4].Value.ToString();
            gt.Text = db1.Rows[curow].Cells[5].Value.ToString();
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
                MessageBox.Show("Mời tiếp tục chương trình!");

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void macantim_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void manv_TextChanged(object sender, EventArgs e)
        {

        }

        private void manhanvien_Click(object sender, EventArgs e)
        {

        }
    }
}
