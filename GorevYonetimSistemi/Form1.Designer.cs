namespace GorevYonetimSistemi
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
            lstGorevler = new ListBox();
            textGorevAdi = new TextBox();
            textAciklama = new TextBox();
            buttonGorevEkle = new Button();
            buttonGorevSil = new Button();
            buttonDrumDegistir = new Button();
            labelGorevler = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // lstGorevler
            // 
            lstGorevler.BackColor = Color.FromArgb(255, 192, 192);
            lstGorevler.Dock = DockStyle.Top;
            lstGorevler.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lstGorevler.FormattingEnabled = true;
            lstGorevler.ItemHeight = 18;
            lstGorevler.Location = new Point(0, 0);
            lstGorevler.Name = "lstGorevler";
            lstGorevler.Size = new Size(447, 184);
            lstGorevler.TabIndex = 0;
            // 
            // textGorevAdi
            // 
            textGorevAdi.BackColor = Color.FromArgb(255, 192, 192);
            textGorevAdi.Location = new Point(0, 208);
            textGorevAdi.Name = "textGorevAdi";
            textGorevAdi.Size = new Size(448, 23);
            textGorevAdi.TabIndex = 1;
            // 
            // textAciklama
            // 
            textAciklama.BackColor = Color.FromArgb(255, 192, 192);
            textAciklama.Location = new Point(0, 264);
            textAciklama.Name = "textAciklama";
            textAciklama.Size = new Size(448, 23);
            textAciklama.TabIndex = 2;
            // 
            // buttonGorevEkle
            // 
            buttonGorevEkle.BackColor = Color.FromArgb(255, 192, 255);
            buttonGorevEkle.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            buttonGorevEkle.Location = new Point(2, 317);
            buttonGorevEkle.Name = "buttonGorevEkle";
            buttonGorevEkle.Size = new Size(146, 71);
            buttonGorevEkle.TabIndex = 3;
            buttonGorevEkle.Text = "Görev Ekle";
            buttonGorevEkle.UseVisualStyleBackColor = false;
            buttonGorevEkle.Click += buttonGorevEkle_Click;
            // 
            // buttonGorevSil
            // 
            buttonGorevSil.BackColor = Color.FromArgb(255, 192, 255);
            buttonGorevSil.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            buttonGorevSil.Location = new Point(154, 317);
            buttonGorevSil.Name = "buttonGorevSil";
            buttonGorevSil.Size = new Size(135, 71);
            buttonGorevSil.TabIndex = 4;
            buttonGorevSil.Text = "Görev Sil";
            buttonGorevSil.UseVisualStyleBackColor = false;
            buttonGorevSil.Click += buttonGorevSil_Click;
            // 
            // buttonDrumDegistir
            // 
            buttonDrumDegistir.BackColor = Color.FromArgb(255, 192, 255);
            buttonDrumDegistir.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            buttonDrumDegistir.Location = new Point(295, 317);
            buttonDrumDegistir.Name = "buttonDrumDegistir";
            buttonDrumDegistir.Size = new Size(140, 71);
            buttonDrumDegistir.TabIndex = 5;
            buttonDrumDegistir.Text = "Durum Değiştir";
            buttonDrumDegistir.UseVisualStyleBackColor = false;
            buttonDrumDegistir.Click += buttonDrumDegistir_Click;
            // 
            // labelGorevler
            // 
            labelGorevler.AutoSize = true;
            labelGorevler.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            labelGorevler.Location = new Point(0, 187);
            labelGorevler.Name = "labelGorevler";
            labelGorevler.Size = new Size(93, 18);
            labelGorevler.TabIndex = 6;
            labelGorevler.Text = "Görev Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(2, 243);
            label2.Name = "label2";
            label2.Size = new Size(85, 18);
            label2.TabIndex = 7;
            label2.Text = "Açıklama";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(447, 422);
            Controls.Add(label2);
            Controls.Add(labelGorevler);
            Controls.Add(buttonDrumDegistir);
            Controls.Add(buttonGorevSil);
            Controls.Add(buttonGorevEkle);
            Controls.Add(textAciklama);
            Controls.Add(textGorevAdi);
            Controls.Add(lstGorevler);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstGorevler;
        private TextBox textGorevAdi;
        private TextBox textAciklama;
        private Button buttonGorevEkle;
        private Button buttonGorevSil;
        private Button buttonDrumDegistir;
        private Label labelGorevler;
        private Label label2;
    }
}
