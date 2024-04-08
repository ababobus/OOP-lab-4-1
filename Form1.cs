using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        class CCircle
        {
            private int x, y;
            private const int radius = 30;
            public bool isSelected;
            public CCircle(int x_pos, int y_pos) { 
                x = x_pos;
                y = y_pos;

            }

            public void draw(Graphics g)
            {
                Brush brush = isSelected ? Brushes.Red : Brushes.Blue;
                g.FillEllipse(brush, x - radius, y - radius, 2 * radius, 2 * radius);
                Debug.WriteLine("CCircle.draw");
            }

            


        }
    }
}
