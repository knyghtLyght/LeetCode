using System;

namespace ContainerWithMostWater
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] test1 = new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
            Console.WriteLine(MaxAreaTwo(test1));
            Console.ReadLine();
        }

        //First attempt. Results: Time Limit exceeded
        public static int MaxArea(int[] height)
        {
            int containerMax = 0;
            for (int i = 0; i < height.Length; i++)
            {
                for (int j = i + 1; j < height.Length; j++)
                {
                    int checkContainerHeight = (height[i] < height[j]) ? height[i] : height[j];
                    int checkContainerLength = (j + 1) - (i + 1);
                    int containerArea = checkContainerHeight * checkContainerLength;
                    if (containerArea > containerMax)
                    {
                        containerMax = containerArea;
                    }
                }
            }
            return containerMax;
        }

        //Solution given
        //Two pointers running from opposite sides if the array.
        //We are trying to make a complete container so we take
        //the lower of the two heights for each pair then
        //calculate the area and check it against our maxArea
        public static int MaxAreaTwo(int[] height)
        {
            int maxArea = 0;
            int left = 0;
            int right = height.Length - 1;

            while (left < right)
            {
                //Taking advantage of th Math class to check if our max area is larger
                //than our calculated area, and to check which container wall is shorter.
                maxArea = Math.Max(maxArea, Math.Min(height[left], height[right]) * (right - left));

                //Move our pointers depending on which one is larger
                if (height[left] < height[right])
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }

            return maxArea;
        }
    }
}
