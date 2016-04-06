using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sonartez.Entities
{
    public class APIResult
    {
        public string Message {get;set;}
        public DateTime UpdateDate { get; set; }
        public bool Success { get; set; }
    }
}
