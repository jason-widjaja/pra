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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {        
            int x = boxmakanan.SelectedIndex;
            boxmakanan.Items.RemoveAt(x);
            boxharga.Items.RemoveAt(x);

            if (boxmakanan.Items.Count == 0)
            {
                delete.Enabled = false;
            }
        }

        private void minuman_CheckedChanged(object sender, EventArgs e)
        {
            if (minuman.Checked == true)
            {
                menu.Items.Clear();
                size.Visible = true;
                menu.Items.Add("Es teh");
                menu.Items.Add("Teh hangat");
                menu.Items.Add("Nutrisari");
                menu.Items.Add("Aqua");

            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (menu.Text == "Es teh")
            {
                int a = 5000;

                harga.Text = Convert.ToString(a);
            }

            if (menu.Text == "Teh hangat")
            {
                int a = 3000;

                harga.Text = Convert.ToString(a);
            }

            if (menu.Text == "Aqua")
            {
                int a = 2000;

                harga.Text = Convert.ToString(a);
            }
            if (menu.Text == "Nutrisari")
            {
                int a = 6000;

                harga.Text = Convert.ToString(a);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void menu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (menu.Text == "Nasi Goreng")
            {
                int a = 10000;
                
                harga.Text = Convert.ToString(a);
            }
            if (menu.Text == "Nasi Goreng Spesial")
            {
                int a = 12000;
                
                harga.Text = Convert.ToString(a);
            }
            if (menu.Text == "Nasi Goreng Pete")
            {
                int a = 15000;
               
                harga.Text = Convert.ToString(a);
            }
            if (menu.Text == "Ayam Bakar")
            {
                int a = 15000;
                
                harga.Text = Convert.ToString(a);
            }
            if (menu.Text == "Es teh")
            {
                int a = 5000;
                
                harga.Text = Convert.ToString(a);
            }

            if (menu.Text == "Teh hangat")
            {
                int a = 3000;

                harga.Text = Convert.ToString(a);
            }

            if (menu.Text == "Aqua")
            {
                int a = 2000;

                harga.Text = Convert.ToString(a);
            }
            if (menu.Text == "Nutrisari")
            {
                int a = 6000;

                harga.Text = Convert.ToString(a);
            }



            if (menu.Text == "Es teh" && jumbo.Checked == true)
            {
                int a = 7000;

                harga.Text = Convert.ToString(a);
            }

            if (menu.Text == "Teh hangat" && jumbo.Checked == true)
            {
                int a = 5000;

                harga.Text = Convert.ToString(a);
            }

            if (menu.Text == "Aqua" && jumbo.Checked == true)
            {
                int a = 5000;

                harga.Text = Convert.ToString(a);
            }
            if (menu.Text == "Nutrisari" && jumbo.Checked == true)
            {
                int a = 10000;

                harga.Text = Convert.ToString(a);
            }
        }

        private void makanan_CheckedChanged(object sender, EventArgs e)
        {
            
            if (makanan.Checked == true)
            {
                menu.Items.Clear();
                menu.Items.Add("Nasi Goreng");
                menu.Items.Add("Nasi Goreng Spesial");
                menu.Items.Add("Nasi Goreng Pete");
                menu.Items.Add("Ayam Bakar");
                size.Visible = false;
            }
            
        }

        private void price_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void jumbo_CheckedChanged(object sender, EventArgs e)
        {
            if (menu.Text == "Es teh")
            {
                int a = 7000;

                harga.Text = Convert.ToString(a);
            }

            if (menu.Text == "Teh hangat")
            {
                int a = 5000;

                harga.Text = Convert.ToString(a);
            }

            if (menu.Text == "Aqua")
            {
                int a = 5000;

                harga.Text = Convert.ToString(a);
            }
            if (menu.Text == "Nutrisari")
            {
                int a = 10000;

                harga.Text = Convert.ToString(a);
            }
        }

        private void buy_Click(object sender, EventArgs e)
        {
            
            boxmakanan.Items.Add(menu.Text);
            boxharga.Items.Add(harga.Text);

            delete.Enabled = true;

            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void check_Click(object sender, EventArgs e)
        {
            if (boxharga.Items.Count == 0)
            {
                MessageBox.Show("Choose Menu");
            }

            else if (boxharga.Items.Count != 0)
            {
                var form2 = new Form2();
                form2.ShowDialog();

                int total = 0;
                int y = boxharga.Items.Count;

                for (int i = 0; 0 <y; i++)
                {
                    total = total + Convert.ToInt32(boxharga.Items.IndexOf(i));
                }

                abc.Text = Convert.ToString(total);

            
               
            }
        }

        private void harga_Click(object sender, EventArgs e)
        {

        }

        private void boxharga_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
