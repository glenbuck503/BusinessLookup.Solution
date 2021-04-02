using System.ComponentModel.DataAnnotations;
using System;
using Microsoft.EntityFrameworkCore;

namespace BusinessLookup.Models
{
    public class Restaurant
    {
        public int RestaurantId { get; set; }
        [Required]
        [StringLength(20)]
        public string Name { get; set; }
        [Required]
        public string Food { get; set; }
     
        public string Number { get; set; }
    
    
        
    }
}

