using System.Drawing;
using System.Drawing.Drawing2D;

namespace BurgerDecoratorLab
{
    public class SauceBurger : BurgerDecorator
    {
        public SauceBurger(Burger burger)
            : base(burger.Name + ", з соусом", burger)
        { }

        public override int GetCost()
        {
            return burger.GetCost() + 5;
        }

        // Соус: кремова хвиляста доріжка і кілька крапель
        public override int Draw(Graphics g, int cx, int y)
        {
            y = burger.Draw(g, cx, y);
            int mid = y - 7;
            Point[] wave = new Point[8];
            for (int i = 0; i < wave.Length; i++)
            {
                wave[i] = new Point(cx - 84 + i * 24, mid + (i % 2 == 0 ? 3 : -3));
            }
            using (Pen outline = new Pen(Color.FromArgb(214, 176, 112), 9))
            using (Pen sauce = new Pen(Color.FromArgb(252, 238, 200), 6))
            using (SolidBrush drop = new SolidBrush(Color.FromArgb(252, 238, 200)))
            {
                outline.StartCap = LineCap.Round;
                outline.EndCap = LineCap.Round;
                sauce.StartCap = LineCap.Round;
                sauce.EndCap = LineCap.Round;
                g.DrawCurve(outline, wave);
                g.DrawCurve(sauce, wave);
                g.FillEllipse(drop, cx - 38, y - 1, 7, 10);
                g.FillEllipse(drop, cx + 30, y - 1, 7, 8);
            }
            return y - 13;
        }
    }
}
