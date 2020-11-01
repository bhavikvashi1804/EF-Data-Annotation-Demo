﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<Course> Courses { get; set; }
        //tag can have many courses
        //Course - Tag is many to many relationship
    }
}