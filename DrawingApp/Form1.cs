using System;
using System.Drawing;
using System.Windows.Forms;

namespace DrawingApp
{
    public partial class Form1 : Form
    {
        private bool isDrawing = false;
        private Point previousPoint = new Point();
        private Bitmap canvasBitmap;
        private Graphics canvasGraphics;

        public Form1()
        {
            InitializeComponent();

            // Initialize the canvas
            canvasBitmap = new Bitmap(this.ClientSize.Width, this.ClientSize.Height);
            canvasGraphics = Graphics.FromImage(canvasBitmap);
            canvasGraphics.Clear(Color.White);
            this.BackgroundImage = canvasBitmap;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDrawing = true;
                previousPoint = e.Location;
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                Point currentPoint = e.Location;
                canvasGraphics.DrawLine(Pens.Black, previousPoint, currentPoint);
                previousPoint = currentPoint;
                this.Invalidate(); // Refresh the form to show the new line
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDrawing = false;
            }
        }
    }
}
