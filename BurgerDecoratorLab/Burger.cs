using System.Drawing;

namespace BurgerDecoratorLab
{
    public abstract class Burger
    {
        public Burger(string name)
        {
            this.Name = name;
        }
        public string Name { get; protected set; }
        public abstract int GetCost();

        public abstract int Draw(Graphics g, int cx, int y);
    }
}
