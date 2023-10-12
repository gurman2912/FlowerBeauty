using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace FlowerBeauty.Models
{
    public class FlowerCategoryViewModel
    {
        public List<Flower> Flowers { get; set; }

        public string FlowerCategory { get; set; }
        public SelectList Category { get; set; }
       
        public string SearchString { get; set; }
    }
}
