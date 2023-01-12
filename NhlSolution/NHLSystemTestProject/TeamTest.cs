using NhlSystemClassLibrary;

namespace NHLSystemTestProject
{
    [TestClass]
    public class TeamTest
    {
        [TestMethod]
        [DataRow("Canadiens")]
        [DataRow("Senators")]
        [DataRow("Maple Leafs")]
        [DataRow("Canucks")]
        [DataRow("flames")]
        public void Name_ValidName_NameSet(string teamName)
        {
            // Arrange
            // Act
            Team currentTeam = new Team(teamName);
            // Assert
            Assert.AreEqual(teamName, currentTeam.Name);

        }

        [TestMethod]
        //[DataRow(null,"Name cannot be blank")]
        [DataRow("", "Name cannot be blank")]
        [DataRow("    ", "Name cannot be blank")]
        public void Name_InvalidName_ThrowsArgumentNullException(string? teamName, string expectedErrorMessage)
        {
            // arrange
            // act
            try
            {
                Team currentTeam = new Team(teamName);
                Assert.Fail("An ArgumentNullException should have been thrown");
            }
            catch(ArgumentNullException ex)
            {
                StringAssert.Contains(ex.Message, expectedErrorMessage);
            }
        }
    }
}