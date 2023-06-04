using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace VisualLab5
{
    public delegate void Inform(string message);

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void Show(string message)
        {
            if (message != "")
                MessageBox.Show(message);
        }
        void Type(string message)
        {
            label1.Text = message;
            label1.Location = new Point(300, 50);
            label1.Visible = true;
        }

        private Point MouseDownLocation;
        private System.DateTime startMoveTime, endMoveTime;
        private int startLocationX, endLocationX;

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MouseDownLocation = e.Location;
            }
            startMoveTime = System.DateTime.Now;
            startLocationX = button1.Location.X;
        }

        private void button1_Click(object sender, System.EventArgs e)
        {

        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                button1.Left += e.X - MouseDownLocation.X;
            }
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            endMoveTime = System.DateTime.Now;
            endLocationX = button1.Location.X;
            int velocity = (int)(System.Math.Abs(endLocationX - startLocationX) / (endMoveTime - startMoveTime).TotalSeconds) / 10;
            int x = button1.Location.X;

            Inform inform = Type;  // создаем экземпляр делегата 
            inform += Show;

            for (int i = velocity; i > 0; i--)
            {
                Thread.Sleep((velocity - i) / 10);
                x += i / 10;
                button1.Location = new Point(x, button1.Location.Y);
                
                if (button1.Location.X + button1.Size.Width >= panel1.Width)
                {
                    inform("Коллизия");
                    break;
                }
                else
                {
                    inform("");
                }
            }
            /*if (inform != null)
            {
                MessageBox.Show("Подписчик назначен");
            }*/
            Thread.Sleep(500);
            button1.Location = new Point(0, button1.Location.Y);
        }
    }
}
