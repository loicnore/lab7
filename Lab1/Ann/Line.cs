using System;
using System.Collections.Generic;
using System.Text;

namespace Ann
{
    class Line
    {
        protected List<float> x;
        public List<float> Linear(float a, float b)
        {
            if (a == 0)
            {
                return null;
            }
            return x = new List<float> { -b / a };
        }
    }
}
