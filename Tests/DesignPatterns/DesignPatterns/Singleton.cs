namespace DesignPatterns
{
    using System;

    public class Singleton
    {
        private static class SingletonHolder
        {
            internal static readonly Singleton instance = new Singleton();

            static SingletonHolder() { }
        }

        private Singleton()
        {
            Console.WriteLine("Singleton constructor");
        }

        public static Singleton Instance { get { return SingletonHolder.instance; } }

        public void SayHi()
        {
            Console.WriteLine("Hi there!");
        }
    }
}
