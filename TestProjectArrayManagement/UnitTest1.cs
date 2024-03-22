using ArrayManagement;
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
        Assert.Equal(4,result);
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

        SwapElements(arrayInteri,i,j);
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
        int[] arrayInteri = {1,2};
        int[] arraySort = {1,2};

        int i = 0;
        int j = 6;

        SwapElements(arrayInteri, i, j);
        Assert.Equal(arraySort, arrayInteri);
    }
}