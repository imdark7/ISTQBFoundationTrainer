using System.Collections.Generic;

namespace ISTQBFoundationTrainer.Models
{
    public class Question
    {
        public int Id;
        public string EnglishText;
        public string RussianText;
        public List<Answer> Answers;
        public string Theme;
        public string Resource;
    }

    public class Answer
    {
        public int Id;
        public int QuestionId;
        public string EnglishText;
        public string RussianText;
        public bool IsCorrect;
    }
}