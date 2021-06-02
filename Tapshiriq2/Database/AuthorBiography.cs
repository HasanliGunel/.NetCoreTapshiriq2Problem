using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tapshiriq2.Database
{
    public class AuthorBiography
    {
        public int ID { get; set; }
        public int AuthorID { get; set; }
        public int BiographyID { get; set; }
        public Author Author { get; set; }
        public Biography Biography { get; set; }
    }
}
