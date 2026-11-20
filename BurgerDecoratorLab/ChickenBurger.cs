using System.Drawing;

namespace BurgerDecoratorLab
{
    public class ChickenBurger : Burger
    {
        public ChickenBurger()
            : base("Курячий бургер")
        { }
        public override int GetCost()
        {
            return 100;
        }

        public override int Draw(Graphics g, int cx, int y)
        {
            int w = 184, h = 38;
            int left = cx - w / 2;
            int top = y - h;
            int[] crumbX = { -66, -46, -24, -2, 20, 42, 62, -56, -14, 32, 70 };
            int[] crumbY = { 12, 24, 11, 22, 12, 24, 14, 20, 28, 27, 18 };
            using (SolidBrush edge = new SolidBrush(Color.FromArgb(176, 112, 32)))
            using (SolidBrush crust = new SolidBrush(Color.FromArgb(214, 152, 52)))
            using (SolidBrush crumb = new SolidBrush(Color.FromArgb(242, 202, 112)))
            {
                g.FillEllipse(edge, left, top, w, h);
                g.FillEllipse(crust, left + 3, top + 3, w - 6, h - 6);
                for (int i = 0; i < crumbX.Length; i++)
                {
                    g.FillEllipse(crumb, cx + crumbX[i] - 3, top + crumbY[i] - 2, 6, 5);
                }
            }
            return top;
        }
    }
}
