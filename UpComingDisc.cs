using System.Collections.Generic;

namespace OOAD_Project
{
    public class UpComingDisc : IUpcomingDisc
    {
        List<Customer> customers = new List<Customer>();
        string discName;

        public string DiscName
        {
            get { return discName; }
            set { discName = value; }
        }
        public UpComingDisc(string discName)
        {
            this.discName = discName;
        }
        public void Attach(ICustomer observer)
        {

        }

        public void Detach(ICustomer observer)
        {

        }

        public void Notify()
        {
            foreach (Customer customer in customers)
            {
                customer.Update(this);
            }
        }
    }
}
