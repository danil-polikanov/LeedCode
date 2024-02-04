public class Solution 
{
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        var sizeA = nums1.Length;
        var sizeB = nums2.Length;
        var union = new int[sizeA + sizeB];
        
        var isEven = (sizeA + sizeB) % 2 == 0;
        var center = (sizeA + sizeB) / 2;
        
        Array.Copy(nums1, 0, union, 0, sizeA);
        Array.Copy(nums2, 0, union, sizeA, sizeB);
        Array.Sort(union);

        return isEven ? (union[center - 1] + union[center]) / 2D : union[center];
    }
}