namespace LEDAnimator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.StripGroups = new System.Windows.Forms.ToolStrip();
            this.toolStripButton10 = new System.Windows.Forms.ToolStripButton();
            this.cbGroups = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripButton11 = new System.Windows.Forms.ToolStripButton();
            this.StripLoadSave = new System.Windows.Forms.ToolStrip();
            this.toolStripButton12 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton13 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton14 = new System.Windows.Forms.ToolStripButton();
            this.StripAction = new System.Windows.Forms.ToolStrip();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton9 = new System.Windows.Forms.ToolStripButton();
            this.StripTool = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton20 = new System.Windows.Forms.ToolStripButton();
            this.StripSteps = new System.Windows.Forms.ToolStrip();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.lCurrentMax = new System.Windows.Forms.ToolStripLabel();
            this.StripColor = new System.Windows.Forms.ToolStrip();
            this.toolStripButton15 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton16 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton17 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton18 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton19 = new System.Windows.Forms.ToolStripButton();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.StripGroups.SuspendLayout();
            this.StripLoadSave.SuspendLayout();
            this.StripAction.SuspendLayout();
            this.StripTool.SuspendLayout();
            this.StripSteps.SuspendLayout();
            this.StripColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            this.toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.pictureBox1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(1080, 429);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(1080, 573);
            this.toolStripContainer1.TabIndex = 1;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.StripGroups);
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.StripLoadSave);
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.StripAction);
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.StripColor);
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.StripTool);
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.StripSteps);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1080, 429);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // StripGroups
            // 
            this.StripGroups.Dock = System.Windows.Forms.DockStyle.None;
            this.StripGroups.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.StripGroups.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton10,
            this.cbGroups,
            this.toolStripButton11});
            this.StripGroups.Location = new System.Drawing.Point(3, 0);
            this.StripGroups.Name = "StripGroups";
            this.StripGroups.Size = new System.Drawing.Size(207, 39);
            this.StripGroups.TabIndex = 3;
            // 
            // toolStripButton10
            // 
            this.toolStripButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton10.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton10.Image")));
            this.toolStripButton10.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton10.Name = "toolStripButton10";
            this.toolStripButton10.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton10.Text = "Save Group";
            this.toolStripButton10.Click += new System.EventHandler(this.bSaveGroup_Click);
            // 
            // cbGroups
            // 
            this.cbGroups.Name = "cbGroups";
            this.cbGroups.Size = new System.Drawing.Size(121, 39);
            this.cbGroups.SelectedIndexChanged += new System.EventHandler(this.cbGroups_SelectedIndexChanged);
            // 
            // toolStripButton11
            // 
            this.toolStripButton11.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton11.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton11.Image")));
            this.toolStripButton11.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton11.Name = "toolStripButton11";
            this.toolStripButton11.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton11.Text = "deleteGroup";
            this.toolStripButton11.Click += new System.EventHandler(this.bRemoveGroup);
            // 
            // StripLoadSave
            // 
            this.StripLoadSave.Dock = System.Windows.Forms.DockStyle.None;
            this.StripLoadSave.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.StripLoadSave.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton12,
            this.toolStripButton13,
            this.toolStripButton14});
            this.StripLoadSave.Location = new System.Drawing.Point(3, 39);
            this.StripLoadSave.Name = "StripLoadSave";
            this.StripLoadSave.Size = new System.Drawing.Size(120, 39);
            this.StripLoadSave.TabIndex = 4;
            // 
            // toolStripButton12
            // 
            this.toolStripButton12.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton12.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton12.Image")));
            this.toolStripButton12.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton12.Name = "toolStripButton12";
            this.toolStripButton12.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton12.Text = "Load";
            this.toolStripButton12.Click += new System.EventHandler(this.bLoad_Click);
            // 
            // toolStripButton13
            // 
            this.toolStripButton13.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton13.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton13.Image")));
            this.toolStripButton13.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton13.Name = "toolStripButton13";
            this.toolStripButton13.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton13.Text = "Save";
            this.toolStripButton13.Click += new System.EventHandler(this.bSave_Click);
            // 
            // toolStripButton14
            // 
            this.toolStripButton14.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton14.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton14.Image")));
            this.toolStripButton14.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton14.Name = "toolStripButton14";
            this.toolStripButton14.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton14.Text = "SaveAs";
            this.toolStripButton14.Click += new System.EventHandler(this.bSaveAs_Click);
            // 
            // StripAction
            // 
            this.StripAction.Dock = System.Windows.Forms.DockStyle.None;
            this.StripAction.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.StripAction.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton8,
            this.toolStripButton9});
            this.StripAction.Location = new System.Drawing.Point(123, 39);
            this.StripAction.Name = "StripAction";
            this.StripAction.Size = new System.Drawing.Size(84, 39);
            this.StripAction.TabIndex = 2;
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton8.Image")));
            this.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton8.Text = "Play";
            this.toolStripButton8.Click += new System.EventHandler(this.bPlay_Click);
            // 
            // toolStripButton9
            // 
            this.toolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton9.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton9.Image")));
            this.toolStripButton9.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton9.Name = "toolStripButton9";
            this.toolStripButton9.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton9.Text = "Stop";
            this.toolStripButton9.Click += new System.EventHandler(this.bStop_Click);
            // 
            // StripTool
            // 
            this.StripTool.Dock = System.Windows.Forms.DockStyle.None;
            this.StripTool.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.StripTool.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton20});
            this.StripTool.Location = new System.Drawing.Point(270, 105);
            this.StripTool.Name = "StripTool";
            this.StripTool.Size = new System.Drawing.Size(156, 39);
            this.StripTool.TabIndex = 0;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton1.Text = "Select";
            this.toolStripButton1.Click += new System.EventHandler(this.bSelect_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton2.Text = "Color";
            this.toolStripButton2.Click += new System.EventHandler(this.bColor_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton3.Text = "Add Point";
            this.toolStripButton3.Click += new System.EventHandler(this.bAddPoint_Click);
            // 
            // toolStripButton20
            // 
            this.toolStripButton20.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton20.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton20.Image")));
            this.toolStripButton20.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton20.Name = "toolStripButton20";
            this.toolStripButton20.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton20.Text = "Move";
            this.toolStripButton20.Click += new System.EventHandler(this.bMoveTool);
            // 
            // StripSteps
            // 
            this.StripSteps.Dock = System.Windows.Forms.DockStyle.None;
            this.StripSteps.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.StripSteps.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton4,
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripButton7,
            this.lCurrentMax});
            this.StripSteps.Location = new System.Drawing.Point(3, 105);
            this.StripSteps.Name = "StripSteps";
            this.StripSteps.Size = new System.Drawing.Size(267, 39);
            this.StripSteps.TabIndex = 1;
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton4.Text = "previous";
            this.toolStripButton4.Click += new System.EventHandler(this.bPrev_Click);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton5.Text = "next";
            this.toolStripButton5.Click += new System.EventHandler(this.bNext_Click);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton6.Text = "add";
            this.toolStripButton6.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton7.Text = "addCopy";
            this.toolStripButton7.Click += new System.EventHandler(this.bAddCopy_Click);
            // 
            // lCurrentMax
            // 
            this.lCurrentMax.Name = "lCurrentMax";
            this.lCurrentMax.Size = new System.Drawing.Size(111, 36);
            this.lCurrentMax.Text = "toolStripLabel1";
            // 
            // StripColor
            // 
            this.StripColor.Dock = System.Windows.Forms.DockStyle.None;
            this.StripColor.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.StripColor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton15,
            this.toolStripButton16,
            this.toolStripButton17,
            this.toolStripButton18,
            this.toolStripButton19});
            this.StripColor.Location = new System.Drawing.Point(3, 78);
            this.StripColor.Name = "StripColor";
            this.StripColor.Size = new System.Drawing.Size(237, 27);
            this.StripColor.TabIndex = 5;
            // 
            // toolStripButton15
            // 
            this.toolStripButton15.BackColor = System.Drawing.Color.Red;
            this.toolStripButton15.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton15.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton15.Image")));
            this.toolStripButton15.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton15.Name = "toolStripButton15";
            this.toolStripButton15.Size = new System.Drawing.Size(35, 24);
            this.toolStripButton15.Text = "red";
            this.toolStripButton15.Click += new System.EventHandler(this.bRot_Click);
            // 
            // toolStripButton16
            // 
            this.toolStripButton16.BackColor = System.Drawing.Color.Green;
            this.toolStripButton16.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton16.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton16.Image")));
            this.toolStripButton16.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton16.Name = "toolStripButton16";
            this.toolStripButton16.Size = new System.Drawing.Size(51, 24);
            this.toolStripButton16.Text = "green";
            this.toolStripButton16.Click += new System.EventHandler(this.bGruen_Click);
            // 
            // toolStripButton17
            // 
            this.toolStripButton17.BackColor = System.Drawing.Color.Blue;
            this.toolStripButton17.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton17.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton17.Image")));
            this.toolStripButton17.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton17.Name = "toolStripButton17";
            this.toolStripButton17.Size = new System.Drawing.Size(42, 24);
            this.toolStripButton17.Text = "blue";
            this.toolStripButton17.Click += new System.EventHandler(this.bBlau_Click);
            // 
            // toolStripButton18
            // 
            this.toolStripButton18.BackColor = System.Drawing.Color.White;
            this.toolStripButton18.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton18.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton18.Image")));
            this.toolStripButton18.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton18.Name = "toolStripButton18";
            this.toolStripButton18.Size = new System.Drawing.Size(49, 24);
            this.toolStripButton18.Text = "white";
            this.toolStripButton18.Click += new System.EventHandler(this.bWhite_Click);
            // 
            // toolStripButton19
            // 
            this.toolStripButton19.BackColor = System.Drawing.Color.Black;
            this.toolStripButton19.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton19.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton19.Image")));
            this.toolStripButton19.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton19.Name = "toolStripButton19";
            this.toolStripButton19.Size = new System.Drawing.Size(48, 24);
            this.toolStripButton19.Text = "black";
            this.toolStripButton19.Click += new System.EventHandler(this.bBlack_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 573);
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.StripGroups.ResumeLayout(false);
            this.StripGroups.PerformLayout();
            this.StripLoadSave.ResumeLayout(false);
            this.StripLoadSave.PerformLayout();
            this.StripAction.ResumeLayout(false);
            this.StripAction.PerformLayout();
            this.StripTool.ResumeLayout(false);
            this.StripTool.PerformLayout();
            this.StripSteps.ResumeLayout(false);
            this.StripSteps.PerformLayout();
            this.StripColor.ResumeLayout(false);
            this.StripColor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip StripTool;
        private System.Windows.Forms.ToolStrip StripSteps;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStrip StripAction;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.ToolStripButton toolStripButton9;
        private System.Windows.Forms.ToolStripLabel lCurrentMax;
        private System.Windows.Forms.ToolStrip StripGroups;
        private System.Windows.Forms.ToolStripButton toolStripButton10;
        private System.Windows.Forms.ToolStripComboBox cbGroups;
        private System.Windows.Forms.ToolStripButton toolStripButton11;
        private System.Windows.Forms.ToolStrip StripLoadSave;
        private System.Windows.Forms.ToolStripButton toolStripButton12;
        private System.Windows.Forms.ToolStripButton toolStripButton13;
        private System.Windows.Forms.ToolStripButton toolStripButton14;
        private System.Windows.Forms.ToolStrip StripColor;
        private System.Windows.Forms.ToolStripButton toolStripButton15;
        private System.Windows.Forms.ToolStripButton toolStripButton16;
        private System.Windows.Forms.ToolStripButton toolStripButton17;
        private System.Windows.Forms.ToolStripButton toolStripButton18;
        private System.Windows.Forms.ToolStripButton toolStripButton19;
        private System.Windows.Forms.ToolStripButton toolStripButton20;
    }
}

