using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            public CCircle(int x_pos, int y_pos) { 
                x = x_pos;
                y = y_pos;

            }
        }
    }
}
