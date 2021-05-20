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
        Pen myPen = new Pen(Color.Black);
        Graphics paper;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Rectangle rect = new Rectangle(150, 100, 200, 300);
            paper = board.CreateGraphics();
            paper.DrawEllipse(myPen, rect);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            paper = board.CreateGraphics();
            paper.DrawLine(myPen, 100, 100, 150, 150);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PointF[] points = new PointF[3];
            points[0] = new Point(50, 50);
            points[1] = new Point(150, 50);
            points[2] = new Point(250, 150);
            paper = board.CreateGraphics();
            paper.DrawPolygon(myPen, points);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Rectangle rect = new Rectangle(250, 200, 200, 300);
            paper = board.CreateGraphics();
            paper.DrawRectangle(myPen, rect);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
