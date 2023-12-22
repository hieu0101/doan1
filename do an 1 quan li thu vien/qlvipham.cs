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
    public partial class qlvipham : Form
    {
        SqlConnection con;
        public void Hienthi()
        {
            string sqlSELECT = "SELECT * FROM THUTIENPHAT";
            SqlCommand cmd = new SqlCommand(sqlSELECT, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            db5.DataSource = dt;
        }
        public qlvipham()
        {
            InitializeComponent();
        }

        private void qlvipham_Load(object sender, EventArgs e)
        {
            string conString = ConfigurationManager.ConnectionStrings["QUANLYTHUVIEN"].ConnectionString.ToString();
            con = new SqlConnection(conString);
            con.Open();
            Hienthi();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sqlINSERT = "INSERT INTO THUTIENPHAT VALUES (@MAPHIEUTHU , @MATHE , @MASACH , @SOTIENPHAT , @SOTIENTHU , @CONLAI , @MANV , @LYDOPHAT ";
            SqlCommand cmd = new SqlCommand(sqlINSERT, con);
            cmd.Parameters.AddWithValue("MAPHIEUTHU", maphieuthu.Text);
            cmd.Parameters.AddWithValue("MATHE", mathe.Text);
            cmd.Parameters.AddWithValue("MASACH", masach.Text);
            cmd.Parameters.AddWithValue("SOTIENPHAT", tienphat.Text);
            cmd.Parameters.AddWithValue("SOTIENTHU", tienthu.Text);
            cmd.Parameters.AddWithValue("CONLAI", conlai.Text);
            cmd.Parameters.AddWithValue("MANV", manv.Text);
            cmd.Parameters.AddWithValue("LYDOPHAT", lidophat.Text);
            cmd.ExecuteNonQuery();
            Hienthi();
        }

        private void db5_Click(object sender, EventArgs e)
        {

            int curow = db5.CurrentRow.Index;
            maphieuthu.Text = db5.Rows[curow].Cells[0].Value.ToString();
            mathe.Text = db5.Rows[curow].Cells[1].Value.ToString();
            masach.Text = db5.Rows[curow].Cells[2].Value.ToString();
            tienphat.Text = db5.Rows[curow].Cells[3].Value.ToString();
            tienthu.Text = db5.Rows[curow].Cells[4].Value.ToString();
            conlai.Text = db5.Rows[curow].Cells[5].Value.ToString();
            manv.Text = db5.Rows[curow].Cells[6].Value.ToString();
            lidophat.Text = db5.Rows[curow].Cells[7].Value.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sqledit = "UPDATE THUTIENPHAT SET MATHE = @MATHE , MASACH = @MASACH , SOTIENPHAT = @SOTIENPHAT , SOTIENTHU = @SOTIENTHU , CONLAI = @CONLAI , MANV = @MANV , LYDOPHAT = @LYDOPHAT WHERE MAPHIEUTHU = @MAPHIEUTHU";
            SqlCommand cmd = new SqlCommand(sqledit, con);
            cmd.Parameters.AddWithValue("MAPHIEUTHU", maphieuthu.Text);
            cmd.Parameters.AddWithValue("MATHE", mathe.Text);
            cmd.Parameters.AddWithValue("MASACH", masach.Text);
            cmd.Parameters.AddWithValue("SOTIENPHAT", tienphat.Text);
            cmd.Parameters.AddWithValue("SOTIENTHU", tienthu.Text);
            cmd.Parameters.AddWithValue("CONLAI", conlai.Text);
            cmd.Parameters.AddWithValue("MANV", manv.Text);
            cmd.Parameters.AddWithValue("LYDOPHAT", lidophat.Text);
            cmd.ExecuteNonQuery();
            Hienthi();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sqlDELETE = "DELETE FROM THUTIENPHAT WHERE MAPHIEUTHU = @MAPHIEUTHU";
            SqlCommand cmd = new SqlCommand(sqlDELETE, con);
            cmd.Parameters.AddWithValue("MAPHIEUTHU", maphieuthu.Text);
            cmd.Parameters.AddWithValue("MATHE", mathe.Text);
            cmd.Parameters.AddWithValue("MASACH", masach.Text);
            cmd.Parameters.AddWithValue("SOTIENPHAT", tienphat.Text);
            cmd.Parameters.AddWithValue("SOTIENTHU", tienthu.Text);
            cmd.Parameters.AddWithValue("CONLAI", conlai.Text);
            cmd.Parameters.AddWithValue("MANV", manv.Text);
            cmd.Parameters.AddWithValue("LYDOPHAT", lidophat.Text);
            cmd.ExecuteNonQuery();
            Hienthi();
        }

        private void button4_Click(object sender, EventArgs e)
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

        private void tienphat_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            groupBox2.BackColor = Color.FromArgb(60, Color.Gray);
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
