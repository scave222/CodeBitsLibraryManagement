using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeBitsLibraryManagement.Models
{
    public class Author
    {
        public int Au_ID { get; set; }
        public string Au_Name { get; set; }
        public string Sex { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        public IEnumerable<State> AllState { get; set; }
    }
}
