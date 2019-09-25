using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getuserinfo
{
    class User
    {
        public string First { get; set; }
        public string Last { get; set; }
        public string Animal { get; set; }
        public string Color { get; set; }
        public string Book { get; set; }

        public string BirthMonth { get; set; }
        public int Birthdate { get; set; }

        public int Birthyear { get; set; }

        public string Answerquestions(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }
        public int AnswerIntQuestion(string question)
        {
            string stringAnswer = Answerquestions(question);
            return int.Parse(stringAnswer);
        }
    }
}
