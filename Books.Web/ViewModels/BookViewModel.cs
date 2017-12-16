using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Books.Web.ViewModels
{
    public class BookViewModel
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string Author { get; set; }
        public string Content { get; set; }
    }
}
