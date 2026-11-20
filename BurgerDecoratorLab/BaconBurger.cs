using System.Drawing;
using System.Drawing.Drawing2D;

namespace BurgerDecoratorLab
{
    public class BaconBurger : BurgerDecorator
    {
        public BaconBurger(Burger burger)
            : base(burger.Name + ", з беконом", burger)
        { }

        public override int GetCost()
        {
            return burger.GetCost() + 30;
        }

        // Бекон: хвиляста червона смужка з світлішим жиром посередині
        public override int Draw(Graphics g, int cx, int y)
        {
            y = burger.Draw(g, cx, y);
            int mid = y - 9;
            Point[] wave = new Point[9];
            for (int i = 0; i < wave.Length; i++)
            {
                wave[i] = new Point(cx - 96 + i * 24, mid + (i % 2 == 0 ? 3 : -3));
            }
            using (Pen meat = new Pen(Color.FromArgb(170, 44, 38), 11))
            using (Pen fat = new Pen(Color.FromArgb(236, 156, 134), 3))
            {
                meat.StartCap = LineCap.Round;
                meat.EndCap = LineCap.Round;
                fat.StartCap = LineCap.Round;
                fat.EndCap = LineCap.Round;
                g.DrawCurve(meat, wave);
                g.DrawCurve(fat, wave);
            }
            return y - 16;
        }
    }
}
