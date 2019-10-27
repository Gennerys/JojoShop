using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace JojoMarket.DAL.Entities
{
    public class Order
    {

        public int Id { get; set; }
        public ICollection<CartLine> Lines { get; set; }
        public OrderStatus Status { get; set; }

        [Required(ErrorMessage = "Please enter a name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter the first address line")]
        public string Street { get; set; }

        [Required(ErrorMessage = "Please enter a city name")]
        public string City { get; set; }

        [Required(ErrorMessage = "Please enter a state name")]
        public string State { get; set; }

        public string Zip { get; set; }

        [Required(ErrorMessage = "Please enter a country name")]
        public string Country { get; set; }

        public bool GiftWrap { get; set; }
    }

    public enum OrderStatus { Shipped, InProcess, Canceled}
}
