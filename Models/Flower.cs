using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlowerBeauty.Models
{
    //part4- create model and attributes for flower products
    public class Flower
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [Display(Name = "Release Date")] //part6 -add code to covert ReleaseDate as Release data
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }

        [Column(TypeName = "decimal(18, 2)")]  //add data annotations
        public decimal Price { get; set; }
        public string StoreLocation {get; set;}
        public string Rating { get; set; }
    }
}
