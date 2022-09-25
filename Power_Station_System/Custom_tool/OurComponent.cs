using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace OurComponent
{
    public class OurPanel : Panel
    {
        //Fields

        private int borderRaduis = 30;
        private float gardientAngle = 90F;
        private Color gardientTopClor = Color.DodgerBlue;
        private Color gardientBottomClor = Color.CadetBlue;

        //Constructors: 
        public OurPanel()
        {
            this.BackColor = Color.White;
            this.ForeColor = Color.Black;
            this.Size = new Size(350, 200);


        }
        //properties
        public int BorderRaduis
        {
            get => borderRaduis;
            set { borderRaduis = value; this.Invalidate(); }
        }
        public float GardientAngle
        {
            get => gardientAngle;
            set { gardientAngle = value; this.Invalidate(); }
        }
        public Color GardientTopClor
        {
            get => gardientTopClor;
            set { gardientTopClor = value; }
        }

        public Color GardientBottomClor
        {
            get => gardientBottomClor;
            set { gardientBottomClor = value; this.Invalidate(); }

        }

        //Methods
        private GraphicsPath GetOurPath(RectangleF rectangle, float radius)
        {
            GraphicsPath graphicsPath = new GraphicsPath();
            graphicsPath.StartFigure();
            graphicsPath.AddArc(rectangle.Width - radius, rectangle.Height - radius, radius, radius, 0, 90);
            graphicsPath.AddArc(rectangle.X, rectangle.Height - radius, radius, radius, 90, 90);
            graphicsPath.AddArc(rectangle.X, rectangle.Y, radius, radius, 180, 90);
            graphicsPath.AddArc(rectangle.Width-radius, rectangle.Y, radius, radius, 270, 90);
            graphicsPath.CloseFigure();
            return graphicsPath; 
        }

        //overridden Mehtods
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            //Gradient
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            LinearGradientBrush brushOsama = new LinearGradientBrush(this.ClientRectangle,this.gardientTopClor, this.gardientBottomClor,this.gardientAngle);
            Graphics graphicsOsama = e.Graphics;
            graphicsOsama.FillRectangle(brushOsama, ClientRectangle);



            //BorderRadius
            RectangleF rectangleF = new RectangleF(0, 0, this.Width, this.Height);
            if (borderRaduis > 2)
            {

                using (GraphicsPath graphicsPath = GetOurPath(rectangleF, borderRaduis))
                using (Pen pen = new Pen(this.Parent.BackColor, 2))
                {
                    this.Region = new Region(graphicsPath);
                    e.Graphics.DrawPath(pen, graphicsPath);
                }
            }

            else this.Region = new Region(rectangleF); 

        }


    }
}
