namespace Tests
{
    using System;

    public class Program
    {
        static void Main()
        {
            //delegate instance
            WorkPerformedHandler delegate1 = 
                new WorkPerformedHandler(WorkPerformed1);

            WorkPerformedHandler delegate2 =
               new WorkPerformedHandler(WorkPerformed2);

            WorkPerformedHandler delegate3 =
               new WorkPerformedHandler(WorkPerformed3);

            delegate1 += delegate2 + delegate3;
            int hours = delegate1(10, WorkType.Player);
            Console.WriteLine(hours);
            //DoWork(delegate3);

        }

        //handler
        static int WorkPerformed1(int workHours, WorkType type)
        {
            System.Console.WriteLine
                ("WorkPerformed1 called!" + workHours.ToString());

            return workHours + 1;
        }

        //handler
        static int WorkPerformed2(int workHours, WorkType type)
        {
            System.Console.WriteLine
                ("WorkPerformed2 called!" + workHours.ToString());

            return workHours + 1;
        }

        //handler
        static int WorkPerformed3(int workHours, WorkType type)
        {
            System.Console.WriteLine
                ("WorkPerformed3 called!" + workHours.ToString());

            return workHours + 1;
        }

        static void DoWork(WorkPerformedHandler del)
        {
            del(5, WorkType.Player);
        }
    }

    public enum WorkType
    {
        Golf,
        GenerateReports,
        Player
    }
}
