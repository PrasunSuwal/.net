namespace EBookStore.Repositories
{
    public interface IUserOrderRepository
    {
        Task<IEnumerable<Order>> UserOrders();
    }
}