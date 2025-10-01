namespace _01_Skriv_namn___Test;

[TestClass]
public sealed class PrintNameTest
{
    [TestMethod]
    public void SuccessfulTest1()
    {
        string actual = PrintName.RegardsUser("Claes");
        string expected = "Hej Claes!";

        Assert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void SuccessfulTest2() 
    {
        string actual = PrintName.RegardsUser("Peter");
        string expected = "Hej Peter!";

        Assert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void FailTest1()
    {
        string actual = PrintName.RegardsUser("Claes");
        string expected = "Claes är inte Peter";

        Assert.AreNotEqual(expected, actual);
    }
}
