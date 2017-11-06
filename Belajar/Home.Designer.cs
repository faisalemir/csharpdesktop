namespace Belajar
{
    partial class Home
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
            this.gv_tampil = new System.Windows.Forms.DataGridView();
            this.id_mahasiswa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alamat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_title = new System.Windows.Forms.Label();
            this.btn_tambah = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gv_tampil)).BeginInit();
            this.SuspendLayout();
            // 
            // gv_tampil
            // 
            this.gv_tampil.AllowUserToAddRows = false;
            this.gv_tampil.AllowUserToDeleteRows = false;
            this.gv_tampil.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gv_tampil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gv_tampil.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_mahasiswa,
            this.nama,
            this.alamat});
            this.gv_tampil.Location = new System.Drawing.Point(12, 71);
            this.gv_tampil.Name = "gv_tampil";
            this.gv_tampil.ReadOnly = true;
            this.gv_tampil.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.gv_tampil.Size = new System.Drawing.Size(502, 258);
            this.gv_tampil.TabIndex = 0;
            this.gv_tampil.TabStop = false;
            this.gv_tampil.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_tampil_CellContentClick);
            // 
            // id_mahasiswa
            // 
            this.id_mahasiswa.DataPropertyName = "id_mahasiswa";
            this.id_mahasiswa.HeaderText = "ID";
            this.id_mahasiswa.Name = "id_mahasiswa";
            this.id_mahasiswa.ReadOnly = true;
            // 
            // nama
            // 
            this.nama.DataPropertyName = "nama";
            this.nama.HeaderText = "Nama";
            this.nama.Name = "nama";
            this.nama.ReadOnly = true;
            // 
            // alamat
            // 
            this.alamat.DataPropertyName = "alamat";
            this.alamat.HeaderText = "Alamat";
            this.alamat.Name = "alamat";
            this.alamat.ReadOnly = true;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Location = new System.Drawing.Point(13, 27);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(0, 13);
            this.lbl_title.TabIndex = 1;
            // 
            // btn_tambah
            // 
            this.btn_tambah.Location = new System.Drawing.Point(400, 36);
            this.btn_tambah.Name = "btn_tambah";
            this.btn_tambah.Size = new System.Drawing.Size(75, 23);
            this.btn_tambah.TabIndex = 3;
            this.btn_tambah.Text = "Tambah";
            this.btn_tambah.UseVisualStyleBackColor = true;
            this.btn_tambah.Click += new System.EventHandler(this.btn_tambah_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 341);
            this.Controls.Add(this.btn_tambah);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.gv_tampil);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Home";
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.gv_tampil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Button btn_tambah;
        private System.Windows.Forms.DataGridView gv_tampil;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_mahasiswa;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamat;
    }
}