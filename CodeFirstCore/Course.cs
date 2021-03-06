﻿using System;
using System.Collections.Generic;

namespace CodeFirstCore
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public CourseLevel Level { get; set; }
        public float FullPrice { get; set; }
        public Author Author { get; set; }        


        public ICollection<CourseTag> CourseTags { get; } = new List<CourseTag>();
    }
}
