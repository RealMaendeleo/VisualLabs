using System;
using System.Windows.Forms;

namespace VisualLab2forms
{
    public partial class Form1 : Form
    {
        Matrix3x3 matrix1 = new Matrix3x3();
        Matrix3x3 matrix2 = new Matrix3x3();
        Matrix3x3 resultMatrix = new Matrix3x3();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                matrix1.array[0, 0] = int.Parse(textBox1.Text);
            }
            catch { }
            
        }
        
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox23_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox25_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox26_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox27_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                matrix1.array[0, 0] = int.Parse(textBox1.Text);
                matrix1.array[0, 1] = int.Parse(textBox2.Text);
                matrix1.array[0, 2] = int.Parse(textBox3.Text);
                matrix1.array[1, 0] = int.Parse(textBox4.Text);
                matrix1.array[1, 1] = int.Parse(textBox5.Text);
                matrix1.array[1, 2] = int.Parse(textBox6.Text);
                matrix1.array[2, 0] = int.Parse(textBox7.Text);
                matrix1.array[2, 1] = int.Parse(textBox8.Text);
                matrix1.array[2, 2] = int.Parse(textBox9.Text);

                matrix2.array[0, 0] = int.Parse(textBox18.Text);
                matrix2.array[0, 1] = int.Parse(textBox17.Text);
                matrix2.array[0, 2] = int.Parse(textBox16.Text);
                matrix2.array[1, 0] = int.Parse(textBox15.Text);
                matrix2.array[1, 1] = int.Parse(textBox14.Text);
                matrix2.array[1, 2] = int.Parse(textBox13.Text);
                matrix2.array[2, 0] = int.Parse(textBox12.Text);
                matrix2.array[2, 1] = int.Parse(textBox11.Text);
                matrix2.array[2, 2] = int.Parse(textBox10.Text);

                resultMatrix = matrix1 + matrix2;

                textBox27.Text = resultMatrix.array[0, 0].ToString();
                textBox26.Text = resultMatrix.array[0, 1].ToString();
                textBox25.Text = resultMatrix.array[0, 2].ToString();
                textBox24.Text = resultMatrix.array[1, 0].ToString();
                textBox23.Text = resultMatrix.array[1, 1].ToString();
                textBox22.Text = resultMatrix.array[1, 2].ToString();
                textBox21.Text = resultMatrix.array[2, 0].ToString();
                textBox20.Text = resultMatrix.array[2, 1].ToString();
                textBox19.Text = resultMatrix.array[2, 2].ToString();

                textBox28.Text = resultMatrix.Det.ToString();
                textBox29.Text = resultMatrix.getMainDiagSum().ToString();
                textBox30.Text = resultMatrix.SideDiagSum.ToString();
            }
            catch
            {
                MessageBox.Show("Input an int number");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                matrix1.array[0, 0] = int.Parse(textBox1.Text);
                matrix1.array[0, 1] = int.Parse(textBox2.Text);
                matrix1.array[0, 2] = int.Parse(textBox3.Text);
                matrix1.array[1, 0] = int.Parse(textBox4.Text);
                matrix1.array[1, 1] = int.Parse(textBox5.Text);
                matrix1.array[1, 2] = int.Parse(textBox6.Text);
                matrix1.array[2, 0] = int.Parse(textBox7.Text);
                matrix1.array[2, 1] = int.Parse(textBox8.Text);
                matrix1.array[2, 2] = int.Parse(textBox9.Text);

                matrix2.array[0, 0] = int.Parse(textBox18.Text);
                matrix2.array[0, 1] = int.Parse(textBox17.Text);
                matrix2.array[0, 2] = int.Parse(textBox16.Text);
                matrix2.array[1, 0] = int.Parse(textBox15.Text);
                matrix2.array[1, 1] = int.Parse(textBox14.Text);
                matrix2.array[1, 2] = int.Parse(textBox13.Text);
                matrix2.array[2, 0] = int.Parse(textBox12.Text);
                matrix2.array[2, 1] = int.Parse(textBox11.Text);
                matrix2.array[2, 2] = int.Parse(textBox10.Text);

                resultMatrix = matrix1 * matrix2;
                            
                textBox27.Text = resultMatrix.array[0, 0].ToString();
                textBox26.Text = resultMatrix.array[0, 1].ToString();
                textBox25.Text = resultMatrix.array[0, 2].ToString();
                textBox24.Text = resultMatrix.array[1, 0].ToString();
                textBox23.Text = resultMatrix.array[1, 1].ToString();
                textBox22.Text = resultMatrix.array[1, 2].ToString();
                textBox21.Text = resultMatrix.array[2, 0].ToString();
                textBox20.Text = resultMatrix.array[2, 1].ToString();
                textBox19.Text = resultMatrix.array[2, 2].ToString();

                textBox28.Text = resultMatrix.Det.ToString();
                textBox29.Text = resultMatrix.getMainDiagSum().ToString();
                textBox30.Text = resultMatrix.SideDiagSum.ToString();
            }
            catch
            {
                MessageBox.Show("Input an int number");
            }
        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox28_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox29_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox30_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
