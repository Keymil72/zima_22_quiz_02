using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace QuizConsole.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public int Category { get; set; }
        public List<Answer> Answers { get; set; } = new List<Answer>();
        public string Author { get; set; }
        

        public int Display(bool isWheelAvailable, List<int> correctKeys)
        {
            Console.Clear();
            while (true)
            {
                QuestionText(isWheelAvailable);
                var answer = Console.ReadLine();
                if (IsCorrectKey(answer, isWheelAvailable, correctKeys) != 0)
                {
                    Console.WriteLine(IsCorrectKey(answer, isWheelAvailable, correctKeys));
                    return IsCorrectKey(answer, isWheelAvailable, correctKeys);
                }
                else
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Wcisnałaś/eś nieprawidłowy klawisz ...");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }

        private void QuestionText(bool isWheelAvailable)
        {
            Console.WriteLine($"Pytanie za {Category} pkt");
            Console.WriteLine($"Autor: {Author}");
            Console.WriteLine();
            Console.WriteLine(Content);
            Console.WriteLine();

            foreach (var answer in Answers)
                Console.WriteLine($"{answer.DisplayOrder}. {answer.Content}");

            Console.WriteLine();
            var message = isWheelAvailable
                ? "Naciśnij 1, 2, 3, 4 lub K aby użyć koła  => "
                : "Naciśnij 1, 2, 3 lub 4 => ";

            Console.Write(message);

        }


        private int IsCorrectKey(string key, bool isWheelAvailable, List<int> correctKeys)
        {
            if ((key.ToLower() == "k") && isWheelAvailable) return 5;
            if (int.TryParse(key, out int x) && correctKeys.Contains(x)) return x;
            return 0;
        }

    }
}
