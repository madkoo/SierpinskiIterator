using System;
using System.Collections;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Iteraator
{
    public partial class PointDrawer : Form
    {
        private readonly double _cx;
        private readonly double _cy;
        private readonly double _simulationElementWidth;
        private readonly double _zoom;

        public PointDrawer()
        {
            InitializeComponent();
            _simulationElementWidth = 3;
            _zoom = 6;
            _cx = 100;
            _cy = 100;



        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            Graphics g = CreateGraphics();
            var factory = new ElementFactory();

            var points = factory.AppendSierpinski(GetLevel());
            //var points = factory.AppendPlanets();
            //DrawPoints(g, points.GetEnumerator());
            DrawPoints(points.GetEnumerator());
        }

        //private void DrawPoints(Graphics g, IEnumerator points)
        //{
        //    while (points.MoveNext())
        //    {
        //        DrawPoint(g, (Point)points.Current);
        //    }
        //}



        public void DrawPoints(IEnumerator points)
        {
            var bm = new Bitmap(picBox.ClientSize.Width, picBox.ClientSize.Height);
            

                using (Graphics gr = Graphics.FromImage(bm))
                {
                    gr.Clear(Color.White);
                    gr.SmoothingMode = SmoothingMode.AntiAlias;
                    // Draw triangle.
                    while (points.MoveNext())
                    {
                        DrawPoint(gr, (Point)points.Current);
                    }

                }
                // Display the result.
                picBox.Image = bm;
                // Save the bitmap into a file.
                bm.Save("Triangle " + GetLevel() + ".bmp");
                
        }


        public void DrawPoint(Graphics g, Point point)
        {
            var a = new Pen(Color.Black);

            double x = point.X();
            double y = point.Y();
            double[] newCoordinates = ConvCoords(x, y);
            g.DrawEllipse(a, (float)newCoordinates[0], (float)newCoordinates[1], (float)_simulationElementWidth, (float)_simulationElementWidth);


        }

        #region Private

        private int GetLevel()
        {
            var level = tbLevel.Text;
            return int.TryParse(level, out int lvl) ? lvl : 7;
        }


        private double[] ConvCoords(double x, double y)
        {
            double x0 = (_cx + x * _zoom);
            double y0 = (_cy + y * _zoom);
            double x1 = x0 + _simulationElementWidth;
            double y1 = y0 + _simulationElementWidth;
            return new[]
            {
                x0, y0, x1, y1
            };
        }
        

        #endregion
    }
}
