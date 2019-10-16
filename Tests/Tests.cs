using Xunit;

namespace GildedRoseTests
{
    public class Tests
    {
        [Fact]
        public void TestActualDataMatchesExpectedData()
        {
            GildedRose.Program.BuildConsoleOutput();
            Assert.Equal(TestData.ValidOutput, GildedRose.Program.ConsoleOutputString);
        }
    }
}
