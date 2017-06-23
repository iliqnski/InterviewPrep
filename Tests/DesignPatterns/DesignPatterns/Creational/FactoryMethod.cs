namespace DesignPatterns.Creational
{
    using System;

    public class FactoryMethod
    {

    }

    public abstract class Manufacturer
    {
        public abstract Gsm ManufactureGsm();
    }

    public class PearComputers : Manufacturer
    {
        public override Gsm ManufactureGsm()
        {
            var phone = new EyePhone { Height = 200, Weight = 100 };
            return phone;
        }
    }
    public class SamunComputers : Manufacturer
    {
        public override Gsm ManufactureGsm()
        {
            var phone = new SamunGalaxy { Height = 199, Weight = 99 };
            return phone;
        }
    }


    public abstract class Gsm
    {
        public string Name { get; set; }

        public int Weight { get; set; }

        public int Height { get; set; }
    }

    public class EyePhone : Gsm
    {
        public EyePhone()
        {
            this.Name = "EyePhone";
        }
    }

    public class SamunGalaxy : Gsm
    {
        public SamunGalaxy()
        {
            this.Name = "Samun Galaxy";
        }
    }
}
