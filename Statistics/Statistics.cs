using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statistics
{
    public class StatsComputer
    {
        public Stats CalculateStatistics(List<double> numbers)
        {
            Stats stats = new Stats();
            if (numbers.Count == 0)
                return stats;

            List<double> UpdatedList = new List<double>();
            UpdatedList.AddRange(numbers);

            if (UpdatedList.Contains(double.NaN))
                UpdatedList.RemoveAll(double.IsNaN);

            stats.MIN = UpdatedList.Min();
            stats.MAX = UpdatedList.Max();
            stats.AVG = UpdatedList.Average();

            return stats;
        }
    }
}
