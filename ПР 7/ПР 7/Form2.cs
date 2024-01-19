using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ПР_7
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_ForeColorChanged(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(this.DialogResult== DialogResult.OK)
            {
                int n = 0;
                try
                {
                    int k=Convert.ToInt32(textBox2.Text);
                    if(textBox1.Text.Trim() =="")
                    {
                        throw new Exception("Вы не ввели ФИО");
                    }
                    n++;
                    if (textBox2.Text.Trim() == "")
                    {
                        throw new Exception("Вы не ввели год выпуска");
                    }
                    if (textBox3.Text.Trim() == "")
                    {
                        throw new Exception("Вы не ввели пробег");
                    }

                }
                catch(FormatException) {
                    MessageBox.Show("Год выпуска введён некоректно");
                    e.Cancel = true;
                }
                catch (Exception ex)
                {
                    if (n == 0)
                    {
                        textBox1.Focus();
                    }
                    else if(n == 1)
                    {
                        textBox2.Focus();
                    }
                        MessageBox.Show(ex.Message);
                        e.Cancel = true;
                  

                    
                }

            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
