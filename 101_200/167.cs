public class Solution
    {
        public int[] TwoSum(int[] numbers, int target)
        {
            int firstNum = 0;
            int secondNum = numbers.Length - 1;

            while(firstNum < secondNum)
            {
                var sum = numbers[firstNum] + numbers[secondNum];
                if(sum == target)
                {
                    return new int[]{ firstNum + 1, secondNum + 1 };
                }
                else if(sum > target)
                {
                    secondNum--;
                } else if(sum < target)
                {
                    firstNum++;
                }

            }

            return new int[2];
        }
 }