using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statistics
{
    public class Stats
    {
        private double min;
        private double max;
        private double avg;

        public double MIN
        {
            get { return min; }
            set { min = value; }
        }

        public double MAX
        {
            get { return max; }
            set { max = value; }
        }

        public double AVG
        {
            get { return avg; }
            set { avg = value; }
        }

        public Stats()
        {
            MIN = double.NaN;
            MAX = double.NaN;
            AVG = double.NaN;
        }
    }
}
