using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzerProblem
{
    class MoodAnalysisException : Exception
    {
        public enum Errors { EMPTY }
        /// <summary>
        /// custom exception for mood analysis. display an empty message.
        /// </summary>
        public MoodAnalysisException()
        {
            Console.WriteLine(Errors.EMPTY);
        }
    }
}
