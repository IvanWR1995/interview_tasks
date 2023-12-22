using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    class FirstTask
    {
        private static int Partition(int[] values, int left, int right)
        {
            int x = values[right];
            int less = left;

            for (int i = left; i < right; ++i)
            {
                if (values[i] >= x)
                {
                    swap(ref values[i], ref values[less]);
                    ++less;
                }
            }
            swap(ref values[less], ref values[right]);
            return less;
        }
        private static void swap(ref int left, ref int right)
        {
            int tmp = left;
            left = right;
            right = tmp;
        }

        private static void QuickSort(int[] values, int left, int right)
        {
            if (left <= right)
            {
                int support = Partition(values, left, right);
                QuickSort(values, left, support - 1);
                QuickSort(values, support + 1, right);
            }
        }

        public static void Run(int[] values)
        {
            if (values.Count() == 0)
                return;

            QuickSort(values, 0, values.Count() - 1);

        }

    }
}
