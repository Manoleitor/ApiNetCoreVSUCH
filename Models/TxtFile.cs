using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiNetCoreVS.Models
{
    public class TxtFile
    {
        public int Id { get; set; }
        public string Base64 { get; set; }
        public string Name { get; set; }
    }
}
