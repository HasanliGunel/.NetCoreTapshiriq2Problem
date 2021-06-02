using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tapshiriq2.Database
{
    public class AuthorWorks
    {
        public int ID { get; set; }
        public int AuthorId { get; set; }
        public int WorksId { get; set; }
        public Author Author { get; set; }
        public Works Works { get; set; }
    }
}
