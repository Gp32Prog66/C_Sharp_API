using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Consoles
    {
        public int console_id { get; set; }

        public string console_name { get; set; } = string.Empty;

        public string manufacturer { get; set; } = string.Empty;

        public int release_year { get; set; }
    }
}