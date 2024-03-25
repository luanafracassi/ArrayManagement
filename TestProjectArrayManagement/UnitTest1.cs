using ArrayManagement;
using FluentAssertions;
using static ArrayManagement.ArraySorter;
namespace TestProjectArrayManagement;


public class UnitTest1
{
    [Fact]
    public void FindIndexOfMinText()
    {
        int[] arrayInteri = { 1, 2, 3, 8, 2, 4 };
        int indexFrom = 2;
        int indexTo = 5;

        int result = FindIndexOfMin(arrayInteri, indexFrom, indexTo);
        Assert.Equal(4, result);
    }
    [Fact]
    public void FindIndexOfMinTextIndexNoValid()
    {
        int[] arrayInteri = { 1, 2, 3, 8, 2, 4 };
        int indexFrom = 2;
        int indexTo = 7;

        int result = FindIndexOfMin(arrayInteri, indexFrom, indexTo);
        Assert.Equal(-1, result);
    }
    [Fact]
    public void SortElementsTest()
    {
        int[] arrayInteri = { 1, 2, 3, 8, 2, 4 };
        int[] arraySort = { 1, 2, 2, 3, 4, 8 };
        //int[] arraySort = arrayInteri.OrderBy(x => x).ToArray();

        SortArray(arrayInteri);
        Assert.Equal(arraySort, arrayInteri);
    }
    [Fact]
    public void SortElementsTestEmpty()
    {
        int[] arrayInteri = { };
        int[] arraySort = { };

        SortArray(arrayInteri);
        Assert.Equal(arraySort, arrayInteri);
    }
    [Fact]
    public void SwapElementsTest()
    {
        int[] arrayInteri = { 1, 2, 3, 8, 2, 4 };
        int[] arraySort = { 3, 2, 1, 8, 2, 4 };

        int i = 0;
        int j = 2;

        SwapElements(arrayInteri, i, j);
        Assert.Equal(arraySort, arrayInteri);
    }
    [Fact]
    public void SwapElementsTestEmpty()
    {
        int[] arrayInteri = { };
        int[] arraySort = { };

        int i = 0;
        int j = 2;

        SwapElements(arrayInteri, i, j);
        Assert.Equal(arraySort, arrayInteri);
    }
    [Fact]
    public void SwapElementsTestNoValidIndex()
    {
        int[] arrayInteri = { 1, 2 };
        int[] arraySort = { 1, 2 };

        int i = 0;
        int j = 6;

        SwapElements(arrayInteri, i, j);
        Assert.Equal(arraySort, arrayInteri);
    }
    [Theory]
    [InlineData(new int[] { -1, 2, -3, -8, 5 }, 0, 3, 3)]
    public void TestWithParameters(int[] arrayInt, int indexFrom, int indexTo, int indexMin)
    {
        int result = FindIndexOfMin(arrayInt, indexFrom, indexTo);
        //Assert.Equal(indexMin, result);
        result.Should().Be(indexMin);  //libreria fluent
    }
    [Fact]
    public void Test1()
    {
        Action action = () =>
        {
            int[] arrayInteri = { 1, 2, 3, 8, 2, 4 };
            int indexFrom = 2;
            int indexTo = 15;

            int result = FindIndexOfMin(arrayInteri, indexFrom, indexTo);
        };
        action.Invoke();
        action.Should().Throw<ArgumentOutOfRangeException>();
        //restituisce ok nel test se la funzione va in eccezione
    }
    [Theory]
    [InlineData(new int[] { -1, 2, -3, -8 }, 3, 3, new int[] { -1, 2, -3, -8})]
    [InlineData(new int[] { -1, 2, -3, -8 }, 0, 3, new int[] { -8, 2, -3, -1 })]
    public void TestWithParametersSwap(int[] arrayInt, int i, int j, int[] arrayIntExpected)
    {
        SwapElements(arrayInt, i, j);
        //Assert.Equal(indexMin, result);
        arrayInt.Should().Equal(arrayIntExpected);  //libreria fluent
    }
}