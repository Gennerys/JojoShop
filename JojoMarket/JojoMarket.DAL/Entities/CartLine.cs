﻿using System;
using System.Collections.Generic;
using System.Text;

namespace JojoMarket.DAL.Entities
{
    public class CartLine
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
