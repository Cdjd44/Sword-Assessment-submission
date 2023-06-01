namespace AssessmentTDD
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckForValidInputFile()
        {
            InputFile inputFile = new InputFile();
            inputFile.getFile(@"E:\Users\Craig\Source\Repos\Sword-Assessment\Assessment\Sample.txt");

            Assert.IsNotNull(inputFile);
        }

        [TestMethod]
        public void CheckCaseSensitivityIsSetToTrue()
        {
            CaseSensitivity caseSensitivity = new CaseSensitivity();

            Assert.IsTrue(caseSensitivity.getValue());
        }

        [TestMethod]
        public void CheckCaseSensitivityIsSetToFalse()
        {
            CaseSensitivity caseSensitivity = new CaseSensitivity("false");

            Assert.IsFalse(caseSensitivity.getValue());
        }

        [TestMethod]
        public void CheckLetterCount()
        {
            //string[] sample = new string[] { "a", "a", "a", "a", "a","b","b","b" };
            string sample = "aaaaabbb";
            LetterCount letterCount = new LetterCount(sample);
            List<KeyValuePair<string, int>> count = letterCount.getCharacters(true);
            int numberOfLetters = count[0].Value;

            Assert.AreEqual(numberOfLetters, 5);
        }

        [TestMethod]
        public void CheckTotalCharacters()
        {
            string sample = "aaaaabbb";
            LetterCount letterCount = new LetterCount(sample);
            int count = letterCount.getTotalCharacters();
        
            Assert.AreEqual(count, 8);
        }
    }
}