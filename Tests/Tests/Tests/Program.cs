namespace Tests
{
    using System;

    public delegate int BizRulesDelegate(int x, int y);

    public class Program
    {
        static void Main()
        {
            //delegate instance
            //WorkPerformedHandler delegate1 = 
            //    new WorkPerformedHandler(WorkPerformed1);

            //WorkPerformedHandler delegate2 =
            //   new WorkPerformedHandler(WorkPerformed2);

            //WorkPerformedHandler delegate3 =
            //   new WorkPerformedHandler(WorkPerformed3);

            //delegate1 += delegate2 + delegate3;
            //int hours = delegate1(10, WorkType.Player);
            //Console.WriteLine(hours);
            //DoWork(delegate3);

            BizRulesDelegate addDelegate = (a, b) => a + b;
            BizRulesDelegate multiplyDelegate = (a, b) => a * b;

            Func<int, int, int> funcAddDel = (a, b) => a + b;

            var data = new ProcessData();
            data.Process(2, 3, addDelegate);
            data.ProcessFunc(2, 3, funcAddDel);

            var worker = new Worker();
            worker.WorkPerformed += new EventHandler<WorkPerformedEventArgs>(worker_WorkPerformed);
            worker.WorkCompleted += new EventHandler(worker_WorkCompleted);

            //using lambda
            worker.WorkPerformed += (s, e) =>
            {
                Console.WriteLine(e.Hours + " " + e.WorkType);
            };

            //delegate inference
            worker.WorkPerformed += worker_WorkPerformed;

            //anonymous methods


            worker.DoWork(8, WorkType.GenerateReports);

            Action<string> messageTarget = ShowWindowsMessage;
            messageTarget("Invoking message!");

            Func<string, bool> logFunc = LogToEventLog;
            logFunc("Log Message");
        }

        private static bool LogToEventLog(string message)
        {
            //log
            return true;
        }

        private static void ShowWindowsMessage(string message)
        {
            Console.WriteLine(message);
        }

        static void worker_WorkPerformed(object sender, WorkPerformedEventArgs e)
        {
            Console.WriteLine(e.Hours + " " + e.WorkType);
        }

        static void worker_WorkCompleted(object sender, EventArgs e)
        {
            Console.WriteLine("Work is done");
        }


        //handler
        //static int WorkPerformed1(int workHours, WorkType type)
        //{
        //    System.Console.WriteLine
        //        ("WorkPerformed1 called!" + workHours.ToString());

        //    return workHours + 1;
        //}

        ////handler
        //static int WorkPerformed2(int workHours, WorkType type)
        //{
        //    System.Console.WriteLine
        //        ("WorkPerformed2 called!" + workHours.ToString());

        //    return workHours + 1;
        //}

        ////handler
        //static int WorkPerformed3(int workHours, WorkType type)
        //{
        //    System.Console.WriteLine
        //        ("WorkPerformed3 called!" + workHours.ToString());

        //    return workHours + 1;
        //}

        //static void DoWork(WorkPerformedHandler del)
        //{
        //    del(5, WorkType.Player);
        //}
    }

    public enum WorkType
    {
        Golf,
        GenerateReports,
        Player
    }
}
