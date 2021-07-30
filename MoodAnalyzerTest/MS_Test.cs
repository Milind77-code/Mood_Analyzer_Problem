using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzerProblem;
using System;

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
            try
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
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        /// <summary>
        /// Check for Happy mood, return "HAPPY" message.
        /// </summary>
        [TestMethod]
        public void WhenGivenHappyMood_ReturnsHappyMessage()
        {
            try
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
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
        /// <summary>
        /// check for invalid mood, returns "HAPPY" message.
        /// </summary>
        [TestMethod]
        public void WhenGivenInvalidMood_ReturnsHappyMessage()
        {
            try
            {
                //Arrange
                string message = "";
                string expected = null;
                //Act
                MoodAnalyzer mood = new MoodAnalyzer(message);
                string result = mood.MoodCheck();
                //Assert
                Assert.AreEqual(expected, result);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
        /// <summary>
        /// check when given Class name should return object name
        /// </summary>
        [TestMethod]
        public void WhenGivenClassName_ReturnsObject()
        {
            try
            {
                object tempObject = MoodAnalyserFactory.CreateObjectAtRuntime("MoodAnalyser.MoodAnalyserr");
                //Arrange
                string expected = "MoodAnalyser.MoodAnalyserr";
                //Act
                string result = tempObject.ToString();
                //Assert
                Assert.AreEqual(expected, result);
            }
            catch (MoodAnalysisException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Done Test case: WhenGivenClassName_ReturnsObject");
            }
        }
        [TestMethod]
        public void WhenGivenClassNameImproper_ThrowsMoodAnalysisException()
        {
            try
            {
                //passing improper class name will return me Null value which means an improper class name has been
                //passed and throws me an custom exception NO Such Class Error.
                object tempObject = MoodAnalyserFactory.CreateObjectAtRuntime("MoodAnalyser.MoodAnalysers");
                //Arrange
                string expected = null;
                //Act
                string result = null;
                //Assert
                Assert.AreEqual(result, expected);
            }
            catch (MoodAnalysisException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Done Test case: WhenGivenClassNameWrong_ThrowsMoodAnalysisException");
            }
        }
    }
}
