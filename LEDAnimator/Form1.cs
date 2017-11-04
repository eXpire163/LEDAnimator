using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LEDAnimator
{
    public partial class Form1 : Form
    {
        public enum Toolsmode { AddPoint, Paint, Select }

        Toolsmode toolsmode = Toolsmode.Select;
        List<int> selection = new List<int>();

        Sequenz sequenz;

        Color selectedColor = Color.Black;
        public Color SelectedColor
        {
            get { return selectedColor; }
            set
            {
                selectedColor = value;
                pictureBox2.BackColor = selectedColor;
                pictureBox2.Update();
            }
        }

        public Form1()
        {
            InitializeComponent();

            load();
        }



        #region update
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            sequenz.Shape.draw(e.Graphics, sequenz.CurrentStep);
            updateStepsInfo();

        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {

            switch (toolsmode)
            {

                case Toolsmode.AddPoint:
                    sequenz.Shape.Positions.Add(new KCPoint(e.Location));
                    pictureBox1.Invalidate();
                    break;
                case Toolsmode.Paint:
                    int selectedNumber = sequenz.Shape.select(new KCPoint(e.Location));


                    if (selectedNumber >= 0)
                    {

                        sequenz.CurrentStep.Add(selectedNumber, selectedColor);

                    }
                    break;
                case Toolsmode.Select:
                default:
                   int singleselection = sequenz.Shape.select(new KCPoint(e.Location));
                     
                   if (e.Button == MouseButtons.Left && ModifierKeys == Keys.None)
                    {
                        selection.Clear();
                       if (singleselection >= 0)
                       {
                           selection.Add(singleselection);
                       }
                       
                    }
                    if (e.Button == MouseButtons.Left && ModifierKeys == Keys.Control)
                    {
                        if (singleselection >= 0)
                        {
                            selection.Add(singleselection);
                        }
                    }
                    break;

            }

           

              /*  int[] selectedGroup = sequenz.Shape.selectGroup(new KCPoint(e.Location));

                if (sequenz.Recording && selectedGroup.Length > 0)
                {
                    foreach (int i in selectedGroup)
                    {
                        sequenz.CurrentStep.Add(i, selectedColor);
                    }
                }*/

                pictureBox1.Invalidate();


            
        }
        private void updateStepsInfo()
        {
            lCurrentMax.Text = String.Format("{0}/{1}  Mode {2}, selection {3}", sequenz.CurrentStepInt, sequenz.TotalSteps, toolsmode.ToString(), string.Join(", ",selection));
        }
        #endregion

        #region  buttons
       

       

        private void bWhite_Click(object sender, EventArgs e)
        {
            SelectedColor = Color.White;
        }

        private void bBlack_Click(object sender, EventArgs e)
        {
            SelectedColor = Color.Black;
        }

        private void bRot_Click(object sender, EventArgs e)
        {
            SelectedColor = Color.Red;
        }

        private void bBlau_Click(object sender, EventArgs e)
        {
            SelectedColor = Color.Blue;
        }

        private void bGruen_Click(object sender, EventArgs e)
        {
            SelectedColor = Color.Green;
        }

        private void bPrev_Click(object sender, EventArgs e)
        {
            sequenz.prevStep();
            pictureBox1.Invalidate();
            updateStepsInfo();
        }

        private void bNext_Click(object sender, EventArgs e)
        {
            nextStep();
        }
        private void nextStep()
        {
            sequenz.nextStep();
            pictureBox1.Invalidate();
            updateStepsInfo();
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            sequenz.addStep();
            pictureBox1.Update();
            updateStepsInfo();
        }
        private void bAddCopy_Click(object sender, EventArgs e)
        {
            sequenz.cloneStep();
            nextStep();
        }


        #endregion




        #region loadclose

        private void load()
        {
            sequenz = Sequenz.load();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                sequenz = XMLHelper.DeSerializeObject<Sequenz>("C:\\temp\\xmlanimation.xml");
                if (sequenz == null)
                {
                    sequenz = Sequenz.load();
                }
            }
            catch
            {
                sequenz = Sequenz.load();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            XMLHelper.SerializeObject<Sequenz>(sequenz, "C:\\temp\\xmlanimation.xml");

        }

        #endregion

        #region action


        Timer t = new Timer();


        private void bPlay_Click(object sender, EventArgs e)
        {
            t.Tick += t_Tick;
            t.Enabled = true;
            t.Interval = 500;
        }

        private void bStop_Click(object sender, EventArgs e)
        {
            t.Enabled = false;
            t.Tick -= t_Tick;
        }

        void t_Tick(object sender, EventArgs e)
        {
            nextStep();
        }

        #endregion

        private void bSelect_Click(object sender, EventArgs e)
        {
            toolsmode = Toolsmode.Select;
        }

        private void bColor_Click(object sender, EventArgs e)
        {
            toolsmode = Toolsmode.Paint;
        }

        private void bAddPoint_Click(object sender, EventArgs e)
        {
            toolsmode = Toolsmode.AddPoint;
        }





    }
}
