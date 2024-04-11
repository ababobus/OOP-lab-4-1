using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const int radius = 30;

        class CCircle
        {
            public Rectangle crug;
            bool Selected = false;
            public CCircle(int x, int y)
            {
                crug = new Rectangle(x, y, radius * 2, radius * 2);
            }
        }

        List<CCircle> Circles = new List<CCircle>();


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }
        //add btn delete save group load
    }


}
