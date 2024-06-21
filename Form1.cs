using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__inclass_assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tabcontrol1.TabPages.Remove(tabHome);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Wonkah" && textBox2.Text == "Ballincat")
            {
                if (!tabcontrol1.TabPages.Contains(tabHome))
                {
                    if (tabcontrol1.TabPages.Count >= 1)
                    {
                        tabcontrol1.TabPages.Insert(1, tabHome);
                    }
                    else
                    {
                        tabcontrol1.TabPages.Add(tabHome);
                    }
                }
            }
            else
            {
                MessageBox.Show("Nuh uh");
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem.ToString() == "Ranks")
            {
                listBox2.Items.Clear();
                listBox2.Items.Add("Bronze");
                listBox2.Items.Add("Silver");
                listBox2.Items.Add("Gold");
                listBox2.Items.Add("Platinum");
                listBox2.Items.Add("Diamond");
                listBox2.Items.Add("Champion");
                listBox2.Items.Add("Grand Champion");
                listBox2.Items.Add("Super Sonic Legend");
            }
            if (listBox1.SelectedItem.ToString() == "Gamemodes")
            {
                listBox2.Items.Clear();
                listBox2.Items.Add("1v1");
                listBox2.Items.Add("2v2");
                listBox2.Items.Add("3v3");
                listBox2.Items.Add("Hoops");
                listBox2.Items.Add("Rumble");
                listBox2.Items.Add("Dropshot");
                listBox2.Items.Add("Heatseeker");
            }
            if (listBox1.SelectedItem.ToString() == "Players")
            {
                listBox2.Items.Clear();
                listBox2.Items.Add("Player Population: 235,344");
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}