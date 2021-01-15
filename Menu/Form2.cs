using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void cekdiskon_CheckedChanged(object sender, EventArgs e)
        {
            if (cekdiskon.Checked == true) 
            {
                labeldiskon.Visible = true;
                inputdiskon.Visible = true;
                persen.Visible = true;
                hitung.Visible = true;
            }
            else if (cekdiskon.Checked == false) 
            {
                labeldiskon.Visible = false;
                inputdiskon.Visible = false;
                persen.Visible = false;
                hitung.Visible = false;
            }
        }

        private void hargatotal_Click(object sender, EventArgs e)
        {

        }
    }
}
