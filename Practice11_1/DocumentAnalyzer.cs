using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice11_1
{

    public class DocumentAnalyzer
    {
        public int Analiz(Document document)
        {
            document.score = 100;
            string[] words = document.Content.Split(' ');
            string[] sentences = document.Content.Split('?', '.','!');
            if (words.Length < 500)
            {
                document.score -= 5;
            }
            foreach (var sentence in sentences)
            {
                if (!string.IsNullOrWhiteSpace(sentence) && !(sentence.Trim()[0] >= 'A' && sentence.Trim()[0] <= 'Z'))
                {
                    document.score -= 5;
                }
            }
            foreach (var word in words)
            {
                if (word.Length > 20)
                {
                    document.score -= 20;
                }
            }

            foreach (var sentenc in sentences)
            {
                var sentence = sentenc.Trim().Split(',',' ');
                
                for (var wordB = 1; wordB < sentence.Length; wordB++)
                {
                    if (sentence[wordB] != sentence[wordB].ToLower())
                    {

                        document.score -= 10;
                        break;
                    }
                }
            }
            var count = words.Length * 0.20F;
            Dictionary<string, int> countWord = new Dictionary<string, int>();
            foreach (var word in words)
            {


                if (!countWord.Keys.Contains(word))
                {
                    countWord.Add(word, 1);
                }
                else
                {
                    countWord[word]++;
                }
            }

            foreach (var word in countWord)
            {
                if (word.Value > count)
                {
                }
                    document.score -= 5;
            }

            return document.score;
        }
    }
}

