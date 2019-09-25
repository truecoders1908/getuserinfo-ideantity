using System;
using System.Collections.Generic;

namespace Getuserinfo
{
    class Program
    {
        static void Main(string[] args)
        {
            User you = new User();
            you.First = you.Answerquestions("What's your firstname? :");
            you.Last = you.Answerquestions("Whats your lastname? :");
            you.Animal = you.Answerquestions("Whats your favorite animal? :");
            you.Color = you.Answerquestions("Whats your favorite color? : ");
            you.Book = you.Answerquestions("Whats your favorite book? :");
            you.BirthMonth = you.Answerquestions("What month were you born?");
            you.Birthdate = you.AnswerIntQuestion("What day were you born?");
            you.Birthyear = you.AnswerIntQuestion("What year were you born?");
            Console.WriteLine($"Hello! {you.First} {you.Last} nice to meet you. I heard from my little buddy at NSA these are some of your favorite things in life. Your favorite animal is a {you.Animal}, you find the color {you.Color} comforting and your favorite thing to read is {you.Book} " +
                $"you were also born on {you.BirthMonth} {you.Birthdate} {you.Birthyear}");
            Console.WriteLine("Press enter to close...");
            Console.ReadLine();




        }
    }
}
