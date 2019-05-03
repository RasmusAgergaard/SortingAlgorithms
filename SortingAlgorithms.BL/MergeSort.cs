using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms.BL
{
    public class MergeSort
    {
        public int amount = 75;
        public Random random = new Random();
        public int[] numbers;

        public MergeSort()
        {
            numbers = new int[amount];
            PopulateArray();
            RadomizeArray(numberOfMoves: 1000);
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

        public void SortArrayOneStep()
        {
            
        }
    }
}
