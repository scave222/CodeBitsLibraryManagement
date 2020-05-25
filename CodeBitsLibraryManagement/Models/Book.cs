using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeBitsLibraryManagement.Models
{
    public class Book
    {
        public int Book_ID { get; set; }
        public string Book_Name { get; set; }
        public decimal Price { get; set; }
        public int Au_ID { get; set; }
        public int Pub_ID { get; set; }
        public string Dt_Of_Publish { get; set; }

    }
}
