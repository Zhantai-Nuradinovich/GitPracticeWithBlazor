using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWithIdentity.Shared
{
    public class Quiz
    {
        public Int32 Id { get; set; }
        public string QuizName { get; set; }
        public DateTime When { get; set; }
        public virtual ICollection<QuizItem> Items { get; set; }
    }
}
