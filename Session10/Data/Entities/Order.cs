using System;
using System.Collections;
using System.ComponentModel.DataAnnotations.Schema;

namespace Session10.Data.Entities
{
    public class Order
    {
        public int Id {set; get;}
        public DateTime OrderDate {set; get;}
        public string OrderNumber {set; get;}
        [NotMapped]
        public ICollection Items {set; get;}
    }
}