using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tapshiriq2.Database
{
    public class Works
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Date { get; set; }
        public ICollection<Works> Workss { get; set; }
    }
}
