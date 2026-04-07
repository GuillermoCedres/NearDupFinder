namespace Domain.Tests;

[TestClass]
public class ItemTests
{
    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void ShouldThrowException_WhenItemTitleIsEmpty()
    {
        var item = new Item(""); 
    }
}