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
    public partial class Form_Apartment : Form
    {
        Apartment apartment;

        public Form_Apartment()
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
                float kitchenArea = float.Parse(kitchen_area.Text);
                float bathroomArea = float.Parse(bathroom_area.Text);
                float restroomArea = float.Parse(restroom_area.Text);
                float hallwayArea = float.Parse(hallway_area.Text);
                if (height < 2.0)
                {
                    throw new Exception("Высота квартиры менее 2 метров недопустима");
                }
                if (length * width < 1.0)
                {
                    throw new Exception("Недопустимо малая площадь квартиры");
                }
                if (kitchenArea + bathroomArea + restroomArea + hallwayArea > length * width * height)
                {
                    throw new Exception("Все не поместится! Задайте меньшую площадь комнат");
                }
                apartment = new Apartment(length, width, height, kitchenArea, bathroomArea, restroomArea, hallwayArea);
                area_field.Text = apartment.Area.ToString();
                volume_field.Text = apartment.Volume.ToString();
                textBox1.Text = apartment.LivingArea.ToString();
                textBox2.Text = (apartment.LivingArea * height).ToString();
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
