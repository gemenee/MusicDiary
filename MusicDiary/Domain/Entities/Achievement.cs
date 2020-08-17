using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicDiary.Domain.Entities
{
    public class Achievement
    {
        public int Id { get; set; }
        public bool TextIsLearned { get; set; }
        public bool IsReadyForConcert { get; set; }
    }
}
