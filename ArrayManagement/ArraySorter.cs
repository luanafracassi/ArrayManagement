namespace ArrayManagement
{
    public static class ArraySorter
    {
        public static int FindIndexOfMin(int[] array, int fromIndex, int toIndex)
        {
            /* Considera un array di lunghezza n contenente numeri interi. Scrivi una funzione in C# che, 
               preso un vettore in input, ritorni l’indice dell’elemento con il valore più piccolo 
               compreso nel range(estremi inclusi) indicati da fromIndex e toIndex */

            if (array.Length <= toIndex || fromIndex < 0 || fromIndex >= toIndex)
                return -1;

            int index = fromIndex;
            for (int i = fromIndex + 1; i <= toIndex; i++)
                if (array[i] < array[index])
                    index = i;
            return index;
        }
        public static void SwapElements(int[] array, int i, int j)
        {
            //Scrivere un metodo che scambia gli elementi in posizione i e j nel vettore array

            if (array.Length < 2)
            {
                // ritornare errore perche servono almeno due indici
                Console.WriteLine("Errore: L'array deve contenere almeno due elementi per poterli scambiare");
                return;
            }
            if (i > array.Length - 1 || j > array.Length - 1 || i == j)
            {
                Console.WriteLine("Errore: Indici non corretti");
                return;
            }

            int numToSwap = array[i];
            array[i] = array[j];
            array[j] = numToSwap;
        }
        public static void SortArray(int[] array)
        {
            /*  Sfruttando i metodi implementati al punto 1) e al punto 2) scrivi un altro metodo che
                effettui l’ordinamento crescente del vettore :
                Prendo l'elemento piu piccolo e scambio */

            for (int i = 0; i < array.Length - 1; i++)
            {
                int min = FindIndexOfMin(array, i, array.Length - 1);
                SwapElements(array, min, i);
            }
        }
    }
}

