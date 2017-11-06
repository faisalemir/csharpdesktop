namespace Belajar
{
    partial class FormInput
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
            this.lbl_nama = new System.Windows.Forms.Label();
            this.tbx_nama = new System.Windows.Forms.TextBox();
            this.lbl_alamat = new System.Windows.Forms.Label();
            this.tbx_alamat = new System.Windows.Forms.TextBox();
            this.btn_tambah = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_nama
            // 
            this.lbl_nama.AutoSize = true;
            this.lbl_nama.Location = new System.Drawing.Point(13, 13);
            this.lbl_nama.Name = "lbl_nama";
            this.lbl_nama.Size = new System.Drawing.Size(35, 13);
            this.lbl_nama.TabIndex = 0;
            this.lbl_nama.Text = "Nama";
            // 
            // tbx_nama
            // 
            this.tbx_nama.Location = new System.Drawing.Point(68, 10);
            this.tbx_nama.Name = "tbx_nama";
            this.tbx_nama.Size = new System.Drawing.Size(177, 20);
            this.tbx_nama.TabIndex = 1;
            // 
            // lbl_alamat
            // 
            this.lbl_alamat.AutoSize = true;
            this.lbl_alamat.Location = new System.Drawing.Point(13, 39);
            this.lbl_alamat.Name = "lbl_alamat";
            this.lbl_alamat.Size = new System.Drawing.Size(39, 13);
            this.lbl_alamat.TabIndex = 2;
            this.lbl_alamat.Text = "Alamat";
            // 
            // tbx_alamat
            // 
            this.tbx_alamat.Location = new System.Drawing.Point(68, 36);
            this.tbx_alamat.Multiline = true;
            this.tbx_alamat.Name = "tbx_alamat";
            this.tbx_alamat.Size = new System.Drawing.Size(177, 66);
            this.tbx_alamat.TabIndex = 3;
            // 
            // btn_tambah
            // 
            this.btn_tambah.Location = new System.Drawing.Point(92, 117);
            this.btn_tambah.Name = "btn_tambah";
            this.btn_tambah.Size = new System.Drawing.Size(75, 23);
            this.btn_tambah.TabIndex = 4;
            this.btn_tambah.Text = "Tambah";
            this.btn_tambah.UseVisualStyleBackColor = true;
            this.btn_tambah.Click += new System.EventHandler(this.btn_tambah_Click);
            // 
            // FormInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 152);
            this.Controls.Add(this.btn_tambah);
            this.Controls.Add(this.tbx_alamat);
            this.Controls.Add(this.lbl_alamat);
            this.Controls.Add(this.tbx_nama);
            this.Controls.Add(this.lbl_nama);
            this.Name = "FormInput";
            this.Text = "FormInput";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nama;
        private System.Windows.Forms.TextBox tbx_nama;
        private System.Windows.Forms.Label lbl_alamat;
        private System.Windows.Forms.TextBox tbx_alamat;
        private System.Windows.Forms.Button btn_tambah;
    }
}