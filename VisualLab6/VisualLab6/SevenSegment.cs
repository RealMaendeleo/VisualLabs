using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualLab6
{
    public partial class SevenSegment : UserControl
    {
        public int value = -1;
        Color activeColor = Color.FromArgb(56, 229, 77);
        Color color = Color.FromArgb(247, 247, 247);
        public SevenSegment()
        {
            InitializeComponent();
        }
        public void drawSegmentByDigit(int digit)
        {
            value = digit;
            switch(digit)
            {
                case 0:
                    Top.BackColor = activeColor;
                    LeftTop.BackColor = activeColor;
                    RightTop.BackColor = activeColor;
                    Middle.BackColor = color;
                    LeftBottom.BackColor = activeColor;
                    RightBottom.BackColor = activeColor;
                    Bottom.BackColor = activeColor;
                    break;

                case 1:
                    Top.BackColor = color;
                    LeftTop.BackColor = color;
                    RightTop.BackColor = activeColor;
                    Middle.BackColor = color;
                    LeftBottom.BackColor = color;
                    RightBottom.BackColor = activeColor;
                    Bottom.BackColor = color;
                    break;

                case 2:
                    Top.BackColor = activeColor;
                    LeftTop.BackColor = color;
                    RightTop.BackColor = activeColor;
                    Middle.BackColor = activeColor;
                    LeftBottom.BackColor = activeColor;
                    RightBottom.BackColor = color;
                    Bottom.BackColor = activeColor;
                    break;

                case 3:
                    Top.BackColor = activeColor;
                    LeftTop.BackColor = color;
                    RightTop.BackColor = activeColor;
                    Middle.BackColor = activeColor;
                    LeftBottom.BackColor = color;
                    RightBottom.BackColor = activeColor;
                    Bottom.BackColor = activeColor;
                    break;

                case 4:
                    Top.BackColor = color;
                    LeftTop.BackColor = activeColor;
                    RightTop.BackColor = activeColor;
                    Middle.BackColor = activeColor;
                    LeftBottom.BackColor = color;
                    RightBottom.BackColor = activeColor;
                    Bottom.BackColor = color;
                    break;

                case 5:
                    Top.BackColor = activeColor;
                    LeftTop.BackColor = activeColor;
                    RightTop.BackColor = color;
                    Middle.BackColor = activeColor;
                    LeftBottom.BackColor = color;
                    RightBottom.BackColor = activeColor;
                    Bottom.BackColor = activeColor;
                    break;

                case 6:
                    Top.BackColor = activeColor;
                    LeftTop.BackColor = activeColor;
                    RightTop.BackColor = color;
                    Middle.BackColor = activeColor;
                    LeftBottom.BackColor = activeColor;
                    RightBottom.BackColor = activeColor;
                    Bottom.BackColor = activeColor;
                    break;

                case 7:
                    Top.BackColor = activeColor;
                    LeftTop.BackColor = color;
                    RightTop.BackColor = activeColor;
                    Middle.BackColor = color;
                    LeftBottom.BackColor = color;
                    RightBottom.BackColor = activeColor;
                    Bottom.BackColor = color;
                    break;

                case 8:
                    Top.BackColor = activeColor;
                    LeftTop.BackColor = activeColor;
                    RightTop.BackColor = activeColor;
                    Middle.BackColor = activeColor;
                    LeftBottom.BackColor = activeColor;
                    RightBottom.BackColor = activeColor;
                    Bottom.BackColor = activeColor;
                    break;

                case 9:
                    Top.BackColor = activeColor;
                    LeftTop.BackColor = activeColor;
                    RightTop.BackColor = activeColor;
                    Middle.BackColor = activeColor;
                    LeftBottom.BackColor = color;
                    RightBottom.BackColor = activeColor;
                    Bottom.BackColor = activeColor;
                    break;
            }
        }
    }
}
