namespace PracticalIoC.Models
{
    using System;

    public class ProteinTrackingService : IProteinTrackingService
    {
        //We can use the same approach here like in the controller. We will resolve the dependency manually in the CustomControllerFactory
        private ProteinRepository repository = new ProteinRepository();

        public int Total
        {
            get
            {
                return 1; //repository.GetData(new DateTime().Date).Total;
            }
            set
            {
                repository.SetGoal(new DateTime().Date, value);
            }
        }

        public int Goal
        {
            get
            {
                return 1; //repository.GetData(new DateTime().Date).Goal;
            }
            set
            {
                repository.SetGoal(new DateTime().Date, value);
            }
        }

        public void AddProtein(int amount)
        {
            this.Total += amount;
        }
    }
}