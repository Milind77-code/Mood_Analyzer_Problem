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
            Console.WriteLine("<--------Mood Analyser program using Exceptions-------->");
            Console.WriteLine("--------------------------------------------------------");
            MoodAnalyzer moodAnalyserr = new MoodAnalyzer(" ");
            Console.WriteLine(moodAnalyserr.MoodCheck());
        }
    }
}
