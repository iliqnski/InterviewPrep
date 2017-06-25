namespace DesignPatterns.Structural
{
    using System;

    static class AdapterExample
    {
        static void Main()
        {
            var client = new Client(new Adapter());
            client.Request();
        }

        interface ITarget
        {
            void SomeMethod();
        }

        class Client
        {
            private readonly ITarget _target;

            public Client(ITarget target)
            {
                _target = target;
            }

            public void Request()
            {
                _target.SomeMethod();
            }
        }

        public class Adaptee
        {
            public void SomeMethod()
            {
                Console.WriteLine("Adaptee's MethodB called");
            }
        }

        public class Adapter : ITarget
        {
            readonly Adaptee _adaptee = new Adaptee();

            public void SomeMethod()
            {
                _adaptee.SomeMethod();
            }
        }
    }
}
