namespace SinemaOtomasyonuWinForm
{
    partial class MasterForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.anasayfaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ekleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filmEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seansEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salonEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.düzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seansToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayarlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yöneticiEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yöneticiSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblYoneticiAdi = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(117)))), ((int)(((byte)(158)))));
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anasayfaToolStripMenuItem,
            this.ekleToolStripMenuItem,
            this.düzenleToolStripMenuItem,
            this.ayarlarToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MinimumSize = new System.Drawing.Size(0, 40);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(809, 40);
            this.menuStrip1.TabIndex = 41;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // anasayfaToolStripMenuItem
            // 
            this.anasayfaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.anasayfaToolStripMenuItem.Name = "anasayfaToolStripMenuItem";
            this.anasayfaToolStripMenuItem.Size = new System.Drawing.Size(52, 36);
            this.anasayfaToolStripMenuItem.Text = "Bilet";
            this.anasayfaToolStripMenuItem.Click += new System.EventHandler(this.anasayfaToolStripMenuItem_Click);
            // 
            // ekleToolStripMenuItem
            // 
            this.ekleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filmEkleToolStripMenuItem,
            this.seansEkleToolStripMenuItem,
            this.salonEkleToolStripMenuItem});
            this.ekleToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ekleToolStripMenuItem.Name = "ekleToolStripMenuItem";
            this.ekleToolStripMenuItem.Size = new System.Drawing.Size(50, 36);
            this.ekleToolStripMenuItem.Text = "Ekle";
            // 
            // filmEkleToolStripMenuItem
            // 
            this.filmEkleToolStripMenuItem.Name = "filmEkleToolStripMenuItem";
            this.filmEkleToolStripMenuItem.Size = new System.Drawing.Size(121, 26);
            this.filmEkleToolStripMenuItem.Text = "Film";
            this.filmEkleToolStripMenuItem.Click += new System.EventHandler(this.filmEkleToolStripMenuItem_Click);
            // 
            // seansEkleToolStripMenuItem
            // 
            this.seansEkleToolStripMenuItem.Name = "seansEkleToolStripMenuItem";
            this.seansEkleToolStripMenuItem.Size = new System.Drawing.Size(121, 26);
            this.seansEkleToolStripMenuItem.Text = "Seans";
            this.seansEkleToolStripMenuItem.Click += new System.EventHandler(this.seansEkleToolStripMenuItem_Click);
            // 
            // salonEkleToolStripMenuItem
            // 
            this.salonEkleToolStripMenuItem.Name = "salonEkleToolStripMenuItem";
            this.salonEkleToolStripMenuItem.Size = new System.Drawing.Size(121, 26);
            this.salonEkleToolStripMenuItem.Text = "Salon";
            this.salonEkleToolStripMenuItem.Click += new System.EventHandler(this.salonEkleToolStripMenuItem_Click);
            // 
            // düzenleToolStripMenuItem
            // 
            this.düzenleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filmToolStripMenuItem,
            this.seansToolStripMenuItem,
            this.salonToolStripMenuItem});
            this.düzenleToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.düzenleToolStripMenuItem.Name = "düzenleToolStripMenuItem";
            this.düzenleToolStripMenuItem.Size = new System.Drawing.Size(78, 36);
            this.düzenleToolStripMenuItem.Text = "Düzenle";
            // 
            // filmToolStripMenuItem
            // 
            this.filmToolStripMenuItem.Name = "filmToolStripMenuItem";
            this.filmToolStripMenuItem.Size = new System.Drawing.Size(121, 26);
            this.filmToolStripMenuItem.Text = "Film";
            this.filmToolStripMenuItem.Click += new System.EventHandler(this.filmToolStripMenuItem_Click);
            // 
            // seansToolStripMenuItem
            // 
            this.seansToolStripMenuItem.Name = "seansToolStripMenuItem";
            this.seansToolStripMenuItem.Size = new System.Drawing.Size(121, 26);
            this.seansToolStripMenuItem.Text = "Seans";
            this.seansToolStripMenuItem.Click += new System.EventHandler(this.seansToolStripMenuItem_Click);
            // 
            // salonToolStripMenuItem
            // 
            this.salonToolStripMenuItem.Name = "salonToolStripMenuItem";
            this.salonToolStripMenuItem.Size = new System.Drawing.Size(121, 26);
            this.salonToolStripMenuItem.Text = "Salon";
            this.salonToolStripMenuItem.Click += new System.EventHandler(this.salonToolStripMenuItem_Click);
            // 
            // ayarlarToolStripMenuItem
            // 
            this.ayarlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yöneticiEkleToolStripMenuItem,
            this.yöneticiSilToolStripMenuItem});
            this.ayarlarToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ayarlarToolStripMenuItem.Name = "ayarlarToolStripMenuItem";
            this.ayarlarToolStripMenuItem.Size = new System.Drawing.Size(72, 36);
            this.ayarlarToolStripMenuItem.Text = "Ayarlar";
            // 
            // yöneticiEkleToolStripMenuItem
            // 
            this.yöneticiEkleToolStripMenuItem.Name = "yöneticiEkleToolStripMenuItem";
            this.yöneticiEkleToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.yöneticiEkleToolStripMenuItem.Text = "Yönetici";
            this.yöneticiEkleToolStripMenuItem.Click += new System.EventHandler(this.yöneticiEkleToolStripMenuItem_Click);
            // 
            // yöneticiSilToolStripMenuItem
            // 
            this.yöneticiSilToolStripMenuItem.Name = "yöneticiSilToolStripMenuItem";
            this.yöneticiSilToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.yöneticiSilToolStripMenuItem.Text = "Bilet Fiyatları";
            this.yöneticiSilToolStripMenuItem.Click += new System.EventHandler(this.yöneticiSilToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(55, 36);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // lblYoneticiAdi
            // 
            this.lblYoneticiAdi.AutoSize = true;
            this.lblYoneticiAdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(117)))), ((int)(((byte)(158)))));
            this.lblYoneticiAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblYoneticiAdi.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblYoneticiAdi.Location = new System.Drawing.Point(667, 12);
            this.lblYoneticiAdi.Name = "lblYoneticiAdi";
            this.lblYoneticiAdi.Size = new System.Drawing.Size(132, 15);
            this.lblYoneticiAdi.TabIndex = 43;
            this.lblYoneticiAdi.Text = "Hoş geldin, YoneticiAdi";
            // 
            // MasterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(809, 490);
            this.Controls.Add(this.lblYoneticiAdi);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MasterForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.MasterForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem anasayfaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filmEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seansEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salonEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yöneticiEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yöneticiSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayarlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seansToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem düzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ekleToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label lblYoneticiAdi;
    }
}