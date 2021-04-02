using System.ComponentModel.DataAnnotations;
using System;
using Microsoft.EntityFrameworkCore;

namespace BusinessLookup.Models
{
    public class Business
    {
        public int RestaurantId { get; set; }
        [Required]
        [StringLength(20)]
        public string Name { get; set; }
        [Required]
        public string Food { get; set; }
     
        public int Number { get; set; }
    
    
        
    }
}

