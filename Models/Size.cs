﻿namespace WebApplication5.Models
{
    public class Size
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Product> Products { get; set; }
    }
}
