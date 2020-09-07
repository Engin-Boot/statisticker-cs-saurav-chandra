using System;
using Xunit;
using Statistics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statistics.Test
{
    public class StatsUnitTest
    {
        [Fact]
        public void ReportsStatsForAListOfNums()
        {
            var statsComputer = new StatsComputer();
            var computedStats = statsComputer.CalculateStatistics(
                new List<double>{1.5, 8.9, 3.2, 4.5});
            float epsilon = 0.001F;
            Assert.True(Math.Abs(computedStats.AVG - 4.525) <= epsilon);
            Assert.True(Math.Abs(computedStats.MAX - 8.9) <= epsilon);
            Assert.True(Math.Abs(computedStats.MIN - 1.5) <= epsilon);
        }

        [Fact]
        public void ReportsNaNForEmptyInput()
        {
            var statsComputer = new StatsComputer();
            var computedStats = statsComputer.CalculateStatistics(
                new List<double>{});
            //All fields of computedStats (average, max, min) must be
            //Double.NaN (not-a-number), as described in
            //https://docs.microsoft.com/en-us/dotnet/api/system.double.nan?view=netcore-3.1
            Assert.True(double.IsNaN(computedStats.AVG));
            Assert.True(double.IsNaN(computedStats.MAX));
            Assert.True(double.IsNaN(computedStats.MIN));
        }

        [Fact]
        public void WhenListIsHavingNaNThenReturnStatsOfRemainingNumWithoutResizingList()
        {
            List<double> ListWithNanValues = new List<double>() {1.5, 8.9, double.NaN, 4.5};
            int count = ListWithNanValues.Count;
            var statsComputer = new StatsComputer();
            var computedStats = statsComputer.CalculateStatistics(ListWithNanValues);
            float epsilon = 0.001F;
            Assert.True(Math.Abs(computedStats.AVG - 4.96666667) <= epsilon);
            Assert.True(Math.Abs(computedStats.MAX - 8.9) <= epsilon);
            Assert.True(Math.Abs(computedStats.MIN - 1.5) <= epsilon);
            Assert.True(ListWithNanValues.Count == count);
        }
    }
}
