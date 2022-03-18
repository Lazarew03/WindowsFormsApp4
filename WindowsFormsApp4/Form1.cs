using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {

            if (textBoxValidate(textBox1, textBox2))
            {

                double n = int.Parse(textBox1.Text);
                double s = int.Parse(textBox2.Text);


                double p = n / s;




                resultLabel.Text = ($"Плотность тела  {p} кг на м³");
            }



        }

        private bool textBoxValidate(params TextBox[] textBox)
        {

            bool result = true;

            foreach (TextBox t in textBox)
            {
                if (t.Text == "")
                {
                    errorProvider1.SetError(t, "Заполните поле");
                    result = false;
                }
                else errorProvider1.SetError(t, "");
            }

            return result;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
