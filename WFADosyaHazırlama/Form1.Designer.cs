namespace WFADosyaHazırlama
{
    partial class Form1
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
            this.grpKlasorolusturma = new System.Windows.Forms.GroupBox();
            this.txtKayitYeri = new System.Windows.Forms.TextBox();
            this.lnkDosyayoluSec = new System.Windows.Forms.LinkLabel();
            this.btnKlasorOlustur = new System.Windows.Forms.Button();
            this.txtKlasorAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpKlasorListele = new System.Windows.Forms.GroupBox();
            this.lstDosyalar = new System.Windows.Forms.ListBox();
            this.lnkKlasorSec = new System.Windows.Forms.LinkLabel();
            this.grpDosyaİslemleri = new System.Windows.Forms.GroupBox();
            this.txtYazi = new System.Windows.Forms.TextBox();
            this.btnDosyaKaydet = new System.Windows.Forms.Button();
            this.grpKlasorolusturma.SuspendLayout();
            this.grpKlasorListele.SuspendLayout();
            this.grpDosyaİslemleri.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpKlasorolusturma
            // 
            this.grpKlasorolusturma.Controls.Add(this.txtKayitYeri);
            this.grpKlasorolusturma.Controls.Add(this.lnkDosyayoluSec);
            this.grpKlasorolusturma.Controls.Add(this.btnKlasorOlustur);
            this.grpKlasorolusturma.Controls.Add(this.txtKlasorAdi);
            this.grpKlasorolusturma.Controls.Add(this.label1);
            this.grpKlasorolusturma.Location = new System.Drawing.Point(12, 12);
            this.grpKlasorolusturma.Name = "grpKlasorolusturma";
            this.grpKlasorolusturma.Size = new System.Drawing.Size(290, 232);
            this.grpKlasorolusturma.TabIndex = 0;
            this.grpKlasorolusturma.TabStop = false;
            this.grpKlasorolusturma.Text = "Klasör oluşturma";
            // 
            // txtKayitYeri
            // 
            this.txtKayitYeri.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtKayitYeri.Location = new System.Drawing.Point(6, 102);
            this.txtKayitYeri.Name = "txtKayitYeri";
            this.txtKayitYeri.ReadOnly = true;
            this.txtKayitYeri.Size = new System.Drawing.Size(237, 26);
            this.txtKayitYeri.TabIndex = 4;
            // 
            // lnkDosyayoluSec
            // 
            this.lnkDosyayoluSec.AutoSize = true;
            this.lnkDosyayoluSec.Location = new System.Drawing.Point(10, 79);
            this.lnkDosyayoluSec.Name = "lnkDosyayoluSec";
            this.lnkDosyayoluSec.Size = new System.Drawing.Size(149, 20);
            this.lnkDosyayoluSec.TabIndex = 3;
            this.lnkDosyayoluSec.TabStop = true;
            this.lnkDosyayoluSec.Text = "Kayıt Yerini Seçin";
            this.lnkDosyayoluSec.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkDosyayoluSec_LinkClicked);
            // 
            // btnKlasorOlustur
            // 
            this.btnKlasorOlustur.Location = new System.Drawing.Point(70, 175);
            this.btnKlasorOlustur.Name = "btnKlasorOlustur";
            this.btnKlasorOlustur.Size = new System.Drawing.Size(117, 35);
            this.btnKlasorOlustur.TabIndex = 2;
            this.btnKlasorOlustur.Text = "button1";
            this.btnKlasorOlustur.UseVisualStyleBackColor = true;
            this.btnKlasorOlustur.Click += new System.EventHandler(this.btnKlasorOlustur_Click);
            // 
            // txtKlasorAdi
            // 
            this.txtKlasorAdi.Location = new System.Drawing.Point(6, 46);
            this.txtKlasorAdi.Name = "txtKlasorAdi";
            this.txtKlasorAdi.Size = new System.Drawing.Size(237, 26);
            this.txtKlasorAdi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Klasör Adı Girin";
            // 
            // grpKlasorListele
            // 
            this.grpKlasorListele.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpKlasorListele.Controls.Add(this.lstDosyalar);
            this.grpKlasorListele.Controls.Add(this.lnkKlasorSec);
            this.grpKlasorListele.Location = new System.Drawing.Point(376, 25);
            this.grpKlasorListele.Name = "grpKlasorListele";
            this.grpKlasorListele.Size = new System.Drawing.Size(277, 219);
            this.grpKlasorListele.TabIndex = 1;
            this.grpKlasorListele.TabStop = false;
            // 
            // lstDosyalar
            // 
            this.lstDosyalar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstDosyalar.FormattingEnabled = true;
            this.lstDosyalar.ItemHeight = 20;
            this.lstDosyalar.Location = new System.Drawing.Point(10, 33);
            this.lstDosyalar.Name = "lstDosyalar";
            this.lstDosyalar.Size = new System.Drawing.Size(261, 164);
            this.lstDosyalar.TabIndex = 0;
            // 
            // lnkKlasorSec
            // 
            this.lnkKlasorSec.AutoSize = true;
            this.lnkKlasorSec.Location = new System.Drawing.Point(6, 10);
            this.lnkKlasorSec.Name = "lnkKlasorSec";
            this.lnkKlasorSec.Size = new System.Drawing.Size(95, 20);
            this.lnkKlasorSec.TabIndex = 0;
            this.lnkKlasorSec.TabStop = true;
            this.lnkKlasorSec.Text = "Klasör Seç";
            this.lnkKlasorSec.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkKlasorSec_LinkClicked);
            // 
            // grpDosyaİslemleri
            // 
            this.grpDosyaİslemleri.Controls.Add(this.txtYazi);
            this.grpDosyaİslemleri.Location = new System.Drawing.Point(12, 267);
            this.grpDosyaİslemleri.Name = "grpDosyaİslemleri";
            this.grpDosyaİslemleri.Size = new System.Drawing.Size(641, 161);
            this.grpDosyaİslemleri.TabIndex = 2;
            this.grpDosyaİslemleri.TabStop = false;
            this.grpDosyaİslemleri.Text = "Dosya İşlemleri";
            // 
            // txtYazi
            // 
            this.txtYazi.Location = new System.Drawing.Point(14, 38);
            this.txtYazi.Multiline = true;
            this.txtYazi.Name = "txtYazi";
            this.txtYazi.Size = new System.Drawing.Size(607, 104);
            this.txtYazi.TabIndex = 0;
            // 
            // btnDosyaKaydet
            // 
            this.btnDosyaKaydet.Location = new System.Drawing.Point(448, 434);
            this.btnDosyaKaydet.Name = "btnDosyaKaydet";
            this.btnDosyaKaydet.Size = new System.Drawing.Size(199, 30);
            this.btnDosyaKaydet.TabIndex = 3;
            this.btnDosyaKaydet.Text = "Dosya olarak kaydet";
            this.btnDosyaKaydet.UseVisualStyleBackColor = true;
            this.btnDosyaKaydet.Click += new System.EventHandler(this.btnDosyaKaydet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 591);
            this.Controls.Add(this.btnDosyaKaydet);
            this.Controls.Add(this.grpDosyaİslemleri);
            this.Controls.Add(this.grpKlasorListele);
            this.Controls.Add(this.grpKlasorolusturma);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpKlasorolusturma.ResumeLayout(false);
            this.grpKlasorolusturma.PerformLayout();
            this.grpKlasorListele.ResumeLayout(false);
            this.grpKlasorListele.PerformLayout();
            this.grpDosyaİslemleri.ResumeLayout(false);
            this.grpDosyaİslemleri.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpKlasorolusturma;
        private System.Windows.Forms.TextBox txtKayitYeri;
        private System.Windows.Forms.LinkLabel lnkDosyayoluSec;
        private System.Windows.Forms.Button btnKlasorOlustur;
        private System.Windows.Forms.TextBox txtKlasorAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpKlasorListele;
        private System.Windows.Forms.ListBox lstDosyalar;
        private System.Windows.Forms.LinkLabel lnkKlasorSec;
        private System.Windows.Forms.GroupBox grpDosyaİslemleri;
        private System.Windows.Forms.TextBox txtYazi;
        private System.Windows.Forms.Button btnDosyaKaydet;
    }
}

