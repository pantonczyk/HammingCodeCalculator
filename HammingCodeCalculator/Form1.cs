using System;
using System.Collections;
using System.Windows.Forms;

namespace HammingCodeCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            //var decimal_value = int.Parse(tbDecimalInput.Text);
            //var result = BinaryConversion.ToBinaryConversion(decimal_value);
            //tb_output.Text = string.Join("", result);



            //var binary_value = BinaryConversion.ToDecimalConversion(tbDecimalInput.Text);
            //tb_output.Text = string.Join("", binary_value);
            //var tmp = tbDecimalInput.Text;

            var result = tb_output.Text;
            var xor = OperationXOR.functionXOR(result);
            tb_xor_out.Text = string.Join("", xor);

            
            //var numbers = Array.ConvertAll(tmp.Split(new char[] { ' ' }, (StringSplitOptions)1), int.Parse);
           
            



        }
    }
}
