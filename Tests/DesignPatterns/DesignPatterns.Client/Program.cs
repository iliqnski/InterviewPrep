namespace DesignPatterns.Client
{
    using System;

    class Program
    {
        static void Main()
        {
            Singleton s1 = Singleton.Instance;
            s1.SayHi();

            Singleton s2 = Singleton.Instance;
            s2.SayHi();

            Console.WriteLine(s1 == s2);
        }
    }
}
