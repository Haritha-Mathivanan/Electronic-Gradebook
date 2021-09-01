using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IndividualGradebook
{
    class Program
    {
        static Indstudent s = new Indstudent();
            
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Student Name : ");

            s.Studentname = Console.ReadLine();
            Console.WriteLine("Enter the Rollno : ");

            s.Studentrollno = Console.ReadLine();
            Console.Write("Enter marks in Tamil : ");

            s.Tamil = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter marks in English : ");
            s.English = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter marks in Maths : ");
            s.Maths = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter marks in Science : ");
            s.Science = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter marks in Social : ");
            s.Social = Convert.ToInt32(Console.ReadLine());

            Indstatistics statistic = new Indstatistics(s.Tamil,s.English,s.Maths,s.Science,s.Social);
            float mean = statistic.Mean;
            double median = statistic.Median;
            double variance = statistic.Variance(mean);
            double standarddeviation = statistic.Standarddeviation(variance);
            float lowergrade = statistic.Lowergrade;
            float highergrade = statistic.Highergrade;
            float averagegrade = (mean / 100);
            Console.WriteLine("________________________________________________");
            Display(mean, median, variance, standarddeviation, highergrade, lowergrade, averagegrade);
            Console.WriteLine("_________________________________________________");

        }
        public static void Display(float mean,double median,double variance,double standarddeviation,float highg,float lowg,float avgg)
        {
            Console.WriteLine("_________Student Details______________");
            Console.WriteLine("Student Name : "+s.Studentname);
            Console.WriteLine("Student Rollno : "+s.Studentrollno);
            Console.WriteLine("_________Scores_______________");
            Console.WriteLine("Tamil : "+s.Tamil);
            Console.WriteLine("English : "+s.English);
            Console.WriteLine("Maths : "+s.Maths);
            Console.WriteLine("Science : "+s.Science);
            Console.WriteLine("Social : "+s.Social);
            Console.WriteLine("_________Statistics_____________");
            Console.WriteLine("Mean :  "+Math.Round(mean,2));
            Console.WriteLine("Median : "+median);
            Console.WriteLine("Variance : "+Math.Round(variance,2));
            Console.WriteLine("Standard Diviation : "+Math.Round(standarddeviation,2));
            Console.WriteLine("_________Grade__________________");
            Console.WriteLine("highest Grade : "+Math.Round(highg,2));
            Console.WriteLine("Lowest Grade : "+Math.Round(lowg,2));
            Console.WriteLine("Average Grade : "+Math.Round(avgg,2));
        }
    }
}
