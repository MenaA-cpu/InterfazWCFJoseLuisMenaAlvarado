using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIWcfSergioJoseLuisMena
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Servicepeliculas.Service1Client metod = new Servicepeliculas.Service1Client();
            string[] datos = new string[5];
            datos = metod.buscarPeli(int.Parse (textBox1.Text));
            textBox2.Text = datos[0];
            textBox3.Text = datos[1];
            textBox4.Text = datos[2];
            textBox5.Text = datos[3];


        }
    }
}
