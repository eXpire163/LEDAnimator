using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LEDAnimator.forms
{
    public partial class MessagBoxString : Form
    {
        public string DialogResult="";
        public MessagBoxString()
        {
            InitializeComponent();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter && textBox1.Text.Length>3){
                DialogResult = textBox1.Text;
                this.Close();
            }
        }
    }
}
