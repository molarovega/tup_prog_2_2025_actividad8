using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            string path = "Vehiculos.csv";

            string[] lineas = File.ReadAllLines(path);

            foreach (string line in lineas) 
            {
                string[] s = line.Split(';');
                tbxResultados.Text += s[0] + "/" + s[1] + "\r\n";
            }
        }
    }
}
