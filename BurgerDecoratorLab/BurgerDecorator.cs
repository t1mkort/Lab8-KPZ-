namespace BurgerDecoratorLab
{
    public abstract class BurgerDecorator : Burger
    {
        protected Burger burger;
        public BurgerDecorator(string name, Burger burger) : base(name)
        {
            this.burger = burger;
        }
    }
}
