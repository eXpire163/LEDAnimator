using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace LEDAnimator
{
    [Serializable]
    public class KCColor
    {

        public int position;

        int r;

        public int R
        {
            get { return r; }
            set { r = value; }
        }
         int g;

         public int G
         {
             get { return g; }
             set { g = value; }
         }
         int b;

         public int B
         {
             get { return b; }
             set { b = value; }
         }

        
        [XmlIgnore]
        public Color Color
        {
            get { return Color.FromArgb(r,g,b); }
            set { 
                R = value.R;
                G = value.G;
                B = value.B;
            }
        }
       
        public KCColor() { }

        public KCColor(int selectedNumber, Color selectedColor)
        {
            // TODO: Complete member initialization
            this.position = selectedNumber;
            this.Color = selectedColor;
        }
    }
}
