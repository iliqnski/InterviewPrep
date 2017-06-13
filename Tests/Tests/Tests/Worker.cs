
namespace Tests
{
    using System;

    //delegate 
    //public delegate int WorkPerformedHandler(object sender, WorkPerformedEventArgs e);

    public class Worker
    {
        public event EventHandler<WorkPerformedEventArgs> WorkPerformed;
        //public event WorkPerformedHandler WorkPerformed;
        public event EventHandler WorkCompleted;

        public void DoWork(int hours, WorkType type)
        {
            for (int i = 0; i < hours; i++)
            {
                //Do work here and notify consumer that work has been performed
                System.Threading.Thread.Sleep(1000);
                OnWorkPerformed(hours, type);
            }

            OnWorkCompleted();
        }

        protected virtual void OnWorkPerformed(int hours, WorkType workType)
        {
            var del = WorkPerformed as EventHandler<WorkPerformedEventArgs>;
            if (del != null)
            {
                del(this, new WorkPerformedEventArgs(hours, workType));
            }
        }

        protected virtual void OnWorkCompleted()
        {
            var del = WorkCompleted as EventHandler;
            if (del != null)
            {
                del(this, EventArgs.Empty);
            }
        }
    }
}
