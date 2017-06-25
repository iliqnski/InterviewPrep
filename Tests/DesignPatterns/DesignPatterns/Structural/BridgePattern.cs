namespace DesignPatterns.Structural
{
    using System;

    static class BridgePattern
    {
        static void Main()
        {
            Abstraction abstraction = new RefinedAbstraction
            {
                Implementor = new ConcreteImplementorA()
            };

            abstraction.Operation();
        }

        abstract class Implementor
        {
            public abstract void Operation();
        }

        class Abstraction
        {
            protected Implementor implementor;

            public Implementor Implementor
            {
                set { implementor = value; }
            }

            public virtual void Operation()
            {
                implementor.Operation();
            }

        }

        class RefinedAbstraction : Abstraction
        {
            public override void Operation()
            {
                implementor.Operation();
            }
        }

        class ConcreteImplementorA : Implementor
        {
            public override void Operation()
            {
                Console.WriteLine("ConcreteImplementor's Operation");
            }
        }
    }
}
