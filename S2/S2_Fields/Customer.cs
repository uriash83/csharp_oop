namespace Course_OOP.S2.S2_Fields
{
    public class Customer
    {
        public int Id;
        public string Name;
        public readonly List<Order> Orders = new List<Order>(); // pole readonly mona tylko raz zainicjalizowac

        public Customer(int id)
        {
            this.Id = Id;
        }
        public Customer(int id, string name)
            :this(id)
        {
            this.Name = name;
        }
        public void Promote()
        {
            //Orders = new List<Order>();
        }
    }
}
