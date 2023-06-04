using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualLab3
{
    public abstract class Room
    {
        protected float _length, _width, _height, _area, _volume;

        protected Room(float length, float width, float height)
        {
            _length = length;
            _width = width;
            _height = height;
        }

        public float Area
        {
            get
            {
                return _length * _width;
            }
        }
        
        public float Volume
        {
            get
            {
                return _length * _width * _height;
            }
        }
    }
}
