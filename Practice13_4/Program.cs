using System.Threading.Tasks.Sources;

List<string> StandardQuestion = new List<string>() 
{
    "What is the capital city of Australia?",
    "Which river is the longest in South America?",
    "Which continent is known as the Land Down Under?",
    "In which continent is the Sahara Desert located?",
    "What is the highest mountain in the European Alps?"
};

List<string> StandardAnswer = new List<string>() 
{
    "Canberra",
    "Amazon",
    "Australia",
    "Africa",
    "Mont Blanc"
};

List<string> QiyinQuestion = new List<string>()
{
    "Which country is home to the world's largest coral reef system?",
    "What is the deepest oceanic trench in the world?",
    "Name the active volcano in Italy that famously erupted in AD 79, burying the city of Pompeii."
};

List<string> QiyinAnswer = new List<string>() 
{
    "Australia",
    "Mariana",
    "Mount Vesuvius"
};

List<string> OsonQuestion = new List<string>() 
{
    "Name the largest island in the world",
    "What is the largest lake by surface area in Africa?",
    "Name the smallest country in the world by land area.",
    "ha",
    "yuq"
};

List<string> OsonAnswer = new List<string>() 
{
      "Greenland",
      "Victoria",
      "Vatican",
      "yuq",
      "ha"
};
var standart = 0;
var correct = 0;
var incorrect = 0;
while (true)
{
    try
    {
        Console.WriteLine(StandardQuestion[standart]);
        if (Console.ReadLine() == StandardAnswer[standart])
        {
            correct++;
            Console.WriteLine("Correct");
        }
        else
        {
            Console.WriteLine("Incorrect");
            incorrect++;
        }

        if (correct == 2)
        {
            correct = 0;
            StandardAnswer.Insert(standart +1, QiyinAnswer[standart]);
            StandardQuestion.Insert(standart +1 , QiyinQuestion[standart]);
        }
        else if (incorrect == 2)
        {
            incorrect = 0;
            StandardQuestion.Insert(standart + 1, OsonQuestion[standart]);
            StandardAnswer.Insert(standart + 1, OsonAnswer[standart]);

        }
        standart++;
    }
    catch
    {
        Console.WriteLine(("Savolllar tugadi"));
        break;
    }
}
