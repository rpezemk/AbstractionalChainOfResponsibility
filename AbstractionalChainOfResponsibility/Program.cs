using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractionalChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            TypeOneProblem problemOne = new TypeOneProblem() { Description = "problem for TypeOneHandler"};
            TypeTwoProblem problemTwo = new TypeTwoProblem() { Description = "problem for TypeTwoHandler" };
            TypeThreeProblem problemThree = new TypeThreeProblem() { Description = "problem for TypeThreeHandler" };
            TypeFourProblem problemFour = new TypeFourProblem() { Description = "problem for non existing TypeFourHandler" };

            List<object> problems = new List<object>();
            problems.Add(problemOne);
            problems.Add(problemTwo);
            problems.Add(problemThree);
            problems.Add(problemFour);

            TypeOneHandler typeOneHandler = new TypeOneHandler();
            TypeTwoHandler typeTwoHandler = new TypeTwoHandler();
            TypeThreeHandler typeThreeHandler = new TypeThreeHandler();
            typeOneHandler.SetNext(typeTwoHandler).SetNext(typeThreeHandler);

            foreach (IProblem problem in problems)
            {
                Console.WriteLine(typeOneHandler.Handle(problem).GetDescription());
            }

            Console.ReadLine();
        }
    }

}
