namespace SistemPendaftaranAcara
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txt_nama = new TextBox();
            txt_email = new TextBox();
            cb_kategori = new ComboBox();
            cb_setuju = new CheckBox();
            cb_tidak = new CheckBox();
            rb_laki = new RadioButton();
            rb_perempuan = new RadioButton();
            txt_telepon = new TextBox();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            btn_tampilkan = new Button();
            btn_clear = new Button();
            btn_delete = new Button();
            btn_tambahkan = new Button();
            btn_close = new Button();
            cb_biasa = new CheckBox();
            cb_vip = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(227, 23);
            label1.Name = "label1";
            label1.Size = new Size(348, 37);
            label1.TabIndex = 0;
            label1.Text = "Sistem Pendaftaran Acara";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 90);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 1;
            label2.Text = "Nama Lengkap";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 126);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 2;
            label3.Text = "Email";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 166);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 3;
            label4.Text = "Kategori Acara";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 205);
            label5.Name = "label5";
            label5.Size = new Size(96, 15);
            label5.TabIndex = 4;
            label5.Text = "Tipe Pendaftaran";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(31, 245);
            label6.Name = "label6";
            label6.Size = new Size(69, 15);
            label6.TabIndex = 5;
            label6.Text = "Persetujuan";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(427, 88);
            label7.Name = "label7";
            label7.Size = new Size(78, 15);
            label7.TabIndex = 6;
            label7.Text = "Jenis Kelamin";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(427, 126);
            label8.Name = "label8";
            label8.Size = new Size(89, 15);
            label8.TabIndex = 7;
            label8.Text = "Nomor Telepon";
            // 
            // txt_nama
            // 
            txt_nama.Location = new Point(183, 88);
            txt_nama.Name = "txt_nama";
            txt_nama.Size = new Size(203, 23);
            txt_nama.TabIndex = 8;
            // 
            // txt_email
            // 
            txt_email.Location = new Point(183, 118);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(203, 23);
            txt_email.TabIndex = 9;
            // 
            // cb_kategori
            // 
            cb_kategori.FormattingEnabled = true;
            cb_kategori.Items.AddRange(new object[] { "", "seminar", "workshop", "konferensi" });
            cb_kategori.Location = new Point(183, 163);
            cb_kategori.Name = "cb_kategori";
            cb_kategori.Size = new Size(121, 23);
            cb_kategori.TabIndex = 10;
            // 
            // cb_setuju
            // 
            cb_setuju.AutoSize = true;
            cb_setuju.Location = new Point(183, 241);
            cb_setuju.Name = "cb_setuju";
            cb_setuju.Size = new Size(59, 19);
            cb_setuju.TabIndex = 13;
            cb_setuju.Text = "Setuju";
            cb_setuju.UseVisualStyleBackColor = true;
            // 
            // cb_tidak
            // 
            cb_tidak.AutoSize = true;
            cb_tidak.Location = new Point(270, 241);
            cb_tidak.Name = "cb_tidak";
            cb_tidak.Size = new Size(90, 19);
            cb_tidak.TabIndex = 14;
            cb_tidak.Text = "Tidak Setuju";
            cb_tidak.UseVisualStyleBackColor = true;
            // 
            // rb_laki
            // 
            rb_laki.AutoSize = true;
            rb_laki.Location = new Point(579, 86);
            rb_laki.Name = "rb_laki";
            rb_laki.Size = new Size(75, 19);
            rb_laki.TabIndex = 15;
            rb_laki.TabStop = true;
            rb_laki.Text = "Laki - laki";
            rb_laki.UseVisualStyleBackColor = true;
            // 
            // rb_perempuan
            // 
            rb_perempuan.AutoSize = true;
            rb_perempuan.Location = new Point(688, 86);
            rb_perempuan.Name = "rb_perempuan";
            rb_perempuan.Size = new Size(86, 19);
            rb_perempuan.TabIndex = 16;
            rb_perempuan.TabStop = true;
            rb_perempuan.Text = "Perempuan";
            rb_perempuan.UseVisualStyleBackColor = true;
            // 
            // txt_telepon
            // 
            txt_telepon.Location = new Point(579, 126);
            txt_telepon.Name = "txt_telepon";
            txt_telepon.Size = new Size(203, 23);
            txt_telepon.TabIndex = 17;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            dataGridView1.Location = new Point(31, 288);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(743, 150);
            dataGridView1.TabIndex = 18;
            // 
            // Column1
            // 
            Column1.HeaderText = "Nama";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Email";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Kategori";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Tipe";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Persetujuan";
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "Kelamin";
            Column6.Name = "Column6";
            // 
            // Column7
            // 
            Column7.HeaderText = "Telepon";
            Column7.Name = "Column7";
            // 
            // btn_tampilkan
            // 
            btn_tampilkan.Cursor = Cursors.Hand;
            btn_tampilkan.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_tampilkan.Location = new Point(427, 162);
            btn_tampilkan.Name = "btn_tampilkan";
            btn_tampilkan.Size = new Size(89, 23);
            btn_tampilkan.TabIndex = 19;
            btn_tampilkan.Text = "TAMPILKAN";
            btn_tampilkan.UseVisualStyleBackColor = true;
            btn_tampilkan.Click += btn_tampilkan_Click;
            // 
            // btn_clear
            // 
            btn_clear.Cursor = Cursors.Hand;
            btn_clear.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_clear.Location = new Point(551, 162);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(75, 23);
            btn_clear.TabIndex = 20;
            btn_clear.Text = "CLEAR";
            btn_clear.UseVisualStyleBackColor = true;
            btn_clear.Click += btn_clear_Click;
            // 
            // btn_delete
            // 
            btn_delete.Cursor = Cursors.Hand;
            btn_delete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_delete.Location = new Point(699, 245);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(75, 23);
            btn_delete.TabIndex = 21;
            btn_delete.Text = "DELETE";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_tambahkan
            // 
            btn_tambahkan.Cursor = Cursors.Hand;
            btn_tambahkan.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_tambahkan.Location = new Point(572, 245);
            btn_tambahkan.Name = "btn_tambahkan";
            btn_tambahkan.Size = new Size(94, 23);
            btn_tambahkan.TabIndex = 22;
            btn_tambahkan.Text = "TAMBAHKAN";
            btn_tambahkan.UseVisualStyleBackColor = true;
            btn_tambahkan.Click += btn_tambahkan_Click;
            // 
            // btn_close
            // 
            btn_close.Cursor = Cursors.Hand;
            btn_close.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_close.Location = new Point(699, 163);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(75, 23);
            btn_close.TabIndex = 23;
            btn_close.Text = "CLOSE";
            btn_close.UseVisualStyleBackColor = true;
            btn_close.Click += btn_close_Click;
            // 
            // cb_biasa
            // 
            cb_biasa.AutoSize = true;
            cb_biasa.Location = new Point(183, 201);
            cb_biasa.Name = "cb_biasa";
            cb_biasa.Size = new Size(53, 19);
            cb_biasa.TabIndex = 24;
            cb_biasa.Text = "Biasa";
            cb_biasa.UseVisualStyleBackColor = true;
            // 
            // cb_vip
            // 
            cb_vip.AutoSize = true;
            cb_vip.Location = new Point(270, 201);
            cb_vip.Name = "cb_vip";
            cb_vip.Size = new Size(43, 19);
            cb_vip.TabIndex = 25;
            cb_vip.Text = "VIP";
            cb_vip.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cb_vip);
            Controls.Add(cb_biasa);
            Controls.Add(btn_close);
            Controls.Add(btn_tambahkan);
            Controls.Add(btn_delete);
            Controls.Add(btn_clear);
            Controls.Add(btn_tampilkan);
            Controls.Add(dataGridView1);
            Controls.Add(txt_telepon);
            Controls.Add(rb_perempuan);
            Controls.Add(rb_laki);
            Controls.Add(cb_tidak);
            Controls.Add(cb_setuju);
            Controls.Add(cb_kategori);
            Controls.Add(txt_email);
            Controls.Add(txt_nama);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txt_nama;
        private TextBox txt_email;
        private ComboBox cb_kategori;
        private CheckBox cb_setuju;
        private CheckBox cb_tidak;
        private RadioButton rb_laki;
        private RadioButton rb_perempuan;
        private TextBox txt_telepon;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private Button btn_tampilkan;
        private Button btn_clear;
        private Button btn_delete;
        private Button btn_tambahkan;
        private Button btn_close;
        private CheckBox cb_biasa;
        private CheckBox cb_vip;
    }
}