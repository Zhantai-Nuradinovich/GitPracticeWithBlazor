using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWithIdentity.Shared
{
    public class QuizItem
    {
        public Int32 Id { get; set; }

        public string Question { get; set; }

        public string PicturePath { get; set; }

        public string Answers { get; set; }

        public string RightAnswer { get; set; }

        public string QuestionType { get; set; }

        public DateTime When { get; set; }

        public Int32 QuizID { get; set; }

        public string ChoosenAnswer { get; set; }

        public string[] Normalized
        {
            get { return Answers.Split("1NZN1"); }
        }
    }
}
