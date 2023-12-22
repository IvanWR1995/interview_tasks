using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
     class ThirdTask
    {
        public static double Run(List<int> list)
        {
            if (list == null || list.Count == 0)
                return 0;

            var average = list.Average();
            var averageDestinationSquare = list.Select(d => Math.Pow(average - d, 2)).Sum() / list.Count;
            return Math.Sqrt(averageDestinationSquare);
        }

    }
}
