using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.Bot.Models
{
    public static class Data
    {
        public static List<QuestionModel> Questions = new List<QuestionModel>()
        {
            new QuestionModel()
            {
                Id = 1,
                Question = "What is your name?",
                AnswerA = "Shahzod",
                AnswerB = "Shohjahon",
                AnswerC = "Mirjalol",
                CorrectAnswer = "B"
            },
            new QuestionModel()
            {
                Id = 2,
                Question = "How many people are there in your room?",
                AnswerA = "12",
                AnswerB = "11",
                AnswerC = "13",
                CorrectAnswer = "B"
            },
            new QuestionModel()
            {
                Id = 3,
                Question = "What is your favourite color?",
                AnswerA = "Black",
                AnswerB = "White",
                AnswerC = "Green",
                CorrectAnswer = "C"
            }
        };
    }
}
