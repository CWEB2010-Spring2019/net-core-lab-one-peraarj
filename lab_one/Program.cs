using System;
using static System.Console;
using System.Collections.Generic;

namespace lab_one
{
	// This program is a quiz application that will ask answeres and have a multiple choice option
	// The use of mulitple arrays will be used to store the questions and answers
	class Program
	{
		static void Main(string[] args)
		{
			// Answer key for quiz app is "B", "B", "c", "A", "D", "A", "A", "C", "D", "A"
			string[] correctAnswers = new string[10] { "B", "B", "C", "A", "D", "A", "A", "C", "D", "A" };
			string[] quizQuestions = new string[10] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
			string[] userSelection = new string[10];
			string[,] quizQuestionOptions = {{"A)", "B)", "C)", "D)"},
											 {"A)", "B)", "C)", "D)"},
											 {"A)", "B)", "C)", "D)"},
											 {"A)", "B)", "C)", "D)"},
											 {"A)", "B)", "C)", "D)"},
											 {"A)", "B)", "C)", "D)"},
											 {"A)", "B)", "C)", "D)"},
											 {"A)", "B)", "C)", "D)"},
											 {"A)", "B)", "C)", "D)"},
											 {"A)", "B)", "C)", "D)"}};
			string selection;
			int start;
			int EXIT = -1; //Sentinal Value

			List<string> correct = new List<string>();
			List<string> wrong = new List<string>();

			start = greetings();

			while (start != EXIT)
			{
				for (int x = 0; x < quizQuestions.Length; x++)
				{
					Console.WriteLine(quizQuestions[x]);
					for (int i = 0; i < quizQuestionOptions.GetLength(1); i++)
					{
						Console.WriteLine(quizQuestionOptions[x, i]);
					}

					Console.WriteLine("Please enter and option: ");
					selection = ReadLine();
					userSelection[x] = selection;

					//Need to determing if the user's selectio is the correct answer
					if (selection == correctAnswers[x])
						correct.Add(selection);
					else
						wrong.Add("Question: " + (x + 1) + ") " + selection);
				}
				Console.WriteLine("You answered " + correct.Count + " out of " + quizQuestions.Length);

				// Determing if they passed
				var results = (correct.Count >= 1) ? "You passes the assessment " : " You didnt pass ";
				
				//Output the wrong questions
				if (wrong.Count > 0)
					Console.WriteLine("Listed below are the questions you got wrong.");
					wrong.ForEach(x => { Console.WriteLine(x); });

				wrong.Clear();
				correct.Clear();
				Console.WriteLine("To take the quiz again, enter any value other than -1. To exit enter -1.");
				string startAsString = ReadLine();
				start = Convert.ToInt32(startAsString);
			}

			Console.WriteLine("Program has concluded");
		}

		static int greetings()
		{ //Method header
			int start;
			Console.WriteLine("Welcome, this program will assess your knowledge or .NET Core.");
			Console.WriteLine("To get started, please enter a number other than -1: ");
			string startAsString = ReadLine();
			start = Convert.ToInt32(startAsString);
		return start;

		}	

    }
}
