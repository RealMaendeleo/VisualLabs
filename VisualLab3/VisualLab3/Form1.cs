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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_Stock stock_form = new Form_Stock();
            stock_form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_Office office_form = new Form_Office();
            office_form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form_Apartment apartment_form = new Form_Apartment();
            apartment_form.ShowDialog();
        }
    }
}