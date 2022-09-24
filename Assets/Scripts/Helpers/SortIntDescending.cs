using System.Collections.Generic;

public class SortIntDescending : IComparer<int>
{
    int IComparer<int>.Compare(int a, int b) //implement Compare
    {              
        if (a > b)
            return -1; //normally greater than = 1
        if (a < b)
            return 1; // normally smaller than = -1
        else
            return 0; // equal
    }
}
