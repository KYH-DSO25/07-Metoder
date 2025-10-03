namespace _05_Större_än_sina_grannar___Test;

[TestClass]
public class StörreÄnSinaGrannarTest
{
    [TestMethod]
    public void TestMethod1()
    {
        int[] numbers = { 1, 5, 1 };

        bool actual = StörreÄnSinaGrannar.ÄrStörreÄnSinaGrannar(numbers, index: 1);
        bool expected = true;

        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestMethod2()
    {
        int[] numbers = { 5, 1, 1 };

        bool actual = StörreÄnSinaGrannar.ÄrStörreÄnSinaGrannar(numbers, index: 0);
        bool expected = true;

        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestMethod3()
    {
        int[] numbers = { 1, 1, 5 };

        bool actual = StörreÄnSinaGrannar.ÄrStörreÄnSinaGrannar(numbers, index: 2);
        bool expected = true;

        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestMethod4()
    {
        int[] numbers = { 5, 1, 5 };

        bool actual = StörreÄnSinaGrannar.ÄrStörreÄnSinaGrannar(numbers, index: 1);
        bool expected = false;

        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestMethod5()
    {
        int[] numbers = { 1, 2, 3 };

        bool actual = StörreÄnSinaGrannar.ÄrStörreÄnSinaGrannar(numbers, index: 1);
        bool expected = false;

        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestMethod6()
    {
        int[] numbers = { 1, 2, 3 };

        bool actual = StörreÄnSinaGrannar.ÄrStörreÄnSinaGrannar(numbers, index: 0);
        bool expected = false;

        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestMethod7()
    {
        int[] numbers = { 1, 2, 3 };

        bool actual = StörreÄnSinaGrannar.ÄrStörreÄnSinaGrannar(numbers, index: 2);
        bool expected = true;

        Assert.AreEqual(expected, actual);
    }
}