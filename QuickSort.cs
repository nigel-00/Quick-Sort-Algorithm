namespace AlgorithmLib;

public static class QuickSort
{
    private static int Partition(List<IComparable> data, int first, int last)
    {   
        // set the pivot to the first element in the array
        int lmgp = first;
        // loop from first index to the end index
        for (int i = first; i < last; i++)
        {   
            // swap the lmgp index with current index if the current index is less than or equal to the pivot
            if (data[i].CompareTo(data[last]) <= 0)
            {
                (data[lmgp], data[i]) = (data[i], data[lmgp]);
                // increment the lmgp by 1
                lmgp += 1;
            }
        }
        // at the end of the loop swap the lmgp with pivot
        (data[lmgp], data[last]) = (data[last], data[lmgp]); 
        // return the index of the lmgp
        return lmgp;

    }

    public static void Sort(List<IComparable> data)
    {
        // call the _sort function
        _Sort(data, 0, data.Count - 1);
    }
    
    private static void _Sort(List<IComparable> data, int first, int last)
    {
        // implement base case,subarray has at-most one element so its already sorted
        if (first.CompareTo(last) >= 0)
        {
            return;
        }
        // a pivot value to use in recursion
        int pivot = Partition(data, first, last);
        // recursively call  _sort  to sort all elements in the arrray
        _Sort(data, first, pivot - 1);
        _Sort(data, pivot + 1, last);

    }
}

