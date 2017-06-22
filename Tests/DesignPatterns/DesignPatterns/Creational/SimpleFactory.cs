namespace DesignPatterns.Creational
{
    using System;

    public class SimpleFactory
    {
        public Coffee GetCoffee(CoffeeType coffeetype)
        {
            switch (coffeetype)
            {
                case CoffeeType.Regular:
                    return new Coffee(0, 150);
                case CoffeeType.Double:
                    return new Coffee(0, 200);
                case CoffeeType.Cappuccino:
                    return new Coffee(100, 100);
                case CoffeeType.Macchiato:
                    return new Coffee(200, 100);
                default:
                    return new Coffee(0, 150);
            }
        }
    }

    public class Coffee
    {
        public Coffee(int milk, int coffee)
        {
            this.MilkContent = milk;
            this.CoffeeContent = coffee;
        }

        public int MilkContent { get; set; }

        public int CoffeeContent { get; set; }
    }

    public enum CoffeeType
    {
        Regular,
        Double,
        Cappuccino,
        Macchiato
    }
}
