public class Solution
{
    public string solution(string input) 
    {
        int[] temp = new int[input.Split(' ').Length];

        for (int i = 0; i < temp.Length; i++)
        {
            temp[i] = int.Parse(input.Split(" ")[i]);
        }

        int min = temp[0];
        int max = temp[0];

        for (int i = 1; i < temp.Length; i++)
        {
            if (temp[i] < min)
            {
                min = temp[i];
            }

            if (temp[i] > max)
            {
                max = temp[i];
            }
        }

        return min + " " + max;
    }
}
