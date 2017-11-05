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
        #region vars_init
        public struct KCGroup
        {
            public string name;
            public int[] positions;
        }

        List<KCPoint> positions = new List<KCPoint>();

        List<KCGroup> groups = new List<KCGroup>();

        public List<KCGroup> Groups
        {
            get { return groups; }
            set { groups = value; }
        }

        public List<KCPoint> Positions
        {
            get { return positions; }
            set { positions = value; }
        }

        private int diameter = 10;
      
        public Shape()
        {

        }

        #endregion

        #region draw

        public void draw(System.Drawing.Graphics graphics, Step currentStep, List<int> selection)
        {

            drawPoints(graphics, currentStep, selection);
            drawGroups(graphics);

        }

        private void drawPoints(System.Drawing.Graphics graphics, Step currentStep, List<int> selection)
        {
            for (int i = 0; i < positions.Count; i++)
            {
                KCColor foundColor = currentStep.Datapoints.Find(x => x.position == i);
                if (foundColor != null)
                {
                    drawCircleFill(graphics, positions[i], foundColor.Color);

                }

                if (selection.Contains(i))
                {
                    drawCircle(graphics, positions[i], Color.Lime);
                }
                else
                {
                    drawCircle(graphics, positions[i], Color.Red);
                }

            }

        }
        
        private void drawGroups(Graphics g)
        {
            float[] dashValues = { 5, 3, 2, 3 };
            Pen blackPen = new Pen(Color.Blue, 1);
            blackPen.DashPattern = dashValues;

            Font font = new Font("verdana", 7);


            foreach (KCGroup group in groups)
            {
                if (group.positions == null || group.positions.Length < 2)
                {
                    continue;
                }
                List<KCPoint> grouppoints = new List<KCPoint>();
                foreach (int shapepointId in group.positions)
                {
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

        #endregion

        #region select

        public int select(KCPoint point)
        {
            //Console.WriteLine("------------");
            for (int i = 0; i < positions.Count; i++)
            {
                if (Mathhelper.dist(positions[i], point) < diameter)
                {


                    return i;
                }

            }



            return -1;
        }

        public int[] selectGroup(KCPoint kCPoint)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
