// See https://aka.ms/new-console-template for more information

int[] arrayInteri = { 4, 2, 3, 8, 2, 1 };
int indexFrom = 2;
int indexTo = 8;

int result = ArrayManagement.ArraySorter.FindIndexOfMin(arrayInteri,indexFrom,indexTo);
ArrayManagement.ArraySorter.SwapElements(arrayInteri, indexFrom, indexTo);
ArrayManagement.ArraySorter.SortArray(arrayInteri);

Console.WriteLine(result);

for(int i=0;i<arrayInteri.Length-1;i++)
    Console.WriteLine(arrayInteri[i].ToString());
