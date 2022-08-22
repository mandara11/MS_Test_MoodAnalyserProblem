using MoodAnalyzerProblem;

namespace MoodAnalyzerTest
{
    [TestClass]
    public class MoodAnalyserTest
    {
        private readonly HappySad moodAnalyzer;
        public MoodAnalyserTest()
        {
            moodAnalyzer = new HappySad("");
        }
        [TestMethod]
        [DataRow("", "message is Empty")]
        [DataRow(null, "message is null")]
        public void InputInString_CheckingMoodAnalysis_MustBeReturn_Null(string input, string expected)
        {
            try
            {
                var result = moodAnalyzer.AnalysingMood();
            }
            catch (CustomException ex)
            {
                Assert.AreEqual(ex.Message, "Message is Null");
            }
        }
        public void InputInString_CheckingMoodAnalysis_MustBeReturn_EmptyMessage(string input, string expected)
        {
            try
            {
                var result = moodAnalyzer.AnalysingMood();
            }
            catch (CustomException ex)
            {
                Assert.AreEqual(ex.Message, "Message is Empty");
            }

        }
    }
}