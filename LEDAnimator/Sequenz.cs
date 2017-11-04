using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LEDAnimator
{
    [Serializable]
    public class Sequenz
    {
        #region getset
        Shape shape = new Shape();

        public Shape Shape
        {
            get { return shape; }
            set { shape = value; }
        }

        List<Step> steps = new List<Step>();

        public List<Step> Steps
        {
            get { return steps; }
            set { steps = value; }
        }

        public int TotalSteps { get { return steps.Count-1; } }
        int currentstep = 0;
        public int CurrentStepInt { get { return currentstep; } }

        public Step CurrentStep { get {
            if (steps.Count == 0) {
                steps.Add(new Step());
            }
            return steps[CurrentStepInt]; } }
        public void nextStep()
        {
            if (currentstep < TotalSteps)
            {
                currentstep++;
            }
            else {
                currentstep = 0;
            }
        }
        public void prevStep()
        {
            if (currentstep > 0)
            {
                currentstep--;
            }
        }



    
        
        #endregion


        public Sequenz()
        {

           

        }




        internal static Sequenz load()
        {
            // TODO
            return initNew() ;
        }

        private static Sequenz initNew()
        {
            Sequenz newSequenz = new Sequenz();
            newSequenz.steps = new List<Step>();
            newSequenz.steps.Add(new Step());

            return newSequenz;
        }

        internal void addStep()
        {
            
        }

        internal void cloneStep()
        {
            if (steps.Count > 0)
            {
                steps.Insert(currentstep + 1, Step.Clone(CurrentStep));
            }
        }
    }
}
