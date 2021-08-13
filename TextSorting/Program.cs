using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

// Во входном файле записан русский текст, содержащий не более 1000 слов
// Вывести в алфавитном порядке слова текста, все буквы которых различны
// Остальные слова инвертировать и вывести в соответствии с убыванием длины.

namespace TextSorting
{
    internal class StringLengthComparer : Comparer<string>
    {
        public override int Compare(string x, string y)
        {
            if (x.Length < y.Length)
                return 1;
            else if (x.Length > y.Length)
                return -1;
            else return 0;
        }
    }

    class Program
    {
        /// <summary>
        /// Checks if all letters in word are different.
        /// </summary>
        /// <param name="word"></param>
        /// <returns>true if all letters are different, false otherwise</returns>
        static bool AllCharsDifferent(string word)
        {

            HashSet<char> charSet = new HashSet<char>();
            foreach (char c in word)
                charSet.Add(c);
            return charSet.Count == word.Length;

        }

        static void Main(string[] args)
        {

            // Getting Program.cs directory
            string exeDir = Environment.CurrentDirectory; // \bin\ directory, where the .exe file resides
            string projectDir = Directory.GetParent(exeDir).Parent.FullName; // project directory
            
            // Console.WriteLine(projectDir);
            string text = "";
            try
            {
                text = File.ReadAllText(projectDir + @"\input.txt");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found!");
                Console.ReadKey();
                Environment.Exit(0);
            }

            StringBuilder tempStr = new StringBuilder("");
            // removing punctuation
            foreach (char c in text)
                if (char.IsLetter(c))
                    tempStr.Append(c);
                else
                    tempStr.Append(' ');

            string[] words = tempStr.ToString().Split(new char[] { ' '}, StringSplitOptions.RemoveEmptyEntries);
            List<string> words1 = new List<string>();
            List<string> words2 = new List<string>();

            foreach (string word in words)
            {
                if (AllCharsDifferent(word))
                    words1.Add(word);
                else
                {
                    char[] temp = word.ToCharArray();
                    Array.Reverse(temp);
                    words2.Add(new String(temp));
                }
            }

            words1.Sort();
            words2.Sort(new StringLengthComparer());

            StreamWriter output = File.CreateText(projectDir + @"\output.txt");
            string outString = string.Join("\n", words1) + "\n" + string.Join("\n", words2);
            output.Write(outString);
            output.Close();
            // Console.WriteLine(outString);
            // Console.ReadKey();
        }
    }
}
