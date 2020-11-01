using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class PlutoContext : DbContext
    {
        //to get the list of course
        public DbSet<Course> Courses { get; set; }
        //to get the list of Authors
        public DbSet<Author> Authors { get; set; }
        //to get the list of Tags
        public DbSet<Tag> Tags { get; set; }

        public PlutoContext()
            : base("name=DefaultConnection")
        {

        }
    }
}
