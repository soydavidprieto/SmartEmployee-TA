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
    internal class Afp
    {
        public int Id { get; set; }

        
        public string? Name { get; set; }

        public string? Nit { get; set; }
    }
}
