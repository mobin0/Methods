using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
           

            Console.WriteLine(Sum(5, 6, 7));
            Console.WriteLine(Multiply(5, 6, 7));
        }

        public static int Sum(params int[] nums) {
            int result = 0;
            for (int i = 0; i < nums.Length; i++) {
                result += nums[i];

            }
            return result;
        }
        public static int Multiply(params int[] nums)
        {
            int result = 1;
            for (int i = 0; i < nums.Length; i++)
            {
                result *= nums[i];
            }
            return result;
        }
    }
}
