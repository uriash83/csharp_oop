﻿namespace Course_OOP.S2.S2_Constructors
{
    public class Customer
    {
        public int Id;
        public string Name;
        public List<Order> Orders;

        public Customer()
        {
            Orders = new List<Order>();
        }
        public Customer(int id)
            : this() //wywyoanie konstruktora bezparametrowego
        {
            this.Id = id;
        }
        public Customer(int id, string name)
            :this(id)
        {
            this.Name = name;   
        }
    }
}
