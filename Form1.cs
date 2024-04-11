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

        static Pen PenCircleSelect = new Pen(Brushes.HotPink);
        static Pen PenCircleNotSelect = new Pen(Brushes.Black);
        void PenCircleMake()
        {
            PenCircleSelect.Width = 2;
            PenCircleNotSelect.Width = 2;
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

            public void Draw(PaintEventArgs e) 
            {
                Graphics graphic = e.Graphics;
                graphic.DrawEllipse((Selected ? PenCircleSelect : PenCircleNotSelect), crug);
            }

            public bool IsClicked(int x, int y) 
            {
                if (Math.Abs(crug.X - x) <= radius && Math.Abs(crug.Y - y) <= radius)
                    return true;
                else
                    return false;
            }
            public void SetSelect(bool select) 
            {
                Selected = select;
            }
            public void ChangeSelect() 
            {
                Selected = !Selected;
            }
            public bool GetSelect()
            {
                return Selected;
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
            PenCircleMake();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }
        //add btn delete save group load
    }


}
