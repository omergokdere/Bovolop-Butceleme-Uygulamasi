using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bovolop_Butceleme_Uygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Verilen hizmetler urun ismi girdisi ve satislara tasima
        private void tbVH1_TextChanged(object sender, EventArgs e)
        {
            textBox1090.Text = tbVH1.Text;
            groupBox2.Text = tbVH1.Text;

        }

        private void tbVH2_TextChanged(object sender, EventArgs e)
        {
            textBox1103.Text = tbVH2.Text;
            groupBox1.Text = tbVH2.Text;
            if (tbVH2.Text == "")
            {
                tabPage11.Enabled = false;
            }
        }

        private void tbVH3_TextChanged(object sender, EventArgs e)
        {
            textBox1110.Text = tbVH3.Text;
            groupBox3.Text = tbVH3.Text;
        }

        private void tbVH4_TextChanged(object sender, EventArgs e)
        {
            textBox1096.Text = tbVH4.Text;
            groupBox4.Text = tbVH4.Text;
        }

        private void tbVH5_TextChanged(object sender, EventArgs e)
        {
            textBox1083.Text = tbVH5.Text;
            groupBox5.Text = tbVH5.Text;
        }

        private void tbVH6_TextChanged(object sender, EventArgs e)
        {
            textBox1081.Text = tbVH6.Text;
            groupBox6.Text = tbVH6.Text;
        }

        private void tbVH7_TextChanged(object sender, EventArgs e)
        {
            textBox1115.Text = tbVH7.Text;
            groupBox7.Text = tbVH7.Text;
        }

        private void tbVH8_TextChanged(object sender, EventArgs e)
        {
            textBox1105.Text = tbVH8.Text;
            groupBox8.Text = tbVH8.Text;
        }

        private void tbVH9_TextChanged(object sender, EventArgs e)
        {
            textBox1098.Text = tbVH9.Text;
            groupBox9.Text = tbVH9.Text;
        }

        private void tbVH10_TextChanged(object sender, EventArgs e)
        {
            textBox1070.Text = tbVH10.Text;
            groupBox10.Text = tbVH10.Text;
        }

        private void tbVH11_TextChanged(object sender, EventArgs e)
        {
            textBox1106.Text = tbVH11.Text;
            groupBox11.Text = tbVH11.Text;
        }

        private void tbVH12_TextChanged(object sender, EventArgs e)
        {
            textBox1079.Text = tbVH12.Text;
            groupBox12.Text = tbVH12.Text;
        }

        private void tbVH13_TextChanged(object sender, EventArgs e)
        {
            textBox1101.Text = tbVH13.Text;
            groupBox13.Text = tbVH13.Text;
        }

        private void tbVH14_TextChanged(object sender, EventArgs e)
        {
            textBox1060.Text = tbVH14.Text;
            groupBox14.Text = tbVH14.Text;
        }

        private void tbVH15_TextChanged(object sender, EventArgs e)
        {
            textBox1102.Text = tbVH15.Text;
            groupBox15.Text = tbVH15.Text;
        }
        #endregion
        #region Diger giderler birim fiyat
        private void numericUpDown108_ValueChanged(object sender, EventArgs e)
        {
            decimal d = numericUpDown108.Value * numericUpDown94.Value;
            tbDGt1.Text = d.ToString();
        }

        private void numericUpDown107_ValueChanged(object sender, EventArgs e)
        {
            decimal d = numericUpDown107.Value * numericUpDown93.Value;
            tbDGt2.Text = d.ToString();
        }

        private void numericUpDown106_ValueChanged(object sender, EventArgs e)
        {
            decimal d = numericUpDown106.Value * numericUpDown91.Value;
            tbDGt3.Text = d.ToString();
        }

        private void numericUpDown105_ValueChanged(object sender, EventArgs e)
        {
            decimal d = numericUpDown105.Value * numericUpDown92.Value;
            tbDGt4.Text = d.ToString();
        }

        private void numericUpDown104_ValueChanged(object sender, EventArgs e)
        {
            decimal d = numericUpDown104.Value * numericUpDown89.Value;
            tbDGt5.Text = d.ToString();
        }

        private void numericUpDown103_ValueChanged(object sender, EventArgs e)
        {
            decimal d = numericUpDown103.Value * numericUpDown87.Value;
            tbDGt6.Text = d.ToString();
        }

        private void numericUpDown102_ValueChanged(object sender, EventArgs e)
        {
            decimal d = numericUpDown102.Value * numericUpDown90.Value;
            tbDGt7.Text = d.ToString();
        }

        private void numericUpDown101_ValueChanged(object sender, EventArgs e)
        {
            decimal d = numericUpDown101.Value * numericUpDown72.Value;
            tbDGt8.Text = d.ToString();
        }

        private void numericUpDown100_ValueChanged(object sender, EventArgs e)
        {
            decimal d = numericUpDown100.Value * numericUpDown59.Value;
            tbDGt9.Text = d.ToString();
        }

        private void numericUpDown99_ValueChanged(object sender, EventArgs e)
        {
            decimal d = numericUpDown99.Value * numericUpDown69.Value;
            tbDGt10.Text = d.ToString();
        }

        private void numericUpDown98_ValueChanged(object sender, EventArgs e)
        {
            decimal d = numericUpDown98.Value * numericUpDown85.Value;
            tbDGt11.Text = d.ToString();
        }

        private void numericUpDown97_ValueChanged(object sender, EventArgs e)
        {
            decimal d = numericUpDown97.Value * numericUpDown88.Value;
            tbDGt12.Text = d.ToString();
        }
        #endregion
        #region Diger giderler adet 
        private void numericUpDown94_ValueChanged(object sender, EventArgs e)
        {
            decimal d = numericUpDown108.Value * numericUpDown94.Value;
            tbDGt1.Text = d.ToString();
            tbDGt13.Text = tbDGt1.Text;
        }

        private void numericUpDown93_ValueChanged(object sender, EventArgs e)
        {
            decimal d = numericUpDown107.Value * numericUpDown93.Value;
            tbDGt2.Text = d.ToString();
        }

        private void numericUpDown91_ValueChanged(object sender, EventArgs e)
        {
            decimal d = numericUpDown106.Value * numericUpDown91.Value;
            tbDGt3.Text = d.ToString();
        }

        private void numericUpDown92_ValueChanged(object sender, EventArgs e)
        {
            decimal d = numericUpDown105.Value * numericUpDown92.Value;
            tbDGt4.Text = d.ToString();
        }

        private void numericUpDown89_ValueChanged(object sender, EventArgs e)
        {
            decimal d = numericUpDown104.Value * numericUpDown89.Value;
            tbDGt5.Text = d.ToString();
        }

        private void numericUpDown87_ValueChanged(object sender, EventArgs e)
        {
            decimal d = numericUpDown103.Value * numericUpDown87.Value;
            tbDGt6.Text = d.ToString();
        }

        private void numericUpDown90_ValueChanged(object sender, EventArgs e)
        {
            decimal d = numericUpDown102.Value * numericUpDown90.Value;
            tbDGt7.Text = d.ToString();
        }

        private void numericUpDown72_ValueChanged(object sender, EventArgs e)
        {
            decimal d = numericUpDown101.Value * numericUpDown72.Value;
            tbDGt8.Text = d.ToString();
        }

        private void numericUpDown59_ValueChanged(object sender, EventArgs e)
        {
            decimal d = numericUpDown100.Value * numericUpDown59.Value;
            tbDGt9.Text = d.ToString();
        }

        private void numericUpDown86_ValueChanged(object sender, EventArgs e)
        {
            decimal d = numericUpDown99.Value * numericUpDown69.Value;
            tbDGt10.Text = d.ToString();
        }

        private void numericUpDown85_ValueChanged(object sender, EventArgs e)
        {
            decimal d = numericUpDown98.Value * numericUpDown85.Value;
            tbDGt11.Text = d.ToString();
        }

        private void numericUpDown88_ValueChanged(object sender, EventArgs e)
        {
            decimal d = numericUpDown97.Value * numericUpDown88.Value;
            tbDGt12.Text = d.ToString();
        }

        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
