using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeBitsLibraryManagement.Models
{
    public class Publisher
    {
        public int Pub_ID { get; set; }
        public string Pub_Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }

        public IEnumerable<State> AllState { get; set; }
        //public List<Countries> Countries { get; set; }
    }
}
