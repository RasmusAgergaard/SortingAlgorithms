using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms.BL
{
    public class BubbleSort
    {
        public int amount = 152;
        public Random random = new Random();
        public int[] numbers;

        public int Check { get; set; }
        public int check = 0;
        public int reduce = 0;

        public BubbleSort()
        {
            numbers = new int[amount];
            PopulateArray();
            RadomizeArray(numberOfMoves: 1000);
            //SortArray();
        }

        public void PopulateArray()
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i;
            }
        }

        public void RadomizeArray(int numberOfMoves)
        {
            for (int i = 0; i < numberOfMoves; i++)
            {
                var posA = random.Next(amount);
                var posB = random.Next(amount);

                var temp = numbers[posA];
                numbers[posA] = numbers[posB];
                numbers[posB] = temp;
            }
        }

        public void SortArray() //TODO: Fix this to only use the right amount of passes
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                var numbersOfPasses = numbers.Length - 1;

                for (int j = 0; j < numbersOfPasses; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        var temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    } 
                }
            }
        }

        public void SortArrayOneStep()
        {
            if (check >= (numbers.Length - 1) - reduce)
            {
                check = 0;
                reduce++;
            }

            if (numbers[check] > numbers[check + 1])
            {
                var temp = numbers[check];
                numbers[check] = numbers[check + 1];
                numbers[check + 1] = temp;
            }

            check++;
        }
    }
}
