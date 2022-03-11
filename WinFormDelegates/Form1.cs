using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormDelegates
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button button = new Button();
            button.Text = "click on me";
            button.Size = new Size(100, 100);
            button.Location = new Point(50, 50);
            Controls.Add(button);
            //button.Click += new EventHandler(button_Click);
            button.Click += (x,y) => /*delegate*/
            {
                MessageBox.Show("hello world");
            };

        }
        //private void button_Click(object sender, EventArgs e)
        //{
        //    MessageBox.Show("hello world");
        //}
    }
}
