using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Timers;
using System.Windows.Threading;
using System.Windows.Forms;

namespace VisualLab6
{
    public partial class Clock : UserControl
    {
        public Clock()
        {
            InitializeComponent();
            colorDots();
            timer1.Start();
        }
        public void colorDots()
        {
            Color color = Color.FromArgb(33, 220, 160);
            dot1.BackColor = color;
            dot2.BackColor = color;
            dot3.BackColor = color;
            dot4.BackColor = color;
        }
        public void displayTime()
        {
            DateTime currentDateTime = DateTime.Now;
            int hours = currentDateTime.Hour;
            int minutes = currentDateTime.Minute;
            int seconds = currentDateTime.Second;

            if (hours / 10 != sevenSegment1.value)
                sevenSegment1.drawSegmentByDigit(hours / 10);

            if (hours % 10 != sevenSegment2.value)
                sevenSegment2.drawSegmentByDigit(hours % 10);

            if (minutes / 10 != sevenSegment3.value)
                sevenSegment3.drawSegmentByDigit(minutes / 10);

            if (minutes % 10 != sevenSegment4.value)
                sevenSegment4.drawSegmentByDigit(minutes % 10);
            
            if (seconds / 10 != sevenSegment5.value)
                sevenSegment5.drawSegmentByDigit(seconds / 10);

            if (seconds % 10 != sevenSegment6.value)
                sevenSegment6.drawSegmentByDigit(seconds % 10);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            displayTime();
        }
    }
}
