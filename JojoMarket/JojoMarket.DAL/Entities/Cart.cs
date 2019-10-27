using System;
using System.Collections.Generic;
using System.Text;

namespace JojoMarket.DAL.Entities
{
    public class Cart
    {
        List<CartLine> Line { get; set; }
    }
}
