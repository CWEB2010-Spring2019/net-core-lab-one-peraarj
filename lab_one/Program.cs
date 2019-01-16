using System;

namespace lab_one
{
	// This program is a quiz application that will ask answeres and have a multiple choice option
	// The use of mulitple arrays will be used to store the questions and answers
    class Program
    {
        static void Main(string[] args)
        {
			// Answer key for quiz app is "B", "B", "c", "A", "D", "A", "A", "C", "D", "A"
			string[] correctAnswers = new string[10] {"B", "B", "C", "A", "D", "A", "A", "C", "D", "A"};
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
			int EXIT;


		}
    }
}
