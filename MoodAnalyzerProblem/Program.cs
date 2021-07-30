using System;

namespace MoodAnalyzerProblem
{
    class Program
    {
        /// <summary>
        /// Mood Analyser Program using Reflections.
        /// Creating an Object of Mood Analyser class at run time with reflections.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //MoodAnalyzer mood = new MoodAnalyzer("");
            //mood.MoodCheck();
            Console.WriteLine("<-------Mood Analyser program using Reflections-------->");
            Console.WriteLine("--------------------------------------------------------");
            //creating an instance of an Class at Compile time.
            //MoodAnalyzer moodAnalyserr = new MoodAnalyzer("");
            //Console.WriteLine(" Method called at Compile time : " + moodAnalyserr.MoodCheck("Iam in Sad Mood"));

            //// method to create an instance of class at Run Time.
            MoodAnalyserFactory moodAnalyserFactory = new MoodAnalyserFactory("MoodAnalyzerProblem.MoodAnalyzer");
            object objName = moodAnalyserFactory.CreateObjectAtRuntime();
            Console.WriteLine("Object of the class :- " + objName);
        }
    }
}
