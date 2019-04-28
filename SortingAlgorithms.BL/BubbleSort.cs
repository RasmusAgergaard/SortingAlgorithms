using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms.BL
{
    public class BubbleSort
    {
        private Random random = new Random();
        public int[] numbers = new int[100];

        public BubbleSort()
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(100);
            }
        }

        public void SortList()
        {

        }
    }
}
