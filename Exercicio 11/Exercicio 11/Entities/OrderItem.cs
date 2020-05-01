﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_11.Entities {
    class OrderItem {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; } = new Product();

        public OrderItem() {
        }
        public OrderItem(int quantity, double price, Product product) {
            Quantity = quantity;
            Price = price;
            Product = product;
        }
        public double SubTotal() {
            return Quantity * Price;
        }
    }
}
