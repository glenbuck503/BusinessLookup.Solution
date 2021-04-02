using System.ComponentModel.DataAnnotations;
using System;
using Microsoft.EntityFrameworkCore;

namespace BusinessLookup.Models
{
    public class Business
    {
        public int ShopId { get; set; }
        [Required]
        [StringLength(20)]
        public string Name { get; set; }
     
        public string Goods { get; set; }
     
        public int Number { get; set; }
    
    
        
    }
}

