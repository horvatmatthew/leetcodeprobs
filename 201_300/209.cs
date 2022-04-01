    public class Solution
    {
        public int MinSubArrayLen(int target, int[] nums)
        {
            int minLength = Int32.MaxValue;
            int firstNum = 0;
            
            int sum = 0;

            for(int secondNum = 0; secondNum < nums.Length; secondNum++) 
            {
               sum += nums[secondNum];
               while (sum >= target)
                {
                    minLength = Math.Min(minLength, (secondNum - firstNum+1));
                    sum -= nums[firstNum++];
                }
                          
            }

            return minLength == Int32.MaxValue ? 0 : minLength;
        }
    }