using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace learnGraphics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            //Graphics surface;
            //surface = this.CreateGraphics();
            //Pen pen1 = new Pen(Color.Blue, 1.0f);
            //surface.DrawLine(pen1, 10, 10, 100, 100);

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics surface;
            surface = this.CreateGraphics();
            Pen pen1 = new Pen(Color.Blue, 1.0f);
            surface.DrawLine(pen1, 50, 50, 150, 150);
            
            Rectangle recOne = new Rectangle(150, 10, 50, 200);
            surface.DrawRectangle(pen1, recOne);

            Rectangle recTwo = new Rectangle();
            recTwo.X = 20;
            recTwo.Y = 20;
            recTwo.Width = 100;
            recTwo.Height = 100;
            surface.DrawRectangle(pen1, recTwo);

            surface.DrawEllipse(pen1, recOne);
            surface.DrawEllipse(pen1, recTwo);
            surface.DrawEllipse(pen1, 100, 10, 200, 200);


            SolidBrush brushOne = new SolidBrush(Color.Blue);
            surface.FillRectangle(brushOne, recTwo);

            Point[] polygonPoints = new Point[5];
            polygonPoints[0] = new Point(113, 283);
            polygonPoints[1] = new Point(70, 156);
            polygonPoints[2] = new Point(180, 70);
            polygonPoints[3] = new Point(290, 156);
            polygonPoints[4] = new Point(250, 283);

            surface.DrawPolygon(pen1, polygonPoints);
            surface.FillPolygon(brushOne, polygonPoints);

        }
    }
}
