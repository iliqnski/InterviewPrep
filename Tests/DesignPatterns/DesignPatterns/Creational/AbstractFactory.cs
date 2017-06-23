namespace DesignPatterns.Creational
{
    using System;

    class AbstractFactory
    {

    }

    abstract class ContinentFactory
    {
        public abstract Herbivore CreateHerbivore();
        public abstract Carnivore CreateCarnivore();
    }

    class AfricaFactory : ContinentFactory
    {
        public override Carnivore CreateCarnivore()
        {
            throw new WildeBeest();
        }

        public override Herbivore CreateHerbivore()
        {
            throw new Lion();
        }
    }

    class AmericaFactory : ContinentFactory
    {
        public override Herbivore CreateHerbivore()
        {
            throw new Bison();
        }

        public override Carnivore CreateCarnivore()
        {
            throw new Wolf();
        }
    }
}
