using System.Drawing;
using System.Drawing.Drawing2D;

namespace BurgerDecoratorLab
{
    public class BeefBurger : Burger
    {
        public BeefBurger() : base("Яловичий бургер")
        { }
        public override int GetCost()
        {
            return 120;
        }

        // Яловича котлета: широка темно-коричнева "таблетка" зі смужками від гриля
        public override int Draw(Graphics g, int cx, int y)
        {
            int w = 200, h = 34;
            int left = cx - w / 2;
            int top = y - h;
            using (SolidBrush meat = new SolidBrush(Color.FromArgb(92, 50, 30)))
            using (SolidBrush shine = new SolidBrush(Color.FromArgb(124, 76, 48)))
            using (Pen grill = new Pen(Color.FromArgb(48, 26, 14), 4))
            {
                g.FillEllipse(meat, left, top, h, h);
                g.FillEllipse(meat, left + w - h, top, h, h);
                g.FillRectangle(meat, left + h / 2, top, w - h, h);
                g.FillRectangle(shine, left + h / 2, top + 4, w - h, 7);
                grill.StartCap = LineCap.Round;
                grill.EndCap = LineCap.Round;
                for (int x = left + 36; x < left + w - 36; x += 26)
                {
                    g.DrawLine(grill, x, top + 15, x + 10, top + h - 6);
                }
            }
            return top;
        }
    }
}
