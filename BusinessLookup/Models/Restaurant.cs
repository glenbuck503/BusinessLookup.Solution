using System.ComponentModel.DataAnnotations;
using System;
using Microsoft.EntityFrameworkCore;

namespace BusinessLookup.Models
{
    public class Restaurant
    {
        public int RestaurantId { get; set; }

        public string Name { get; set; }

        public string Food { get; set; }
     
        public string Number { get; set; }
    
    
        
    }
}

