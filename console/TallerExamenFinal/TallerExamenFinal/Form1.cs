using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TallerExamenFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TxtBoxNombre_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void BtEdicion_Click(object sender, EventArgs e)
        {
            TxtBoxNombre.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
