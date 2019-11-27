using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace ExamenTaller2doParcial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tbPalabra_TextChanged(object sender, EventArgs e)
        {
            ArrayList tbPalabra = new ArrayList();
            tbPalabra.Add(bAgregar);
            
        }

        private void bAgregar_Click(object sender, EventArgs e)
        {
            Console.WriteLine(tbPalabra);
        }
    }
}
