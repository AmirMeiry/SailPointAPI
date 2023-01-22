using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SailPointAPI.Models
{
    public class City
    {
        [Key]
        public string CityName { get; set; }
    }
}
