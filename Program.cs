using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

int[] sortedarray = CombineSortedArrays(new int[] { 1, 3, 5 }, new int[] { -5, 3, 6, 7 });
for(int i = 0; i < sortedarray.Length; i++)
    System.Console.WriteLine(sortedarray[i]);


System.Diagnostics.Debug.Assert(Enumerable.SequenceEqual(
    CombineSortedArrays(new int[]{1, 3, 5}, new int[]{-5, 3, 6, 7}),
    new int[]{-5, 1, 3, 3, 5, 6, 7}));

System.Diagnostics.Debug.Assert(Enumerable.SequenceEqual(
    CombineSortedArrays(new int[] { -5, 2, 5, 8, 10 }, new int[] { 1, 2, 5 }),
    new int[] { -5, 1, 2, 2, 5, 5, 8, 10 }));

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


