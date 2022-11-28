using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizConsole.Models
{
    public class Game
    {
        public Game()
        {
            
            GetQuestions();
            Random = new Random();
            Categories = AllQuestions
                .Select(x => x.Category)
                .OrderBy(x => x)
                .Distinct().ToList();

            //Categories = new List<int> { 100, 200, 300, 400, 500, 750, 1000 };
            CurrentCategory = Categories[CurrentCategoryIndex];

            IsWheelAvailable= true;
        }


        // właściwości
        public List<Question> AllQuestions { get; set; }
        public int CurrentCategory { get; set; }
        public Question CurrentQuestion { get; set; }
        public Random Random { get; set; }
        public List<int> Categories { get; set; }
        public int CurrentCategoryIndex { get; set; }
        public bool IsWheelAvailable { get; set; }

        public List<int> CorrectKeys = new List<int> { 1, 2, 3, 4 };


        // metoda tworzaca bazę pytań
        void GetQuestions()
        {
            var path = $"{Directory.GetCurrentDirectory()}\\questions.json";
            var json = File.ReadAllText(path);
            AllQuestions = JsonConvert.DeserializeObject<List<Question>>(json);
        }

        // metoda losująca jedno pytanie z wszystkich pytan aktualnej kategorii
        public void DrawQuestion()
        {
            var questionsCat = AllQuestions.Where(q => q.Category == CurrentCategory).ToList();
            var number = Random.Next(0, questionsCat.Count);
            var selectedQuestion = questionsCat[number];
            selectedQuestion.Answers = selectedQuestion.Answers.OrderBy(a => Random.Next()).ToList();
            int index = 1;
            foreach (var a in selectedQuestion.Answers)
            {
                a.DisplayOrder = index;
                index++;
            }
            
            CurrentQuestion = selectedQuestion;
        }

        public bool CheckIfAnswerCorrect(int playerAnswer)
        {
            return CurrentQuestion.Answers.First(a => a.DisplayOrder == playerAnswer).IsCorrect;
        }

        public bool CheckIfLastQuestion()
        {
            if (CurrentCategoryIndex == 6) return true;
            else
            {
                CurrentCategoryIndex++;
                CurrentCategory = Categories[CurrentCategoryIndex];
                return false;
            }
        }

        public void GetQuestionWithTwoAnswers()
        {
            var badAnswers = CurrentQuestion.Answers.Where(a => !a.IsCorrect);
            var removed = badAnswers.OrderBy(a => Random.Next()).Take(2).ToList();
            CorrectKeys.Remove(removed[0].DisplayOrder);
            CorrectKeys.Remove(removed[1].DisplayOrder);
            CurrentQuestion.Answers.Remove(removed[0]);
            CurrentQuestion.Answers.Remove(removed[1]);
            
        }
    }
}

// 100, 200, 300, 400, 500, 750, 1000