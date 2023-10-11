using System;
using System.ComponentModel.DataAnnotations;

namespace FlowerBeauty.Models
{
    //part4- create model and attributes for flower products
    public class Flower
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string StoreLocation {get; set;}
        public string Rating { get; set; }
    }
}
