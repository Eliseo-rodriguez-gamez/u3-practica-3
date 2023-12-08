using System;

namespace u3_practica_3
{
    public partial class Form1 : Form
    {
        float f_num, Total = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Boton sumar numeros
            textBox2.Text = Total.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Boton añadir
            listBox1.Items.Add(textBox1.Text);
            //Aqui es donde pasamos el parametro
            f_num = float.Parse(textBox1.Text); 
            Total += f_num;
            textBox1.Text = "";
            textBox1.Focus();
        }
    }
}