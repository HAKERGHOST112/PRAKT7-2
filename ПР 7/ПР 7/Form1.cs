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

namespace ПР_7
{
    public partial class Form1 : Form
    {
        struct People
        {
            public string FIO;
            public int age;
            public int probeg;


        }



        List<People> people=new List<People>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*if(textBox1.Text.Trim().Length == 0)
            {
                MessageBox.Show("Вы не ввели фио");
                textBox1.Focus();
            }
            else if(textBox2.Text.Trim().Length == 0)
            {
                MessageBox.Show("Вы не ввели год выпуска");
                textBox2.Focus();
            }
            else if (textBox3.Text.Trim().Length == 0)
            {
                MessageBox.Show("Вы не ввели пробег");
                textBox3.Focus();
            }
            else
            {
                if (Convert.ToInt32(textBox3.Text) < 0)  
                {
                    MessageBox.Show("пробег некоректен");
                    textBox3.Focus();
                }
                else
                {



                    People p = new People();
                    p.FIO = textBox1.Text;
                    p.age = Convert.ToInt32(textBox2.Text);
                    p.probeg = Convert.ToInt32(textBox3.Text);
                    people.Add(p);
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            for (int k = 0; k < 3; k++)
                            {



                            }

                        }
                    }

                    dataGridView1.RowCount = people.Count;
                    for (int i = 0; i < people.Count; i++)
                    {
                        dataGridView1[0, i].Value = people[i].FIO;
                        dataGridView1[1, i].Value = people[i].age.ToString();
                        dataGridView1[2, i].Value = people[i].probeg.ToString();
                    }
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                }


            }*/


            Form2 f= new Form2();
            if (f.ShowDialog()== DialogResult.OK)
            {
                People p = new People();
                p.FIO = f.textBox1.Text;
                p.age = Convert.ToInt32(f.textBox2.Text);
                p.probeg = Convert.ToInt32(f.textBox3.Text);
                people.Add(p);
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        for (int k = 0; k < 3; k++)
                        {



                        }

                    }
                }

                dataGridView1.RowCount = people.Count;
                for (int i = 0; i < people.Count; i++)
                {
                    dataGridView1[0, i].Value = people[i].FIO;
                    dataGridView1[1, i].Value = people[i].age.ToString();
                    dataGridView1[2, i].Value = people[i].probeg.ToString();
                }
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Вы выделили строку");
            }
            else
            {
                DialogResult result = MessageBox.Show("Точно удалить элемент?",
                    "",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
                if (result == DialogResult.OK)
                {
                    int n = dataGridView1.CurrentRow.Index;
                    people.RemoveAt(n);

                    dataGridView1.RowCount = people.Count;
                    for (int i = 0; i < people.Count; i++)
                    {
                        dataGridView1[0, i].Value = people[i].FIO;
                        dataGridView1[1, i].Value = people[i].age.ToString();
                        dataGridView1[2, i].Value = people[i].probeg.ToString();
                    }
                }
               
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            /*int n = dataGridView1.CurrentRow.Index;
            textBox1.Text = dataGridView1[0, n].Value.ToString();
            textBox2.Text = dataGridView1[1, n].Value.ToString();
            textBox3.Text = dataGridView1[2, n].Value.ToString();
            button3.Visible = true;*/

        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*int n = dataGridView1.CurrentRow.Index;
           People p = new People();
           p.FIO=textBox1.Text;
           p.age=Convert.ToInt32(textBox2.Text);
           p.probeg = Convert.ToInt32(textBox3.Text);
           people[n] = p;
           dataGridView1.RowCount = people.Count;
           for (int i = 0; i < people.Count; i++)
           {
               dataGridView1[0, i].Value = people[i].FIO;
               dataGridView1[1, i].Value = people[i].age.ToString();
               dataGridView1[2, i].Value = people[i].probeg.ToString();

        }*/
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StreamWriter wr = new StreamWriter("1.txt");
            for (int i = 0; i < people.Count; i++)
            {
                wr.WriteLine(dataGridView1[0,i].Value.ToString());
                wr.WriteLine(dataGridView1[1, i].Value.ToString());
                wr.WriteLine(dataGridView1[2, i].Value.ToString());
            }
            wr.Close();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            people.Clear();
            StreamReader read = new StreamReader("1.txt");
            while (read.EndOfStream==false)
            {
                People p = new People();
                p.FIO = read.ReadLine();
                p.age = Convert.ToInt32(read.ReadLine());
                p.probeg = Convert.ToInt32(read.ReadLine());
                people.Add(p);
            }
            dataGridView1.RowCount = people.Count;
            for (int i = 0; i < people.Count; i++)
            {
                dataGridView1[0, i].Value = people[i].FIO;
                dataGridView1[1, i].Value = people[i].age.ToString();
                dataGridView1[2, i].Value = people[i].probeg.ToString();



            }
            read.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < people.Count; i++)
            {
                for (int j = 0; j < people.Count - i - 1; j++)
                {
                    if (people[j].probeg < people[j + 1].probeg)
                    {
                        People p = people[j];
                        people[j] = people[j + 1];
                        people[j + 1] = p;
                    }
                }
            }
            dataGridView2.RowCount = people.Count;
            for (int i = 0; i < people.Count; i++)
            {
                dataGridView2[0, i].Value = people[i].FIO;
                dataGridView2[1, i].Value = people[i].age.ToString();
                dataGridView2[2, i].Value = people[i].probeg.ToString();


            }


            
        }




        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView2.RowCount = people.Count;
            for (int i = 0; i < people.Count; i++)
            {
                dataGridView2[0, i].Value = people[i].FIO;
                dataGridView2[1, i].Value = people[i].age.ToString();
                dataGridView2[2, i].Value = people[i].probeg.ToString();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            int n = dataGridView1.CurrentRow.Index;
            f.textBox1.Text = dataGridView1[0, n].Value.ToString();
            f.textBox2.Text = dataGridView1[1, n].Value.ToString();
            f.textBox3.Text = dataGridView1[2, n].Value.ToString();
            if (f.ShowDialog() == DialogResult.OK)
            {
                People p = new People();
                p.FIO = f.textBox1.Text;
                p.age = Convert.ToInt32(f.textBox2.Text);
                p.probeg = Convert.ToInt32(f.textBox3.Text);
                people[n] = p;
                dataGridView1.RowCount = people.Count;
                for (int i = 0; i < people.Count; i++)
                {
                    dataGridView1[0, i].Value = people[i].FIO;
                    dataGridView1[1, i].Value = people[i].age.ToString();
                    dataGridView1[2, i].Value = people[i].probeg.ToString();

                }
            }

        }
    }
    
}
