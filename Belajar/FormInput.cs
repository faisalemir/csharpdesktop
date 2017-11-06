using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data;

namespace Belajar
{
    public partial class FormInput : Form
    {
        public FormInput()
        {
            InitializeComponent();
        }

        private void btn_tambah_Click(object sender, EventArgs e)
        {
            ModelMahasiswa m = new ModelMahasiswa();
            m.nama = tbx_nama.Text;
            m.alamat = tbx_alamat.Text;
            m.created_by = string.Empty;

            DataMahasiswa data_mhs = new DataMahasiswa();
            bool result = data_mhs.insert(m);

            if (result)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
                MessageBox.Show("Data has been added.", "Success");
            }
        }
    }
}
