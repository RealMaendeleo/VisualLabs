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
    public partial class Form_Office : Form
    {
        public Office office;

        public Form_Office()
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
                float toiletLength = float.Parse(toiletLenField.Text);
                if (height < 2.0)
                {
                    throw new Exception("Высота офиса менее 2 метров недопустима");
                }
                if (length * width < 1.0)
                {
                    throw new Exception("Недопустимо малая площадь офиса");
                }
                if (length - toiletLength < 0.1)
                {
                    throw new Exception("Недопустимо большая длина санузла");
                }
                office = new Office(length, width, height, toiletLength);
                area_field.Text = office.Area.ToString();
                volume_field.Text = office.Volume.ToString();
                textBox1.Text = office.ToiletArea.ToString();
                textBox2.Text = office.ToiletVolume.ToString();
                pictureBox1.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_Office_Load(object sender, EventArgs e)
        {

        }
    }
}
