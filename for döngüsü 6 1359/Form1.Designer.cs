namespace for_döngüsü_6_1359
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
            this.başl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSayi1 = new System.Windows.Forms.TextBox();
            this.txtSayi2 = new System.Windows.Forms.TextBox();
            this.btnYaz = new System.Windows.Forms.Button();
            this.lbTek = new System.Windows.Forms.ListBox();
            this.lbCift = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // başl
            // 
            this.başl.AutoSize = true;
            this.başl.Location = new System.Drawing.Point(45, 57);
            this.başl.Name = "başl";
            this.başl.Size = new System.Drawing.Size(52, 13);
            this.başl.TabIndex = 0;
            this.başl.Text = "başlangıç";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "bitiş";
            // 
            // txtSayi1
            // 
            this.txtSayi1.Location = new System.Drawing.Point(48, 87);
            this.txtSayi1.Multiline = true;
            this.txtSayi1.Name = "txtSayi1";
            this.txtSayi1.Size = new System.Drawing.Size(100, 34);
            this.txtSayi1.TabIndex = 2;
            // 
            // txtSayi2
            // 
            this.txtSayi2.Location = new System.Drawing.Point(48, 178);
            this.txtSayi2.Multiline = true;
            this.txtSayi2.Name = "txtSayi2";
            this.txtSayi2.Size = new System.Drawing.Size(100, 34);
            this.txtSayi2.TabIndex = 3;
            // 
            // btnYaz
            // 
            this.btnYaz.Location = new System.Drawing.Point(48, 242);
            this.btnYaz.Name = "btnYaz";
            this.btnYaz.Size = new System.Drawing.Size(107, 54);
            this.btnYaz.TabIndex = 4;
            this.btnYaz.Text = "yaz";
            this.btnYaz.UseVisualStyleBackColor = true;
            this.btnYaz.Click += new System.EventHandler(this.btnYaz_Click);
            // 
            // lbTek
            // 
            this.lbTek.FormattingEnabled = true;
            this.lbTek.Location = new System.Drawing.Point(198, 83);
            this.lbTek.Name = "lbTek";
            this.lbTek.Size = new System.Drawing.Size(120, 212);
            this.lbTek.TabIndex = 5;
            // 
            // lbCift
            // 
            this.lbCift.FormattingEnabled = true;
            this.lbCift.Location = new System.Drawing.Point(354, 83);
            this.lbCift.Name = "lbCift";
            this.lbCift.Size = new System.Drawing.Size(120, 212);
            this.lbCift.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbCift);
            this.Controls.Add(this.lbTek);
            this.Controls.Add(this.btnYaz);
            this.Controls.Add(this.txtSayi2);
            this.Controls.Add(this.txtSayi1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.başl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label başl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSayi1;
        private System.Windows.Forms.TextBox txtSayi2;
        private System.Windows.Forms.Button btnYaz;
        private System.Windows.Forms.ListBox lbTek;
        private System.Windows.Forms.ListBox lbCift;
    }
}

