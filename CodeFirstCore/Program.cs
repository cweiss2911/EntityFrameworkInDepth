using System;

namespace CodeFirstCore
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*             
             dotnet add package Microsoft.EntityFrameworkCore.Design
             think of changing csproj
             dotnet ef migrations add init
             dotnet ef database update
             dotnet ef migrations script

             */
            PlutoContext context = new PlutoContext();

            Author banger = new Author()
            {
                Name = "Bangerang"
            };

            Course c = new Course()
            {
                Name = "How to .net Core",
                Author = banger,
                Description = "How become a .net core legend",
                FullPrice = 1337,
                Level = CourseLevel.Advanced,
            };

            c.CourseTags.Add(new CourseTag()
            {
                Course = c,
                Tag = new Tag()
                {
                    Name = "So hot right now"
                }
            });

            context.Add(c);

            context.SaveChanges();
        }
    }
}
