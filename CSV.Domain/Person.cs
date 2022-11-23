using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSV.Domain
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public bool IsLiving { get; set; }

        public static List<Person> GetPersonList()
        {
            var personList = new List<Person>()
            {
                new Person { Id = 1, IsLiving = true, Name = "John" },
                new Person { Id = 2, IsLiving = true, Name = "Steve" },
                new Person { Id = 3, IsLiving = true, Name = "James" }
            };

            return personList;
        }
    }
}
