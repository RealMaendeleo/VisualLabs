using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualLab3
{
    public class Apartment : Room
    {
        float _livingArea, _kitchenArea, _bathroomArea, _restroomArea, _hallwayArea;

        public Apartment(float length, float width, float height, float kitchenArea, float bathroomArea, 
            float restroomArea, float hallwayArea) : base(length, width, height)
        {
            _kitchenArea = kitchenArea;
            _bathroomArea = bathroomArea;
            _restroomArea = restroomArea;
            _hallwayArea = hallwayArea;
        }

        public float LivingArea
        {
            get
            {
                return Area - (_kitchenArea + _bathroomArea + _restroomArea + _hallwayArea);
            }
        }
    }
}
