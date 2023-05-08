
using MoodAnalyzer;


namespace MoodAnalyserTesting
{

    public class UnitTest1
    {


        [Test]
        public void GivenSadMoodReturnSad()
        {
            //Arrange
            string expected = "SAD";
            string message = "I am in Sad Mood";
            MoodAnalyser moodanalyse = new MoodAnalyser(message);

            //Act
            string mood = moodanalyse.AnalyserMood();

            //Assert
            Assert.AreEqual(expected, mood);
        }
        [Test]
        public void GivenHappyMoodReturnHappy()
        {
            //Arrange
            string expected = "HAPPY";
            string message = "I am in Any Mood";
            MoodAnalyser moodAnalyser = new MoodAnalyser(message);

            //Act
            string mood = moodAnalyser.AnalyserMood();

            //Assert
            Assert.AreEqual(expected, mood);
        }
        [Test]

        public void GivenNullMoodReturnHappy()
        {
            //Arrange
            string expected = "HAPPY";
            string message = null;
            MoodAnalyser moodAnalyser = new MoodAnalyser(message);

            //Act
            string mood = moodAnalyser.AnalyserMood();

            //Assert
            Assert.AreEqual(expected, mood);
        }
        [Test]

        public void GivenNullMoodShouldThrowMoodAnalysisException()
        {
            //Arrange
            try
            {
                //string expected = "HAPPY";
                string message = "";
                MoodAnalyser moodAnalyser = new MoodAnalyser(message);

                //Act
                string mood = moodAnalyser.AnalyserMood();
            }
            catch (MoodAnalyzerCustomException e)
            {

                //Assert
                Assert.AreEqual("Mood should not be Empty", e.Message);
            }
        }
        [Test]
        public void GivenMoodAnalyserClassName_ShouldReturnMoodAnalyseObject()
        {
            string message = null;
            object expected = new MoodAnalyser(message);
            object obj = MoodAnalyzerFactory.CreateMoodAnalyse("MoodAnalyzer.MoodAnalyser", "MoodAnalyser");
            expected.Equals(obj);
        }

    }
}