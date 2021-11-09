
namespace IgranjeKart
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
            this.listKup1 = new System.Windows.Forms.ListBox();
            this.listKup2 = new System.Windows.Forms.ListBox();
            this.btnNaKup2 = new System.Windows.Forms.Button();
            this.btnNaKup1 = new System.Windows.Forms.Button();
            this.btnPonastaviKup1 = new System.Windows.Forms.Button();
            this.btnMešajKup1 = new System.Windows.Forms.Button();
            this.btnMešajKup2 = new System.Windows.Forms.Button();
            this.btnPonastaviKup2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "kup 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(405, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "kup 2";
            // 
            // listKup1
            // 
            this.listKup1.FormattingEnabled = true;
            this.listKup1.Location = new System.Drawing.Point(12, 29);
            this.listKup1.Name = "listKup1";
            this.listKup1.Size = new System.Drawing.Size(169, 342);
            this.listKup1.TabIndex = 3;
            // 
            // listKup2
            // 
            this.listKup2.FormattingEnabled = true;
            this.listKup2.Location = new System.Drawing.Point(271, 29);
            this.listKup2.Name = "listKup2";
            this.listKup2.Size = new System.Drawing.Size(169, 342);
            this.listKup2.TabIndex = 4;
            // 
            // btnNaKup2
            // 
            this.btnNaKup2.Location = new System.Drawing.Point(188, 76);
            this.btnNaKup2.Name = "btnNaKup2";
            this.btnNaKup2.Size = new System.Drawing.Size(75, 23);
            this.btnNaKup2.TabIndex = 5;
            this.btnNaKup2.Text = ">>";
            this.btnNaKup2.UseVisualStyleBackColor = true;
            this.btnNaKup2.Click += new System.EventHandler(this.btnNaKup2_Click);
            // 
            // btnNaKup1
            // 
            this.btnNaKup1.Location = new System.Drawing.Point(187, 105);
            this.btnNaKup1.Name = "btnNaKup1";
            this.btnNaKup1.Size = new System.Drawing.Size(75, 23);
            this.btnNaKup1.TabIndex = 6;
            this.btnNaKup1.Text = "<<";
            this.btnNaKup1.UseVisualStyleBackColor = true;
            this.btnNaKup1.Click += new System.EventHandler(this.btnNaKup1_Click);
            // 
            // btnPonastaviKup1
            // 
            this.btnPonastaviKup1.Location = new System.Drawing.Point(12, 386);
            this.btnPonastaviKup1.Name = "btnPonastaviKup1";
            this.btnPonastaviKup1.Size = new System.Drawing.Size(169, 23);
            this.btnPonastaviKup1.TabIndex = 7;
            this.btnPonastaviKup1.Text = "ponastavi kup 1";
            this.btnPonastaviKup1.UseVisualStyleBackColor = true;
            this.btnPonastaviKup1.Click += new System.EventHandler(this.btnPonastaviKup1_Click);
            // 
            // btnMešajKup1
            // 
            this.btnMešajKup1.Location = new System.Drawing.Point(12, 415);
            this.btnMešajKup1.Name = "btnMešajKup1";
            this.btnMešajKup1.Size = new System.Drawing.Size(169, 23);
            this.btnMešajKup1.TabIndex = 8;
            this.btnMešajKup1.Text = "mešaj kup 1";
            this.btnMešajKup1.UseVisualStyleBackColor = true;
            this.btnMešajKup1.Click += new System.EventHandler(this.btnMešajKup1_Click);
            // 
            // btnMešajKup2
            // 
            this.btnMešajKup2.Location = new System.Drawing.Point(270, 415);
            this.btnMešajKup2.Name = "btnMešajKup2";
            this.btnMešajKup2.Size = new System.Drawing.Size(169, 23);
            this.btnMešajKup2.TabIndex = 9;
            this.btnMešajKup2.Text = "mešaj kup 2";
            this.btnMešajKup2.UseVisualStyleBackColor = true;
            this.btnMešajKup2.Click += new System.EventHandler(this.btnMešajKup2_Click);
            // 
            // btnPonastaviKup2
            // 
            this.btnPonastaviKup2.Location = new System.Drawing.Point(270, 386);
            this.btnPonastaviKup2.Name = "btnPonastaviKup2";
            this.btnPonastaviKup2.Size = new System.Drawing.Size(169, 23);
            this.btnPonastaviKup2.TabIndex = 10;
            this.btnPonastaviKup2.Text = "ponastavi kup 2";
            this.btnPonastaviKup2.UseVisualStyleBackColor = true;
            this.btnPonastaviKup2.Click += new System.EventHandler(this.btnPonastaviKup2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 450);
            this.Controls.Add(this.btnPonastaviKup2);
            this.Controls.Add(this.btnMešajKup2);
            this.Controls.Add(this.btnMešajKup1);
            this.Controls.Add(this.btnPonastaviKup1);
            this.Controls.Add(this.btnNaKup1);
            this.Controls.Add(this.btnNaKup2);
            this.Controls.Add(this.listKup2);
            this.Controls.Add(this.listKup1);
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
        private System.Windows.Forms.ListBox listKup1;
        private System.Windows.Forms.ListBox listKup2;
        private System.Windows.Forms.Button btnNaKup2;
        private System.Windows.Forms.Button btnNaKup1;
        private System.Windows.Forms.Button btnPonastaviKup1;
        private System.Windows.Forms.Button btnMešajKup1;
        private System.Windows.Forms.Button btnMešajKup2;
        private System.Windows.Forms.Button btnPonastaviKup2;
    }
}

