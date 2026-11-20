using System.Drawing;

namespace BurgerDecoratorLab
{
    public class CheeseBurger : BurgerDecorator
    {
        public CheeseBurger(Burger burger)
            : base(burger.Name + ", з сиром", burger)
        { }

        public override int GetCost()
        {
            return burger.GetCost() + 20;
        }

        // Спочатку малюється те, що було до сиру, потім зверху шматок сиру з "потіками"
        public override int Draw(Graphics g, int cx, int y)
        {
            y = burger.Draw(g, cx, y);
            int w = 204, h = 8;
            using (SolidBrush cheese = new SolidBrush(Color.FromArgb(255, 201, 40)))
            using (SolidBrush shade = new SolidBrush(Color.FromArgb(232, 164, 20)))
            {
                g.FillRectangle(shade, cx - w / 2, y - h, w, h);
                g.FillRectangle(cheese, cx - w / 2, y - h, w, h - 2);
                g.FillPolygon(cheese, new Point[]
                {
                    new Point(cx - 62, y - 2), new Point(cx - 30, y - 2), new Point(cx - 46, y + 15)
                });
                g.FillPolygon(cheese, new Point[]
                {
                    new Point(cx + 30, y - 2), new Point(cx + 64, y - 2), new Point(cx + 48, y + 11)
                });
            }
            return y - h;
        }
    }
}
