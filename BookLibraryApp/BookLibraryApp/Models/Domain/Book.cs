using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookLibraryApp.Models.Domain
{
    public class Book
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public List<Author> Authors { get; set; }
    }
}
