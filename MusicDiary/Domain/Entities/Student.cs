using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicDiary.Domain.Entities
{
    public class Student : Person
    {
        public List<Teacher> Teachers {get; set;}
    }
}
