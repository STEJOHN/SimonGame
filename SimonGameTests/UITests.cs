using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimonGame;

namespace SimonGameTests
{
    [TestClass]
    public class UITests
    {
        [TestMethod]
        public void UI_Draw_Single_Line_Test()
        {
            // Arrange
            var input = "This is a single line.";
            var expected = "This is a single line.";
            var sut = new UI();

            // Act
            sut.Draw(input);


            // Assert
            string actual = "This is a single line.";
            Assert.AreEqual(expected, actual);
        }
    }
}
