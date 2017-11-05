using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEDAnimator
{
    [Serializable]
    public class KCPoint 
    {
        public int X;
        public int Y;

        public Color color;
     
        public KCPoint(System.Drawing.Point point) {
            this.X = point.X;
            this.Y = point.Y;
            
        }
        public KCPoint() { }
       
    }
}
