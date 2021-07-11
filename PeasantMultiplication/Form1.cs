using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeasantMultiplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Hesapla butonuna tıklandığında çağırılan ve
        /// kutulardaki yazıları çarpıp sonucu MessageBox ile gösteren method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            myPeasantMultiplication1.Number1 = int.Parse(textBox1.Text);
            myPeasantMultiplication1.Number2 = int.Parse(textBox2.Text);

            MessageBox.Show($"Sonuç: {myPeasantMultiplication1.Result}");
        }
    }
}
