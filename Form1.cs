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

        static readonly Pen PenCircleSelect = new Pen(Brushes.HotPink);
        static readonly Pen PenCircleNotSelect = new Pen(Brushes.Black);
        void PenCircleMake()
        {
            PenCircleSelect.Width = 2;
            PenCircleNotSelect.Width = 2;
        }
        const int radius = 30;
        bool IsCtrl = false;
        class CCircle
        {
            public Rectangle crug;
            bool Selected = false;
            public CCircle(int x, int y)
            {
                crug = new Rectangle(x, y, radius * 2, radius * 2);
                Selected = true;
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


        private void Figures_MouseClick(object sender, MouseEventArgs e)
        {
            bool CircleClickFlag = false;
            if (IsCtrl  == false|| CtrlCheckBox.Checked == false)
                foreach (var i in Circles)
                    i.SetSelect(false);

            foreach (var i in Circles) 
            {
                if (i.IsClicked(e.X - radius, e.Y - radius))
                {
                    i.ChangeSelect();
                    CircleClickFlag = true;
                    if (OverlayCheckBox.Checked == false)
                        break;
                }
            }

            if (CircleClickFlag == false)
            {
                if (IsCtrl == false|| CtrlCheckBox.Checked == false)
                    foreach (var i in Circles)
                        i.SetSelect(false);
                Circles.Add(new CCircle(e.X - radius, e.Y - radius));

            }
            Figures.Invalidate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PenCircleMake();
        }
        private void Figures_Paint(object sender, PaintEventArgs e) // Событие отрисовки
        {
            foreach (var i in Circles)
                i.Draw(e);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete) 
            {
                for (int i = 0; i < Circles.Count(); ++i)
                {
                    if (Circles[i].GetSelect())
                    {
                        Circles.RemoveAt(i--);
                    }
                }
                if (Circles.Count != 0)
                    Circles.Last().SetSelect(true);

                Figures.Invalidate();
            }
            else if (e.Control) // Нажатие CTRL
            {
                IsCtrl = true;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ControlKey)
            {
                IsCtrl = false;
            }
        }
    }


}
