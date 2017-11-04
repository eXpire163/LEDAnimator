using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace LEDAnimator
{

    /// <summary>
    /// make shure to upadte COPY on new properties
    /// </summary>
    [Serializable]
    public class Step
    {



        List<KCColor> datapoints = new List<KCColor>();

        public List<KCColor> Datapoints
        {
            get { return datapoints; }
            set { datapoints = value; }
        }

        public Step() { }

        public void Add(int selectedNumber, Color selectedColor)
        {

            KCColor kcc = datapoints.Find(x => x.position == selectedNumber);
            if (null != kcc)
            {
                kcc.Color = selectedColor;
            }
            else {
                datapoints.Add(new KCColor(selectedNumber, selectedColor));
            }
        }

        public static Step Clone(Step CurrentStep)
        {
            Step newstep = new Step();
            foreach (KCColor datapoint in CurrentStep.Datapoints) {
                newstep.Add(datapoint.position, datapoint.Color);
            
            }
            return newstep;
        }
    }


}
