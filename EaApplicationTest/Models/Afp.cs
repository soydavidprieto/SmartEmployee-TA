using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Xunit.Sdk;

namespace EaApplicationTest.Models
{
    public class Afp
    {
        [Key]
        public int afpId { get; set; }

        [Required]
        [Display(Name = "Name of AFP")]
        [MaxLength(100, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        public string? afpName { get; set; }

        [Required]
        [Display(Name = "Nit of AFP")]
        [MaxLength(20, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        public string? afpNit { get; set; }
    }
}
