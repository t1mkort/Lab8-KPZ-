using System.Drawing;

namespace BurgerDecoratorLab
{
    public class TomatoBurger : BurgerDecorator
    {
        public TomatoBurger(Burger burger)
            : base(burger.Name + ", з помідорами", burger)
        { }

        public override int GetCost()
        {
            return burger.GetCost() + 10;
        }

        public override int Draw(Graphics g, int cx, int y)
        {
            y = burger.Draw(g, cx, y);
            int w = 72, h = 16;
            using (SolidBrush skin = new SolidBrush(Color.FromArgb(200, 40, 36)))
            using (SolidBrush pulp = new SolidBrush(Color.FromArgb(238, 92, 72)))
            using (SolidBrush seed = new SolidBrush(Color.FromArgb(250, 224, 150)))
            {
                for (int i = -1; i <= 1; i++)
                {
                    int x = cx + i * 62 - w / 2;
                    g.FillEllipse(skin, x, y - h, w, h);
                    g.FillEllipse(pulp, x + 4, y - h + 3, w - 8, h - 6);
                    g.FillEllipse(seed, x + 22, y - h + 6, 5, 4);
                    g.FillEllipse(seed, x + 44, y - h + 6, 5, 4);
                }
            }
            return y - h + 2;
        }
    }
}
