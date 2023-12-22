namespace do_an_1_quan_li_thu_vien
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dangnhap = new Button();
            thoat = new Button();
            taikhoan = new Label();
            matkhau = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            panel1 = new Panel();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dangnhap
            // 
            dangnhap.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dangnhap.ForeColor = Color.Black;
            dangnhap.Location = new Point(31, 508);
            dangnhap.Margin = new Padding(4);
            dangnhap.Name = "dangnhap";
            dangnhap.Size = new Size(222, 46);
            dangnhap.TabIndex = 0;
            dangnhap.Text = "Đăng nhập";
            dangnhap.UseVisualStyleBackColor = true;
            dangnhap.Click += dangnhap_Click;
            // 
            // thoat
            // 
            thoat.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            thoat.ForeColor = Color.Black;
            thoat.Location = new Point(252, 508);
            thoat.Margin = new Padding(4);
            thoat.Name = "thoat";
            thoat.Size = new Size(208, 46);
            thoat.TabIndex = 0;
            thoat.Text = "Thoát";
            thoat.UseVisualStyleBackColor = true;
            thoat.Click += thoat_Click;
            // 
            // taikhoan
            // 
            taikhoan.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            taikhoan.BackColor = Color.DimGray;
            taikhoan.BorderStyle = BorderStyle.FixedSingle;
            taikhoan.Font = new Font("Microsoft JhengHei", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            taikhoan.ForeColor = Color.WhiteSmoke;
            taikhoan.Location = new Point(20, 341);
            taikhoan.Margin = new Padding(4, 0, 4, 0);
            taikhoan.Name = "taikhoan";
            taikhoan.Size = new Size(128, 37);
            taikhoan.TabIndex = 1;
            taikhoan.Text = "Tài khoản";
            taikhoan.TextAlign = ContentAlignment.TopCenter;
            // 
            // matkhau
            // 
            matkhau.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            matkhau.BackColor = Color.DimGray;
            matkhau.BorderStyle = BorderStyle.FixedSingle;
            matkhau.Font = new Font("Microsoft JhengHei", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            matkhau.ForeColor = Color.WhiteSmoke;
            matkhau.Location = new Point(20, 426);
            matkhau.Margin = new Padding(4, 0, 4, 0);
            matkhau.Name = "matkhau";
            matkhau.Size = new Size(128, 37);
            matkhau.TabIndex = 1;
            matkhau.Text = "Mật khẩu";
            matkhau.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(156, 341);
            textBox1.Margin = new Padding(4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(277, 34);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(156, 426);
            textBox2.Margin = new Padding(4);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(277, 34);
            textBox2.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.AutoScroll = true;
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(dangnhap);
            panel1.Controls.Add(thoat);
            panel1.Controls.Add(matkhau);
            panel1.Controls.Add(taikhoan);
            panel1.ForeColor = Color.CornflowerBlue;
            panel1.Location = new Point(477, 55);
            panel1.Name = "panel1";
            panel1.Size = new Size(461, 694);
            panel1.TabIndex = 3;
            panel1.Paint += panel1_Paint;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.DimGray;
            button1.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.LightCyan;
            button1.Location = new Point(0, 85);
            button1.Name = "button1";
            button1.Size = new Size(460, 94);
            button1.TabIndex = 3;
            button1.Text = "ĐĂNG NHẬP";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.thu_vien_admont_admont_ao_104923205;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1405, 793);
            Controls.Add(panel1);
            Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = SystemColors.ControlText;
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Đăng Nhập";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button dangnhap;
        private Button thoat;
        private Label taikhoan;
        private Label matkhau;
        private TextBox textBox1;
        private TextBox textBox2;
        private Panel panel1;
        private Label label1;
        private Button button1;
    }
}