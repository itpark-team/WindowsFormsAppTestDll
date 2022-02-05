using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MyMathClassLibrary;

namespace WindowsFormsAppTestDll
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PlainArithmetic plainArithmetic = new PlainArithmetic();

            try
            {
                double result = plainArithmetic.Dev(
                    double.Parse(textBox1.Text),
                    double.Parse(textBox2.Text)
                    );

                MessageBox.Show(result.ToString());
            }
            catch(Exception ex)
            {
                //MessageBox.Show(ex.Message);
               MessageBox.Show("ошибка ввода данных проверьте поля для ввода");
            }
        }
    }
}
