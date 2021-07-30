using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzerProblem;

namespace MoodAnalyzerTest
{
    [TestClass]
    public class MS_Test
    {
        /// <summary>
        /// check for sad mood, returns "SAD" message.
        /// </summary>
        [TestMethod]
        public void WhenGivenSadMood_ReturnsSadMessge()
        {
            //Arrange
            string message = "Iam in Sad Mood";
            string expected = "SAD";
            //Act
            MoodAnalyzer mood = new MoodAnalyzer(message);
            string result = mood.MoodCheck();
            //Assert
            Assert.AreEqual(expected, result);
        }
        /// <summary>
        /// Check for Happy mood, return "HAPPY" message.
        /// </summary>
        [TestMethod]
        public void WhenGivenHappyMood_ReturnsHappyMessage()
        {
            //Arrange
            string message = "Iam in Any Mood";
            string expected = "HAPPY";
            //Act
            MoodAnalyzer mood = new MoodAnalyzer(message);
            string result = mood.MoodCheck();
            //Assert
            Assert.AreEqual(expected, result);
        }
        /// <summary>
        /// check for invalid mood, returns "HAPPY" message.
        /// </summary>
        [TestMethod]
        public void WhenGivenInvalidMood_ReturnsHappyMessage()
        {
            //Arrange
            string message = "";
            string expected = "HAPPY";
            //Act
            MoodAnalyzer mood = new MoodAnalyzer(message);
            string result = mood.MoodCheck();
            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
