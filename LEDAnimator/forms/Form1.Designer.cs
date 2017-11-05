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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.bSave = new System.Windows.Forms.Button();
            this.bLoad = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbGroups = new System.Windows.Forms.ComboBox();
            this.bSaveGroup = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bStop = new System.Windows.Forms.Button();
            this.bPlay = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.bRot = new System.Windows.Forms.Button();
            this.bBlau = new System.Windows.Forms.Button();
            this.bGruen = new System.Windows.Forms.Button();
            this.bWhite = new System.Windows.Forms.Button();
            this.bBlack = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.gbSteps = new System.Windows.Forms.GroupBox();
            this.bPrev = new System.Windows.Forms.Button();
            this.bNext = new System.Windows.Forms.Button();
            this.lCurrentMax = new System.Windows.Forms.Label();
            this.bAdd = new System.Windows.Forms.Button();
            this.bAddCopy = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bAddPoint = new System.Windows.Forms.Button();
            this.bColor = new System.Windows.Forms.Button();
            this.bSelect = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bSaveAs = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.gbSteps.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.bSaveAs);
            this.splitContainer1.Panel1.Controls.Add(this.bSave);
            this.splitContainer1.Panel1.Controls.Add(this.bLoad);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox4);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.gbSteps);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1080, 573);
            this.splitContainer1.SplitterDistance = 360;
            this.splitContainer1.TabIndex = 0;
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(126, 537);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(75, 23);
            this.bSave.TabIndex = 20;
            this.bSave.Text = "save";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // bLoad
            // 
            this.bLoad.Location = new System.Drawing.Point(25, 538);
            this.bLoad.Name = "bLoad";
            this.bLoad.Size = new System.Drawing.Size(75, 23);
            this.bLoad.TabIndex = 19;
            this.bLoad.Text = "bLoad";
            this.bLoad.UseVisualStyleBackColor = true;
            this.bLoad.Click += new System.EventHandler(this.bLoad_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbGroups);
            this.groupBox4.Controls.Add(this.bSaveGroup);
            this.groupBox4.Location = new System.Drawing.Point(15, 461);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(324, 63);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groups";
            // 
            // cbGroups
            // 
            this.cbGroups.FormattingEnabled = true;
            this.cbGroups.Location = new System.Drawing.Point(120, 22);
            this.cbGroups.Name = "cbGroups";
            this.cbGroups.Size = new System.Drawing.Size(121, 24);
            this.cbGroups.TabIndex = 1;
            this.cbGroups.SelectedIndexChanged += new System.EventHandler(this.cbGroups_SelectedIndexChanged);
            // 
            // bSaveGroup
            // 
            this.bSaveGroup.Location = new System.Drawing.Point(10, 22);
            this.bSaveGroup.Name = "bSaveGroup";
            this.bSaveGroup.Size = new System.Drawing.Size(95, 23);
            this.bSaveGroup.TabIndex = 0;
            this.bSaveGroup.Text = "save group";
            this.bSaveGroup.UseVisualStyleBackColor = true;
            this.bSaveGroup.Click += new System.EventHandler(this.bSaveGroup_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bStop);
            this.groupBox3.Controls.Add(this.bPlay);
            this.groupBox3.Location = new System.Drawing.Point(15, 393);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(327, 61);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Actions";
            // 
            // bStop
            // 
            this.bStop.Location = new System.Drawing.Point(91, 21);
            this.bStop.Name = "bStop";
            this.bStop.Size = new System.Drawing.Size(75, 23);
            this.bStop.TabIndex = 13;
            this.bStop.Text = "Stop";
            this.bStop.UseVisualStyleBackColor = true;
            this.bStop.Click += new System.EventHandler(this.bStop_Click);
            // 
            // bPlay
            // 
            this.bPlay.Location = new System.Drawing.Point(10, 21);
            this.bPlay.Name = "bPlay";
            this.bPlay.Size = new System.Drawing.Size(75, 23);
            this.bPlay.TabIndex = 12;
            this.bPlay.Text = "Play";
            this.bPlay.UseVisualStyleBackColor = true;
            this.bPlay.Click += new System.EventHandler(this.bPlay_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel1);
            this.groupBox2.Location = new System.Drawing.Point(12, 235);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(330, 152);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Color";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.bRot, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.bBlau, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.bGruen, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.bWhite, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.bBlack, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(324, 131);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // bRot
            // 
            this.bRot.BackColor = System.Drawing.Color.Red;
            this.bRot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bRot.Location = new System.Drawing.Point(3, 46);
            this.bRot.Name = "bRot";
            this.bRot.Size = new System.Drawing.Size(102, 37);
            this.bRot.TabIndex = 2;
            this.bRot.Text = "&1 red";
            this.bRot.UseVisualStyleBackColor = false;
            this.bRot.Click += new System.EventHandler(this.bRot_Click);
            // 
            // bBlau
            // 
            this.bBlau.BackColor = System.Drawing.Color.Blue;
            this.bBlau.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bBlau.Location = new System.Drawing.Point(111, 46);
            this.bBlau.Name = "bBlau";
            this.bBlau.Size = new System.Drawing.Size(102, 37);
            this.bBlau.TabIndex = 3;
            this.bBlau.Text = " &2 blue";
            this.bBlau.UseVisualStyleBackColor = false;
            this.bBlau.Click += new System.EventHandler(this.bBlau_Click);
            // 
            // bGruen
            // 
            this.bGruen.BackColor = System.Drawing.Color.Green;
            this.bGruen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bGruen.Location = new System.Drawing.Point(219, 46);
            this.bGruen.Name = "bGruen";
            this.bGruen.Size = new System.Drawing.Size(102, 37);
            this.bGruen.TabIndex = 4;
            this.bGruen.Text = "&3 green";
            this.bGruen.UseVisualStyleBackColor = false;
            this.bGruen.Click += new System.EventHandler(this.bGruen_Click);
            // 
            // bWhite
            // 
            this.bWhite.BackColor = System.Drawing.Color.White;
            this.bWhite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bWhite.Location = new System.Drawing.Point(3, 89);
            this.bWhite.Name = "bWhite";
            this.bWhite.Size = new System.Drawing.Size(102, 39);
            this.bWhite.TabIndex = 5;
            this.bWhite.Text = "&4 white";
            this.bWhite.UseVisualStyleBackColor = false;
            this.bWhite.Click += new System.EventHandler(this.bWhite_Click);
            // 
            // bBlack
            // 
            this.bBlack.BackColor = System.Drawing.Color.Black;
            this.bBlack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bBlack.Location = new System.Drawing.Point(111, 89);
            this.bBlack.Name = "bBlack";
            this.bBlack.Size = new System.Drawing.Size(102, 39);
            this.bBlack.TabIndex = 5;
            this.bBlack.Text = "&5 schwarz";
            this.bBlack.UseVisualStyleBackColor = false;
            this.bBlack.Click += new System.EventHandler(this.bBlack_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(102, 37);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // gbSteps
            // 
            this.gbSteps.Controls.Add(this.bPrev);
            this.gbSteps.Controls.Add(this.bNext);
            this.gbSteps.Controls.Add(this.lCurrentMax);
            this.gbSteps.Controls.Add(this.bAdd);
            this.gbSteps.Controls.Add(this.bAddCopy);
            this.gbSteps.Location = new System.Drawing.Point(12, 94);
            this.gbSteps.Name = "gbSteps";
            this.gbSteps.Size = new System.Drawing.Size(330, 135);
            this.gbSteps.TabIndex = 14;
            this.gbSteps.TabStop = false;
            this.gbSteps.Text = "Steps";
            // 
            // bPrev
            // 
            this.bPrev.Location = new System.Drawing.Point(26, 21);
            this.bPrev.Name = "bPrev";
            this.bPrev.Size = new System.Drawing.Size(75, 23);
            this.bPrev.TabIndex = 7;
            this.bPrev.Text = "pre";
            this.bPrev.UseVisualStyleBackColor = true;
            this.bPrev.Click += new System.EventHandler(this.bPrev_Click);
            // 
            // bNext
            // 
            this.bNext.Location = new System.Drawing.Point(190, 19);
            this.bNext.Name = "bNext";
            this.bNext.Size = new System.Drawing.Size(75, 23);
            this.bNext.TabIndex = 8;
            this.bNext.Text = "next";
            this.bNext.UseVisualStyleBackColor = true;
            this.bNext.Click += new System.EventHandler(this.bNext_Click);
            // 
            // lCurrentMax
            // 
            this.lCurrentMax.AutoSize = true;
            this.lCurrentMax.Location = new System.Drawing.Point(91, 89);
            this.lCurrentMax.Name = "lCurrentMax";
            this.lCurrentMax.Size = new System.Drawing.Size(46, 17);
            this.lCurrentMax.TabIndex = 10;
            this.lCurrentMax.Text = "label1";
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(107, 19);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(75, 23);
            this.bAdd.TabIndex = 9;
            this.bAdd.Text = "add";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // bAddCopy
            // 
            this.bAddCopy.Location = new System.Drawing.Point(107, 48);
            this.bAddCopy.Name = "bAddCopy";
            this.bAddCopy.Size = new System.Drawing.Size(75, 23);
            this.bAddCopy.TabIndex = 11;
            this.bAddCopy.Text = "addCopy";
            this.bAddCopy.UseVisualStyleBackColor = true;
            this.bAddCopy.Click += new System.EventHandler(this.bAddCopy_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bAddPoint);
            this.groupBox1.Controls.Add(this.bColor);
            this.groupBox1.Controls.Add(this.bSelect);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 75);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "tools";
            // 
            // bAddPoint
            // 
            this.bAddPoint.Location = new System.Drawing.Point(190, 32);
            this.bAddPoint.Name = "bAddPoint";
            this.bAddPoint.Size = new System.Drawing.Size(75, 23);
            this.bAddPoint.TabIndex = 2;
            this.bAddPoint.Text = "&Add Point";
            this.bAddPoint.UseVisualStyleBackColor = true;
            this.bAddPoint.Click += new System.EventHandler(this.bAddPoint_Click);
            // 
            // bColor
            // 
            this.bColor.Location = new System.Drawing.Point(107, 32);
            this.bColor.Name = "bColor";
            this.bColor.Size = new System.Drawing.Size(75, 23);
            this.bColor.TabIndex = 1;
            this.bColor.Text = "&color";
            this.bColor.UseVisualStyleBackColor = true;
            this.bColor.Click += new System.EventHandler(this.bColor_Click);
            // 
            // bSelect
            // 
            this.bSelect.Location = new System.Drawing.Point(26, 32);
            this.bSelect.Name = "bSelect";
            this.bSelect.Size = new System.Drawing.Size(75, 23);
            this.bSelect.TabIndex = 0;
            this.bSelect.Text = "&select";
            this.bSelect.UseVisualStyleBackColor = true;
            this.bSelect.Click += new System.EventHandler(this.bSelect_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(716, 573);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // bSaveAs
            // 
            this.bSaveAs.Location = new System.Drawing.Point(225, 538);
            this.bSaveAs.Name = "bSaveAs";
            this.bSaveAs.Size = new System.Drawing.Size(75, 23);
            this.bSaveAs.TabIndex = 21;
            this.bSaveAs.Text = "asve as";
            this.bSaveAs.UseVisualStyleBackColor = true;
            this.bSaveAs.Click += new System.EventHandler(this.bSaveAs_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 573);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.gbSteps.ResumeLayout(false);
            this.gbSteps.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bWhite;
        private System.Windows.Forms.Button bBlack;
        private System.Windows.Forms.Button bGruen;
        private System.Windows.Forms.Button bBlau;
        private System.Windows.Forms.Button bRot;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button bNext;
        private System.Windows.Forms.Button bPrev;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Label lCurrentMax;
        private System.Windows.Forms.Button bAddCopy;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bStop;
        private System.Windows.Forms.Button bPlay;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox gbSteps;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bAddPoint;
        private System.Windows.Forms.Button bColor;
        private System.Windows.Forms.Button bSelect;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button bSaveGroup;
        private System.Windows.Forms.ComboBox cbGroups;
        private System.Windows.Forms.Button bLoad;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Button bSaveAs;
    }
}

