using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forms
{
    class Gallery : MegaButton
    {

        private string text = "";
        private Bitmap bitmap = new Bitmap(Properties.Resources.left);
        private int i = 1;

        public Gallery() : base()
        {

        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);

            if (i == 1)
                text = "Он слева?";
            if (i == 2)
                text = "Может справа?";
            if (i == 3)
                text = "НАШЁЛ!!!!!";
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {

            pevent.Graphics.DrawImage(bitmap, 0, 0);

            stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;

            pevent.Graphics.DrawString(text, Font, new SolidBrush(ForeColor), ClientRectangle, stringFormat);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);

            text = "";
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            i++;

            if (i > 3)
                i = 1;

            if (i == 1)
            {
                bitmap = new Bitmap(Properties.Resources.left);
                text = "";
                text = "Он слева?";
            }
            if (i == 2)
            {
                bitmap = new Bitmap(Properties.Resources.right);
                text = "";
                text = "Может справа?";
            }
            if (i == 3)
            {
                bitmap = new Bitmap(Properties.Resources.center);
                //bitmap.SetResolution(400, 277);
                text = "";
                text = "НАШЁЛ!!!!!";
            }
        }

    }
}
