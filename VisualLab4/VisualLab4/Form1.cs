using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualLab4
{
    public partial class Form1 : Form
    {
        GenericLIFO<int> intStack;
        GenericLIFO<double> doubleStack;
        GenericLIFO<char> charStack;

        int selectedType;

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            intStack = new GenericLIFO<int>();
            button3.Enabled = false;
            button4.Enabled = false;
            textBox1.Enabled = true;
            button1.Enabled = true;
            selectedType = 0;
            button5.Enabled = true;
            button6.Enabled = true;
            button2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            doubleStack = new GenericLIFO<double>();
            button2.Enabled = false;
            button4.Enabled = false;
            textBox1.Enabled = true;
            button1.Enabled = true;
            selectedType = 1;
            button5.Enabled = true;
            button6.Enabled = true;
            button3.Enabled = false;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            charStack = new GenericLIFO<char>();
            button2.Enabled = false;
            button3.Enabled = false;
            textBox1.Enabled = true;
            button1.Enabled = true;
            selectedType = 2;
            button5.Enabled = true;
            button6.Enabled = true;
            button4.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count != 0)
            {
                label2.Text = listBox1.SelectedItem.ToString();
            }
            else
            {
                MessageBox.Show("Стек пуст");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (selectedType)
            {
                case 0:
                    int intValue;
                    bool resInt = int.TryParse(textBox1.Text, out intValue);
                    if (resInt)
                    {
                        intStack.Push(intValue);
                        int topItem = intStack.Peek();
                        listBox1.Items.Insert(0, topItem);
                        listBox1.SelectedIndex = listBox1.Items.IndexOf(intValue);
                    }
                    else
                    {
                        MessageBox.Show("Это не целое число");
                    }
                    break;

                case 1:
                    double doubleValue;
                    bool resDouble = double.TryParse(textBox1.Text, out doubleValue);
                    if (resDouble)
                    {
                        doubleStack.Push(doubleValue);
                        double topItem = doubleStack.Peek();
                        listBox1.Items.Insert(0, topItem);
                        listBox1.SelectedIndex = listBox1.Items.IndexOf(doubleValue);
                    }
                    else
                    {
                        MessageBox.Show("Это не дробное число");
                    }
                    break;

                case 2:
                    char charValue;
                    bool resChar = char.TryParse(textBox1.Text, out charValue);
                    if (resChar)
                    {
                        charStack.Push(charValue);
                        char topItem = charStack.Peek();
                        listBox1.Items.Insert(0, topItem);
                        listBox1.SelectedIndex = listBox1.Items.IndexOf(charValue);
                    }
                    else
                    {
                        MessageBox.Show("Это не символ");
                    }
                    break;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            String value;

            try
            {
                if (selectedType == 0)
                {
                    intStack.Pop();
                    value = listBox1.SelectedItem.ToString();
                    label2.Text = value;
                }
                else if (selectedType == 1)
                {
                    doubleStack.Pop();
                    value = listBox1.SelectedItem.ToString();
                    label2.Text = value;
                }
                else if (selectedType == 2)
                {
                    charStack.Pop();
                    value = listBox1.SelectedItem.ToString();
                    label2.Text = value;
                }

                if (listBox1.Items.Count == 1)
                {
                    listBox1.Items.RemoveAt(0);
                }

                if (listBox1.SelectedIndex != -1 || listBox1.Items.Count != 0)
                {
                    listBox1.Items.RemoveAt(0);
                    listBox1.SelectedItem = listBox1.Items[0];
                }
                else
                {
                    MessageBox.Show("Стек пуст");
                }
            } catch
            {
                MessageBox.Show("Стек пуст");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
    }
}
