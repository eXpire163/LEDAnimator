using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LEDAnimator
{
    [Serializable]
    public class Sequenz
    {
        #region vars_init
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

        public Step CurrentStep
        {
            get
            {
                if (steps.Count == 0)
                {
                    steps.Add(new Step());
                }
                return steps[CurrentStepInt];
            }
        }
     

        public Sequenz()
        {



        }



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
   
        #region saveload


        public static Sequenz loadFromFIle(Boolean loadLast)
        {
           

            if (new FileInfo(Properties.Settings.Default.lastProfile).Exists && loadLast)
            {
                try
                {
                    Sequenz sequenz = XMLHelper.DeSerializeObject<Sequenz>(Properties.Settings.Default.lastProfile);
                    return sequenz;
                }
                catch (Exception e) {
                    MessageBox.Show(e.Message, "Could not load last profile, created new one");
                }

            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = "xmlanimation.xml";
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Properties.Settings.Default.lastProfile = sfd.FileName;
                Properties.Settings.Default.Save();
            }
            
            return Sequenz.initNew();

        }

        public static void save(bool saveas, Sequenz sequenz)
        {
            if (saveas) {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.FileName = "xmlanimation.xml";
                if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    Properties.Settings.Default.lastProfile = sfd.FileName;
                    Properties.Settings.Default.Save();
                }
            }

            if (MessageBox.Show("Save to " + Properties.Settings.Default.lastProfile, "Save", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                XMLHelper.SerializeObject<Sequenz>(sequenz, Properties.Settings.Default.lastProfile);
            }
        }

        private static Sequenz initNew()
        {
            Sequenz newSequenz = new Sequenz();
            newSequenz.steps = new List<Step>();
            newSequenz.steps.Add(new Step());

            return newSequenz;
        }

#endregion

        #region steps

        internal void addStep()
        {
            throw new NotImplementedException();
        }

        internal void cloneStep()
        {
            if (steps.Count > 0)
            {
                steps.Insert(currentstep + 1, Step.Clone(CurrentStep));
            }
        }

        #endregion

        #region groups
        public void addGroup(List<int> selection, string p)
        {
            if (selection.Count > 1) {
                shape.Groups.Add(new Shape.KCGroup() { name = p, positions = selection.ToArray<int>() });
            }
        }

        public void removeGroup(String selectedText)
        {
            Shape.Groups.RemoveAll(element => element.name == selectedText);
        }
        #endregion
    }
}
