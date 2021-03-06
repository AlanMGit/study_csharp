﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relationship_EntityFramework.Model
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Book> Books { get; set; }

        public Author()
        {
            Books = new List<Book>();
        }
    }
}
