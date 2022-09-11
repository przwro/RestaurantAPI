using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantAPI.Models
{
    public class CreateClientDto
    {
        public string Name { get; set; }
        public int Age { get; set; }
        [Required]
        public bool IsMarried { get; set; }
    }
}
