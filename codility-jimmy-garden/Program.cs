using System;

namespace codility_jimmy_garden
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class Solution
    {
        public int solution(int[] a)
        {
            if (isAesthetic(a))
            {
                return 0; //Edge Case completion for already aesthetic tree pattern.
            }

            int aestheticPatternCount = 0;
            for (int j = 0; j < a.Length; j++)
            {
                int[] newA = copyArrayWithoutAnElement(a, j);
                if (isAesthetic(newA))
                {
                    aestheticPatternCount++;
                }
            }

            if (aestheticPatternCount == 0)
            {
                return -1;
            }
            else
            {
                return aestheticPatternCount;
            }
        }

        private int[] copyArrayWithoutAnElement(int[] array, int indexOfElementToBeRemoved)
        {
            int arrayLength = array.Length;
            int[] newArr = new int[arrayLength - 1];
            int tempK = 0;
            for (int k = 0; k < arrayLength; k++)
            {
                if (k != indexOfElementToBeRemoved)
                {
                    newArr[tempK++] = array[k];
                }
            }
            return newArr;
        }

        private Boolean isAesthetic(int[] array)
        {
            int newArrayLength = array.Length;
            int increasingFlag = 0;
            for (int i = 0; i < newArrayLength; i++)
            {
                if (increasingFlag == 0)
                {
                    if (array[i] < array[i + 1])
                    {
                        increasingFlag = 1;
                    }
                    else
                    {
                        increasingFlag = 2;
                    }
                }
                else
                {
                    if (increasingFlag == 1)
                    {
                        if (i % 2 == 1 && array[i] > array[i - 1])
                        {

                        }
                        else if (i % 2 == 0 && array[i] < array[i - 1])
                        {

                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        if (i % 2 == 1 && array[i] < array[i - 1])
                        {

                        }
                        else if (i % 2 == 0 && array[i] > array[i - 1])
                        {

                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }

    }


}
