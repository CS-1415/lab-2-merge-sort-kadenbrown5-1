using System.Reflection.Metadata;
using System.Runtime.CompilerServices;


System.Diagnostics.Debug.Assert(Enumerable.SequenceEqual(
    CombineSortedArrays(new int[]{1, 3, 5}, new int[]{-5, 3, 6, 7}),
    new int[]{-5, 1, 3, 3, 5, 6, 7}));

System.Diagnostics.Debug.Assert(Enumerable.SequenceEqual(
    CombineSortedArrays(new int[] { -5, 2, 5, 8, 10 }, new int[] { 1, 2, 5 }),
    new int[] { -5, 1, 2, 2, 5, 5, 8, 10 }));

System.Diagnostics.Debug.Assert(Enumerable.SequenceEqual(
    SortViaMergesort(new int[]{6, 1, -5, 3, 5, 3, 7}),
    new int[]{-5, 1, 3, 3, 5, 6, 7}));

System.Diagnostics.Debug.Assert(Enumerable.SequenceEqual(
    SortViaMergesort(new int[]{1, 10, -5, 2, 5, 2, 5, 8}),
    new int[]{-5, 1, 2, 2, 5, 5, 8, 10}));


int[] CombineSortedArrays(int[] a, int [] b)
{
    int[] combined = new int[a.Length + b.Length];
    int aIndex = 0;
    int bIndex = 0;

    for (int i = 0; i < combined.Length; i++)
    {
        if (bIndex == b.Length || (aIndex != a.Length && a[aIndex] < b[bIndex]))
        {
            combined[i] = a[aIndex];
            aIndex++;
        }
        else
        {
            combined[i] = b[bIndex];
            bIndex++;
        }
    }

    return combined;
}

int[] SortViaMergesort(int[] a)
{
    int middle = a.Length / 2;
    int[] firstHalf = a[0..middle];
    int[] secondHalf = a[middle..a.Length];
    if (a.Length < 2)
        return a;
    else
        return CombineSortedArrays(SortViaMergesort(firstHalf), SortViaMergesort(secondHalf));
}


