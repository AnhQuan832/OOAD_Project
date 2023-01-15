using System.Collections.Generic;

namespace OOAD_Project
{
    public class UpComingDisc : IUpcomingDisc
    {
        private List<ICustomer> customers = new List<ICustomer>();
        private string discName;

        private string DiscName { get; set; }

        public UpComingDisc(string discName)
        {
            this.discName = discName;
        }
        public void Attach(ICustomer customer)
        {
            customers.Add(customer);
        }

        public void Detach(ICustomer customer)
        {
            customers.Remove(customer);
        }

        public void Notify()
        {
            foreach (ICustomer customer in customers)
            {
                customer.Update(discName);
            }
        }
    }
}
