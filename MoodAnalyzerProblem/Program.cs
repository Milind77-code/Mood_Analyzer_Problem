using System;

namespace MoodAnalyzerProblem
{
    class Program
    {
        /// <summary>
        /// Mood Analyser Program using Exceptions.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Mood Analyser program using Exceptions");

            MoodAnalyzer moodAnalyserr = new MoodAnalyzer("Iam in Sad Mood");
            Console.WriteLine(moodAnalyserr.MoodCheck());
        }
    }
}
