using MatLibs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MatLib
{
    public class Game
    {
        public void Start()
        {
            Output.Print("Введите предложение:");
            string input = Console.ReadLine();
            string[] splitted = input.Split('_');
            List<string> inputWords = InputWords();
            GenerateSentence(splitted, inputWords);
            string result = GenerateSentence(splitted, inputWords);
            result = Regex.Replace(result, @"\s+", " ");
            Output.Print(result.Trim());
        }
        private List<string> InputWords()
        {
            List<string> words = new List<string>();
            Output.Print("Введите слова, которые поместите на место пропусков.");
            Output.Print("Введите слово \"стоп\" для остановки ввода:");
            string word = "";
            while (word != "стоп")
            {
                word = Console.ReadLine();
                if (word != "стоп" && word != "")
                {
                    words.Add(word);
                }
            }
            return words;
        }
        private string GenerateSentence(string[] oldSentence, List<string> words)
        {
            Random random = new Random();
            StringBuilder new_string = new StringBuilder();
            for (int i = 0; i < oldSentence.Length - 1; i++
                )
            {
                int index = random.Next(words.Count);
                new_string.Append(oldSentence[i]);
                new_string.Append(" " + words[index] + " ");
                new_string.Append(oldSentence[oldSentence.Length - 1]);
            }
            return new_string.ToString();
        }
    }
}