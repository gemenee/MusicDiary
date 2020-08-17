using System.Collections.Generic;

namespace MusicDiary.Domain.Entities
{
    public class Teacher : Person
    {
        public List<Student> Students {get; set;}
    }
}