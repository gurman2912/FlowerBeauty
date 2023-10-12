using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlowerBeauty.Models
{
    //part4- create model and attributes for flower products
    public class Flower
    {
        public int Id { get; set; }


        //part9- apply regular expression and validation rules
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Name { get; set; }



        [Display(Name = "Launch Date")] //part6 -add code to covert ReleaseDate as Release data
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }



        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required]
        [StringLength(30)]
        public string Category { get; set; }




        [StringLength(200, MinimumLength = 10)]
        [Required]
        public string Description { get; set; }




        [Range(1, 100)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]  //add data annotations
        public decimal Price { get; set; }




        [Display(Name = "Store Location")]
        [RegularExpression(@"^[A-Za-z0-9\s.,'""()! ? &/ -]+$")]
        [Required]
        [StringLength(30)]
        public string StoreLocation {get; set;}



        
        [RegularExpression(@"^(\d+(\.\d{0,1})?|10(\.0{0,1})?)$")]
        [StringLength(5)]
        [Required]
        public string Rating { get; set; }
    }
}
