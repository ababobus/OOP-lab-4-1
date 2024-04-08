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

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        class CCircle
        {
            private int x, y, r;
            public bool isSelected;

            private SolidBrush brush = new SolidBrush(Color.Gray);

            public CCircle(int x_pos, int y_pos)
            {
                x = x_pos;
                y = y_pos;
                r = 20;
                isSelected = true;
            }
            public CCircle(int x_pos, int y_pos, int radius)
            {
                x = x_pos;
                y = y_pos;
                r = radius;

                isSelected = true;
            }

            public SolidBrush GetBrush()
            {
                return brush;
            }

            public int returnX()
            {
                return x;
            }
            public int returnY()
            {
                return y;
            }
            public void draw(Graphics gr)
            {
                gr.FillEllipse(GetBrush(), x - r / 2, y - r / 2, r, r);
                if (isSelected == true)
                {
                    gr.DrawEllipse(Pens.Orange, x - r / 2, y - r / 2, r, r);
                }

            }
            public void setSelect(bool select)
            {
                isSelected = select;
            }
            public void changeSelect()
            {
                isSelected = !isSelected;
            }
            public bool getSelect()
            {
                return isSelected;
            }

            public void setColor(Color color)
            {
                brush.Color = color;
            }
            public bool touched(int x_pos, int y_pos)
            {
                if (x_pos >= x - r / 2 && x_pos <= x - r / 2 && y_pos >= y - r / 2 && y_pos <= y - r / 2)
                    return true;
                else return false;

            }
            public void move(int x_pos, int y_pos, int width, int height)
            {
                int dx = x + x_pos;
                int dy = y + y_pos;
                if (dx - r / 2 > 0 && dx + r / 2 < width && dy - r / 2 > 0 && dy + r / 2 < height)
                {
                    if (dx > 200 || dy > 200)
                    {
                        x += x_pos;
                        y += y_pos;
                    }
                }
            }

            public void changeSize(int num)
            {
                if (num == 1)
                {
                    r += 10;
                }
                else if (num == -1)
                {
                    r -= 10;
                }
            }
            public void save(StreamWriter st)
            {
                st.Write("Circle\n");
                st.Write("Radius = " + r.ToString() + "\n");
                st.Write("The X is " + x + "\n");
                st.Write("The Y is " + y + "\n");
                st.Write("The Color is " + brush.Color + "\n");

            }
            public void load(StreamReader st)
            {
                int radius_s = Int32.Parse(st.ReadLine().Substring(9).Trim());
                r = radius_s;
                int x_s = Int32.Parse(st.ReadLine().Substring(9).Trim()); ;
                x = x_s;
                int y_s = Int32.Parse(st.ReadLine().Substring(9).Trim()); ;
                y = y_s;
                string color_s = (st.ReadLine().Substring(20).Trim());
                //MessageBox.Show(color_s); 

                switch (color_s)
                {
                    case "Blue]":
                        brush.Color = Color.Blue;
                        break;
                    case "Green]":
                        brush.Color = Color.Green;
                        break;
                    case "Pink]":
                        brush.Color = Color.Pink;
                        break;
                    case "Gold]":
                        brush.Color = Color.Gold;
                        break;

                }
            
            }
            public void drawArr(Graphics g, int x_pos, int y_pos)
            {
                // MessageBox.Show("Hello world");
                Pen p = new Pen(Brushes.GreenYellow, 3);
                p.StartCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
                g.DrawLine(p, x, y, x_pos, y_pos);

            }

        }
        List<CCircle> Circles = new List<CCircle>();
    }

}
