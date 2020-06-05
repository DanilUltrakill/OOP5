using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forms
{
    class GalEllipse : Gallery
    {
        private Bitmap bitmap;

        public GalEllipse() : base()
        {
            this.bitmap = new Bitmap(Properties.Resources.left);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            GraphicsPath graphicsPath = new GraphicsPath();
            graphicsPath.AddEllipse(new Rectangle(0, 0, Width - 1, Height - 1));
            Region = new Region(graphicsPath);
        }
    }
}
