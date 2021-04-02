using System.ComponentModel.DataAnnotations;
using System;
using Microsoft.EntityFrameworkCore;

namespace BusinessLookup.Models
{
    public class Shop
    {
        public int ShopId { get; set; }

        public string Name { get; set; }
     
        public string Goods { get; set; }
     
        public string Number { get; set; }
    
    
        
    }
}

