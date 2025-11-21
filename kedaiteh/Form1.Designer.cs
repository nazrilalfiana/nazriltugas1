namespace kedaiteh
{
    partial class kedai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kedai));
            l_nama = new Label();
            t_nama = new TextBox();
            l_menu = new Label();
            c_menu = new ComboBox();
            l_toping = new Label();
            c_madu = new CheckBox();
            c_selasih = new CheckBox();
            c_cincau = new CheckBox();
            l_size = new Label();
            r_kecil = new RadioButton();
            r_sedang = new RadioButton();
            r_besar = new RadioButton();
            groupBox1 = new GroupBox();
            listBox1 = new ListBox();
            l_jumlah = new Label();
            t_jumlah = new TextBox();
            b_pesan = new Button();
            b_hapus = new Button();
            t_total = new TextBox();
            l_total = new Label();
            t_bayar = new TextBox();
            l_bayar = new Label();
            c_metod = new ComboBox();
            l_metod = new Label();
            b_bayar = new Button();
            b_lanjut = new Button();
            t_search = new TextBox();
            b_search = new Button();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // l_nama
            // 
            l_nama.AutoSize = true;
            l_nama.ForeColor = SystemColors.ButtonHighlight;
            l_nama.Location = new Point(47, 117);
            l_nama.Name = "l_nama";
            l_nama.Size = new Size(90, 15);
            l_nama.TabIndex = 0;
            l_nama.Text = "Nama Pemesan";
            // 
            // t_nama
            // 
            t_nama.Location = new Point(183, 117);
            t_nama.Name = "t_nama";
            t_nama.Size = new Size(121, 23);
            t_nama.TabIndex = 1;
            // 
            // l_menu
            // 
            l_menu.AutoSize = true;
            l_menu.ForeColor = SystemColors.ButtonHighlight;
            l_menu.Location = new Point(47, 160);
            l_menu.Name = "l_menu";
            l_menu.Size = new Size(64, 15);
            l_menu.TabIndex = 2;
            l_menu.Text = "Pilih Menu";
            // 
            // c_menu
            // 
            c_menu.FormattingEnabled = true;
            c_menu.Items.AddRange(new object[] { "" });
            c_menu.Location = new Point(183, 157);
            c_menu.Name = "c_menu";
            c_menu.Size = new Size(121, 23);
            c_menu.TabIndex = 4;
            // 
            // l_toping
            // 
            l_toping.AutoSize = true;
            l_toping.ForeColor = SystemColors.ButtonHighlight;
            l_toping.Location = new Point(47, 285);
            l_toping.Name = "l_toping";
            l_toping.Size = new Size(44, 15);
            l_toping.TabIndex = 5;
            l_toping.Text = "Toping";
            // 
            // c_madu
            // 
            c_madu.AutoSize = true;
            c_madu.ForeColor = SystemColors.ButtonHighlight;
            c_madu.Location = new Point(183, 284);
            c_madu.Name = "c_madu";
            c_madu.Size = new Size(57, 19);
            c_madu.TabIndex = 6;
            c_madu.Text = "Madu";
            c_madu.UseVisualStyleBackColor = true;
            // 
            // c_selasih
            // 
            c_selasih.AutoSize = true;
            c_selasih.ForeColor = SystemColors.ButtonHighlight;
            c_selasih.Location = new Point(183, 309);
            c_selasih.Name = "c_selasih";
            c_selasih.Size = new Size(81, 19);
            c_selasih.TabIndex = 7;
            c_selasih.Text = "Biji Selasih";
            c_selasih.UseVisualStyleBackColor = true;
            // 
            // c_cincau
            // 
            c_cincau.AutoSize = true;
            c_cincau.ForeColor = SystemColors.ButtonHighlight;
            c_cincau.Location = new Point(183, 334);
            c_cincau.Name = "c_cincau";
            c_cincau.Size = new Size(63, 19);
            c_cincau.TabIndex = 8;
            c_cincau.Text = "Cincau";
            c_cincau.UseVisualStyleBackColor = true;
            // 
            // l_size
            // 
            l_size.AutoSize = true;
            l_size.ForeColor = SystemColors.ButtonHighlight;
            l_size.Location = new Point(47, 200);
            l_size.Name = "l_size";
            l_size.Size = new Size(45, 15);
            l_size.TabIndex = 9;
            l_size.Text = "Ukuran";
            // 
            // r_kecil
            // 
            r_kecil.AutoSize = true;
            r_kecil.ForeColor = SystemColors.ButtonHighlight;
            r_kecil.Location = new Point(183, 198);
            r_kecil.Name = "r_kecil";
            r_kecil.Size = new Size(50, 19);
            r_kecil.TabIndex = 10;
            r_kecil.TabStop = true;
            r_kecil.Text = "Kecil";
            r_kecil.UseVisualStyleBackColor = true;
            // 
            // r_sedang
            // 
            r_sedang.AutoSize = true;
            r_sedang.ForeColor = SystemColors.ButtonHighlight;
            r_sedang.Location = new Point(183, 223);
            r_sedang.Name = "r_sedang";
            r_sedang.Size = new Size(64, 19);
            r_sedang.TabIndex = 11;
            r_sedang.TabStop = true;
            r_sedang.Text = "Sedang";
            r_sedang.UseVisualStyleBackColor = true;
            // 
            // r_besar
            // 
            r_besar.AutoSize = true;
            r_besar.ForeColor = SystemColors.ButtonHighlight;
            r_besar.Location = new Point(183, 248);
            r_besar.Name = "r_besar";
            r_besar.Size = new Size(53, 19);
            r_besar.TabIndex = 12;
            r_besar.TabStop = true;
            r_besar.Text = "Besar";
            r_besar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listBox1);
            groupBox1.ForeColor = SystemColors.ButtonHighlight;
            groupBox1.Location = new Point(368, 155);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(339, 266);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "List Pesanan";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(6, 16);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(327, 244);
            listBox1.TabIndex = 0;
            // 
            // l_jumlah
            // 
            l_jumlah.AutoSize = true;
            l_jumlah.ForeColor = SystemColors.ButtonHighlight;
            l_jumlah.Location = new Point(47, 370);
            l_jumlah.Name = "l_jumlah";
            l_jumlah.Size = new Size(45, 15);
            l_jumlah.TabIndex = 14;
            l_jumlah.Text = "Jumlah";
            // 
            // t_jumlah
            // 
            t_jumlah.Location = new Point(183, 367);
            t_jumlah.Name = "t_jumlah";
            t_jumlah.Size = new Size(121, 23);
            t_jumlah.TabIndex = 15;
            t_jumlah.KeyPress += t_jumlah_KeyPress;
            // 
            // b_pesan
            // 
            b_pesan.BackgroundImageLayout = ImageLayout.None;
            b_pesan.Font = new Font("Segoe UI", 9F);
            b_pesan.Image = (Image)resources.GetObject("b_pesan.Image");
            b_pesan.ImageAlign = ContentAlignment.MiddleLeft;
            b_pesan.Location = new Point(225, 437);
            b_pesan.Name = "b_pesan";
            b_pesan.Size = new Size(79, 31);
            b_pesan.TabIndex = 16;
            b_pesan.Text = "Pesan";
            b_pesan.TextAlign = ContentAlignment.MiddleRight;
            b_pesan.UseVisualStyleBackColor = true;
            b_pesan.Click += b_pesan_Click;
            // 
            // b_hapus
            // 
            b_hapus.BackgroundImageLayout = ImageLayout.None;
            b_hapus.Image = (Image)resources.GetObject("b_hapus.Image");
            b_hapus.ImageAlign = ContentAlignment.TopLeft;
            b_hapus.Location = new Point(368, 437);
            b_hapus.Name = "b_hapus";
            b_hapus.Size = new Size(126, 31);
            b_hapus.TabIndex = 17;
            b_hapus.Text = "Hapus Pesanan";
            b_hapus.TextAlign = ContentAlignment.MiddleRight;
            b_hapus.UseVisualStyleBackColor = true;
            b_hapus.Click += b_hapus_Click;
            // 
            // t_total
            // 
            t_total.Location = new Point(867, 117);
            t_total.Name = "t_total";
            t_total.ReadOnly = true;
            t_total.Size = new Size(92, 23);
            t_total.TabIndex = 19;
            t_total.Visible = false;
            // 
            // l_total
            // 
            l_total.AutoSize = true;
            l_total.ForeColor = SystemColors.ButtonHighlight;
            l_total.Location = new Point(760, 120);
            l_total.Name = "l_total";
            l_total.Size = new Size(33, 15);
            l_total.TabIndex = 18;
            l_total.Text = "Total";
            l_total.Visible = false;
            // 
            // t_bayar
            // 
            t_bayar.Location = new Point(867, 155);
            t_bayar.Name = "t_bayar";
            t_bayar.Size = new Size(92, 23);
            t_bayar.TabIndex = 21;
            t_bayar.Visible = false;
            t_bayar.KeyPress += t_bayar_KeyPress;
            // 
            // l_bayar
            // 
            l_bayar.AutoSize = true;
            l_bayar.ForeColor = SystemColors.ButtonHighlight;
            l_bayar.Location = new Point(760, 160);
            l_bayar.Name = "l_bayar";
            l_bayar.Size = new Size(67, 15);
            l_bayar.TabIndex = 20;
            l_bayar.Text = "Uang Bayar";
            l_bayar.Visible = false;
            // 
            // c_metod
            // 
            c_metod.FormattingEnabled = true;
            c_metod.Items.AddRange(new object[] { "Transfer", "Cash" });
            c_metod.Location = new Point(867, 195);
            c_metod.Name = "c_metod";
            c_metod.Size = new Size(92, 23);
            c_metod.TabIndex = 23;
            c_metod.Visible = false;
            // 
            // l_metod
            // 
            l_metod.AutoSize = true;
            l_metod.ForeColor = SystemColors.ButtonHighlight;
            l_metod.Location = new Point(760, 198);
            l_metod.Name = "l_metod";
            l_metod.Size = new Size(74, 15);
            l_metod.TabIndex = 22;
            l_metod.Text = "Pilih Metode";
            l_metod.Visible = false;
            // 
            // b_bayar
            // 
            b_bayar.Image = (Image)resources.GetObject("b_bayar.Image");
            b_bayar.ImageAlign = ContentAlignment.MiddleLeft;
            b_bayar.Location = new Point(884, 437);
            b_bayar.Name = "b_bayar";
            b_bayar.Size = new Size(75, 31);
            b_bayar.TabIndex = 25;
            b_bayar.Text = "Bayar";
            b_bayar.TextAlign = ContentAlignment.MiddleRight;
            b_bayar.UseVisualStyleBackColor = true;
            b_bayar.Visible = false;
            b_bayar.Click += b_bayar_Click;
            // 
            // b_lanjut
            // 
            b_lanjut.Image = (Image)resources.GetObject("b_lanjut.Image");
            b_lanjut.ImageAlign = ContentAlignment.MiddleLeft;
            b_lanjut.Location = new Point(618, 437);
            b_lanjut.Name = "b_lanjut";
            b_lanjut.Size = new Size(89, 31);
            b_lanjut.TabIndex = 26;
            b_lanjut.Text = "Lanjut";
            b_lanjut.TextAlign = ContentAlignment.MiddleRight;
            b_lanjut.UseVisualStyleBackColor = true;
            b_lanjut.Click += b_lanjut_Click;
            // 
            // t_search
            // 
            t_search.Location = new Point(374, 117);
            t_search.Name = "t_search";
            t_search.Size = new Size(300, 23);
            t_search.TabIndex = 27;
            // 
            // b_search
            // 
            b_search.BackgroundImage = (Image)resources.GetObject("b_search.BackgroundImage");
            b_search.BackgroundImageLayout = ImageLayout.Zoom;
            b_search.Location = new Point(680, 117);
            b_search.Name = "b_search";
            b_search.Size = new Size(27, 23);
            b_search.TabIndex = 28;
            b_search.UseVisualStyleBackColor = true;
            b_search.Click += b_search_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.DarkKhaki;
            pictureBox1.Image = Properties.Resources.WhatsApp_Image_2025_11_06_at_07_01_44;
            pictureBox1.Location = new Point(456, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(85, 72);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            // 
            // kedai
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaGreen;
            ClientSize = new Size(1047, 600);
            Controls.Add(pictureBox1);
            Controls.Add(b_search);
            Controls.Add(t_search);
            Controls.Add(b_lanjut);
            Controls.Add(b_bayar);
            Controls.Add(c_metod);
            Controls.Add(l_metod);
            Controls.Add(t_bayar);
            Controls.Add(l_bayar);
            Controls.Add(t_total);
            Controls.Add(l_total);
            Controls.Add(b_hapus);
            Controls.Add(b_pesan);
            Controls.Add(t_jumlah);
            Controls.Add(l_jumlah);
            Controls.Add(groupBox1);
            Controls.Add(r_besar);
            Controls.Add(r_sedang);
            Controls.Add(r_kecil);
            Controls.Add(l_size);
            Controls.Add(c_cincau);
            Controls.Add(c_selasih);
            Controls.Add(c_madu);
            Controls.Add(l_toping);
            Controls.Add(c_menu);
            Controls.Add(l_menu);
            Controls.Add(t_nama);
            Controls.Add(l_nama);
            Name = "kedai";
            Text = "Kedai Teh";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label l_nama;
        private TextBox t_nama;
        private Label l_menu;
        private ComboBox c_menu;
        private Label l_toping;
        private CheckBox c_madu;
        private CheckBox c_selasih;
        private CheckBox c_cincau;
        private Label l_size;
        private RadioButton r_kecil;
        private RadioButton r_sedang;
        private RadioButton r_besar;
        private GroupBox groupBox1;
        private ListBox listBox1;
        private Label l_jumlah;
        private TextBox t_jumlah;
        private Button b_pesan;
        private Button b_hapus;
        private TextBox t_total;
        private Label l_total;
        private TextBox t_bayar;
        private Label l_bayar;
        private ComboBox c_metod;
        private Label l_metod;
        private Button b_bayar;
        private Button b_lanjut;
        private TextBox t_search;
        private Button b_search;
        private PictureBox pictureBox1;
    }
}
