namespace DesignStrategies
{
    using System;

    public class SingletonClient
    {
        public void UseSingleton()
        {
            Singleton s1 = new Singleton();
            s1.DoSomething();

            Singleton s2 = new Singleton();
            s2.DoSomething();
        }
    }
}
