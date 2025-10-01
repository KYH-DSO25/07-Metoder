namespace _04_Tal_förekommer_i_vektor___Test;

[TestClass]
public sealed class TalFörekommerTest
{
    [TestMethod]
    public void SuccessfulTest1()
    {
        int[] numbers = { 1, 1, 1, 1, 1 };
        int actual = NumberOccursInArray.GetNumberOfOccurs(numbers, searchNumber: 1);
        int expected = 5;

        Assert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void SuccessfulTest2()
    {
        int[] numbers = { 1, 2, 2, 3, 3, 3, 4, 4, 4, 4 };
        int actual = NumberOccursInArray.GetNumberOfOccurs(numbers, searchNumber: 3);
        int expected = 3;

        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void FailTest1()
    {
        int[] numbers = { 2, 2, 2, 2, 2 };
        int actual = NumberOccursInArray.GetNumberOfOccurs(numbers, searchNumber: 2);
        int expected = 4;

        Assert.AreNotEqual(expected, actual);
    }
}
