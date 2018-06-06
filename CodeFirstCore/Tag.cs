using System.Collections.Generic;

namespace CodeFirstCore
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<CourseTag> CourseTags { get; } = new List<CourseTag>();
    }
}
