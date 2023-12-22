namespace do_an_1_quan_li_thu_vien
{
    partial class quanlichung
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            theodoimuontra = new Button();
            btndocgia = new Button();
            nhanvien = new Button();
            button6 = new Button();
            btnvipham = new Button();
            qlmuonsach = new Button();
            button1 = new Button();
            dateTimePicker1 = new DateTimePicker();
            groupBox2 = new GroupBox();
            label1 = new Label();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // theodoimuontra
            // 
            theodoimuontra.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            theodoimuontra.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            theodoimuontra.Location = new Point(536, 151);
            theodoimuontra.Name = "theodoimuontra";
            theodoimuontra.Size = new Size(324, 50);
            theodoimuontra.TabIndex = 1;
            theodoimuontra.Text = "Theo dõi mượn trả";
            theodoimuontra.UseVisualStyleBackColor = true;
            theodoimuontra.Click += theodoimuontra_Click;
            // 
            // btndocgia
            // 
            btndocgia.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btndocgia.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btndocgia.Location = new Point(344, 358);
            btndocgia.Name = "btndocgia";
            btndocgia.Size = new Size(296, 43);
            btndocgia.TabIndex = 1;
            btndocgia.Text = "QL độc giả";
            btndocgia.UseVisualStyleBackColor = true;
            btndocgia.Click += btndocgia_Click;
            // 
            // nhanvien
            // 
            nhanvien.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nhanvien.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            nhanvien.Location = new Point(344, 288);
            nhanvien.Name = "nhanvien";
            nhanvien.Size = new Size(296, 43);
            nhanvien.TabIndex = 1;
            nhanvien.Text = "QL nhân viên";
            nhanvien.UseVisualStyleBackColor = true;
            nhanvien.Click += nhanvien_Click;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(716, 358);
            button6.Name = "button6";
            button6.Size = new Size(306, 43);
            button6.TabIndex = 1;
            button6.Text = "Ưu đãi ";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // btnvipham
            // 
            btnvipham.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnvipham.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnvipham.Location = new Point(716, 288);
            btnvipham.Name = "btnvipham";
            btnvipham.Size = new Size(306, 43);
            btnvipham.TabIndex = 1;
            btnvipham.Text = "QL vi phạm";
            btnvipham.UseVisualStyleBackColor = true;
            btnvipham.Click += btnvipham_Click;
            // 
            // qlmuonsach
            // 
            qlmuonsach.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            qlmuonsach.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            qlmuonsach.Location = new Point(716, 216);
            qlmuonsach.Name = "qlmuonsach";
            qlmuonsach.Size = new Size(306, 43);
            qlmuonsach.TabIndex = 1;
            qlmuonsach.Text = "QL mượn sách";
            qlmuonsach.UseVisualStyleBackColor = true;
            qlmuonsach.Click += qlmuonsach_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(344, 216);
            button1.Name = "button1";
            button1.Size = new Size(296, 43);
            button1.TabIndex = 1;
            button1.Text = "QL sách";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(1112, 10);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(264, 27);
            dateTimePicker1.TabIndex = 2;
            // 
            // groupBox2
            // 
            groupBox2.AccessibleRole = AccessibleRole.MenuBar;
            groupBox2.Anchor = AnchorStyles.None;
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(theodoimuontra);
            groupBox2.Controls.Add(dateTimePicker1);
            groupBox2.Controls.Add(btndocgia);
            groupBox2.Controls.Add(nhanvien);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(button6);
            groupBox2.Controls.Add(qlmuonsach);
            groupBox2.Controls.Add(btnvipham);
            groupBox2.Location = new Point(3, 171);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1424, 476);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Enter += groupBox2_Enter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.Silver;
            label1.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Tomato;
            label1.Location = new Point(424, 56);
            label1.Name = "label1";
            label1.Size = new Size(546, 55);
            label1.TabIndex = 4;
            label1.Text = "QUẢN LÝ CHUNG";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // quanlichung
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            BackgroundImage = Properties.Resources.pexels_ivo_rainha_1290141;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1426, 645);
            Controls.Add(groupBox2);
            Name = "quanlichung";
            Text = "Quản lí thông tin";
            Load += quanlichung_Load;
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button theodoimuontra;
        private Button btndocgia;
        private Button nhanvien;
        private Button button6;
        private Button btnvipham;
        private Button qlmuonsach;
        private Button button1;
        private DateTimePicker dateTimePicker1;
        private GroupBox groupBox2;
        private Label label1;
    }
}