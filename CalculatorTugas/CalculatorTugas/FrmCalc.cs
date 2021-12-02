using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorTugas
{
    public partial class FrmCalc : Form
    {
        public delegate void Operasi(int a, int b);
        public event Operasi Bagi;
        public event Operasi Kali;
        public event Operasi Kurang;
        public event Operasi Tambah;


        public FrmCalc()
        {
            InitializeComponent();
            cmbOperasi.SelectedIndex = 0;
        }

        private void btnProses_Click(object sender, EventArgs e)
        {
            var opsi = cmbOperasi.Text;
            int a = int.Parse(txtNilaiA.Text);
            int b = int.Parse(txtNilaiB.Text);
            
            if (opsi == "Pembagian")
            {
                Bagi(a, b);
            }
            else if (opsi == "Perkalian")
            {
                Kali(a, b);
            }
            else if (opsi == "Pengurangan")
            {
                Kurang(a, b);
            }
            else if (opsi == "Penjumlahan")
            {
                Tambah(a, b);
            }
        }
    }
}
