using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualLab3
{
    public class Office : Room
    {
        float _toiletLength;

        public Office(float length, float width, float height, float toiletLength) : base(length, width, height)
        {
            _toiletLength = toiletLength;
        }

        public float ToiletArea 
        {
            get
            {
                return _toiletLength * _width;
            }
        }

        public float ToiletVolume
        {
            get
            {
                return _toiletLength * _width * _height;
            }
        }
    }
}
