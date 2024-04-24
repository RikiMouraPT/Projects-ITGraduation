namespace _011___BubbleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 3, 5, 2, 1 };

            for (int i = 0; i < nums.Length; i++)
                for (int j = 0; j < nums.Length - 1; j++)
                    if (nums[j] > nums[j + 1])
                    {
                        int temp = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = temp;
                    }

            for (int i = 0; i < 4; i++)
                Console.WriteLine(nums[i]);
            Console.ReadKey();
        }
    }
}