using System;
using System.IO;
using System.Linq;

namespace Arrays
{
    class Program
    {
        // Complete the hourglassSum function below.
        static int hourglassSum(int[][] arr)
        {
            int max = -63; // "smallest possible value" - 1
            for (int firstDimIndex = 0; firstDimIndex < arr.Length; firstDimIndex++)
            {
                for (int secondDimIndex = 0; secondDimIndex < arr[firstDimIndex].Length; secondDimIndex++)
                {
                    if (secondDimIndex > 3 || firstDimIndex > 3)
                    {
                        continue;
                    }
                    int hourglassFirstRow = arr[firstDimIndex][secondDimIndex] + arr[firstDimIndex][secondDimIndex + 1]
                            + arr[firstDimIndex][secondDimIndex + 2];
                    int hourglassSecondRow = arr[firstDimIndex + 1][secondDimIndex + 1];

                    int hourglassThirdRow = arr[firstDimIndex + 2][secondDimIndex] + arr[firstDimIndex + 2][secondDimIndex + 1]
                                            + arr[firstDimIndex + 2][secondDimIndex + 2];

                    int hourglassTotal = hourglassFirstRow + hourglassSecondRow + hourglassThirdRow;

                    if (hourglassTotal > max)
                    {
                        max = hourglassTotal;
                    }
                }
            }
            return max;
        }

        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(Environment.CurrentDirectory + "..\\..\\output", true);

            int[][] arr = new int[6][];

            for (int i = 0; i < 6; i++)
            {
                string input = File.ReadLines(Environment.CurrentDirectory + "\\..\\..\\..\\input\\input00.txt").ToArray()[i];
                arr[i] = Array.ConvertAll(input.Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }

            int result = hourglassSum(arr);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
