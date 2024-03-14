namespace SistemPendaftaranAcara
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_tampilkan_Click(object sender, EventArgs e)
        {
            string nama = txt_nama.Text;
            string email = txt_email.Text;
            string kategori = cb_kategori.Text;
            string tipe = "";
            if (cb_biasa.Checked == true)
            {
                tipe = "Peserta Biasa";
            }
            else if (cb_vip.Checked == true)
            {
                tipe = "VIP";
            }

            string persetujuan = "";
            if (cb_setuju.Checked == true)
            {
                persetujuan = "Setuju";
            }
            else if (cb_tidak.Checked == true)
            {
                persetujuan = "Tidak Setuju";
            }

            string jk = "";
            if (rb_laki.Checked == true)
            {
                jk = "Laki - laki";
            }
            else if (rb_perempuan.Checked == true)
            {
                jk = "Perempuan";
            }

            string telepon = txt_telepon.Text;

            MessageBox.Show(
                "Atas nama : " + nama +
                "\nEmail : " + email +
                "\nKategori Acara : " + kategori +
                "\nTipe Pendafataran" + tipe +
                "\nPersetujuan : " + persetujuan +
                "\nJenis Kelamin : " + jk +
                "\nNomor Telepon : " + telepon
                , "Biodata"
            );
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_nama.Clear();
            txt_email.Clear();
            cb_kategori.SelectedIndex = -1;
            cb_biasa.Checked = false;
            cb_vip.Checked = false;
            cb_setuju.Checked = false;
            cb_tidak.Checked = false;
            rb_laki.Checked = false;
            rb_perempuan.Checked = false;
            txt_telepon.Clear();
        }

        private void btn_tambahkan_Click(object sender, EventArgs e)
        {
            string nama = txt_nama.Text;
            string email = txt_email.Text;
            string kategori = cb_kategori.Text;
            string tipe = "";
            if (cb_biasa.Checked == true)
            {
                tipe = "Peserta Biasa";
            }
            else if (cb_vip.Checked == true)
            {
                tipe = "VIP";
            }

            string persetujuan = "";
            if (cb_setuju.Checked == true)
            {
                persetujuan = "Setuju";
            }
            else if (cb_tidak.Checked == true)
            {
                persetujuan = "Tidak Setuju";
            }

            string jk = "";
            if (rb_laki.Checked == true)
            {
                jk = "Laki - laki";
            }
            else if (rb_perempuan.Checked == true)
            {
                jk = "Perempuan";
            }

            string telepon = txt_telepon.Text;

            dataGridView1.Rows.Add(
                nama,
                email,
                kategori,
                tipe,
                persetujuan,
                jk,
                telepon
            );
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Pilih baris terlebih dahulu untuk dihapus.");
            }
        }
    }
}