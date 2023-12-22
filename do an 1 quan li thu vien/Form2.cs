using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace do_an_1_quan_li_thu_vien
{
    public partial class quanlichung : Form
    {
        public quanlichung()
        {
            InitializeComponent();
        }

        private void quanlichung_Load(object sender, EventArgs e)
        {

        }

        private void ptb1_Click(object sender, EventArgs e)
        {

        }



        private void nhanvien_Click(object sender, EventArgs e)
        {
            quanlinhanvien s = new quanlinhanvien();
            this.Hide();
            s.ShowDialog();
            this.Show();
        }

        private void btndocgia_Click(object sender, EventArgs e)
        {
            qldocgia s = new qldocgia();
            this.Hide();
            s.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            quanlisach s = new quanlisach();
            this.Hide();
            s.ShowDialog();
            this.Show();
        }

        private void theodoimuontra_Click(object sender, EventArgs e)
        {
            theodoimuontra s = new theodoimuontra();
            this.Hide();
            s.ShowDialog();
            this.Show();
        }

        private void qlmuonsach_Click(object sender, EventArgs e)
        {
            qlmuonsach s = new qlmuonsach();
            this.Hide();
            s.ShowDialog();
            this.Show();
        }

        private void btnvipham_Click(object sender, EventArgs e)
        {
            qlvipham s = new qlvipham();
            this.Hide();
            s.ShowDialog();
            this.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            uudai s = new uudai();
            this.Hide();
            s.ShowDialog();
            this.Show();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            groupBox2.BackColor = Color.FromArgb(50, Color.Gray);
            

        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.BackColor = Color.FromArgb(80, Color.Silver);
        }

    }
}
