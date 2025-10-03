namespace _06_Första_större_än_grannar___Test;

[TestClass]
public class FörstaStörreÄnGrannarTest
{
    [TestMethod]
    public void TestMethod1()
    {
        int[] numbers = { 1, 5, 1 };

        int actual = FörstaStörreÄnGrannar.FindFirstBiggerThanNeighbours(numbers);
        int expected = 1;

        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestMethod2()
    {
        int[] numbers = { 5, 1, 1 };

        int actual = FörstaStörreÄnGrannar.FindFirstBiggerThanNeighbours(numbers);
        int expected = 0;

        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestMethod3()
    {
        int[] numbers = { 1, 1, 5 };

        int actual = FörstaStörreÄnGrannar.FindFirstBiggerThanNeighbours(numbers);
        int expected = 2;

        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestMethod4()
    {
        int[] numbers = { 1, 1, 1 };

        int actual = FörstaStörreÄnGrannar.FindFirstBiggerThanNeighbours(numbers);
        int expected = -1;

        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestMethod5()
    {
        int[] numbers = { 1, 2, 3 };

        int actual = FörstaStörreÄnGrannar.FindFirstBiggerThanNeighbours(numbers);
        int expected = 2;

        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestMethod6()
    {
        int[] numbers = { 1, 2, 2, 3, 2 };

        int actual = FörstaStörreÄnGrannar.FindFirstBiggerThanNeighbours(numbers);
        int expected = 3;

        Assert.AreEqual(expected, actual);
    }
}