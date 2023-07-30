//Linked LIst
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        LinkedList<KeyValuePair<string, string>> questionsAndAnswers = new LinkedList<KeyValuePair<string, string>>();

        questionsAndAnswers.AddLast(new KeyValuePair<string, string>("savoldi kim yozdi? ", "Abdurahmon"));
        questionsAndAnswers.AddLast(new KeyValuePair<string, string>("Abdurahmon kim", "dasturchi"));
        questionsAndAnswers.AddLast(new KeyValuePair<string, string>("qayerda uqiydi", "bilmiman"));
        questionsAndAnswers.AddLast(new KeyValuePair<string, string>("sen kimsan", "Ali"));
        questionsAndAnswers.AddLast(new KeyValuePair<string, string>("akang bormi", "ha"));

        LinkedListNode<KeyValuePair<string, string>> currentNode = questionsAndAnswers.First;
        while (currentNode != null)
        {
            Console.WriteLine(currentNode.Value.Key);

            string userAnswer = Console.ReadLine();
            if (userAnswer == currentNode.Value.Value)
            {
                Console.WriteLine("To'g'ri!");
            }
            else
            {
                Console.WriteLine("Xato!");
            }

            currentNode = currentNode.Next;
        }
    }
}
