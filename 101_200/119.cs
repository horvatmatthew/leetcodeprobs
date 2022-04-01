   public class Solution
    {
        public IList<int> GetRow(int rowIndex)
        {
            if(rowIndex == 0)
            {
                return new List<int> { 1 };
            }

            var answer = new List<int>();
            answer.Add(1);
            
            for(int i = 1; i <= rowIndex;i++)
            {
                var temp = answer;
                answer = new List<int>();

                for (int j = 0; j <= i; j++)
                {
                    if (j == 0 || i == j)
                    {
                        answer.Add(1);
                    }
                    else
                    {
                        answer.Add(temp[j - 1] + temp[j]);
                    }
                }
            }

            return answer;
        }
    }