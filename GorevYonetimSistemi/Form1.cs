namespace GorevYonetimSistemi
{
    public partial class Form1 : Form

    {
        class Gorev
        {
            public string Ad { get; set; }
            public string Aciklama { get; set; }
            public bool Tamamlandi { get; set; }

            
            public Gorev(string ad)
            {
                Ad = ad ?? throw new ArgumentNullException(nameof(ad));
                Aciklama = string.Empty; 
                Tamamlandi = false;
            }

            public override string ToString()
            {
                return $"{Ad} - {(Tamamlandi ? "Tamamland�" : "Devam Ediyor")}";
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private List<Gorev> gorevListesi = new List<Gorev>();

        private void buttonGorevEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textGorevAdi.Text)) 
            {
                MessageBox.Show("G�rev ad� bo� olamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
          Gorev yeniGorev = new Gorev(textGorevAdi.Text)
          {
              Aciklama = textAciklama.Text,
              Tamamlandi = false
          };

            gorevListesi.Add(yeniGorev);
            ListeyiGuncelle(); 
            Temizle(); 

        }

        private void buttonGorevSil_Click(object sender, EventArgs e)
        {
            if (lstGorevler.SelectedIndex == -1) 
            {
                MessageBox.Show("Silmek i�in bir g�rev se�in!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            gorevListesi.RemoveAt(lstGorevler.SelectedIndex); 
            ListeyiGuncelle(); 
        }

        private void buttonDrumDegistir_Click(object sender, EventArgs e)
        {
            if (lstGorevler.SelectedIndex == -1)
            {
                MessageBox.Show("Durumu de�i�tirmek i�in bir g�rev se�in!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (lstGorevler.SelectedIndex >= 0)
            {
                var secilenGorev = gorevListesi[lstGorevler.SelectedIndex];
                secilenGorev.Tamamlandi = !secilenGorev.Tamamlandi;
                ListeyiGuncelle();
            }
            else
            {
                MessageBox.Show("L�tfen bir g�rev se�in.");
            }
        }


            
        private void ListeyiGuncelle()
        {
            lstGorevler.Items.Clear();
            foreach (var gorev in gorevListesi)
            {
                lstGorevler.Items.Add(gorev); 
            }
        }

       
        private void Temizle()
        {
            textGorevAdi.Clear();
            textAciklama.Clear();
        }
    }
}
