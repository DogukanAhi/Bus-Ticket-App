using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
       
        public Form2()
        {
            InitializeComponent();
        }
        int but2 = 0, but3 = 0,but4=0, but5=0, but6=0;
            private void button2_Click(object sender, EventArgs e)
            {
            if (but2 == 1)
            {
                MessageBox.Show("Bu koltuk dolu");
                if (radioButton1.Checked == true)
                {
                    radioButton1.Checked = false;
                }
                else if (radioButton2.Checked == true)
                {
                    radioButton2.Checked = false;
                }
                button2.BackColor = Color.Red;
                textBox1.Clear();
                textBox2.Clear();
            }
            else
            {
                listBox1.Items.Add(textBox1.Text);
                listBox2.Items.Add(button2.Text);
                listBox3.Items.Add(textBox2.Text);
                listBox4.Items.Add(comboBox1.Text);
                if (radioButton1.Checked == true)
                {
                    listBox5.Items.Add(radioButton1.Text);
                    radioButton1.Checked = false;
                }
                else if (radioButton2.Checked == true)
                {
                    listBox5.Items.Add(radioButton1.Text);
                    radioButton2.Checked = false;
                }
                listBox6.Items.Add(comboBox2.Text);
                button2.BackColor = Color.Red;
                textBox1.Clear();
                textBox2.Clear();
                but2++;
            }
        }
        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            int value;
            if (!int.TryParse(textBox1.Text, out value))
            {
                // Girilen değer tamsayı değil. Uyarı mesajı gösterin.
                MessageBox.Show("Lütfen tamsayı bir değer girin!");
                textBox1.Clear();
                textBox2.Clear();

            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (but3 == 1)
            {
                MessageBox.Show("Bu koltuk dolu");
                if (radioButton1.Checked == true)
                {
                    radioButton1.Checked = false;
                }
                else if (radioButton2.Checked == true)
                {
                    radioButton2.Checked = false;
                }
                button2.BackColor = Color.Red;
                textBox1.Clear();
                textBox2.Clear();
            }
            else
            {
                listBox1.Items.Add(textBox1.Text);
                listBox2.Items.Add(button3.Text);
                listBox3.Items.Add(textBox2.Text);
                listBox4.Items.Add(comboBox1.Text);
                if (radioButton1.Checked == true)
                {
                    listBox5.Items.Add(radioButton1.Text);
                    radioButton1.Checked = false;
                }
                else if (radioButton2.Checked == true)
                {
                    listBox5.Items.Add(radioButton1.Text);
                    radioButton2.Checked = false;
                }
                listBox6.Items.Add(comboBox2.Text);
                button3.BackColor = Color.Red;
                textBox1.Clear();
                textBox2.Clear();
                but3++;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (but4 == 1)
            {
                MessageBox.Show("Bu koltuk dolu");
                if (radioButton1.Checked == true)
                {
                    radioButton1.Checked = false;
                }
                else if (radioButton2.Checked == true)
                {
                    radioButton2.Checked = false;
                }
                button2.BackColor = Color.Red;
                textBox1.Clear();
                textBox2.Clear();
            }
            else
            {
                listBox1.Items.Add(textBox1.Text);
                listBox2.Items.Add(button4.Text);
                listBox3.Items.Add(textBox2.Text);
                listBox4.Items.Add(comboBox1.Text);
                if (radioButton1.Checked == true)
                {
                    listBox5.Items.Add(radioButton1.Text);
                    radioButton1.Checked = false;

                }
                else if (radioButton2.Checked == true)
                {
                    listBox5.Items.Add(radioButton1.Text);
                    radioButton1.Checked = false;
                }
                listBox6.Items.Add(comboBox2.Text);
                button4.BackColor = Color.Red;
                textBox1.Clear();
                textBox2.Clear();
                but4++;
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (but5 == 1)
            {
                MessageBox.Show("Bu koltuk dolu");
                if (radioButton1.Checked == true)
                {
                    radioButton1.Checked = false;
                }
                else if (radioButton2.Checked == true)
                {
                    radioButton2.Checked = false;
                }
                button2.BackColor = Color.Red;
                textBox1.Clear();
                textBox2.Clear();
            }
            else
            {
                listBox1.Items.Add(textBox1.Text);
                listBox2.Items.Add(button5.Text);
                listBox3.Items.Add(textBox2.Text);
                listBox4.Items.Add(comboBox1.Text);
                if (radioButton1.Checked == true)
                {
                    listBox5.Items.Add(radioButton1.Text);
                    radioButton1.Checked = false;
                }
                else if (radioButton2.Checked == true)
                {
                    listBox5.Items.Add(radioButton1.Text);
                    radioButton2.Checked = false;
                }
                listBox6.Items.Add(comboBox2.Text);
                button5.BackColor = Color.Red;
                textBox1.Clear();
                textBox2.Clear();
                but5++;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (but6 == 1)
            {
                MessageBox.Show("Bu koltuk dolu");
                if (radioButton1.Checked == true)
                {
                    radioButton1.Checked = false;
                }
                else if (radioButton2.Checked == true)
                {
                    radioButton2.Checked = false;
                }
                button2.BackColor = Color.Red;
                textBox1.Clear();
                textBox2.Clear();
            }
            else
            {
                listBox1.Items.Add(textBox1.Text);
                listBox2.Items.Add(button6.Text);
                listBox3.Items.Add(textBox2.Text);
                listBox4.Items.Add(comboBox1.Text);
                if (radioButton1.Checked == true)
                {
                    listBox5.Items.Add(radioButton1.Text);
                    radioButton1.Checked = false;
                }
                else if (radioButton2.Checked == true)
                {
                    listBox5.Items.Add(radioButton1.Text);
                    radioButton2.Checked = false;
                }
                listBox6.Items.Add(comboBox2.Text);
                button6.BackColor = Color.Red;
                textBox1.Clear();
                textBox2.Clear();
                but6++;
            }
          
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add(button7.Text);
            listBox3.Items.Add(textBox2.Text);
            listBox4.Items.Add(comboBox1.Text);
            if (radioButton1.Checked == true)
            {
                listBox5.Items.Add(radioButton1.Text);
            }
            else if (radioButton2.Checked == true)
            {
                listBox5.Items.Add(radioButton1.Text);
            }
            listBox6.Items.Add(comboBox2.Text);
            button7.BackColor = Color.Red;
            textBox1.Clear();
            textBox2.Clear();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu koltuk şoföre aittir!");
            textBox1.Clear();
            textBox2.Clear();
          

        }
    }
    }
    

