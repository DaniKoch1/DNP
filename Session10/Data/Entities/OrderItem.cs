using System;

namespace Session10.Data.Entities
{
    public class OrderItem
    {
        public int Id {set; get;}
        public Cat cat {set; get;}
        public int quantity {set; get;}
        public Order order {set; get;}
    }
}