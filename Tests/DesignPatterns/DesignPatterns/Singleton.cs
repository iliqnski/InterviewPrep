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

    public class SingletonCommon
    {
        private static readonly SingletonCommon instance = new SingletonCommon();

        public static SingletonCommon Instance { get { return instance; } }

        //Cosntructor present to prevent external construction.
        private SingletonCommon()
        {
            Console.WriteLine("Singleton constructor");
        }

        public static void SayHi()
        {
            Console.WriteLine("Hi there!");
        }
    }
}
