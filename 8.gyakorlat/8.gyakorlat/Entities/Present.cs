using _8.gyakorlat.Abstractions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.gyakorlat.Entities
{
    public class Present : Toy
    {
        public SolidBrush BoxColor { get; private set; }
        public SolidBrush RibbenColor { get; private set; }
        public Present(Color Color1, Color Color2)
        {
            BoxColor = new SolidBrush(Color1);
            RibbenColor = new SolidBrush(Color2);

        }
        protected override void DrawImage(Graphics g)
        {
            g.FillRectangle(BoxColor, 0, 0, this.Width, this.Height);
            g.FillRectangle(RibbenColor, 0, (this.Height/5)*2, this.Width, this.Height/5);
            g.FillRectangle(RibbenColor, (this.Width / 5) * 2, 0, this.Width / 5, this.Height);

        }
    }
}
