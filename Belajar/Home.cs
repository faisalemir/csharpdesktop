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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            lbl_title.Text = "Title";

            DataMahasiswa data = new DataMahasiswa();
            gv_tampil.AutoGenerateColumns = false;
            gv_tampil.DataSource = data.selectall();
        }

        private void gv_tampil_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_tambah_Click(object sender, EventArgs e)
        {
            FormInput frm_input = new FormInput();
            DataMahasiswa data = new DataMahasiswa();

            if (frm_input.ShowDialog() == DialogResult.OK)
            {
                gv_tampil.DataSource = data.selectall();
            }
        }
    }
}
