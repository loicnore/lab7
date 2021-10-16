using core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ann
{
    class Line
    {
        protected List<float> x;
        public List<float> Linear(float b, float c)
        {
            if (b == 0)
            {
                throw new AnnException("Уравнение не существует.");
            }
            AnnLog.I().log("Уравнение является линейным");
            return x = new List<float> { -b / c };
        }
    }
}
