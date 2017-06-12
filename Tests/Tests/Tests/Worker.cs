
namespace Tests
{
    using System;

    //delegate 
    public delegate int WorkPerformedHandler
        (int hours, WorkType type);

    public class Worker
    {
        public event WorkPerformedHandler WorkPerformed;
        public event EventHandler WorkCompleted;

        public void DoWork(int hours, WorkType type)
        {

        }
    }
}
