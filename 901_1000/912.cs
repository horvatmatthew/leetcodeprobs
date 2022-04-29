public class Solution {
	public int[] SortArray(int[] nums) {
		if(nums.Length < 2) return nums;
		return MergeSort(nums.ToList()).ToArray();
	}

	private IList<int> MergeSort(IList<int> nums)
	{
		if(nums.Count <= 1)
			return nums;

		var pivot = nums.Count / 2;
		var left = MergeSort(nums.Take(pivot).ToList());
		var right = MergeSort(nums.Skip(pivot).Take(nums.Count - pivot).ToList());
		return Merge(left, right);
	}

	private IList<int> Merge(IList<int> left, IList<int> right)
	{
		int leftIndex = 0, rightIndex = 0;
		IList<int> list = new List<int>();

		while (leftIndex < left.Count && rightIndex < right.Count)
			list.Add(left[leftIndex] < right[rightIndex] ? 
				left[leftIndex++] : right[rightIndex++]);

		while(leftIndex < left.Count)
			list.Add(left[leftIndex++]);

		while(rightIndex < right.Count)
			list.Add(right[rightIndex++]);

		return list;
	}
}