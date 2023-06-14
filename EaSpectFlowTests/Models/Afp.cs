using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Xunit.Sdk;

namespace EaSpectFlowTests.Models
{
    public class Afp
    {
       
        public int afpId { get; set; }

       
        public string? afpName { get; set; }

        
        public string? afpNit { get; set; }
    }
}
