using System;
using System.Windows.Forms;
using System.Drawing;
using System.Reflection;
using System.Runtime.InteropServices;

namespace VisualLab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            grids_Toggle_list.SelectedIndex = listBox1.SelectedIndex;
        }

        private const int column_width = 150;
        private const int row_height = 50;

        // Нарисуем образец и его имя.
        private void DrawIconSample(Graphics gr, ref int x, int y,
            Icon ico, string ico_name)
        {
            gr.DrawIconUnstretched(ico,
                new Rectangle(x, y, ico.Width, ico.Height));
            int text_y = y + (int)(ico.Height -
                gr.MeasureString(ico_name, this.Font).Height) / 2;
            gr.DrawString(ico_name, this.Font, Brushes.Black,
                x + ico.Width + 5, text_y);
            x += column_width;
        }

        private void add_button(object sender, EventArgs e)
        {
            double number;
            bool isNum = double.TryParse(textBox1.Text, out number);
            if (!textBox1.Text.Equals(""))
            {
                if (isNum)
                {
                    string text = textBox1.Text;
                    listBox1.Items.Add(text);
                    grids_Toggle_list.Items.Add(text);
                }
                else
                {
                    MessageBox.Show("Input a real number");
                }
            }
        }

        private void delete_button(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                string selected = listBox1.SelectedItem.ToString();
                grids_Toggle_list.Items.Remove(selected);
                listBox1.Items.Remove(selected);
            }
        }

        private void grids_toggle_list(object sender, EventArgs e)
        {
            grids_Toggle_list.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        
        
        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = pictureBox1.Visible ? false : true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Enabled = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
