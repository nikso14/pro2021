
namespace deljenje_z_0
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtDeljenec = new System.Windows.Forms.TextBox();
            this.txtDeljitelj = new System.Windows.Forms.TextBox();
            this.labRezultat = new System.Windows.Forms.Label();
            this.btnIzracunaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "deljenec";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "deljitelj";
            // 
            // txtDeljenec
            // 
            this.txtDeljenec.Location = new System.Drawing.Point(146, 9);
            this.txtDeljenec.Name = "txtDeljenec";
            this.txtDeljenec.Size = new System.Drawing.Size(100, 20);
            this.txtDeljenec.TabIndex = 2;
            // 
            // txtDeljitelj
            // 
            this.txtDeljitelj.Location = new System.Drawing.Point(146, 64);
            this.txtDeljitelj.Name = "txtDeljitelj";
            this.txtDeljitelj.Size = new System.Drawing.Size(100, 20);
            this.txtDeljitelj.TabIndex = 3;
            // 
            // labRezultat
            // 
            this.labRezultat.AutoSize = true;
            this.labRezultat.Location = new System.Drawing.Point(143, 110);
            this.labRezultat.Name = "labRezultat";
            this.labRezultat.Size = new System.Drawing.Size(35, 13);
            this.labRezultat.TabIndex = 4;
            this.labRezultat.Text = "label3";
            // 
            // btnIzracunaj
            // 
            this.btnIzracunaj.Location = new System.Drawing.Point(12, 105);
            this.btnIzracunaj.Name = "btnIzracunaj";
            this.btnIzracunaj.Size = new System.Drawing.Size(75, 23);
            this.btnIzracunaj.TabIndex = 5;
            this.btnIzracunaj.Text = "button1";
            this.btnIzracunaj.UseVisualStyleBackColor = true;
            this.btnIzracunaj.Click += new System.EventHandler(this.btnIzracunaj_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnIzracunaj);
            this.Controls.Add(this.labRezultat);
            this.Controls.Add(this.txtDeljitelj);
            this.Controls.Add(this.txtDeljenec);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDeljenec;
        private System.Windows.Forms.TextBox txtDeljitelj;
        private System.Windows.Forms.Label labRezultat;
        private System.Windows.Forms.Button btnIzracunaj;
    }
}

