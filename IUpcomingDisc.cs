namespace OOAD_Project
{
    public interface IUpcomingDisc
    {
        void Attach(ICustomer observer);
        void Detach(ICustomer observer);
        void Notify();
    }
}
