namespace DesignPatterns.Creational
{
    using System;

    class Prototype
    {

    }

    class Animal : ICloneable
    {
        public Head AHead { get; set; }
        public string Name { get; set; }

        public Animal()
        {
            AHead = new Head();
        }

        //Constructor to implement the deep copy here
        public Animal(Animal aAnimal)
        {
            Name = aAnimal.Name;
            AHead = (Head)aAnimal.AHead.Clone();
        }

        //Helper method to show the result from client
        public void Dispaly()
        {
            Console.WriteLine("I am a " + Name);
            AHead.Display();
        }

        public object Clone()
        {
            return new Animal(this);
        }
    }

    class Head : ICloneable
    {
        public int Number { get; set; }
        public string Name { get; set; }


        public void Display()
        {
            Console.WriteLine("I have {0} {1} ", Number, Name);
        }

        #region ICloneable Members
        //create a shallow copy of current object 
        public object Clone()
        {
            return this.MemberwiseClone();
        }

        #endregion
    }

    interface IConeable
    {
        object Clone();
    }
}
