using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace LEDAnimator
{
     [Serializable]
    public class Shape
    {

        List<KCPoint> positions = new List<KCPoint>();

        public List<KCPoint> Positions
        {
            get { return positions; }
            set { positions = value; }
        }
        private int diameter = 10;
        private int setSelected;



        public struct KCGroup {
           public string name;
           public int[] positions;
        }
        public List<KCGroup> groups = new List<KCGroup>();

        public Shape()
        {
           
        }


        public void draw(System.Drawing.Graphics graphics, Step currentStep)
        {
          
            drawPoints(graphics, currentStep);
            drawGroups(graphics);
            
        }

        private void drawPoints(System.Drawing.Graphics graphics, Step currentStep)
        {
            for (int i = 0; i < positions.Count; i++)
            {
                KCColor foundColor = currentStep.Datapoints.Find(x => x.position == i);
                if (foundColor != null)
                {
                    drawCircleFill(graphics, positions[i], foundColor.Color);

                }

                if (positions[i].isSelected)
                {
                    drawCircle(graphics, positions[i], Color.Lime);
                }
                else
                {
                    drawCircle(graphics, positions[i], Color.Red);
                }

            }

        }
        void drawGroups(Graphics g)
        {
            float[] dashValues = { 5, 3, 2, 3   };
            Pen blackPen = new Pen(Color.Blue, 1);
            blackPen.DashPattern = dashValues;

            Font font = new Font("verdana", 7);


            foreach(KCGroup group in groups){
                if (group.positions == null || group.positions.Length<2) {
                    continue;
                }
                List<KCPoint> grouppoints = new List<KCPoint>();
                foreach (int shapepointId in group.positions) {
                    grouppoints.Add(positions[shapepointId]);
                
                }


                int x = grouppoints.Min(elemet => elemet.X);
                int y = grouppoints.Min(elemet => elemet.Y);
                int width = grouppoints.Max(elemet => elemet.X) - x;
                int height = grouppoints.Max(elemet => elemet.Y) - y;

                Rectangle rect = new Rectangle(x, y, width, height);

                g.DrawRectangle(blackPen, rect);
                g.DrawString(group.name, font, new SolidBrush(Color.Blue), x, y);
                
            }
        }


        private void drawCircle(Graphics graphics, KCPoint point, Color color)
        {
            graphics.DrawEllipse(new Pen(new SolidBrush(color)), point.X - diameter, point.Y - diameter, 2 * diameter, 2 * diameter);
        }


        private void drawCircleFill(Graphics graphics, KCPoint point, Color color)
        {
            graphics.FillEllipse(new SolidBrush(color), point.X - diameter, point.Y - diameter, 2 * diameter, 2 * diameter);
        }





        public int select(KCPoint point)
        {
            //Console.WriteLine("------------");
            for (int i = 0; i < positions.Count; i++)
			{
			 if (Mathhelper.dist(positions[i], point) < diameter)
                {
                    try
                    {
                        positions[setSelected].isSelected = false;
                    }
                    catch { }
                    setSelected = i;
                    positions[setSelected].isSelected = true;
                  
                    return i;
                }
               
			}
                

            
            return -1;
        }

        internal int[] selectGroup(KCPoint kCPoint)
        {
            throw new NotImplementedException();
        }
    }
}
