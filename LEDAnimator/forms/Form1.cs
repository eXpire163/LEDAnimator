﻿using LEDAnimator.helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LEDAnimator
{
    public partial class Form1 : Form
    {
        #region vars_init
        public enum Toolsmode { AddPoint, Paint, Select, Move }

        Sequenz sequenz;
        Toolsmode toolsmode = Toolsmode.Select;
      
        List<int> selection = new List<int>();

     
        Color selectedColor = Color.Black;
        public Color SelectedColor
        {
            get { return selectedColor; }
            set
            {
                selectedColor = value;
               
            }
        }

        Boolean moving = false;
        int moveID = -1;

        public Form1()
        {
            InitializeComponent();


        }

        #endregion

        #region update

        void update() {

            pictureBox1.Invalidate();
            updateStepsInfo();
            cbGroups.Items.Clear();

            foreach (LEDAnimator.Shape.KCGroup kcg in sequenz.Shape.Groups) {
                cbGroups.Items.Add(kcg.name);
            }


        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            sequenz.Shape.draw(e.Graphics, sequenz.CurrentStep, selection);
           
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

            update();

            
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
            paintselected();
        }

        private void bBlack_Click(object sender, EventArgs e)
        {
            SelectedColor = Color.Black;
            paintselected();
        }

        private void bRot_Click(object sender, EventArgs e)
        {
            SelectedColor = Color.Red;
            paintselected();
        }

        private void bBlau_Click(object sender, EventArgs e)
        {
            SelectedColor = Color.Blue;
            paintselected();
        }

        private void bGruen_Click(object sender, EventArgs e)
        {
            SelectedColor = Color.Green;
            paintselected();
        }

        private void paintselected()
        {
            foreach(int selectedNumber in selection){
                sequenz.CurrentStep.Add(selectedNumber, selectedColor);

            }
            update();
        }

        private void bPrev_Click(object sender, EventArgs e)
        {
            sequenz.prevStep();
            update();
        }

        private void bNext_Click(object sender, EventArgs e)
        {
            nextStep();
        }
        private void nextStep()
        {
            sequenz.nextStep();
            update();
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            sequenz.addStep();
            update();
        }
        private void bAddCopy_Click(object sender, EventArgs e)
        {
            sequenz.cloneStep();
            nextStep();
        }


        private void bSelect_Click(object sender, EventArgs e)
        {
            toolsmode = Toolsmode.Select;
            update();
        }

        private void bColor_Click(object sender, EventArgs e)
        {
            toolsmode = Toolsmode.Paint;
            update();
        }

        private void bAddPoint_Click(object sender, EventArgs e)
        {
            toolsmode = Toolsmode.AddPoint;
            update();
        }

        private void bMoveTool(object sender, EventArgs e)
        {
            toolsmode = Toolsmode.Move;
        }

        #endregion

        #region loadclose

        
        private void Form1_Load(object sender, EventArgs e)
        {
            sequenz = Sequenz.loadFromFIle(true);
            update();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Sequenz.save(false, sequenz);   
        }
        private void bLoad_Click(object sender, EventArgs e)
        {
            Sequenz.loadFromFIle(false);
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            Sequenz.save(false, sequenz);

        }

        private void bSaveAs_Click(object sender, EventArgs e)
        {
            Sequenz.save(true, sequenz);
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

        #region groups

        private void bSaveGroup_Click(object sender, EventArgs e)
        {
            forms.MessagBoxString mbs = new forms.MessagBoxString();
            mbs.ShowDialog();

            sequenz.addGroup(selection, mbs.DialogResult);
            update();
        }

        private void cbGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedgroup = sequenz.Shape.Groups.Where(element => element.name == cbGroups.Text);
            selection = selectedgroup.First().positions.ToList<int>();

           // update();

        }

      
        private void bRemoveGroup(object sender, EventArgs e)
        {
            sequenz.removeGroup(cbGroups.Text);
            update();
        }

        #endregion

        #region move

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (toolsmode == Toolsmode.Move)
            {
                moving = true;
                moveID = sequenz.Shape.select(new KCPoint(e.Location));
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            moving = false;
            moveID = -1;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (moving && moveID >= 0)
            {


                sequenz.Shape.Positions[moveID].X = Mathhelper.RoundOff(e.X);
                sequenz.Shape.Positions[moveID].Y = Mathhelper.RoundOff(e.Y);
                update();
            }

        }




        #endregion
    }

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

}