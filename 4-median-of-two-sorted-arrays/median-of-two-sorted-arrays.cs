public class Solution
{
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
int[] result = nums1.Take(nums1.Length).Concat(nums2.Take(nums2.Length)).OrderBy(i => i).ToArray();
    if (result.Length % 2 == 0)
    {
        double res = (double)(result[result.Length / 2 - 1] + result[result.Length / 2]) / 2; ;
        if (res < 0)
        {
            return 0;
        }
        else
        {
            return (double)(result[result.Length / 2 - 1] + result[result.Length / 2]) / 2;
        }

    }
    else if (result.Length == 1)
    {
        return result[0];
    }
    else
    {
        return result[result.Length / 2];
    }   
    }
}