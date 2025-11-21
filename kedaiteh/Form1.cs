using System.Net.NetworkInformation;

namespace kedaiteh
{
    public partial class kedai : Form
    {
        private List<string> list = new List<string>();
        int sub = 0;
        private int tot = 0;

        public kedai()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            c_menu.Items.Clear();
            c_menu.Items.Add("Es Teh");
            c_menu.Items.Add("Lemon Tea");
            c_menu.Items.Add("Teh Hijau");
        }
        private void b_pesan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(t_nama.Text))
            {
                MessageBox.Show("Nama harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                t_nama.Focus();
                return;
            }

            if (c_menu.SelectedIndex == -1)
            {
                MessageBox.Show("Pilih salah satu menu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(t_jumlah.Text.Trim(), out int jum) || jum <= 0)
            {
                jum = 1;
            }

            List<string> mpesan = new List<string>();
            int harga = 0;
            string id = t_nama.Text;

            if (c_menu.Text == "Es Teh")
            {
                mpesan.Add("Es Teh");
                harga = 5000;
            }
            else if (c_menu.Text == "Lemon Tea")
            {
                mpesan.Add("Lemon Tea");
                harga = 6500;
            }
            else if (c_menu.Text == "Teh Hijau")
            {
                mpesan.Add("Teh Hijau");
                harga = 7500;
            }

            string ukuran = "";
            if (r_kecil.Checked)
            {
                ukuran = "Kecil";
            }
            else if (r_sedang.Checked)
            {
                ukuran = "Sedang";
                harga += 1000;
            }
            else if (r_besar.Checked)
            {
                ukuran = "Besar";
                harga += 2000;
            }

            string toping = "";
            if (c_cincau.Checked)
            {
                toping += "Cincau, ";
                harga += 500;
            }
            if (c_madu.Checked)
            {
                toping += "Madu, ";
                harga += 500;
            }
            if (c_selasih.Checked)
            {
                toping += "Selasih, ";
                harga += 500;
            }
            if (toping.EndsWith(", "))
            {
                toping = toping.Substring(0, toping.Length - 2);
            }
            int sub = harga * jum;
            tot += sub;
            t_total.Text = tot.ToString();

            string data = toping != ""
                ? $"{string.Join(",", mpesan)} {toping} | {ukuran} | Rp.{sub}"
                : $"{string.Join(",", mpesan)} {ukuran} | Rp.{sub}";
            listBox1.Items.Add(data);
            list.Add(data);

            t_nama.ReadOnly = true;
            c_menu.SelectedIndex = -1;
            r_kecil.Checked = false;
            r_sedang.Checked = false;
            r_besar.Checked = false;
            c_madu.Checked = false;
            c_cincau.Checked = false;
            c_selasih.Checked = false;
            t_jumlah.Clear();
        }

        private void b_lanjut_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show(
                    "Pesan Menu terlebih dahulu !", "Peringatan",
                    MessageBoxButtons.OK);
            }
            else
            {
                l_total.Visible = true;
                t_total.Visible = true;
                l_bayar.Visible = true;
                t_bayar.Visible = true;
                l_metod.Visible = true;
                c_metod.Visible = true;
                b_bayar.Visible = true;
            }
            if (tot >= 100000)
            {
                MessageBox.Show("Selamat Anda Mendapat diskon 10% karena Total Pembelian lebih dari 100k", "Pemberitahuan", MessageBoxButtons.OK);
                tot -= (int)(tot * 0.1);
            }
        }

        private void b_bayar_Click(object sender, EventArgs e)
        {
            if (c_metod.SelectedIndex == -1)
            {
                MessageBox.Show("Pilih metode pembayaran terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                c_metod.Focus();
                return;
            }

            if (!int.TryParse(t_bayar.Text.Trim(), out int bayar))
            {
                MessageBox.Show("Masukkan jumlah uang bayar yang valid!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                t_bayar.Focus();
                return;
            }

            if (bayar < tot)
            {
                MessageBox.Show("Uang bayar kurang dari total pembelian!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                t_bayar.Focus();
                return;
            }

            int kembalian = bayar - tot;

            string pesanan = "";
            foreach (var item in listBox1.Items)
            {
                pesanan += item.ToString() + "\n";
            }

            DialogResult result = MessageBox.Show(
                $"Nama: {t_nama.Text}\n" +
                $"Pesanan:\n{pesanan}\n" +
                $"Total: Rp.{tot}\n" +
                $"Uang Bayar: Rp.{bayar}\n" +
                $"Kembalian: Rp.{kembalian}\n\n" +
                $"Metode Pembayaran: {c_metod.SelectedItem?.ToString() ?? "-"}",
                "Detail Transaksi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (result == DialogResult.OK)
            {
                MessageBox.Show("Terima kasih telah berbelanja di Kedai Teh kami! 😊", "Sampai Jumpa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void b_hapus_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                string itemToRemove = listBox1.SelectedItem.ToString();
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                list.Remove(itemToRemove);
            }
            else
            {
                MessageBox.Show("Pilih pesanan yang ingin dihapus!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void b_search_Click(object sender, EventArgs e)
        {
            string keyword = t_search.Text.ToLower();
            listBox1.Items.Clear();

            foreach (string item in list)
            {
                if (item.ToLower().Contains(keyword))
                {
                    listBox1.Items.Add(item);
                }
            }

            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("Pesanan tidak ditemukan!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void t_bayar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        private void t_jumlah_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}