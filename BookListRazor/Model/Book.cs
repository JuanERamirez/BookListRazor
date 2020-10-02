using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookListRazor.Model
{
    public class Book
    {
        // Key tag, unique, automatically add ID as identity column to not
        // have to pass the value, creates ID value 
        [Key]
        public int Id { get; set; }

        // Required tag does not allow Name and Author to be null
        [Required]
        public string Name { get; set; }
        public string Author { get; set; }
    }
}
