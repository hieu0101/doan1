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
    public partial class qldocgia : Form
    {
        public qldocgia()
        {
            InitializeComponent();
        }
        SqlConnection con;
        public void Hienthi()
        {
            string sqlSELECT = "SELECT * FROM THEDOCGIA";
            SqlCommand cmd = new SqlCommand(sqlSELECT, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            db2.DataSource = dt;
            int curow = db2.CurrentRow.Index;
            db2.Columns[0].Width = 60;
            db2.Columns[1].Width = 80;
            db2.Columns[3].Width = 60;
            db2.Columns[4].Width = 80;
            mathe.Text = db2.Rows[curow].Cells[0].Value.ToString();
            cccd.Text = db2.Rows[curow].Cells[1].Value.ToString();
            ho.Text = db2.Rows[curow].Cells[2].Value.ToString();
            ten.Text = db2.Rows[curow].Cells[3].Value.ToString();
            gioitinh.Text = db2.Rows[curow].Cells[4].Value.ToString();
            loaithe.Text = db2.Rows[curow].Cells[5].Value.ToString();
            ngaycapthe.Text = db2.Rows[curow].Cells[6].Value.ToString();
            ngayhethan.Text = db2.Rows[curow].Cells[7].Value.ToString();
            lanmuonthu.Text = db2.Rows[curow].Cells[8].Value.ToString();
            db2.AllowUserToAddRows = false;
            db2.EditMode = DataGridViewEditMode.EditProgrammatically;

        }
        private void qldocgia_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }

        private void qldocgia_Load(object sender, EventArgs e)
        {
            string conString = ConfigurationManager.ConnectionStrings["QUANLYTHUVIEN"].ConnectionString.ToString();
            con = new SqlConnection(conString);
            con.Open();
            Hienthi();
        }

        private void btnthemdg_Click(object sender, EventArgs e)
        {
            string sqlINSERT = "INSERT INTO THEDOCGIA VALUES (@MATHE , @CCCD , @HODEM , @TEN , @GIOITINH , @LOAITHE , @NGAYCAPTHE , @NGAYHETHAN , @LANMUONTHU )";
            SqlCommand cmd = new SqlCommand(sqlINSERT, con);
            cmd.Parameters.AddWithValue("MATHE", mathe.Text);
            cmd.Parameters.AddWithValue("CCCD", cccd.Text);
            cmd.Parameters.AddWithValue("HODEM", ho.Text);
            cmd.Parameters.AddWithValue("TEN", ten.Text);
            cmd.Parameters.AddWithValue("GIOITINH", gioitinh.Text);
            cmd.Parameters.AddWithValue("LOAITHE", loaithe.Text);
            cmd.Parameters.AddWithValue("NGAYCAPTHE", ngaycapthe.Text);
            cmd.Parameters.AddWithValue("NGAYHETHAN", ngayhethan.Text);
            cmd.Parameters.AddWithValue("LANMUONTHU", lanmuonthu.Text);
            cmd.ExecuteNonQuery();
            Hienthi();
        }

        private void btnsuadg_Click(object sender, EventArgs e)
        {
            string sqlEdit = "UPDATE THEDOCGIA SET CCCD = @CCCD , HODEM = @HODEM , TEN = @TEN , GIOITINH = @GIOITINH , LOAITHE = @LOAITHE , NGAYCAPTHE = @NGAYCAPTHE , NGAYHETHAN = @NGAYHETHAN , LANMUONTHU = @LANMUONTHU WHERE MATHE = @MATHE ";
            SqlCommand cmd = new SqlCommand(sqlEdit, con);
            cmd.Parameters.AddWithValue("MATHE", mathe.Text);
            cmd.Parameters.AddWithValue("CCCD", cccd.Text);
            cmd.Parameters.AddWithValue("HODEM", ho.Text);
            cmd.Parameters.AddWithValue("TEN", ten.Text);
            cmd.Parameters.AddWithValue("GIOITINH", gioitinh.Text);
            cmd.Parameters.AddWithValue("LOAITHE", loaithe.Text);
            cmd.Parameters.AddWithValue("NGAYCAPTHE", ngaycapthe.Text);
            cmd.Parameters.AddWithValue("NGAYHETHAN", ngayhethan.Text);
            cmd.Parameters.AddWithValue("LANMUONTHU", lanmuonthu.Text);
            cmd.ExecuteNonQuery();
            Hienthi();
        }

        private void btnxoadg_Click(object sender, EventArgs e)
        {
            string sqlDELETE = "DELETE FROM THEDOCGIA WHERE MATHE = @MATHE ";
            SqlCommand cmd = new SqlCommand(sqlDELETE, con);
            cmd.Parameters.AddWithValue("MATHE", mathe.Text);
            cmd.Parameters.AddWithValue("CCCD", cccd.Text);
            cmd.Parameters.AddWithValue("HODEM", ho.Text);
            cmd.Parameters.AddWithValue("TEN", ten.Text);
            cmd.Parameters.AddWithValue("GIOITINH", gioitinh.Text);
            cmd.Parameters.AddWithValue("LOAITHE", loaithe.Text);
            cmd.Parameters.AddWithValue("NGAYCAPTHE", ngaycapthe.Text);
            cmd.Parameters.AddWithValue("NGAYHETHAN", ngayhethan.Text);
            cmd.Parameters.AddWithValue("LANMUONTHU", lanmuonthu.Text);
            cmd.ExecuteNonQuery();
            Hienthi();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sqlTIMKIEM = "SELECT * FROM THEDOCGIA WHERE MATHE = @MATHE ";
            SqlCommand cmd = new SqlCommand(sqlTIMKIEM, con);
            cmd.Parameters.AddWithValue("MATHE", timkiemdg.Text);
            cmd.Parameters.AddWithValue("CCCD", cccd.Text);
            cmd.Parameters.AddWithValue("HODEM", ho.Text);
            cmd.Parameters.AddWithValue("TEN", ten.Text);
            cmd.Parameters.AddWithValue("GIOITINH", gioitinh.Text);
            cmd.Parameters.AddWithValue("LOAITHE", loaithe.Text);
            cmd.Parameters.AddWithValue("NGAYCAPTHE", ngaycapthe.Text);
            cmd.Parameters.AddWithValue("NGAYHETHAN", ngayhethan.Text);
            cmd.Parameters.AddWithValue("LANMUONTHU", lanmuonthu.Text);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            db2.DataSource = dt;

        }

        private void qldocgia_Click(object sender, EventArgs e)
        {

        }

        /*private void db2_Click(object sender, EventArgs e)
        {
            int curow = db2.CurrentRow.Index;
            db2.Columns[0].Width = 60;
            db2.Columns[1].Width = 80;
            db2.Columns[3].Width = 60;
            db2.Columns[4].Width = 80;
            mathe.Text = db2.Rows[curow].Cells[0].Value.ToString();
            cccd.Text = db2.Rows[curow].Cells[1].Value.ToString();
            ho.Text = db2.Rows[curow].Cells[2].Value.ToString();
            ten.Text = db2.Rows[curow].Cells[3].Value.ToString();
            gioitinh.Text = db2.Rows[curow].Cells[4].Value.ToString();
            loaithe.Text = db2.Rows[curow].Cells[5].Value.ToString();
            ngaycapthe.Text = db2.Rows[curow].Cells[6].Value.ToString();
            ngayhethan.Text = db2.Rows[curow].Cells[7].Value.ToString();
            lanmuonthu.Text = db2.Rows[curow].Cells[8].Value.ToString();
            db2.AllowUserToAddRows = false;
            db2.EditMode = DataGridViewEditMode.EditProgrammatically;
        }*/

        private void btnthoatdg_Click(object sender, EventArgs e)
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ten_TextChanged(object sender, EventArgs e)
        {

        }

        private void loaithe_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void timkiemdg_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
