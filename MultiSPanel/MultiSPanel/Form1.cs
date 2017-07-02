using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MultiSPanel
{
    public partial class Form1 : Form
    {
        MultipleSlidingPAnel o1, o2;
        public Form1()
        {
            InitializeComponent();

            o1 = new MultipleSlidingPAnel(ref sliding1, ref button1, true, "HIDE", "SHOW");
            o2 = new MultipleSlidingPAnel(ref sliding2, ref button2, false,"H\nI\nD\nE", "S\nH\nO\nW");
        }
    }
}
