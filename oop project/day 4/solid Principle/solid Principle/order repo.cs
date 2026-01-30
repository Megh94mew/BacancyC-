using SOLIDApp.Models;

namespace SOLIDApp.Interfaces
{
    public interface IOrderRepository
    {
        void Save(Order order);
    }
}