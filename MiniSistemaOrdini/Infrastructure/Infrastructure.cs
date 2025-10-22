namespace Infrastructure
{
    using Domain;

    public class InMemoryOrderRepository : IOrderRepository
{
        private readonly List<Order> _orders = new();
        public void Add(Order order) => _orders.Add(order);
        public IEnumerable<Order> GetAll() => _orders;
        public Order? GetById(int id) => _orders.FirstOrDefault(o => o.Id == id);


        //-------------------------------------------------------------------------------------
        //devo gestire meglio queste due 
        public IEnumerable<Order> List()
        {
            throw new NotImplementedException();
        }

        public void Update(Order order)
        {
            throw new NotImplementedException();
        }
    }
}