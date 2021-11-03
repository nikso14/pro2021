
namespace seznam
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtVnos = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnIzpis = new System.Windows.Forms.Button();
            this.txtKonzola = new System.Windows.Forms.TextBox();
            this.btnOdstrani = new System.Windows.Forms.Button();
            this.btnPrvi = new System.Windows.Forms.Button();
            this.btnZadnji = new System.Windows.Forms.Button();
            this.btnPrazna = new System.Windows.Forms.Button();
            this.btnVsebuje = new System.Windows.Forms.Button();
            this.btnLokacija = new System.Windows.Forms.Button();
            this.btnTrim = new System.Windows.Forms.Button();
            this.btnStatistika = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "vnesi niz";
            // 
            // txtVnos
            // 
            this.txtVnos.Location = new System.Drawing.Point(74, 9);
            this.txtVnos.Name = "txtVnos";
            this.txtVnos.Size = new System.Drawing.Size(100, 20);
            this.txtVnos.TabIndex = 1;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(180, 8);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 2;
            this.btnDodaj.Text = "dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnIzpis
            // 
            this.btnIzpis.Location = new System.Drawing.Point(180, 111);
            this.btnIzpis.Name = "btnIzpis";
            this.btnIzpis.Size = new System.Drawing.Size(75, 23);
            this.btnIzpis.TabIndex = 3;
            this.btnIzpis.Text = "izpis";
            this.btnIzpis.UseVisualStyleBackColor = true;
            this.btnIzpis.Click += new System.EventHandler(this.btnIzpis_Click);
            // 
            // txtKonzola
            // 
            this.txtKonzola.Location = new System.Drawing.Point(16, 140);
            this.txtKonzola.Multiline = true;
            this.txtKonzola.Name = "txtKonzola";
            this.txtKonzola.ReadOnly = true;
            this.txtKonzola.Size = new System.Drawing.Size(239, 183);
            this.txtKonzola.TabIndex = 4;
            // 
            // btnOdstrani
            // 
            this.btnOdstrani.Location = new System.Drawing.Point(16, 53);
            this.btnOdstrani.Name = "btnOdstrani";
            this.btnOdstrani.Size = new System.Drawing.Size(75, 23);
            this.btnOdstrani.TabIndex = 5;
            this.btnOdstrani.Text = "odstrani";
            this.btnOdstrani.UseVisualStyleBackColor = true;
            this.btnOdstrani.Click += new System.EventHandler(this.btnOdstrani_Click);
            // 
            // btnPrvi
            // 
            this.btnPrvi.Location = new System.Drawing.Point(99, 53);
            this.btnPrvi.Name = "btnPrvi";
            this.btnPrvi.Size = new System.Drawing.Size(75, 23);
            this.btnPrvi.TabIndex = 6;
            this.btnPrvi.Text = "prvi";
            this.btnPrvi.UseVisualStyleBackColor = true;
            this.btnPrvi.Click += new System.EventHandler(this.btnPrvi_Click);
            // 
            // btnZadnji
            // 
            this.btnZadnji.Location = new System.Drawing.Point(180, 53);
            this.btnZadnji.Name = "btnZadnji";
            this.btnZadnji.Size = new System.Drawing.Size(75, 23);
            this.btnZadnji.TabIndex = 7;
            this.btnZadnji.Text = "Zadnji";
            this.btnZadnji.UseVisualStyleBackColor = true;
            this.btnZadnji.Click += new System.EventHandler(this.btnZadnji_Click);
            // 
            // btnPrazna
            // 
            this.btnPrazna.Location = new System.Drawing.Point(16, 82);
            this.btnPrazna.Name = "btnPrazna";
            this.btnPrazna.Size = new System.Drawing.Size(75, 23);
            this.btnPrazna.TabIndex = 8;
            this.btnPrazna.Text = "Je prazna";
            this.btnPrazna.UseVisualStyleBackColor = true;
            this.btnPrazna.Click += new System.EventHandler(this.btnPrazna_Click);
            // 
            // btnVsebuje
            // 
            this.btnVsebuje.Location = new System.Drawing.Point(99, 82);
            this.btnVsebuje.Name = "btnVsebuje";
            this.btnVsebuje.Size = new System.Drawing.Size(75, 23);
            this.btnVsebuje.TabIndex = 9;
            this.btnVsebuje.Text = "vsebuje";
            this.btnVsebuje.UseVisualStyleBackColor = true;
            this.btnVsebuje.Click += new System.EventHandler(this.btnVsebuje_Click);
            // 
            // btnLokacija
            // 
            this.btnLokacija.Location = new System.Drawing.Point(180, 82);
            this.btnLokacija.Name = "btnLokacija";
            this.btnLokacija.Size = new System.Drawing.Size(75, 23);
            this.btnLokacija.TabIndex = 10;
            this.btnLokacija.Text = "lokacija";
            this.btnLokacija.UseVisualStyleBackColor = true;
            this.btnLokacija.Click += new System.EventHandler(this.btnLokacija_Click);
            // 
            // btnTrim
            // 
            this.btnTrim.Location = new System.Drawing.Point(16, 111);
            this.btnTrim.Name = "btnTrim";
            this.btnTrim.Size = new System.Drawing.Size(75, 23);
            this.btnTrim.TabIndex = 11;
            this.btnTrim.Text = "trim";
            this.btnTrim.UseVisualStyleBackColor = true;
            this.btnTrim.Click += new System.EventHandler(this.btnTrim_Click);
            // 
            // btnStatistika
            // 
            this.btnStatistika.Location = new System.Drawing.Point(99, 111);
            this.btnStatistika.Name = "btnStatistika";
            this.btnStatistika.Size = new System.Drawing.Size(75, 23);
            this.btnStatistika.TabIndex = 12;
            this.btnStatistika.Text = "statistika";
            this.btnStatistika.UseVisualStyleBackColor = true;
            this.btnStatistika.Click += new System.EventHandler(this.btnStatistika_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 340);
            this.Controls.Add(this.btnStatistika);
            this.Controls.Add(this.btnTrim);
            this.Controls.Add(this.btnLokacija);
            this.Controls.Add(this.btnVsebuje);
            this.Controls.Add(this.btnPrazna);
            this.Controls.Add(this.btnZadnji);
            this.Controls.Add(this.btnPrvi);
            this.Controls.Add(this.btnOdstrani);
            this.Controls.Add(this.txtKonzola);
            this.Controls.Add(this.btnIzpis);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.txtVnos);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVnos;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnIzpis;
        private System.Windows.Forms.TextBox txtKonzola;
        private System.Windows.Forms.Button btnOdstrani;
        private System.Windows.Forms.Button btnPrvi;
        private System.Windows.Forms.Button btnZadnji;
        private System.Windows.Forms.Button btnPrazna;
        private System.Windows.Forms.Button btnVsebuje;
        private System.Windows.Forms.Button btnLokacija;
        private System.Windows.Forms.Button btnTrim;
        private System.Windows.Forms.Button btnStatistika;
    }
}

