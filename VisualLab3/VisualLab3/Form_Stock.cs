using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualLab3
{
    public partial class Form_Stock : Form
    {
        public Stock stock;

        public Form_Stock()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                float length = float.Parse(length_field.Text);
                float width = float.Parse(width_field.Text);
                float height = float.Parse(height_field.Text);
                if (height < 3.0)
                {
                    throw new Exception("Высота склада менее 3 метров недопустима");
                }
                if (length * width < 1.0)
                {
                    throw new Exception("Недопустимо малая площадь склада");
                }
                stock = new Stock(length, width, height);
                area_field.Text = stock.Area.ToString();
                volume_field.Text = stock.Volume.ToString();
                pictureBox1.Visible = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
