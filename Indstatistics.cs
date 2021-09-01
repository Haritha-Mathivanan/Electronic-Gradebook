using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IndividualGradebook
{
    public class Indstatistics
    {
        List<int> sortmark;
        float _mean;
        double _median;
        double _variance;
        double _standarddiviation;
        float _lowergrade;
        float _highergrade;
        public Indstatistics(int m1, int m2, int m3, int m4, int m5)
        {
            sortmark = new List<int>();
            sortmark.Add(m1);
            sortmark.Add(m2);
            sortmark.Add(m3);
            sortmark.Add(m4);
            sortmark.Add(m5);
            sortmark.Sort();

        }
        public float Mean
        {
            get
            {
            int total = 0;
            foreach (int x in sortmark)
            {
                total += x;
            }
            _mean = (float)total / 5;
            return _mean;
            }
        }
        public double Median
        {
            get
            {
                int position = sortmark.Count() / 2;
                _median = sortmark[position];
                return _median;
            }
        }
        public double Variance(float mean)
        {
            
            double dividend = 0;
            foreach (int x in sortmark)
            {
                double sub = mean - x;
                double square = Math.Pow(sub, 2);
                dividend += square;
            }
            _variance = dividend / 5;
            return _variance;
        }
        public double Standarddeviation(double variance)
        {
            _standarddiviation = Math.Sqrt(variance);
            return _standarddiviation;
        }
        public float Lowergrade
        {
            get
            {
                return (float)sortmark[0] / 100;
            }
        }
        public float Highergrade
        {
            get
            {
                return (float)sortmark[4] / 100;
            }
        }
       
    }
}
 