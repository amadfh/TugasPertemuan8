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
    public partial class FrmHasil : Form
    {
        public FrmHasil()
        {
            InitializeComponent();
        }
        private void FrmCalc_Bagi(int a, int b)
        {
            var hasil = a / b;
            lstHasil.Items.Add(string.Format("Hasil Pembagian {0} / {1} = {2}", a,b,hasil));
        }
        private void FrmCalc_Kali(int a, int b)
        {
            var hasil = a * b;
            lstHasil.Items.Add(string.Format("Hasil Perkalian {0} X {1} = {2}", a, b, hasil));
        }
        private void FrmCalc_Kurang(int a, int b)
        {
            var hasil = a - b;
            lstHasil.Items.Add(string.Format("Hasil Pengurangan {0} - {1} = {2}", a, b, hasil));
        }
        private void FrmCalc_Tambah(int a, int b)
        {
            var hasil = a + b;
            lstHasil.Items.Add(string.Format("Hasil Penjumlahan : {0} + {1} = {2}", a, b, hasil));
        }
        private void btnHitung_Click(object sender, EventArgs e)
        {
            FrmCalc frmCalc = new FrmCalc();

            frmCalc.Bagi += FrmCalc_Bagi;
            frmCalc.Kali += FrmCalc_Kali;
            frmCalc.Kurang += FrmCalc_Kurang;
            frmCalc.Tambah += FrmCalc_Tambah;
            frmCalc.ShowDialog();
        }
    }
}
