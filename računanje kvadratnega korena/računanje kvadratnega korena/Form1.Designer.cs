
namespace računanje_kvadratnega_korena
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
            this.txtVnos = new System.Windows.Forms.TextBox();
            this.btnKoren = new System.Windows.Forms.Button();
            this.txtRezultat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtVnos
            // 
            this.txtVnos.Location = new System.Drawing.Point(12, 12);
            this.txtVnos.Name = "txtVnos";
            this.txtVnos.Size = new System.Drawing.Size(100, 20);
            this.txtVnos.TabIndex = 0;
            // 
            // btnKoren
            // 
            this.btnKoren.Location = new System.Drawing.Point(23, 38);
            this.btnKoren.Name = "btnKoren";
            this.btnKoren.Size = new System.Drawing.Size(75, 23);
            this.btnKoren.TabIndex = 1;
            this.btnKoren.Text = "button1";
            this.btnKoren.UseVisualStyleBackColor = true;
            this.btnKoren.Click += new System.EventHandler(this.btnKoren_Click);
            // 
            // txtRezultat
            // 
            this.txtRezultat.Location = new System.Drawing.Point(12, 67);
            this.txtRezultat.Name = "txtRezultat";
            this.txtRezultat.Size = new System.Drawing.Size(100, 20);
            this.txtRezultat.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtRezultat);
            this.Controls.Add(this.btnKoren);
            this.Controls.Add(this.txtVnos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtVnos;
        private System.Windows.Forms.Button btnKoren;
        private System.Windows.Forms.TextBox txtRezultat;
    }
}

