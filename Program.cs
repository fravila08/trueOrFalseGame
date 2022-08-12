using System;

namespace TrueOrFalse
{
  class Program
  {
		static void Main(string[] args)
    {
      Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");
      string entry = Console.ReadLine();
      string[] questions= {"Are you alive?", "Do you need a job?", "Do you have a job?"};
      bool[] answers = {true, true, false};
      bool[] responses= new bool[questions.Length];
      if (responses.Length != questions.Length){
        Console.WriteLine("Number of answers does not equal number of questions");
      }
      int askingIndex = 0;
      foreach(string question in questions){
        bool isBool= false;
        while (isBool == false){
          Console.WriteLine(question);
          Console.WriteLine("True or False");
          string input= Console.ReadLine();
          input = input.ToLower();
          if (input != "true" && input != "false"){
            Console.WriteLine("Please respond with \"true\" or \"false\".");
          };
          bool inputBool;
          isBool= Boolean.TryParse(input, out inputBool);
          responses[askingIndex]= inputBool;
        }
        askingIndex++;
      };
      int score = 0;
      for (int index=0; index< answers.Length; index++){
        if (answers[index]==responses[index]){
          score++;
        };
        Console.WriteLine("Input: "+ responses[index] + " | Answer: "+ answers[index]);
      };
      Console.WriteLine($"You got {score} out of 3 correct!");
    }
  }
}