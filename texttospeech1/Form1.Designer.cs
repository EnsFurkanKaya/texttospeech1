namespace texttospeech1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxTTS = new System.Windows.Forms.GroupBox();
            this.btnSeslendir = new System.Windows.Forms.Button();
            this.txtMetinGirdisi = new System.Windows.Forms.TextBox();
            this.trackBarHiz = new System.Windows.Forms.TrackBar();
            this.cmbSesler = new System.Windows.Forms.ComboBox();
            this.groupBoxSTT = new System.Windows.Forms.GroupBox();
            this.txtAlgilananMetin = new System.Windows.Forms.TextBox();
            this.btnDinle = new System.Windows.Forms.Button();
            this.lblDurum = new System.Windows.Forms.Label();
            this.groupBoxTTS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarHiz)).BeginInit();
            this.groupBoxSTT.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTTS
            // 
            this.groupBoxTTS.Controls.Add(this.btnSeslendir);
            this.groupBoxTTS.Controls.Add(this.txtMetinGirdisi);
            this.groupBoxTTS.Controls.Add(this.trackBarHiz);
            this.groupBoxTTS.Controls.Add(this.cmbSesler);
            this.groupBoxTTS.Location = new System.Drawing.Point(51, 52);
            this.groupBoxTTS.Name = "groupBoxTTS";
            this.groupBoxTTS.Size = new System.Drawing.Size(776, 219);
            this.groupBoxTTS.TabIndex = 0;
            this.groupBoxTTS.TabStop = false;
            this.groupBoxTTS.Text = "Metni Sese Dönüştür (TTS)";
            // 
            // btnSeslendir
            // 
            this.btnSeslendir.Location = new System.Drawing.Point(159, 173);
            this.btnSeslendir.Name = "btnSeslendir";
            this.btnSeslendir.Size = new System.Drawing.Size(276, 40);
            this.btnSeslendir.TabIndex = 4;
            this.btnSeslendir.Text = "Seslendir";
            this.btnSeslendir.UseVisualStyleBackColor = true;
            this.btnSeslendir.Click += new System.EventHandler(this.btnSeslendir_Click);
            // 
            // txtMetinGirdisi
            // 
            this.txtMetinGirdisi.Location = new System.Drawing.Point(59, 38);
            this.txtMetinGirdisi.Multiline = true;
            this.txtMetinGirdisi.Name = "txtMetinGirdisi";
            this.txtMetinGirdisi.Size = new System.Drawing.Size(414, 26);
            this.txtMetinGirdisi.TabIndex = 1;
            this.txtMetinGirdisi.Text = "Buraya seslendirilecek metni yazın...";
            // 
            // trackBarHiz
            // 
            this.trackBarHiz.Location = new System.Drawing.Point(135, 122);
            this.trackBarHiz.Minimum = -10;
            this.trackBarHiz.Name = "trackBarHiz";
            this.trackBarHiz.Size = new System.Drawing.Size(327, 69);
            this.trackBarHiz.TabIndex = 3;
            // 
            // cmbSesler
            // 
            this.cmbSesler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSesler.FormattingEnabled = true;
            this.cmbSesler.Location = new System.Drawing.Point(135, 79);
            this.cmbSesler.Name = "cmbSesler";
            this.cmbSesler.Size = new System.Drawing.Size(327, 28);
            this.cmbSesler.TabIndex = 2;
            // 
            // groupBoxSTT
            // 
            this.groupBoxSTT.Controls.Add(this.txtAlgilananMetin);
            this.groupBoxSTT.Controls.Add(this.btnDinle);
            this.groupBoxSTT.Controls.Add(this.lblDurum);
            this.groupBoxSTT.Location = new System.Drawing.Point(51, 299);
            this.groupBoxSTT.Name = "groupBoxSTT";
            this.groupBoxSTT.Size = new System.Drawing.Size(773, 223);
            this.groupBoxSTT.TabIndex = 1;
            this.groupBoxSTT.TabStop = false;
            this.groupBoxSTT.Text = "Sesi Metne Dönüştür (STT)";
            // 
            // txtAlgilananMetin
            // 
            this.txtAlgilananMetin.Location = new System.Drawing.Point(22, 57);
            this.txtAlgilananMetin.Multiline = true;
            this.txtAlgilananMetin.Name = "txtAlgilananMetin";
            this.txtAlgilananMetin.ReadOnly = true;
            this.txtAlgilananMetin.Size = new System.Drawing.Size(464, 37);
            this.txtAlgilananMetin.TabIndex = 2;
            // 
            // btnDinle
            // 
            this.btnDinle.Location = new System.Drawing.Point(135, 137);
            this.btnDinle.Name = "btnDinle";
            this.btnDinle.Size = new System.Drawing.Size(300, 31);
            this.btnDinle.TabIndex = 3;
            this.btnDinle.Text = "Dinlemeyi Başlat";
            this.btnDinle.UseVisualStyleBackColor = true;
            this.btnDinle.Click += new System.EventHandler(this.btnDinle_Click);
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblDurum.Location = new System.Drawing.Point(40, 181);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(145, 20);
            this.lblDurum.TabIndex = 4;
            this.lblDurum.Text = "Durum: Beklemede";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 583);
            this.Controls.Add(this.groupBoxSTT);
            this.Controls.Add(this.groupBoxTTS);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxTTS.ResumeLayout(false);
            this.groupBoxTTS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarHiz)).EndInit();
            this.groupBoxSTT.ResumeLayout(false);
            this.groupBoxSTT.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTTS;
        private System.Windows.Forms.TextBox txtMetinGirdisi;
        private System.Windows.Forms.ComboBox cmbSesler;
        private System.Windows.Forms.TrackBar trackBarHiz;
        private System.Windows.Forms.Button btnSeslendir;
        private System.Windows.Forms.GroupBox groupBoxSTT;
        private System.Windows.Forms.TextBox txtAlgilananMetin;
        private System.Windows.Forms.Button btnDinle;
        private System.Windows.Forms.Label lblDurum;
    }
}

