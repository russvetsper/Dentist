using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Dentist.Models
{
    [Table("Services")]
    public class Service
    {
        [Key]
        public int ServiceId { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }

    }
}