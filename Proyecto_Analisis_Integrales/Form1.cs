using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PolinomiosClass;

namespace Proyecto_Analisis_Integrales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            /*validamos entradas*/
            if (textBox2.Text == "" | textBox1.Text == "" | textBox3.Text=="" | textBox4.Text=="" )
            {
                MessageBox.Show("Uno de los recuadros esta vacio");
                Application.Exit();
            }
            
            /*agarramos nuestra integral, ecuacion, limites, n, h*/
           Integral integ = new Integral(textBox1.Text, textBox4.Text, textBox2.Text, textBox3.Text);      
            

            /*lo ponemos en el recuadro de respuesta*/
            textBox5.Text = integ.Integrar().ToString();                        

        }

        private void datosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Integrantes: \n\n" +
                            "Oscar Moreno Garza, Mat# 1388254 \n" +
                            "Eber Israel Hernandez Alaniz, Mat# 1242279\n" +
                            "Victor Manuel Mendoza Rocha, Mat# 1336694");
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
